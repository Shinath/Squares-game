namespace SquaresGame
{
    partial class Menu
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
            this.menuStart = new System.Windows.Forms.Button();
            this.menuQuit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuStart
            // 
            this.menuStart.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStart.Location = new System.Drawing.Point(88, 132);
            this.menuStart.Name = "menuStart";
            this.menuStart.Size = new System.Drawing.Size(113, 36);
            this.menuStart.TabIndex = 0;
            this.menuStart.TabStop = false;
            this.menuStart.Text = "Start";
            this.menuStart.UseVisualStyleBackColor = true;
            this.menuStart.Click += new System.EventHandler(this.StartGame);
            // 
            // menuQuit
            // 
            this.menuQuit.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuQuit.Location = new System.Drawing.Point(88, 190);
            this.menuQuit.Name = "menuQuit";
            this.menuQuit.Size = new System.Drawing.Size(113, 38);
            this.menuQuit.TabIndex = 1;
            this.menuQuit.TabStop = false;
            this.menuQuit.Text = "Quit";
            this.menuQuit.UseVisualStyleBackColor = true;
            this.menuQuit.Click += new System.EventHandler(this.QuitGame);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "SquaresGame";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuQuit);
            this.Controls.Add(this.menuStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button menuStart;
        private Button menuQuit;
        private Label label1;
    }
}