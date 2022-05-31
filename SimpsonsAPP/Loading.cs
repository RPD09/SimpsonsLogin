using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpsonsAPP
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        //Move the Form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void timerLoad_Tick(object sender, EventArgs e)
        {
            panel2.Width += 7;
            if (panel2.Width >= 800)
            {
                timerLoad.Stop();
                this.Hide();
                Main main = new Main();
                main.Show();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Loading_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
