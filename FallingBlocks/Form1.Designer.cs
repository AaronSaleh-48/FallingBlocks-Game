namespace FallingBlocks
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrGravitation = new System.Windows.Forms.Timer(this.components);
            this.lblScoreText = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.tmrMoving = new System.Windows.Forms.Timer(this.components);
            this.tmrCollision = new System.Windows.Forms.Timer(this.components);
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbBlock = new System.Windows.Forms.PictureBox();
            this.pbWallR = new System.Windows.Forms.PictureBox();
            this.pbWallL = new System.Windows.Forms.PictureBox();
            this.pbTop = new System.Windows.Forms.PictureBox();
            this.pbGround = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWallR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWallL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrGravitation
            // 
            this.tmrGravitation.Enabled = true;
            this.tmrGravitation.Interval = 1;
            this.tmrGravitation.Tick += new System.EventHandler(this.tmrGravitation_Tick);
            // 
            // lblScoreText
            // 
            this.lblScoreText.AutoSize = true;
            this.lblScoreText.BackColor = System.Drawing.Color.FloralWhite;
            this.lblScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreText.ForeColor = System.Drawing.Color.Yellow;
            this.lblScoreText.Location = new System.Drawing.Point(802, 23);
            this.lblScoreText.Name = "lblScoreText";
            this.lblScoreText.Size = new System.Drawing.Size(97, 32);
            this.lblScoreText.TabIndex = 5;
            this.lblScoreText.Text = "Score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Yellow;
            this.lblScore.Location = new System.Drawing.Point(905, 23);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(24, 32);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "-";
            // 
            // tmrMoving
            // 
            this.tmrMoving.Enabled = true;
            this.tmrMoving.Interval = 1;
            this.tmrMoving.Tick += new System.EventHandler(this.tmrMoving_Tick);
            // 
            // tmrCollision
            // 
            this.tmrCollision.Enabled = true;
            this.tmrCollision.Interval = 1;
            this.tmrCollision.Tick += new System.EventHandler(this.tmrCollision_Tick);
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.Blue;
            this.pbPlayer.Image = global::FallingBlocks.Properties.Resources.png_hd_of_stick_figures_png_small_medium_large_598;
            this.pbPlayer.Location = new System.Drawing.Point(448, 429);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(91, 75);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 7;
            this.pbPlayer.TabStop = false;
            // 
            // pbBlock
            // 
            this.pbBlock.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbBlock.Image = global::FallingBlocks.Properties.Resources.jt0h5vc2uro11;
            this.pbBlock.Location = new System.Drawing.Point(417, 186);
            this.pbBlock.Name = "pbBlock";
            this.pbBlock.Size = new System.Drawing.Size(180, 175);
            this.pbBlock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBlock.TabIndex = 4;
            this.pbBlock.TabStop = false;
            this.pbBlock.Click += new System.EventHandler(this.pbBlock_Click);
            // 
            // pbWallR
            // 
            this.pbWallR.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbWallR.BackgroundImage = global::FallingBlocks.Properties.Resources.old_red_brick_wall_background_picture_id980299714;
            this.pbWallR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbWallR.Location = new System.Drawing.Point(959, -30);
            this.pbWallR.Name = "pbWallR";
            this.pbWallR.Size = new System.Drawing.Size(38, 647);
            this.pbWallR.TabIndex = 3;
            this.pbWallR.TabStop = false;
            // 
            // pbWallL
            // 
            this.pbWallL.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbWallL.BackgroundImage = global::FallingBlocks.Properties.Resources.old_red_brick_wall_background_picture_id980299714;
            this.pbWallL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbWallL.Location = new System.Drawing.Point(-13, -30);
            this.pbWallL.Name = "pbWallL";
            this.pbWallL.Size = new System.Drawing.Size(38, 647);
            this.pbWallL.TabIndex = 2;
            this.pbWallL.TabStop = false;
            // 
            // pbTop
            // 
            this.pbTop.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbTop.BackgroundImage = global::FallingBlocks.Properties.Resources.old_red_brick_wall_background_picture_id980299714;
            this.pbTop.Location = new System.Drawing.Point(-35, -30);
            this.pbTop.Name = "pbTop";
            this.pbTop.Size = new System.Drawing.Size(1057, 50);
            this.pbTop.TabIndex = 1;
            this.pbTop.TabStop = false;
            // 
            // pbGround
            // 
            this.pbGround.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbGround.BackgroundImage = global::FallingBlocks.Properties.Resources.old_red_brick_wall_background_picture_id980299714;
            this.pbGround.Location = new System.Drawing.Point(-13, 518);
            this.pbGround.Name = "pbGround";
            this.pbGround.Size = new System.Drawing.Size(1057, 50);
            this.pbGround.TabIndex = 0;
            this.pbGround.TabStop = false;
            this.pbGround.Click += new System.EventHandler(this.pbGround_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FallingBlocks.Properties.Resources.Splash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 554);
            this.Controls.Add(this.pbGround);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblScoreText);
            this.Controls.Add(this.pbBlock);
            this.Controls.Add(this.pbWallR);
            this.Controls.Add(this.pbWallL);
            this.Controls.Add(this.pbTop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "§";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWallR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWallL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGround;
        private System.Windows.Forms.PictureBox pbTop;
        private System.Windows.Forms.PictureBox pbWallL;
        private System.Windows.Forms.PictureBox pbWallR;
        private System.Windows.Forms.PictureBox pbBlock;
        private System.Windows.Forms.Timer tmrGravitation;
        private System.Windows.Forms.Label lblScoreText;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Timer tmrMoving;
        private System.Windows.Forms.Timer tmrCollision;
    }
}

