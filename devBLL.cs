using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace YilanOyunu
{
    internal class devBLL
    {
        public class DeveloperInfo
        {
            public void ShowPopup()
            {
                Form popupForm = new Form();
                popupForm.Text = "Geliştirici Bağlantıları";
                popupForm.Size = new Size(300, 150);
                popupForm.StartPosition = FormStartPosition.CenterParent;
                popupForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                popupForm.MaximizeBox = false;
                popupForm.MinimizeBox = false;

                // GitHub butonu
                Button githubButton = new Button();
                githubButton.Text = "GitHub";
                githubButton.Size = new Size(100, 40);
                githubButton.Location = new Point(40, 40);
                githubButton.Click += (s, args) =>
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = "https://github.com/Ardaa24",
                        UseShellExecute = true
                    });
                    popupForm.Close();
                };

                // Instagram butonu
                Button instagramButton = new Button();
                instagramButton.Text = "Instagram";
                instagramButton.Size = new Size(100, 40);
                instagramButton.Location = new Point(150, 40);
                instagramButton.Click += (s, args) =>
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = "#", 
                        UseShellExecute = true
                    });
                    popupForm.Close();
                };


                popupForm.Controls.Add(githubButton);
                popupForm.Controls.Add(instagramButton);
                popupForm.ShowDialog();
            }
        }


    }
}
