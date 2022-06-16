namespace Sea_of_Thieves_helper
{
	public partial class Form1 : Form
	{
		public static Form1 source = new Form1();
		public static string workingDir = "";

		private PictureBox baitIcon;
		private bool openStatus = false;

		GlobalKeyboardHook gkh = new GlobalKeyboardHook();

		public Form1()
		{
			baitIcon = new PictureBox();
			baitIcon.Location = new Point(28, 443);
			baitIcon.Size = new Size(101,101);
			baitIcon.SizeMode = PictureBoxSizeMode.CenterImage;
			baitIcon.BackColor = Color.Transparent;
			Controls.Add(baitIcon);

			ChangeWindowStatus(); 
			source = this;
			workingDir = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\";
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

			FishMenu.CreateIconsAllFishes();
		}

		public void SetFishInfo(Fish fish)
        {
			baitIcon.Image = Image.FromFile(workingDir + FishDataBase.BaitPicturePath[fish.Bait]);
			TitleText.Text = fish.Name;
			DescriptionText.Text = fish.Description;
        }

        public void ChangeWindowStatus()
        {
			openStatus = !openStatus;

            if (openStatus)
			{
				Opacity = 0.7d;
				//TopMost = true;
			}
            else
			{
				Opacity = 0;
			}
        }
		//I REMOVED THIS EMPTY FUNCTION IF YOU LL HAVE AN ERROR TRY TO REZ IT
		//private void listView1_SelectedIndexChanged(object sender, EventArgs e)

	}
}