using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace YilanOyunu
{
    internal class moveBLL
    {
        private bool move;
        private int mouseX;
        private int mouseY;
        private Form targetForm;

        public moveBLL(Form form)
        {
            targetForm = form;
        }

        public void MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        public void MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                targetForm.SetDesktopLocation(Control.MousePosition.X - mouseX, Control.MousePosition.Y - mouseY);
            }
        }

        public void MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

         public void EnableControlDrag(Control control)
        {
            control.MouseDown += MouseDown;
            control.MouseMove += MouseMove;
            control.MouseUp += MouseUp;
        }
    }
}
    

