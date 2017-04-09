using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace R2B0app
{
	public static class TestObjManager
	{
		public static ObservableCollection<TestObj> All = new ObservableCollection<TestObj> ();

		public static void Populate ()
		{
			for (int i = 0; i < 10; i++) {
				TestObj o = new TestObj ();
				o.Title = $"Test {i}";
				All.Add (o);
			}
		}

	}
}