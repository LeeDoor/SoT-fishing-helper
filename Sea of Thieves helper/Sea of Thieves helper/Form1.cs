namespace Sea_of_Thieves_helper
{
    public partial class Form1 : Form
    {
        public static Form1 source;

        GlobalKeyboardHook gkh = new GlobalKeyboardHook();

        public Form1()
        {
            source = this;
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
            FishMenu.CreateButtons();
        }

    }
}