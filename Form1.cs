using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YilanOyunu
{
    public partial class Form1 : Form
    {
        private moveDAL move;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            move = new moveDAL(this);     
            move.EnableControlDrag(this); 
            move.EnableControlDrag(topPanel); 
           //move.EnableControlDrag(gamePanel);

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Panel parca;
        Panel yemek = new Panel();
        List<Panel> yilan = new List<Panel>();

        string yon = "right";
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           txtScore.Text = "0";
            parca = new Panel();
            parca.Location =  new Point(100, 100);
            parca.Size = new Size(20, 20);
            parca.BackColor = Color.Green;  
            yilan.Add(parca);
            gamePanel.Controls.Add(yilan[0]);
            timer1.Start();
            gamePanel.Focus();
        }

        private void txtScore_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int LocX = yilan[0].Location.X;
            int LocY = yilan[0].Location.Y;

            if (yon == "right")
            {
                if (LocX < gamePanel.Width - 20) 
                    LocX += 20;
                else
                    LocX = 0; 
            }

            if (yon == "left")
            {
                if (LocX >= 20) 
                    LocX -= 20;
                else
                    LocX = gamePanel.Width - 20;
            }

            if (yon == "down")
            {
                if (LocY < gamePanel.Height - 20) 
                    LocY += 20;
                else
                    LocY = 0; 
            }

            if (yon == "up")
            {
                if (LocY > 0) 
                    LocY -= 20; 
                else
                    LocY = gamePanel.Height - 20;
            }

            yilan[0].Location = new Point(LocX, LocY);
        }

        
        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right && yon != "left")
            {
                yon = "right";
            }
            else if (e.KeyCode == Keys.Left && yon != "right")
            {
                yon = "left";
            }
            else if (e.KeyCode == Keys.Up && yon != "down")
            {
                yon = "up";
            }
            else if (e.KeyCode == Keys.Down && yon != "up")
            {
                yon = "down";
            }
        }
    }
}
