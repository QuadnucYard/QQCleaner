
namespace QQCleaner {
	partial class Form1 {
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent() {
			this.lstUserDir = new System.Windows.Forms.ListBox();
			this.btnSearchUser = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chartVideo = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.chartAudio = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.chartImageC2C = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.chartImageGroup2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.btnClean = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.numDaysVideo = new System.Windows.Forms.NumericUpDown();
			this.numDaysAudio = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.numDaysImageC2C = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.numDaysImageGroup2 = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartVideo)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartAudio)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartImageC2C)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartImageGroup2)).BeginInit();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numDaysVideo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numDaysAudio)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numDaysImageC2C)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numDaysImageGroup2)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstUserDir
			// 
			this.lstUserDir.FormattingEnabled = true;
			this.lstUserDir.ItemHeight = 20;
			this.lstUserDir.Location = new System.Drawing.Point(64, 150);
			this.lstUserDir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.lstUserDir.Name = "lstUserDir";
			this.lstUserDir.Size = new System.Drawing.Size(188, 144);
			this.lstUserDir.TabIndex = 0;
			// 
			// btnSearchUser
			// 
			this.btnSearchUser.Location = new System.Drawing.Point(90, 100);
			this.btnSearchUser.Margin = new System.Windows.Forms.Padding(2);
			this.btnSearchUser.Name = "btnSearchUser";
			this.btnSearchUser.Size = new System.Drawing.Size(135, 27);
			this.btnSearchUser.TabIndex = 1;
			this.btnSearchUser.Text = "查找用户文件";
			this.btnSearchUser.UseVisualStyleBackColor = true;
			this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chartVideo);
			this.groupBox1.Location = new System.Drawing.Point(341, 51);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(480, 320);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Video";
			// 
			// chartVideo
			// 
			this.chartVideo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chartVideo.Location = new System.Drawing.Point(3, 23);
			this.chartVideo.Name = "chartVideo";
			this.chartVideo.Size = new System.Drawing.Size(474, 294);
			this.chartVideo.TabIndex = 5;
			this.chartVideo.Text = "chartVideo";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.chartAudio);
			this.groupBox2.Location = new System.Drawing.Point(827, 51);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(480, 320);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Audio";
			// 
			// chartAudio
			// 
			this.chartAudio.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chartAudio.Location = new System.Drawing.Point(3, 23);
			this.chartAudio.Name = "chartAudio";
			this.chartAudio.Size = new System.Drawing.Size(474, 294);
			this.chartAudio.TabIndex = 5;
			this.chartAudio.Text = "chartAudio";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.chartImageC2C);
			this.groupBox3.Location = new System.Drawing.Point(341, 377);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(480, 320);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Image/C2C";
			// 
			// chartImageC2C
			// 
			this.chartImageC2C.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chartImageC2C.Location = new System.Drawing.Point(3, 23);
			this.chartImageC2C.Name = "chartImageC2C";
			this.chartImageC2C.Size = new System.Drawing.Size(474, 294);
			this.chartImageC2C.TabIndex = 6;
			this.chartImageC2C.Text = "chart1";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.chartImageGroup2);
			this.groupBox4.Location = new System.Drawing.Point(827, 377);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(480, 320);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Image/Group2";
			// 
			// chartImageGroup2
			// 
			this.chartImageGroup2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chartImageGroup2.Location = new System.Drawing.Point(3, 23);
			this.chartImageGroup2.Name = "chartImageGroup2";
			this.chartImageGroup2.Size = new System.Drawing.Size(474, 294);
			this.chartImageGroup2.TabIndex = 7;
			this.chartImageGroup2.Text = "chart1";
			// 
			// btnClean
			// 
			this.btnClean.Location = new System.Drawing.Point(135, 597);
			this.btnClean.Name = "btnClean";
			this.btnClean.Size = new System.Drawing.Size(75, 36);
			this.btnClean.TabIndex = 5;
			this.btnClean.Text = "清理";
			this.btnClean.UseVisualStyleBackColor = true;
			this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Video";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.numDaysVideo);
			this.groupBox5.Controls.Add(this.label1);
			this.groupBox5.Controls.Add(this.numDaysAudio);
			this.groupBox5.Controls.Add(this.label3);
			this.groupBox5.Controls.Add(this.numDaysImageC2C);
			this.groupBox5.Controls.Add(this.label2);
			this.groupBox5.Controls.Add(this.numDaysImageGroup2);
			this.groupBox5.Controls.Add(this.label4);
			this.groupBox5.Location = new System.Drawing.Point(42, 415);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(262, 176);
			this.groupBox5.TabIndex = 8;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "要删除多少天前的文件？";
			// 
			// numDaysVideo
			// 
			this.numDaysVideo.Location = new System.Drawing.Point(139, 35);
			this.numDaysVideo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numDaysVideo.Name = "numDaysVideo";
			this.numDaysVideo.Size = new System.Drawing.Size(71, 27);
			this.numDaysVideo.TabIndex = 9;
			// 
			// numDaysAudio
			// 
			this.numDaysAudio.Location = new System.Drawing.Point(139, 65);
			this.numDaysAudio.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numDaysAudio.Name = "numDaysAudio";
			this.numDaysAudio.Size = new System.Drawing.Size(71, 27);
			this.numDaysAudio.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(18, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Image/C2C";
			// 
			// numDaysImageC2C
			// 
			this.numDaysImageC2C.Location = new System.Drawing.Point(139, 95);
			this.numDaysImageC2C.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numDaysImageC2C.Name = "numDaysImageC2C";
			this.numDaysImageC2C.Size = new System.Drawing.Size(71, 27);
			this.numDaysImageC2C.TabIndex = 9;
			this.numDaysImageC2C.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Audio";
			// 
			// numDaysImageGroup2
			// 
			this.numDaysImageGroup2.Location = new System.Drawing.Point(139, 125);
			this.numDaysImageGroup2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numDaysImageGroup2.Name = "numDaysImageGroup2";
			this.numDaysImageGroup2.Size = new System.Drawing.Size(71, 27);
			this.numDaysImageGroup2.TabIndex = 9;
			this.numDaysImageGroup2.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(18, 127);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Image/Group2";
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 717);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1360, 22);
			this.statusStrip1.TabIndex = 9;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// statusLabel
			// 
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(0, 16);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1360, 739);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.btnClean);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnSearchUser);
			this.Controls.Add(this.lstUserDir);
			this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "QQCleaner";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartVideo)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartAudio)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartImageC2C)).EndInit();
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartImageGroup2)).EndInit();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numDaysVideo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numDaysAudio)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numDaysImageC2C)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numDaysImageGroup2)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstUserDir;
		private System.Windows.Forms.Button btnSearchUser;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartVideo;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartAudio;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartImageC2C;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartImageGroup2;
		private System.Windows.Forms.Button btnClean;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numDaysImageGroup2;
		private System.Windows.Forms.NumericUpDown numDaysImageC2C;
		private System.Windows.Forms.NumericUpDown numDaysAudio;
		private System.Windows.Forms.NumericUpDown numDaysVideo;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel statusLabel;
	}
}

