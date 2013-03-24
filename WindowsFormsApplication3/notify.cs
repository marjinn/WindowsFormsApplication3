using System;
using System.Collections.Generic;
using System.Text;

using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class SchedulerForm : Form
    {

        public void notify()
       {

           //POPUP

           popupNotifier1.TitleText = @"Staples® EasyTech™ Small Business Class";
           //popupNotifier1.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(118)))), ((int)(((byte)(135)))));
           popupNotifier1.BodyColor = System.Drawing.Color.White;
           popupNotifier1.ContentFont = new System.Drawing.Font("Microsoft Sans Serif", 9.00F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           popupNotifier1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           popupNotifier1.ContentText = @"Success!  Staples® EasyTech™ Small Business Class has detected and fixed a potential issue with this computer.";
           popupNotifier1.ShowCloseButton = false;
           popupNotifier1.ShowOptionsButton = false;
           popupNotifier1.ShowGrip = true;
           popupNotifier1.Delay = int.Parse("3000");
           popupNotifier1.AnimationInterval = int.Parse("10");
           popupNotifier1.AnimationDuration = int.Parse("1000");
           popupNotifier1.TitlePadding = new Padding(int.Parse("2"));
           popupNotifier1.ContentPadding = new Padding(int.Parse("2"));
           popupNotifier1.ImagePadding = new Padding(int.Parse("9"));
           popupNotifier1.Scroll = true;
           // popupNotifier1.Image =
           //popupNotifier1.Image = Properties.Resources._logo1_(1);
           //popupNotifier1.Image = Properties.Resources._157_GetPermission_48x48_72;




           popupNotifier1.Image = Properties.Resources._157_GetPermission_48x48_72;

           popupNotifier1.Popup();
       }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

     }
}
