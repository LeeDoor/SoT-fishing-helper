namespace Sea_of_Thieves_helper
{
    public delegate void SelectedChanged(Button newSelected);
    public partial class Form1 : Form
    {
        public Button[] fishButtons;
        int selectedId;

        public event SelectedChanged OnSelectedChanged;
        public Form1()
        {
            InitializeComponent();
        }

        GlobalKeyboardHook gkh = new GlobalKeyboardHook();
        private void Form1_Load(object sender, EventArgs e)
        {
            //hook keys for press catching
            gkh.HookedKeys.Add(Keys.NumPad2);
            gkh.HookedKeys.Add(Keys.NumPad4);
            gkh.HookedKeys.Add(Keys.NumPad6);
            gkh.HookedKeys.Add(Keys.NumPad8);
            gkh.HookedKeys.Add(Keys.NumPad5);
            gkh.KeyUp += new KeyEventHandler(gkh_KeyUp);

            fishButtons = new Button[FishDataBase.Fishes.Count];
            OnSelectedChanged += ButtonSelectedChanged;

            for (int i = 0; i < FishDataBase.Fishes.Count; i++)
            {
                Button butt = new Button();
                butt.Size = new Size(70, 70);
                butt.BackColor = Color.Black; 
                butt.ForeColor = Color.White;
                butt.Location = new Point(i * 80, 0);
                butt.Text = FishDataBase.Fishes[i].Name;

                this.Controls.Add(butt);
                fishButtons[i] = butt;
            }
            SetSelectedId(0);
        }
        public void gkh_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad2:
                    break;
                case Keys.NumPad4:
                    SetSelectedId(false);
                    break;
                case Keys.NumPad6:
                    SetSelectedId(true);
                    break;
                case Keys.NumPad8:
                    break;
                case Keys.NumPad5:
                    this.TopMost = true;
                    this.TopMost = false;
                    break;
            }
        }

        private void SetSelectedId(int id)
        {
            if(0 <= id && id <= FishDataBase.Fishes.Count - 1)
            {
                selectedId = id;
            }
            OnSelectedChanged?.Invoke(fishButtons[selectedId]);
        }
        private void SetSelectedId(bool isForward)
        {
            if (isForward)
            {
                selectedId++;
                if (selectedId >= FishDataBase.Fishes.Count)
                {
                    selectedId = 0;
                }
            }
            else
            {
                selectedId--;
                if (selectedId < 0)
                {
                    selectedId = FishDataBase.Fishes.Count - 1;
                }
            }
            OnSelectedChanged?.Invoke(fishButtons[selectedId]);
        }

        public void ButtonSelectedChanged(Button newSelected)
        {
            foreach(var button in fishButtons)
            {
                if(button == newSelected)
                {
                    SetSelected(button);
                }
                else
                {
                    SetUnselected(button);
                }
            }

        }

        private void SetSelected(Button button)
        {
            button.BackColor = Color.FromArgb(255, Color.Black);
        }
        private void SetUnselected(Button button)
        {
            button.BackColor = Color.FromArgb(100, Color.Black);
        }
    }
}