using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace CopyOrder
{
	class MainClass
	{
		public static void Main (string [] args)
		{
			if (args.Length != 1) {
				Console.WriteLine ("Sample > CopyOrder E");
				return;
			}
			string dest = args [0];
			Console.WriteLine ($"Copy from here to {dest}:/");

			string [] files = Directory.GetFiles (".");
			List<string> all = files.ToList<string> ();
			all.Sort ();
			foreach (string s in all) {
				string file = $"{dest}:\\{s.Replace (".\\", "")}";
				if (!File.Exists (file)) {
					Console.WriteLine (file);
					File.Copy (s, file);
				}
			}

		}
	}
}
