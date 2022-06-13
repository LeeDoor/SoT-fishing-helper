namespace Sea_of_Thieves_helper
{
	public partial class Form1 : Form
	{
		public static Form1 source;
		public static string workingDir;

		GlobalKeyboardHook gkh = new GlobalKeyboardHook();

		public Form1()
		{
			source = this;
			string workingDirectory = Environment.CurrentDirectory;
			workingDir = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//hook keys for press catching
			gkh.HookedKeys.Add(Keys.NumPad2);
			gkh.HookedKeys.Add(Keys.NumPad4);
			gkh.HookedKeys.Add(Keys.NumPad6);
			gkh.HookedKeys.Add(Keys.NumPad8);
			gkh.HookedKeys.Add(Keys.NumPad5);
			gkh.KeyDown += new KeyEventHandler(FishMenu.gkh_KeyDown);
			//FishMenu.CreateButtons();


			//listView1.LargeImageList = imageList1;
			//for(int i = 0; i < FishDataBase.Fishes.Count; i++)
			//{
			//    ListViewItem item = new ListViewItem();
			//    item.ImageIndex = i * 5;
			//    listView1.Items.Add(item);
			//}

			

			for(int i = 0; i < FishDataBase.Fishes.Count; i ++)
			{
				PictureBox pictureBox = new PictureBox();
				pictureBox.Size = new Size(200,200);
				pictureBox.Location = new Point(i*200, 0);
				pictureBox.Image = Image.FromFile(workingDir + "\\" + FishDataBase.Fishes[i].Picture);
				Controls.Add(pictureBox);
			}
	  
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}