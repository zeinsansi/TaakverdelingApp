namespace TaakverdelingApp
{
    partial class MijnGroepn
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
            this.btnGroepMaken = new System.Windows.Forms.Button();
            this.gbMijnGroepn = new System.Windows.Forms.GroupBox();
            this.lbxMijnGroepen = new System.Windows.Forms.CheckedListBox();
            this.lbGroepleden = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.gbMijnGroepn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGroepMaken
            // 
            this.btnGroepMaken.Location = new System.Drawing.Point(347, 498);
            this.btnGroepMaken.Name = "btnGroepMaken";
            this.btnGroepMaken.Size = new System.Drawing.Size(208, 81);
            this.btnGroepMaken.TabIndex = 4;
            this.btnGroepMaken.Text = "Groep Maken";
            this.btnGroepMaken.UseVisualStyleBackColor = true;
            this.btnGroepMaken.Click += new System.EventHandler(this.btnGroepMaken_Click);
            // 
            // gbMijnGroepn
            // 
            this.gbMijnGroepn.Controls.Add(this.lbxMijnGroepen);
            this.gbMijnGroepn.Location = new System.Drawing.Point(81, 59);
            this.gbMijnGroepn.Name = "gbMijnGroepn";
            this.gbMijnGroepn.Size = new System.Drawing.Size(474, 421);
            this.gbMijnGroepn.TabIndex = 3;
            this.gbMijnGroepn.TabStop = false;
            this.gbMijnGroepn.Text = "Mijn groepen";
            // 
            // lbxMijnGroepen
            // 
            this.lbxMijnGroepen.FormattingEnabled = true;
            this.lbxMijnGroepen.Location = new System.Drawing.Point(0, 58);
            this.lbxMijnGroepen.Name = "lbxMijnGroepen";
            this.lbxMijnGroepen.Size = new System.Drawing.Size(468, 324);
            this.lbxMijnGroepen.TabIndex = 1;
            this.lbxMijnGroepen.SelectedIndexChanged += new System.EventHandler(this.lbxMijnGroepen_SelectedIndexChanged);
            // 
            // lbGroepleden
            // 
            this.lbGroepleden.FormattingEnabled = true;
            this.lbGroepleden.ItemHeight = 30;
            this.lbGroepleden.Location = new System.Drawing.Point(661, 117);
            this.lbGroepleden.Name = "lbGroepleden";
            this.lbGroepleden.Size = new System.Drawing.Size(210, 334);
            this.lbGroepleden.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(661, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(81, 498);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(208, 81);
            this.btnVerwijderen.TabIndex = 7;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // MijnGroepn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 727);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbGroepleden);
            this.Controls.Add(this.btnGroepMaken);
            this.Controls.Add(this.gbMijnGroepn);
            this.Name = "MijnGroepn";
            this.Text = "Mijn groepen";
            this.Load += new System.EventHandler(this.MijnGroepn_Load);
            this.gbMijnGroepn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGroepMaken;
        private System.Windows.Forms.GroupBox gbMijnGroepn;
        private System.Windows.Forms.CheckedListBox lbxMijnGroepen;
        private System.Windows.Forms.ListBox lbGroepleden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerwijderen;
    }
}