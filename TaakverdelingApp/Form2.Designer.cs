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
            this.btnTerug = new System.Windows.Forms.Button();
            this.gbMijnGroepn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGroepMaken
            // 
            this.btnGroepMaken.Location = new System.Drawing.Point(241, 506);
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
            this.gbMijnGroepn.Location = new System.Drawing.Point(138, 162);
            this.gbMijnGroepn.Name = "gbMijnGroepn";
            this.gbMijnGroepn.Size = new System.Drawing.Size(474, 318);
            this.gbMijnGroepn.TabIndex = 3;
            this.gbMijnGroepn.TabStop = false;
            this.gbMijnGroepn.Text = "Mijn groepen";
            // 
            // lbxMijnGroepen
            // 
            this.lbxMijnGroepen.FormattingEnabled = true;
            this.lbxMijnGroepen.Location = new System.Drawing.Point(0, 58);
            this.lbxMijnGroepen.Name = "lbxMijnGroepen";
            this.lbxMijnGroepen.Size = new System.Drawing.Size(474, 260);
            this.lbxMijnGroepen.TabIndex = 1;
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(24, 40);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(186, 73);
            this.btnTerug.TabIndex = 9;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // MijnGroepn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 727);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnGroepMaken);
            this.Controls.Add(this.gbMijnGroepn);
            this.Name = "MijnGroepn";
            this.Text = "Mijn groepen";
            this.Load += new System.EventHandler(this.MijnGroepn_Load);
            this.gbMijnGroepn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGroepMaken;
        private System.Windows.Forms.GroupBox gbMijnGroepn;
        private System.Windows.Forms.CheckedListBox lbxMijnGroepen;
        private System.Windows.Forms.Button btnTerug;
    }
}