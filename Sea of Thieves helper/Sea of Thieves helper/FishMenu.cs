using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea_of_Thieves_helper
{
    public delegate void SelectedChanged(Button newSelected);
    public static class FishMenu
    {
        public static event SelectedChanged OnSelectedChanged;

        public static Button[] fishButtons;
        public static int selectedId;

        public static void CreateButtons()
        {
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
                Form1.source.Controls.Add(butt);
                fishButtons[i] = butt;
            }
            SetSelectedId(0);
        }
        public static void ButtonSelectedChanged(Button newSelected)
        {
            foreach (var button in fishButtons)
            {
                if (button == newSelected)
                {
                    SetSelected(button);
                }
                else
                {
                    SetUnselected(button);
                }
            }

        }
        private static void SetSelected(Button button)
        {
            button.BackColor = Color.FromArgb(255, Color.Black);
            button.Select();

        }
        private static void SetUnselected(Button button)
        {
            button.BackColor = Color.FromArgb(100, Color.Black);
        }
        private static void SetSelectedId(int id)
        {
            if (0 <= id && id <= FishDataBase.Fishes.Count - 1)
            {
                selectedId = id;
            }
            OnSelectedChanged?.Invoke(fishButtons[selectedId]);
        }
        private static void SetSelectedId(bool isForward)
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
        public static void gkh_KeyDown(object sender, KeyEventArgs e)
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
                    Form1.source.TopMost = true;
                    Form1.source.TopMost = false;
                    break;
            }
        }
    }
}
