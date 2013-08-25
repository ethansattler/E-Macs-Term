using System;

public class ai
{
	public void ai_pipe(String input) {
		var win = MainWindow._MainWindow;
		string input_lower_case = input.ToLower();

		if (input.StartsWith(";;")) {
			command(input.Replace(";;", ""));
		}
	}

	private void command (string input)
	{
		var win = MainWindow._MainWindow;
		if (input.StartsWith ("echo")) {
			win.Append_textview (input.Replace ("echo", "").Trim (), true);
		} 

		//Start Time Func
		else if (input.StartsWith ("utctime")) {
			var time = DateTime.UtcNow.ToString("hh:mm:ss tt");
			win.Append_textview(time, true);
		} else if (input.StartsWith ("localtime")) {
			var time = DateTime.Now.ToString("hh:mm:ss tt");
			win.Append_textview(time, true);
		}

		//End Time Func
	}


}

