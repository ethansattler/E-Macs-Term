using System;
using Gtk;

namespace EMacsTerm
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Title = "E-Macs Terminal";
			win.Show ();
			Application.Run ();
		}
	}
}
