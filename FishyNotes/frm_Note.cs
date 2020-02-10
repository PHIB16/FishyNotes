using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishyNotes
{
    public partial class frm_Note : Form
    {
        private Guid NoteID;

        public Guid ID { get { return NoteID; } }

        private Boolean Min = false;

        private String DefaultText = "Enter note here";

        private ReplaceTextDelegate ReplaceNote;
        private RetrieveTextDelegate RetrieveNote;

        public frm_Note(ReplaceTextDelegate pDelegate, RetrieveTextDelegate pTextDelegate)
        {
            NoteID = Guid.NewGuid();
            InitializeComponent();
            tb_NoteBox.Text = DefaultText;

            ReplaceNote = pDelegate;
            RetrieveNote = pTextDelegate;
        }

        private void btn_Discard_Click(object sender, EventArgs e)
        {
           // DeleteNote(NoteID);
            
        }
        
       

        private void btn_Save_Click(object sender, EventArgs e)
        {

            try
            {
                TextWriter txtSave = new StreamWriter(@"C:\Users\phib1_16\Documents\" + tb_NoteName.Text + ".txt");
                txtSave.Write(tb_NoteBox.Text);
                txtSave.Close();
                tb_NoteName.Clear();
                tb_NoteBox.Clear();
                MessageBox.Show("Congrats", "Save Complete");
            }
            catch (Exception E)
            {
                MessageBox.Show("Something went wrong" + E.ToString(), "Save Failure");
            }

        }

        private void tb_NoteBox_Enter(object sender, EventArgs e)
        {
            if (tb_NoteBox.Text == DefaultText)
            {
                tb_NoteBox.Clear();

            }
        }

        private void tb_NoteBox_Leave(object sender, EventArgs e)
        {
            if (tb_NoteBox.Text == "")
            {
                tb_NoteBox.Text = DefaultText;

            }
            RetrieveNote(NoteID);

        }

        private void frm_Note_Load(object sender, EventArgs e)
        {

        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            if (Min)
            {
         
                tb_NoteBox.Show();
                this.Height = 442;
                Min = false;

            }
            else
            {
                tb_NoteBox.Hide();
                this.Height = 96;
                Min = true;
            }


        }
    }
}
