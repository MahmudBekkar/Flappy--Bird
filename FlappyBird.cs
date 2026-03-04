using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int gravity = 20;
        int speed = 15;
        Random r = new Random();
        int score = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          pictureBox1.Top += gravity;
          pictureBox3.Left -= speed;
          pictureBox2.Left -= speed;
            label1.Text = $"Point Value: {score} ";
            if(pictureBox3.Left < 0) { pictureBox3.Left = r.Next(500, 600); score++; }
            if (pictureBox2.Left < 0) { pictureBox2.Left = r.Next(500, 600); score++; }
            if(pictureBox1.Bounds.IntersectsWith(pictureBox3.Bounds) || 
               pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
            { timer1.Stop(); label1.Text = $" GAME IS OVER, Points Value:{score}";  }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {if (timer1.Enabled == false)
            {
                if (e.KeyCode == Keys.Enter) { timer1.Start(); pictureBox3.Left = r.Next(500, 600); score++; pictureBox2.Left = r.Next(500, 600); score++; pictureBox1.Top = 50; }
            }
            if (e.KeyCode == Keys.Space) { gravity = -15; }
            if (pictureBox1.Top <2) { pictureBox1.Top = 15; }
             
        
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = +15;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
