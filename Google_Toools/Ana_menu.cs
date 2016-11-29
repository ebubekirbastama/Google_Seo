using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Google_Toools
{
    public partial class Ana_menu : MetroForm
    {
        public Ana_menu()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Googlesitekontrol gsk = new Googlesitekontrol();
            gsk.ShowDialog();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com/webmasters/tools/home?hl=tr");
        }

        private void Ana_menu_Load(object sender, EventArgs e)
        {
            webBrowser2.Hide();
        }
    }
}
