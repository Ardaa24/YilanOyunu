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
        private moveBLL move;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);

            move = new moveBLL(this);
            move.EnableControlDrag(this);
            move.EnableControlDrag(topPanel);
            //move.EnableControlDrag(gamePanel);

        }


        Panel parca;
        Panel yemek = new Panel();
        List<Panel> yilan = new List<Panel>();

        string yon = "right";

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        public void btnStart_Click(object sender, EventArgs e)
        {
            txtScore.Text = "0";
            PaneliTemizle();
            parca = new Panel();
            parca.Location = new Point(100, 100);
            parca.Size = new Size(20, 20);
            parca.BackColor = Color.Green;
            yilan.Add(parca);
            gamePanel.Controls.Add(yilan[0]);
            timer1.Start();
            gamePanel.Focus();
            elmaOlustur();
        }


        void carpismaVarMi()
        {
            for (int i = 2; i < yilan.Count; i++)
            {
                if (yilan[0].Location == yilan[i].Location)
                {
                    txtMessage.Visible = true;
                    txtMessage.Text = "Oyun Bitti! Skorunuz: " + txtScore.Text;
                    timer1.Stop();

                }
            }
        }

        void kazanma()
        {
            if (int.Parse(txtScore.Text) >= 500)
            {
                txtMessage.Visible = true;
                txtMessage.Text = "Oyunu Kazandınız! Skorunuz: " + txtScore.Text;
                timer1.Stop();
            }
        }
        void PaneliTemizle()
        {
            for (int i = 0; i < yilan.Count; i++)
            {
                gamePanel.Controls.Remove(yilan[i]);
            }
            yilan.Clear();
            gamePanel.Controls.Remove(yemek);
            txtMessage.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int LocX = yilan[0].Location.X;
            int LocY = yilan[0].Location.Y;
            //Sorgu ve Hareket
            elmaYediMi();
            hareket();
            carpismaVarMi();
            kazanma();


            if (yon == "right")
            {
                if (LocX < Width - 20)
                    LocX += 20;
                else
                    LocX = 0;
            }

            if (yon == "left")
            {
                if (LocX >= 20)
                    LocX -= 20;
                else
                    LocX = Width - 20;
            }

            if (yon == "down")
            {
                if (LocY < Height - 20)
                    LocY += 20;
                else
                    LocY = 0;
            }

            if (yon == "up")
            {
                if (LocY > 0)
                    LocY -= 20;
                else
                    LocY = Height - 20;
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
        void elmaOlustur()
        {
            Random rnd = new Random();
            int x = rnd.Next(0, gamePanel.Width / 20) * 20;
            int y = rnd.Next(0, gamePanel.Height / 20) * 20;
            yemek.Size = new Size(20, 20);
            yemek.BackColor = Color.Red;
            yemek.Location = new Point(x, y);
            gamePanel.Controls.Add(yemek);


        }

        void elmaYediMi()
        {
            int puan = int.Parse(txtScore.Text);
            if (yilan[0].Location == yemek.Location)
            {
                gamePanel.Controls.Remove(yemek);
                puan += 10;
                txtScore.Text = puan.ToString();
                elmaOlustur();
                yilanUzat();
            }
        }

        void yilanUzat()
        {
            Panel ekParca = new Panel();
            ekParca.Size = new Size(20, 20);
            ekParca.BackColor = Color.Gray;
            yilan.Add(ekParca);
            gamePanel.Controls.Add(ekParca);


        }

        void hareket()
        {
            for (int i = yilan.Count - 1; i > 0; i--)
            {
                yilan[i].Location = yilan[i - 1].Location;
            }
        }


    }

}
