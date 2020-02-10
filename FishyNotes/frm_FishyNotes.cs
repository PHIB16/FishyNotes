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

        private IDictionary<Guid, frm_Note> _notes = new Dictionary<Guid, frm_Note>();
        
        private NoteData noteData = new NoteData();

        
        private frm_Note Noteform;



        private DeleteNoteDelegate _DeleteNote;
        private AddNoteDelegate _AddNote;
        private RetrieveTextDelegate _RetrieveText;
        private ReplaceTextDelegate _ReplaceText;

        public frm_FishyNotes()
        {
            InitializeComponent();
            _AddNote = noteData.AddNote;
            _DeleteNote = noteData.RemoveNote;

            _ReplaceText = noteData.ReplaceNoteText;
            _RetrieveText = noteData.RetrieveNoteText;
           
        }

       
        
        private void btn_AddNote_Click(object sender, EventArgs e)
        {
            
            Noteform = new frm_Note(_ReplaceText,_RetrieveText);
            _notes.Add(Noteform.ID, Noteform);
            Noteform.Show();

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
            this.Hide();

        }
    }
}
