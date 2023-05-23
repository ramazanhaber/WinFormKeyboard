using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormKeyboard
{
    public partial class Form1 : Form
    {
        // kaynak  : https://www.codeproject.com/Articles/13596/Touchscreen-Keyboard-UserControl

        public string aciklama = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void keyboardcontrol1_UserKeyPressed(object sender, KeyboardEventArgs e)
        {
            txtAciklama.Focus();
            txtAciklama.Select();
            SendKeys.Send(e.KeyboardKeyPressed);
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            aciklama = "";
            this.Close();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            aciklama = txtAciklama.Text;
            this.Close();
        }
    }
}
