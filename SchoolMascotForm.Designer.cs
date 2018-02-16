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
            this.grbGroup = new System.Windows.Forms.GroupBox();
            this.mnuSelection.SuspendLayout();
            this.grbGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMascot
            // 
            this.lblMascot.AutoSize = true;
            this.lblMascot.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascot.Location = new System.Drawing.Point(68, 85);
            this.lblMascot.Name = "lblMascot";
            this.lblMascot.Size = new System.Drawing.Size(106, 37);
            this.lblMascot.TabIndex = 0;
            this.lblMascot.Text = "Saints";
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Font = new System.Drawing.Font("Charlemagne Std", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchool.Location = new System.Drawing.Point(6, 26);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(263, 38);
            this.lblSchool.TabIndex = 1;
            this.lblSchool.Text = "Immaculata";
            this.lblSchool.Click += new System.EventHandler(this.lblSchool_Click);
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
            this.mniImmaculata.Click += new System.EventHandler(this.mniImmaculata_Click);
            // 
            // mniGryffindor
            // 
            this.mniGryffindor.Name = "mniGryffindor";
            this.mniGryffindor.Size = new System.Drawing.Size(152, 22);
            this.mniGryffindor.Text = "Gryffindor";
            this.mniGryffindor.Click += new System.EventHandler(this.mniGryffindor_Click);
            // 
            // mniSlytherin
            // 
            this.mniSlytherin.Name = "mniSlytherin";
            this.mniSlytherin.Size = new System.Drawing.Size(152, 22);
            this.mniSlytherin.Text = "Slytherin";
            this.mniSlytherin.Click += new System.EventHandler(this.mniSlytherin_Click);
            // 
            // mniRavenclaw
            // 
            this.mniRavenclaw.Name = "mniRavenclaw";
            this.mniRavenclaw.Size = new System.Drawing.Size(152, 22);
            this.mniRavenclaw.Text = "Ravenclaw";
            this.mniRavenclaw.Click += new System.EventHandler(this.mniRavenclaw_Click);
            // 
            // mniHufflepuff
            // 
            this.mniHufflepuff.Name = "mniHufflepuff";
            this.mniHufflepuff.Size = new System.Drawing.Size(152, 22);
            this.mniHufflepuff.Text = "Hufflepuff";
            this.mniHufflepuff.Click += new System.EventHandler(this.mniHufflepuff_Click);
            // 
            // grbGroup
            // 
            this.grbGroup.Controls.Add(this.lblSchool);
            this.grbGroup.Controls.Add(this.lblMascot);
            this.grbGroup.Location = new System.Drawing.Point(12, 76);
            this.grbGroup.Name = "grbGroup";
            this.grbGroup.Size = new System.Drawing.Size(272, 155);
            this.grbGroup.TabIndex = 3;
            this.grbGroup.TabStop = false;
            // 
            // frmSchoolMascot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.grbGroup);
            this.Controls.Add(this.mnuSelection);
            this.MainMenuStrip = this.mnuSelection;
            this.Name = "frmSchoolMascot";
            this.Text = "School Mascot By Tiva";
            this.mnuSelection.ResumeLayout(false);
            this.mnuSelection.PerformLayout();
            this.grbGroup.ResumeLayout(false);
            this.grbGroup.PerformLayout();
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
        private System.Windows.Forms.GroupBox grbGroup;
    }
}

