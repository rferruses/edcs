using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();


	}



	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButton1Clicked (object sender, EventArgs e)
	{
		String aux = entry2.Text;
		String aux2="";
		for (int i = aux.Length - 1; i>=0; i--)
			aux2 += aux[i];

		textview2.Buffer.Text = aux2;
	}
}
