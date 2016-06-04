using System;
using System.Windows.Forms;
using System.Drawing;


namespace Salut
{
	public class salut : Form
	{
		OpenFileDialog	ofd = new OpenFileDialog();
		
		static public void Main()
		{
			Application.Run(new salut());
		}
		public salut ()
		{
			Text = "Salut!Mono";
			
			Size = new Size(450, 400);
			
			//adaugarea unui button
			Button button =  new Button();
			button.Location = new Point(360,300);
			button.Text = "Quit";
			button.Click += new EventHandler(OnClick);
			button.MouseEnter += new EventHandler(OnEnter);
			Controls.Add(button);
			
			//utilizarea layout-lui Dock, adaugarea meniului file
			MainMenu mainMenu = new MainMenu();
			MenuItem file = mainMenu.MenuItems.Add("&File");
			file.MenuItems.Add(new MenuItem("O&pen", new EventHandler(this.OnOpen),
			                                Shortcut.CtrlO));
			file.MenuItems.Add(new MenuItem("E&xit", new EventHandler(this.OnExit),
			                                Shortcut.CtrlX));
			Menu = mainMenu;
			
			//adaugarea unei casete de text
			TextBox tb = new TextBox();
			tb.Parent = this;
			tb.Dock = DockStyle.Fill;
			tb.Multiline = true;
			                                
			StatusBar sb = new StatusBar();
			sb.Parent = this;
			sb.Text = "Ready";
			
			CenterToScreen();
			
		}
		
		void OnOpen(object sender, EventArgs e) {
			DialogResult result = ofd.ShowDialog();
			if(result==DialogResult.OK){
			}
		}
		
		void OnExit(object sender, EventArgs e) {
			Close();
		}
		
		void OnClick(object sender, EventArgs e) {
				Close();
		}
		
		void OnEnter(object sender, EventArgs e) {
			Console.WriteLine("Button Entered");
		}
	}
}

