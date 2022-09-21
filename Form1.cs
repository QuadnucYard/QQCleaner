using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using QY;
using System.Windows.Forms.DataVisualization.Charting;

namespace QQCleaner {
	public partial class Form1 : Form {

		private List<DirectoryInfo> userDirs = new List<DirectoryInfo>();
		private FileInfo[] videoFiles;
		private FileInfo[] audioFiles;
		private FileInfo[] imageC2CFiles;
		private FileInfo[] imageGroup2Files;
		private DateTime tScanStart;
		private DirectoryInfo currentUserDir;

		public Form1() {
			InitializeComponent();

			lstUserDir.MouseDoubleClick += delegate (object sender, MouseEventArgs e) {
				int index = lstUserDir.IndexFromPoint(e.Location);
				if (index == ListBox.NoMatches) {
					return;
				}
				Console.WriteLine(lstUserDir.Items[index]);
				currentUserDir = userDirs[index];
				count(userDirs[index].FullName);
			};
		}

		private void btnSearchUser_Click(object sender, EventArgs e) {

			probe(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
			probe("C:");
			probe("D:");
			probe("E:");

			lstUserDir.Items.Clear();
			lstUserDir.Items.AddRange(userDirs.Select(t => t.Name).ToArray());

			void probe(string dirname) { //找 Tencent Files
				Console.WriteLine(dirname);
				DirectoryInfo dir = new DirectoryInfo(dirname + "\\Tencent Files");
				if (!dir.Exists) return;
				foreach (DirectoryInfo d in dir.GetDirectories()) {
					if (d.Name != "All Users") {
						userDirs.Add(d);
					}
				}
			}

			//count(userDirs[0].FullName);
		}

		/// <summary>
		/// 统计
		/// </summary>
		private void count(string dirname) {
			statusLabel.Text = "正在扫描文件，请稍后……";


			DateTime now = tScanStart = DateTime.Now;

			//视频
			videoFiles = new DirectoryInfo(dirname + "\\Video").GetFiles();
			foreach (FileInfo f in videoFiles) {
				Console.WriteLine($"{f.FullName} {f.CreationTime} {now - f.CreationTime} {(now - f.CreationTime).Days}");
			}

			audioFiles = new DirectoryInfo(dirname + "\\Audio").GetFiles();
			imageC2CFiles = new DirectoryInfo(dirname + "\\Image\\C2C").GetFiles();

			// 获取群图片


			plot(chartVideo, videoFiles);
			plot(chartAudio, audioFiles);
			plot(chartImageC2C, imageC2CFiles);

			//BeginInvoke(new Action(hhh));

			new Thread(() => {
				imageGroup2Files = getFilesRecursively(new DirectoryInfo(dirname + "\\Image\\Group2")).ToArray();
				BeginInvoke(new Action(hhh));
				//plot(chartImageGroup2, imageGroup2Files);
			}).Start();

			void hhh() {
				//imageGroup2Files = getFilesRecursively(new DirectoryInfo(dirname + "\\Image\\Group2")).ToArray();
				plot(chartImageGroup2, imageGroup2Files);
				statusLabel.Text = $"扫描完成！用时{(DateTime.Now - tScanStart).TotalSeconds}s";
			}
		}

		private List<FileInfo> getFilesRecursively(DirectoryInfo dir) {
			DateTime t0 = DateTime.Now;
			List<FileInfo> ret = new List<FileInfo>();
			Stack<DirectoryInfo> stack = new Stack<DirectoryInfo>();
			stack.Push(dir);
			while (stack.Count > 0) {
				DirectoryInfo d = stack.Pop();
				ret.AddRange(d.GetFiles());
				foreach (DirectoryInfo f in d.GetDirectories()) {
					stack.Push(f);
				}
			}
			Console.WriteLine(DateTime.Now - t0);
			return ret;
		}

		private void plot(Chart chart, FileInfo[] files) {
			Console.WriteLine($"{files.Length} files");
			DateTime now = DateTime.Now;

			chart.ChartAreas.Clear();
			chart.Series.Clear();

			ChartArea ch = new ChartArea();
			ch.AxisX.Minimum = 0;

			DataTable dt = new DataTable();
			dt.Columns.Add("Days", typeof(int));
			dt.Columns.Add("Count", typeof(int));
			dt.Columns.Add("Accumulation", typeof(int));
			dt.Columns.Add("Cumulative size", typeof(float));

			int sum1 = 0;
			float sum2 = 0;
			foreach (var g in files.GroupBy(t => (now - t.CreationTime).Days).OrderBy(t => t.Key)) {
				dt.Rows.Add(g.Key, g.Count(), sum1 += g.Count(), sum2 += g.Sum(t => t.Length) * 1.0f / (1 << 20));
			}

			Series series1 = new Series("File count");
			series1.Points.DataBind(dt.AsEnumerable(), "Days", "Count", "");
			series1.YAxisType = AxisType.Primary;
			series1.XValueType = ChartValueType.Int32;
			series1.YValueType = ChartValueType.Int32;
			series1.ChartType = SeriesChartType.Column;
			series1.IsVisibleInLegend = false;

			Series series3 = new Series("Cumulative size");
			series3.Points.DataBind(dt.AsEnumerable(), "Days", "Cumulative size", "");
			series3.YAxisType = AxisType.Secondary;
			series3.XValueType = ChartValueType.Int32;
			series3.YValueType = ChartValueType.Single;
			series3.ChartType = SeriesChartType.Spline;
			series3.BorderWidth = 2;
			series3.IsVisibleInLegend = false;

			chart.Series.Add(series1);
			chart.Series.Add(series3);
			chart.ChartAreas.Add(ch);
		}

		private void btnClean_Click(object sender, EventArgs e) {
			int daysAudio = (int)numDaysAudio.Value;
			int daysVideo = (int)numDaysVideo.Value;
			int daysImageC2C = (int)numDaysImageC2C.Value;
			int daysImageGroup2 = (int)numDaysImageGroup2.Value;
			DateTime now = DateTime.Now;
			FileInfo[] c1 = audioFiles.Where(t => (now - t.CreationTime).Days >= daysAudio).ToArray();
			FileInfo[] c2 = videoFiles.Where(t => (now - t.CreationTime).Days >= daysVideo).ToArray();
			FileInfo[] c3 = imageC2CFiles.Where(t => (now - t.CreationTime).Days >= daysImageC2C).ToArray();
			FileInfo[] c4 = imageGroup2Files.Where(t => (now - t.CreationTime).Days >= daysImageGroup2).ToArray();
			float s1 = c1.Sum(t => t.Length) * 1.0f / (1 << 20);
			float s2 = c2.Sum(t => t.Length) * 1.0f / (1 << 20);
			float s3 = c3.Sum(t => t.Length) * 1.0f / (1 << 20);
			float s4 = c4.Sum(t => t.Length) * 1.0f / (1 << 20);
			if (MessageBox.Show($"发现以下文件：\nAudio: {c1.Length}个 / {s1}MB\nVideo: {c2.Length}个 / {s2}MB\nImageC2C: {c3.Length}个 / {s3}MB\nImageGroup2: {c4.Length}个 / {s4}MB",
				"确定删除？", MessageBoxButtons.YesNo) == DialogResult.Yes) {
				c1.ForEach(t => t.Delete());
				c2.ForEach(t => t.Delete());
				c3.ForEach(t => t.Delete());
				c4.ForEach(t => t.Delete());
				statusLabel.Text = "正在清理空文件夹……";
				new Thread(() => {
					cleanFolders(new DirectoryInfo(currentUserDir.FullName + "\\Image\\Group2"));
				}).Start();
				
			}
		}

		private void cleanFolders(DirectoryInfo dir) {
			
			Stack<DirectoryInfo> stack = new Stack<DirectoryInfo>();
			stack.Push(dir);
			while (stack.Count > 0) {
				DirectoryInfo d = stack.Pop();
				if (d.GetFiles().Length == 0 && d.GetDirectories().Length == 0) {
					d.Delete(true);
				} else {
					foreach (DirectoryInfo f in d.GetDirectories()) {
						stack.Push(f);
					}
				}
			}
			BeginInvoke(new Action(fff));

			void fff() {
				statusLabel.Text = "空文件夹清理完成……";
				MessageBox.Show("终于清理完成了！", "清理完成", MessageBoxButtons.OK);
			}
		}
	}
}
