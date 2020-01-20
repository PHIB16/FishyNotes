using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishyNotes
{
    public partial class frm_FishyNotes : Form
    {

        private frm_Note Noteform;

        public frm_FishyNotes()
        {
            InitializeComponent();
            
        }

        private void btn_AddNote_Click(object sender, EventArgs e)
        {
            Noteform = new frm_Note();
            this.Hide();
            Noteform.ShowDialog();
            this.Show();
            
        }

        private void frm_FishyNotes_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                trayMenu.Visible = true;

            }

        }

        private void trayMenu_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
                ShowInTaskbar = true;
                trayMenu.Visible = false;

            }

        }

        private void frm_FishyNotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            WindowState = FormWindowState.Minimized;
            trayMenu.Visible = true;

        }
    }
}
