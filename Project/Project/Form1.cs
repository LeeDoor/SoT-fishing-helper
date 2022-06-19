namespace Sea_of_Thieves_helper
{
	public delegate void OpacityChanged ();
	public partial class Form1 : Form
	{
		public static Form1 source = new Form1();
		public static string workingDir = "";
		public float CurrentOpacity { get; set; } = 0.7f;

		private readonly Point mapPosition = new Point(233, 387);
		private PictureBox baitIcon;
		private bool openStatus = false;
		private GlobalKeyboardHook gkh = new GlobalKeyboardHook();

		public event OpacityChanged OnOpacityChanged;

		public Form1()
		{
			baitIcon = new PictureBox();
			baitIcon.Location = new Point(28, 443);
			baitIcon.Size = new Size(101,101);
			baitIcon.SizeMode = PictureBoxSizeMode.CenterImage;
			baitIcon.BackColor = Color.Transparent;
			Controls.Add(baitIcon);

			OnOpacityChanged += SetOpacity;

			ChangeWindowStatus();
			source = this;
			workingDir = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\";
			InitializeComponent();

			TopMost = true;
			TransparencyKey = SystemColors.Control;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//hook keys for press catching
			gkh.HookedKeys.Add(Keys.NumPad2);
			gkh.HookedKeys.Add(Keys.NumPad4);
			gkh.HookedKeys.Add(Keys.NumPad6);
			gkh.HookedKeys.Add(Keys.NumPad8);
			gkh.HookedKeys.Add(Keys.NumPad5);
			gkh.HookedKeys.Add(Keys.NumPad7);
			gkh.HookedKeys.Add(Keys.NumPad9);
			gkh.KeyDown += new KeyEventHandler(FishMenu.gkh_KeyDown);

			FishMenu.CreateIconsAllFishes();
		}

		public void SetFishInfo(Fish fish)
        {
			baitIcon.Image = Image.FromFile(workingDir + FishDataBase.BaitPicturePath[fish.Bait]);
			TitleText.Text = fish.Name;
			DescriptionText.Text = fish.Description;
			DrawMapAreas(fish);
		}

		private void DrawMapAreas(Species species)
        {
			HashSet<Rectangle> rectangles = new HashSet<Rectangle>();
			foreach(var rect in species.FishingSpot)
            {
				rectangles.Add(rect);
            }

			foreach(var rect in rectangles)
			{
				PictureBox pictureBox = new PictureBox();
				pictureBox.Location = new Point(rect.X + mapPosition.X, rect.Y + mapPosition.Y);
				pictureBox.Size = new Size(rect.Width, rect.Height);
				pictureBox.Image = Image.FromFile(workingDir + "Images\\IconGreenScreen.png");
				pictureBox.BackColor = Color.Transparent;
				pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
				Controls.Add(pictureBox);
			}
        }
		private void DrawMapAreas(Fish fish)
		{
			foreach(var spec in fish._species)
            {
				DrawMapAreas(spec);
            }
		}

		public void ChangeWindowStatus()
        {
            openStatus = !openStatus;

            if (openStatus)
			{
				SetOpacity();
			}
            else
			{
				Opacity = 0f;
			}
        }

		public void SetOpacity()
        {
			Opacity = CurrentOpacity;
		}

		public void ChangeCurrentOpacity(float difference)
        {
			CurrentOpacity += difference;
			if (CurrentOpacity <= 0) CurrentOpacity = 0;
			if (CurrentOpacity >= 1) CurrentOpacity = 1;
			OnOpacityChanged?.Invoke();
		}
	}
}