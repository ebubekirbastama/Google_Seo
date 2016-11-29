using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Google_Toools
{
    public partial class Googlesitekontrol : MetroForm
    {
        public Googlesitekontrol()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com.tr/?gfe_rd=cr&ei=M9U7WLfzBcGz8wf4qIKwCA&gws_rd=ssl#q=site:" + "" + metroTextBox1.Text);
          
        }
    }
}
