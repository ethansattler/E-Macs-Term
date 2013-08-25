using System;
using System.Collections.Generic;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public List<string> commands = new List<string>();
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		_MainWindow = this;
	}
	public static MainWindow _MainWindow;

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	public void Exit (object sender, EventArgs e)
	{
		Application.Quit();
		DeleteEventArgs a = new DeleteEventArgs();
		a.RetVal = true;
	}	

	public void Exit ()
	{
		Application.Quit();
		DeleteEventArgs a = new DeleteEventArgs();
		a.RetVal = true;
	}

	public void Set_textview(String text) {
		textview3.Buffer.Text = text;
	}

	public void Append_textview (String text, bool newline)
	{
		if (newline == false) {
			textview3.Buffer.Text = textview3.Buffer.Text + text;
		} else {
			if (string.IsNullOrEmpty(textview3.Buffer.Text) == true) {
				textview3.Buffer.Text = text;
			} else {
			textview3.Buffer.Text = textview3.Buffer.Text + "\n" + text;
			}
		}
	}

	protected void Enter (object sender, EventArgs e)
	{
		Posted();
	}	

	protected void Submit (object sender, EventArgs e)
	{
		Posted();
	}

	public void Posted ()
	{
		String input = entry1.Text;
		entry1.Text = "";
		ai ai = new ai ();
		try {
			input = input.Replace ("!!", commands [0]);
		} catch {
		}
		commands.Clear ();
		commands.Add (input);
		if (!string.IsNullOrEmpty (input) || !string.IsNullOrWhiteSpace (input)) {
			ai.ai_pipe (input);
		}
	}		


}


