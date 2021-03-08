namespace FallingBlocks
{
    partial class frmEndScreen
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
            this.lblUGotHit = new System.Windows.Forms.Label();
            this.lblUrScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUGotHit
            // 
            this.lblUGotHit.AutoSize = true;
            this.lblUGotHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUGotHit.Location = new System.Drawing.Point(12, 46);
            this.lblUGotHit.Name = "lblUGotHit";
            this.lblUGotHit.Size = new System.Drawing.Size(797, 91);
            this.lblUGotHit.TabIndex = 0;
            this.lblUGotHit.Text = "Du wurdest getroffen!";
            // 
            // lblUrScore
            // 
            this.lblUrScore.AutoSize = true;
            this.lblUrScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrScore.Location = new System.Drawing.Point(149, 137);
            this.lblUrScore.Name = "lblUrScore";
            this.lblUrScore.Size = new System.Drawing.Size(347, 44);
            this.lblUrScore.TabIndex = 1;
            this.lblUrScore.Text = "Dies ist dein Score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(502, 137);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(33, 44);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter um neu zu starten ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(417, 44);
            this.label2.TabIndex = 4;
            this.label2.Text = "Escape um zu beenden";
            // 
            // frmEndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblUrScore);
            this.Controls.Add(this.lblUGotHit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEndScreen";
            this.Text = "FallingBlocks";
            this.Load += new System.EventHandler(this.frmEndScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEndScreen_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUGotHit;
        private System.Windows.Forms.Label lblUrScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}