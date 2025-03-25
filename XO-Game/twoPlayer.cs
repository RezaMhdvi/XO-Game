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
    public partial class twoPlayer : Form
    {
        public twoPlayer()
        {
            InitializeComponent();
        }

        int[,] array = new int[3, 3];
        int ap = 1;

        void choose()
        {
            if (ap == 1)
            {
                label13.Text = "بازیکن O";
                ap = 2;
            }
            else if (ap == 2)
            {
                label13.Text = "بازیکن X";
                ap = 1;
            }
        }

        void Select(Label lbl)
        {
            if (lbl.Text == "")
                lbl.BackColor = Color.BlanchedAlmond;
        }
        void UnSelect(Label lbl)
        {
            lbl.BackColor = Color.Silver;
        }

        void add(Label lbl, int value, int x, int y)
        {
            if (array[x,y]==0)
            {
                int temp = 0;
                array[x, y] = value;
                if (value == 1)
                    lbl.Text = "X";
                else if(value==2)
                    lbl.Text = "O";
                temp=Check();
                if (temp == 1 )
                    MessageBox.Show("Player 'X' wins the game ","X");
                if (temp == 2)
                    MessageBox.Show("Player 'O' wins the game ", "O");
                End(temp);
                choose(); 
            }
            
        }

        int Check()
        {
          
            int temp = 0;
            for (int i = 0; i < 3; i++)
            {
                if ((array[i, 0]==1 && array[i, 1]==1 && array[i, 2]==1)||(array[0, i]==1 && array[1,i]==1 && array[2,i]==1))
                    temp = 1;
                if ((array[i, 0] == 2 && array[i, 1] == 2 && array[i, 2] == 2) || (array[0, i] == 2 && array[1, i] == 2 && array[2, i] == 2))
                    temp = 2;
            }
            if ((array[0, 0] == 1 && array[1, 1] == 1 && array[2, 2] == 1) || (array[0, 2] == 1 && array[1, 1] == 1 && array[2, 0] == 1))
                temp = 1;
            if ((array[0, 0] == 2 && array[1, 1] == 2 && array[2, 2] == 2) || (array[0, 2] == 2 && array[1, 1] == 2 && array[2, 0] == 2))
                temp = 2;
            return temp;
        }

        int x,o;

        void End(int user)
        {
            if (user == 1)
                x++;
            if (user == 2)
                o++;
            label15.Text = string.Format("X[{0}]  O[{1}]", x, o);
        }
        private void twoPlayer_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = 0;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            add(label1, ap, 0, 0);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            add(label2, ap, 0, 1);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            add(label3, ap, 0, 2);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            add(label4, ap, 1, 0);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            add(label5, ap, 1, 1);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            add(label6, ap, 1, 2);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            add(label7, ap, 2, 0);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            add(label8, ap,2, 1);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            add(label9, ap, 2, 2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int s = int.Parse(lblsecond.Text);
            s++;
            int m = int.Parse(lblminute.Text); ;
            lblsecond.Text = s.ToString();
            if (s==60)
            {
                m++;
                lblminute.Text = m.ToString();
                s =0; 
                lblsecond.Text = s.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Select(((Label)sender));
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            UnSelect(((Label)sender));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = 0;
                }
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
                lblminute.Text = "0";
                lblsecond.Text = "0";
               
            }
        }

        private void twoPlayer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        
    }
}
