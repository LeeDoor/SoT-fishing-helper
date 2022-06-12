namespace Sea_of_Thieves_helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GlobalKeyboardHook gkh = new GlobalKeyboardHook();
        private void Form1_Load(object sender, EventArgs e)
        {
            gkh.HookedKeys.Add(Keys.NumPad2);
            gkh.HookedKeys.Add(Keys.NumPad4);
            gkh.HookedKeys.Add(Keys.NumPad6);
            gkh.HookedKeys.Add(Keys.NumPad8);
            gkh.HookedKeys.Add(Keys.NumPad5);
            gkh.KeyUp += new KeyEventHandler(gkh_KeyUp);
        }
        void gkh_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad2:
                    break;
                case Keys.NumPad4:
                    break;
                case Keys.NumPad6:
                    break;
                case Keys.NumPad8:
                    break;
                case Keys.NumPad5:
                    this.TopMost = true;
                    this.TopMost = false;
                    break;
            }
        }
    }
}