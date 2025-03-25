using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO_Game
{
    public partial class One_player : Form
    {
        public One_player()
        {
            InitializeComponent();
        }
        int[,] array = new int[3, 3];

        private void One_player_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = 0;
                }
            }
        }

        void Add(Label lbl, int x, int y)
        {
            if (array[x,y]==0)
            {
                array[x, y] = 2;
                lbl.Text = "O";
                Restart();
            }
        }

        void Restart()
        {
            string str = label1.Text + label2.Text + label3.Text + label4.Text + label5.Text + label6.Text + label7.Text + label8.Text + label9.Text;
            if (str.Length==9)
            {
                 for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                        array[i, j] = 0;
                 label2.Text = "";
                 label3.Text = "";
                 label4.Text = "";
                 label5.Text = "";
                 label6.Text = "";
                 label7.Text = "";
                 label8.Text = "";
                 label9.Text = "";
                 array[0, 0] = 1;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Add(label2,0,1);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Add(label3, 0, 2);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Add(label4, 1, 0);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Add(label5, 1, 1);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Add(label6, 1, 2);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Add(label7, 2, 0);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Add(label8, 2, 1);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Add(label9, 2, 2);
        }
    }
}
