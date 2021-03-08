namespace FallingBlocks
{
    partial class frmTitleScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrButtonColorChange = new System.Windows.Forms.Timer(this.components);
            this.lblHighScoreText = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Falling Blocks";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Red;
            this.btnStart.Location = new System.Drawing.Point(356, 288);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(191, 68);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrButtonColorChange
            // 
            this.tmrButtonColorChange.Enabled = true;
            this.tmrButtonColorChange.Interval = 1000;
            this.tmrButtonColorChange.Tick += new System.EventHandler(this.tmrButtonColorChange_Tick);
            // 
            // lblHighScoreText
            // 
            this.lblHighScoreText.AutoSize = true;
            this.lblHighScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScoreText.Location = new System.Drawing.Point(351, 521);
            this.lblHighScoreText.Name = "lblHighScoreText";
            this.lblHighScoreText.Size = new System.Drawing.Size(167, 26);
            this.lblHighScoreText.TabIndex = 2;
            this.lblHighScoreText.Text = "Dein Highscore:";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.Location = new System.Drawing.Point(522, 521);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(19, 26);
            this.lblHighScore.TabIndex = 3;
            this.lblHighScore.Text = "-";
            // 
            // frmTitleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblHighScoreText);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTitleScreen";
            this.Text = "FallingBlocks";
            this.Load += new System.EventHandler(this.frmTitleScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrButtonColorChange;
        private System.Windows.Forms.Label lblHighScoreText;
        private System.Windows.Forms.Label lblHighScore;
    }
}