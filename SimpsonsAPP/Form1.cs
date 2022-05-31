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
    public partial class Form1 : Form
    {
        public Form1()
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

        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        SqlConnection conectarBD = new SqlConnection(@"Server = DESKTOP-33VTQCF\SQLEXPRESS; Database= SimpsonsLogin; Integrated Security=True;");

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            conectarBD.Open();
            SqlCommand cmdDados = new SqlCommand("Select * from Credentials where Username='" + textBoxUser.Text.ToString() + "' and Password='" + textBoxPW.Text.ToString() + "'", conectarBD);
            SqlDataReader drDados = cmdDados.ExecuteReader();
            if (drDados.Read())
            {
                drDados.Close();
                if (textBoxUser.Text.Length > 0 && textBoxPW.Text.Length > 0)
                {
                    cmdDados.ExecuteNonQuery();
                    MessageBox.Show(" Successfully logged in");
                    this.Hide();
                    Loading load = new Loading();
                    load.Show();

                }
            }
            else
            {
                drDados.Close();
                MessageBox.Show(" Incorrect Credentials");
                textBoxUser.Text = "";
                textBoxPW.Text = "";
            }
            conectarBD.Close();
        }

        private void textBoxUser_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "Username") { textBoxUser.Text = ""; textBoxPW.Text = ""; }
        }
    }
}
