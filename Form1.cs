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
            move = new moveDAL(this);     
            move.EnableControlDrag(this); 
            move.EnableControlDrag(panel1); 

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
