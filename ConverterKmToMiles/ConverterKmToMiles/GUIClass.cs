using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConverterKmToMiles
{
	public class GUIClass : Form
	{
		public GUIClass ()
		{
			//Fereastra principala titlu si dimensiunea afisata
			Text = "Convertor Kilometrii in Mile";
			Size = new Size(450, 400);
			
			//Adaugarea unui meniu principal in fereastra
			MainMenu mainMenu = new MainMenu();
			//Adaugarea meniului File
			MenuItem file = mainMenu.MenuItems.Add("F&ile");
			file.MenuItems.Add(new MenuItem("E&xit", new EventHandler(this.Exit), 
			                                Shortcut.CtrlX));
			//adaugarea Meniului Help
			MenuItem help = mainMenu.MenuItems.Add("H&elp");
			help.MenuItems.Add(new MenuItem("A&bout", new EventHandler(this.Exit),
			                                Shortcut.CtrlA));
			Menu = mainMenu;
			
			//Adaugarea unui panel 
			Panel panel = new Panel();
			panel.Parent = this;
			panel.Dock = DockStyle.Fill;
			//panel.Location = new Point(10, 380);
			//panel.Anchor = AnchorStyles.Top;
			Controls.Add(panel);
			
			//Adaugare label kilometrii in panel
			Label km = new Label();
			km.Text = "Kilometrii: ";
			km.Location = new Point(10, 10);
			km.Parent = panel;
			
			//Adaugarea unui TextBox tbkm
			TextBox tbkm = new TextBox();
			tbkm.Location = new Point(100, 10);
			tbkm.Parent = panel;
				
			//Adaugarea unui status bar
			StatusBar sb = new StatusBar();
			sb.Parent = this;
			sb.Text = "Ready";
			
			CenterToScreen();
			
		}
		
		void Exit(object sender, EventArgs e){
			Close();	
		}
			
	}
}

