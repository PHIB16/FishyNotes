namespace FishyNotes
{
    partial class frm_FishyNotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_FishyNotes));
            this.btn_AddNote = new System.Windows.Forms.Button();
            this.trayMenu = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // btn_AddNote
            // 
            this.btn_AddNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_AddNote.Location = new System.Drawing.Point(0, 0);
            this.btn_AddNote.Name = "btn_AddNote";
            this.btn_AddNote.Size = new System.Drawing.Size(269, 75);
            this.btn_AddNote.TabIndex = 0;
            this.btn_AddNote.Text = "Add Note";
            this.btn_AddNote.UseVisualStyleBackColor = true;
            this.btn_AddNote.Click += new System.EventHandler(this.btn_AddNote_Click);
            // 
            // trayMenu
            // 
            this.trayMenu.Icon = ((System.Drawing.Icon)(resources.GetObject("trayMenu.Icon")));
            this.trayMenu.Text = "Fishy Notes";
            this.trayMenu.DoubleClick += new System.EventHandler(this.trayMenu_DoubleClick);
            // 
            // frm_FishyNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 75);
            this.Controls.Add(this.btn_AddNote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_FishyNotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Fishy Notes";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_FishyNotes_FormClosing);
            this.SizeChanged += new System.EventHandler(this.frm_FishyNotes_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AddNote;
        private System.Windows.Forms.NotifyIcon trayMenu;
    }
}

