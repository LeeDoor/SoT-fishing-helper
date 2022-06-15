using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;

namespace Sea_of_Thieves_helper
{
    public delegate void SelectedChanged(PictureBox newSelected);


    public static class FishMenu
    {
        public static event SelectedChanged OnSelectedChanged;

        public static PictureBox[] fishIcons;
        public static PictureBox selectedIcon;
        public static int selectedId;

        public static readonly int 
            pictureWidth = 125,
            pictureHeight = 151,
            space = 10,
            gridHeight = 2,
            gridWidth = 5;
        public static void CreateIconsAllFishes()
        {
            OnSelectedChanged += IconSelectedChanged;
            fishIcons = new PictureBox[FishDataBase.Fishes.Count];

            for (int height = 0; height < gridHeight; height++)
            {
                for (int width = 0; width < gridWidth; width++)
                {
                    CreateFishPicture(width, height);
                }
            }
            CreateSelectedIcon();
            SetSelectedId(0);
        }

        private static void CreateSelectedIcon() 
        {
            selectedIcon = new PictureBox();
            selectedIcon.Size = new Size(pictureWidth + 10, pictureHeight + 10);
            selectedIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            selectedIcon.Image = Image.FromFile(Form1.workingDir + "\\Images\\IconGreenScreen.png");
            Form1.source.Controls.Add(selectedIcon);
        }

        private static void CreateFishPicture(int width, int height)
        {

            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(pictureWidth, pictureHeight);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Location = new Point(space + (pictureWidth+space)*width, space + (pictureHeight + space) * height);
            pictureBox.Image = Image.FromFile(Form1.workingDir + FishDataBase.Fishes[width + height * gridWidth].Picture);
            pictureBox.BackColor = Color.Transparent;
            fishIcons[width + height * gridWidth] = pictureBox;
            Form1.source.Controls.Add(pictureBox);
        }

        public static void IconSelectedChanged(PictureBox newSelected)
        {
            foreach (var icon in fishIcons)
            {
                if (icon == newSelected)
                {
                    SetSelected(icon);
                }
                else
                {
                    SetUnselected(icon);
                }
            }

        }
        private static void SetSelected(PictureBox icon)
        {
            if (fishIcons != null)
                selectedIcon.Location = new Point(fishIcons[selectedId].Location.X - 5, fishIcons[selectedId].Location.Y - 5);
            else
                MessageBox.Show("SELECTED ICON NOT LOADED");

            Form1.source.SetFishInfo(FishDataBase.Fishes[selectedId]);
        }

        private static void SetUnselected(PictureBox icon)
        {

        }

        private static void SetSelectedId(int id)
        {
            if (0 <= id && id <= FishDataBase.Fishes.Count - 1)
            {
                selectedId = id;
            }
            OnSelectedChanged?.Invoke(fishIcons[selectedId]);
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
            OnSelectedChanged?.Invoke(fishIcons[selectedId]);
        }
        public static void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad2:
                    for (int i = 0; i < 5; i++)
                        SetSelectedId(false);
                    break;
                case Keys.NumPad4:
                    SetSelectedId(false);
                    break;
                case Keys.NumPad6:
                    SetSelectedId(true);
                    break;
                case Keys.NumPad8:
                    for(int i = 0; i < 5; i++)
                        SetSelectedId(true);
                    break;
                case Keys.NumPad5:
                    Form1.source.TopMost = true;
                    Form1.source.TopMost = false;
                    break;
            }
        }
    }
}
