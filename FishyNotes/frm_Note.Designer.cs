namespace FishyNotes
{
    partial class frm_Note
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
            this.tb_NoteBox = new System.Windows.Forms.TextBox();
            this.btn_Discard = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Min = new System.Windows.Forms.Button();
            this.tb_NoteName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_NoteBox
            // 
            this.tb_NoteBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_NoteBox.Location = new System.Drawing.Point(0, 56);
            this.tb_NoteBox.Multiline = true;
            this.tb_NoteBox.Name = "tb_NoteBox";
            this.tb_NoteBox.Size = new System.Drawing.Size(401, 347);
            this.tb_NoteBox.TabIndex = 1;
            this.tb_NoteBox.Enter += new System.EventHandler(this.tb_NoteBox_Enter);
            this.tb_NoteBox.Leave += new System.EventHandler(this.tb_NoteBox_Leave);
            // 
            // btn_Discard
            // 
            this.btn_Discard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Discard.Location = new System.Drawing.Point(326, 0);
            this.btn_Discard.Name = "btn_Discard";
            this.btn_Discard.Size = new System.Drawing.Size(75, 56);
            this.btn_Discard.TabIndex = 1;
            this.btn_Discard.Text = "Discard Note";
            this.btn_Discard.UseVisualStyleBackColor = true;
            this.btn_Discard.Click += new System.EventHandler(this.btn_Discard_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Save.Location = new System.Drawing.Point(251, 0);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 56);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Save Note";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Min
            // 
            this.btn_Min.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Min.Location = new System.Drawing.Point(0, 0);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.Size = new System.Drawing.Size(75, 56);
            this.btn_Min.TabIndex = 3;
            this.btn_Min.Text = "thing";
            this.btn_Min.UseVisualStyleBackColor = true;
            this.btn_Min.Click += new System.EventHandler(this.btn_Min_Click);
            // 
            // tb_NoteName
            // 
            this.tb_NoteName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_NoteName.Location = new System.Drawing.Point(151, 19);
            this.tb_NoteName.Name = "tb_NoteName";
            this.tb_NoteName.Size = new System.Drawing.Size(94, 20);
            this.tb_NoteName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Note Name:";
            // 
            // frm_Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 403);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_NoteName);
            this.Controls.Add(this.btn_Min);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Discard);
            this.Controls.Add(this.tb_NoteBox);
            this.Name = "frm_Note";
            this.Text = "frm_Note";
            this.Load += new System.EventHandler(this.frm_Note_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_NoteBox;
        private System.Windows.Forms.Button btn_Discard;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Min;
        private System.Windows.Forms.TextBox tb_NoteName;
        private System.Windows.Forms.Label label1;
    }
}