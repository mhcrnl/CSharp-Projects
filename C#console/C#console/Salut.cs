using System;
using System.Windows.Forms;

namespace Cconsole
{
	public class Salut : Form
	{
		static public void Main() {
			Application.Run(new Salut());
		}
		public Salut ()
		{
			Text = "Salut Mono Developer";
		}
	}
}

