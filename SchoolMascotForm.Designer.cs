namespace SchoolMascotTivaR
{
    partial class frmSchoolMascot
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
            this.lblMascot = new System.Windows.Forms.Label();
            this.lblSchool = new System.Windows.Forms.Label();
            this.mnuSelection = new System.Windows.Forms.MenuStrip();
            this.selectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniImmaculata = new System.Windows.Forms.ToolStripMenuItem();
            this.mniGryffindor = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSlytherin = new System.Windows.Forms.ToolStripMenuItem();
            this.mniRavenclaw = new System.Windows.Forms.ToolStripMenuItem();
            this.mniHufflepuff = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMascot
            // 
            this.lblMascot.AutoSize = true;
            this.lblMascot.Location = new System.Drawing.Point(116, 137);
            this.lblMascot.Name = "lblMascot";
            this.lblMascot.Size = new System.Drawing.Size(36, 13);
            this.lblMascot.TabIndex = 0;
            this.lblMascot.Text = "Saints";
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Location = new System.Drawing.Point(116, 95);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(61, 13);
            this.lblSchool.TabIndex = 1;
            this.lblSchool.Text = "Immaculata";
            // 
            // mnuSelection
            // 
            this.mnuSelection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectionToolStripMenuItem});
            this.mnuSelection.Location = new System.Drawing.Point(0, 0);
            this.mnuSelection.Name = "mnuSelection";
            this.mnuSelection.Size = new System.Drawing.Size(284, 24);
            this.mnuSelection.TabIndex = 2;
            this.mnuSelection.Text = "Selection";
            // 
            // selectionToolStripMenuItem
            // 
            this.selectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniImmaculata,
            this.mniGryffindor,
            this.mniSlytherin,
            this.mniRavenclaw,
            this.mniHufflepuff});
            this.selectionToolStripMenuItem.Name = "selectionToolStripMenuItem";
            this.selectionToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.selectionToolStripMenuItem.Text = "Selection";
            // 
            // mniImmaculata
            // 
            this.mniImmaculata.Name = "mniImmaculata";
            this.mniImmaculata.Size = new System.Drawing.Size(152, 22);
            this.mniImmaculata.Text = "Immaculata";
            // 
            // mniGryffindor
            // 
            this.mniGryffindor.Name = "mniGryffindor";
            this.mniGryffindor.Size = new System.Drawing.Size(152, 22);
            this.mniGryffindor.Text = "Gryffindor";
            // 
            // mniSlytherin
            // 
            this.mniSlytherin.Name = "mniSlytherin";
            this.mniSlytherin.Size = new System.Drawing.Size(152, 22);
            this.mniSlytherin.Text = "Slytherin";
            // 
            // mniRavenclaw
            // 
            this.mniRavenclaw.Name = "mniRavenclaw";
            this.mniRavenclaw.Size = new System.Drawing.Size(152, 22);
            this.mniRavenclaw.Text = "Ravenclaw";
            // 
            // mniHufflepuff
            // 
            this.mniHufflepuff.Name = "mniHufflepuff";
            this.mniHufflepuff.Size = new System.Drawing.Size(152, 22);
            this.mniHufflepuff.Text = "Hufflepuff";
            // 
            // frmSchoolMascot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblSchool);
            this.Controls.Add(this.lblMascot);
            this.Controls.Add(this.mnuSelection);
            this.MainMenuStrip = this.mnuSelection;
            this.Name = "frmSchoolMascot";
            this.Text = "School Mascot By Tiva";
            this.mnuSelection.ResumeLayout(false);
            this.mnuSelection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMascot;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.MenuStrip mnuSelection;
        private System.Windows.Forms.ToolStripMenuItem selectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniImmaculata;
        private System.Windows.Forms.ToolStripMenuItem mniGryffindor;
        private System.Windows.Forms.ToolStripMenuItem mniSlytherin;
        private System.Windows.Forms.ToolStripMenuItem mniRavenclaw;
        private System.Windows.Forms.ToolStripMenuItem mniHufflepuff;
    }
}

