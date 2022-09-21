using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QY {
	public static class CollectionUtil {

		private static System.Random random = new System.Random();

		public static bool Empty<T>(this ICollection<T> collection) {
			return collection.Count == 0;
		}

		public static void Pop<T>(this List<T> list) {
			list.RemoveAt(list.Count - 1);
		}

		public static T Shift<T>(this List<T> list) {
			T tmp = list[0];
			list.RemoveAt(0);
			return tmp;
		}

		public static TValue Get<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key, TValue defaultValue = default) {
			return dict.ContainsKey(key) ? dict[key] : defaultValue;
		}

		//public static U Product<T, U>(this IEnumerable<T> source, Func<T, U> pred) {
		//	U cur;
		//	bool isFirst = true;
		//	foreach (T p in source) {
		//		if (isFirst) {
		//			isFirst = false;
		//			cur = pred(p);
		//		} else {
		//			cur *= pred(p);
		//		}
		//	}
		//	return cur;
		//}

		public static void Fill<T>(this T[] array, T x) {
			for (int i = 0; i < array.Length; ++i) array[i] = x;
		}

		public static void Fill<T>(this T[,] array, T x) {
			int n = array.GetLength(0), m = array.GetLength(1);
			for (int i = 0; i < n; ++i)
				for (int j = 0; j < m; ++j)
					array[i, j] = x;
		}

		public static void Generate<T>(this T[] array, Func<int, T> gen) {
			for (int i = 0; i < array.Length; ++i) array[i] = gen(i);
		}

		public static void Generate<T>(this T[,] array, Func<int, int, T> gen) {
			int n = array.GetLength(0), m = array.GetLength(1);
			for (int i = 0; i < n; ++i)
				for (int j = 0; j < m; ++j)
					array[i, j] = gen(i, j);
		}

		public static string ToString<T>(IEnumerable<T> list) {
			string s = string.Empty;
			foreach (T t in list) {
				s += t.ToString() + ',';
			}
			return '[' + s + ']';
		}

		public static void ForEach<T>(this IEnumerable<T> self, Action<T> action) {
			foreach (var p in self) action(p);
		}

		//public static void ForEach<TKey, TValue>(this IDictionary<TKey, TValue> self, Action<TKey, TValue> action) {
		//	foreach (var p in self) action(p.Key, p.Value);
		//}

		public static void ForEach<T>(this T[,] arr, Action<T, int,int> action) {
			int n = arr.GetLength(0), m = arr.GetLength(1);
			for (int i = 0; i < n; i++) {
				for (int j = 0; j < m; j++) {
					action(arr[i, j], i, j);
				}
			}
		}

		public static T[,] Resize<T>(this T[,] arr, int n, int m) {
			int n0 = arr.GetLength(0), m0 = arr.GetLength(1);
			if (n0 == n && m0 == m) return arr;
			T[,] brr = new T[n, m];
			for (int i = 0; i < n; i++) {
				for (int j = 0; j < m; j++) {
					brr[i, j] = i < n0 && j < m0 ? arr[i, j] : default;
				}
			}
			return brr;
		}

		public static bool IsomorphicTo<T>(this T[,] arr, T[,] brr) {
			return arr.GetLength(0) == brr.GetLength(0) && arr.GetLength(1) == brr.GetLength(1);
		}

		public static bool IsSizeOf<T>(this T[,] arr, int n, int m) {
			return arr.GetLength(0) == n && arr.GetLength(1) == m;
		}

		public static TValue GetValueOrDefault<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue) {
			return dictionary.ContainsKey(key) ? dictionary[key] : defaultValue;
		}

		public static IEnumerable<T> Where<T>(this T[,] arr, Func<T, int, int, bool> selector) {
			return from i in Enumerable.Range(0, arr.GetLength(0))
				   from j in Enumerable.Range(0, arr.GetLength(1))
				   where selector(arr[i, j], i, j)
				   select arr[i, j];
		}

		public static IEnumerable<U> Select<T, U>(this T[,] arr, Func<T, int, int, U> selector) {
			return from i in Enumerable.Range(0, arr.GetLength(0))
				   from j in Enumerable.Range(0, arr.GetLength(1))
				   select selector(arr[i, j], i, j);
		}

		public static T sample<T>(this IList<T> list) {
			return list.Empty() ? default : list[random.Next(list.Count)];
		}

		public static List<T> sample<T>(this IList<T> list, int count) {
			List<T> ret = new List<T>();
			int cnt = 0;
			foreach (T t in list) {
				cnt++;
				if (ret.Count < count) ret.Add(t);
				else if (random.NextDouble() * cnt <= count) ret[random.Next(count)] = t;
			}
			return ret;
		}
	}
}
