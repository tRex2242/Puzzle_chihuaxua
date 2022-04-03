using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle
{
    public partial class Form1 : Form
    {
        PictureBox[] frames;
        Image[] original;
        Image[] parts;
        int black_index;
        int moves;
        int estimatedTime;


        public Form1()
        {
            InitializeComponent();
            init_game();
            show();
            shuffle();
        }

        void init_game()
        {
            frames = new PictureBox[]
            {
                frame1,frame2,frame3, frame4,frame5,frame6, frame7, frame8,
                frame9
            };

            original = new Image[]
            {
                Properties.Resources.image_part_001, 
                Properties.Resources.image_part_002,
                Properties.Resources.image_part_003, 
                Properties.Resources.image_part_004,
                Properties.Resources.image_part_005, 
                Properties.Resources.image_part_006,
                Properties.Resources.image_part_007, 
                Properties.Resources.image_part_008,
                Properties.Resources.black
            };

            parts = new Image[9];
            original.CopyTo(parts, 0);
            moves = 0;
            estimatedTime = 90;
            black_index = 0;
        }
        void shuffle()
        {
            List<int> freeIndexies = new List<int>() 
            { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            Random random = new Random();
            for(int a = 0; a < parts.Length; a++)
            {
                int usedIndex = freeIndexies[random.Next
                    (freeIndexies.Count())];
                parts[a] = original[usedIndex];
                freeIndexies.Remove(usedIndex);
                if(usedIndex == 8)
                {
                    black_index = a;
                }
            }
        }
        void show()
        {
            for(int a = 0; a < frames.Length; a++)
            {
                frames[a].Image = parts[a];
            }
        }

        private void Shuffle_Click(object sender, EventArgs e)
        {
            shuffle();
            show();
        }
    }
}
