using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();

		Table table = new Table (9, 10, true);
		table.Visible = true;

		//for (int index = 0; index < 90; index++){ 
		Button button = new Button (Stock.Ok);
		button.Visible = true;

		table.Add (button);

	}
		VBox.Add (button);
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

			for (int fila=0;fila<3;fila++){
				for (int columna=0;columna<10;columna++){
					int index=(fila*10) + columna;
					
				}
			}


}
