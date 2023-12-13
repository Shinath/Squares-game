namespace SquaresGame
{
    partial class Game
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
            this.enemyBottom = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.enemyTop = new System.Windows.Forms.PictureBox();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.border = new System.Windows.Forms.PictureBox();
            this.yBorder = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // enemyBottom
            // 
            this.enemyBottom.BackColor = System.Drawing.Color.Magenta;
            this.enemyBottom.Location = new System.Drawing.Point(316, 273);
            this.enemyBottom.Name = "enemyBottom";
            this.enemyBottom.Size = new System.Drawing.Size(75, 190);
            this.enemyBottom.TabIndex = 0;
            this.enemyBottom.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.player.Location = new System.Drawing.Point(40, 191);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(37, 38);
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // enemyTop
            // 
            this.enemyTop.BackColor = System.Drawing.Color.Magenta;
            this.enemyTop.Location = new System.Drawing.Point(476, 0);
            this.enemyTop.Name = "enemyTop";
            this.enemyTop.Size = new System.Drawing.Size(75, 160);
            this.enemyTop.TabIndex = 2;
            this.enemyTop.TabStop = false;
            // 
            // coin1
            // 
            this.coin1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coin1.BackColor = System.Drawing.Color.Gold;
            this.coin1.Location = new System.Drawing.Point(275, 159);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(23, 23);
            this.coin1.TabIndex = 3;
            this.coin1.TabStop = false;
            this.coin1.Tag = "coin";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // border
            // 
            this.border.Location = new System.Drawing.Point(-16, 461);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(700, 2);
            this.border.TabIndex = 5;
            this.border.TabStop = false;
            // 
            // yBorder
            // 
            this.yBorder.Location = new System.Drawing.Point(621, 0);
            this.yBorder.Name = "yBorder";
            this.yBorder.Size = new System.Drawing.Size(216, 500);
            this.yBorder.TabIndex = 6;
            this.yBorder.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(623, 461);
            this.Controls.Add(this.yBorder);
            this.Controls.Add(this.border);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.enemyTop);
            this.Controls.Add(this.player);
            this.Controls.Add(this.enemyBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.enemyBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yBorder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox enemyBottom;
        private PictureBox player;
        private PictureBox enemyTop;
        private PictureBox coin1;
        private PictureBox coin2;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox border;
        private PictureBox yBorder;
    }
}