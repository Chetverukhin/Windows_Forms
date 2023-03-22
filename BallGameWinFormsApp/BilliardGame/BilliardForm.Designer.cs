namespace BilliardGame
{
    partial class BilliardForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTopMain = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTop = new System.Windows.Forms.Label();
            this.panelDown = new System.Windows.Forms.Panel();
            this.labelDown = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.labelLeft = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.labelRight = new System.Windows.Forms.Label();
            this.panelGame = new System.Windows.Forms.Panel();
            this.panelTopMain.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelDown.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopMain
            // 
            this.panelTopMain.BackColor = System.Drawing.Color.LightGray;
            this.panelTopMain.Controls.Add(this.buttonStart);
            this.panelTopMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMain.Location = new System.Drawing.Point(0, 0);
            this.panelTopMain.Name = "panelTopMain";
            this.panelTopMain.Size = new System.Drawing.Size(800, 50);
            this.panelTopMain.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStart.Location = new System.Drawing.Point(162, 0);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 50);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "START!";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelTop.Controls.Add(this.labelTop);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 50);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 30);
            this.panelTop.TabIndex = 1;
            // 
            // labelTop
            // 
            this.labelTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTop.Location = new System.Drawing.Point(383, 0);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(66, 30);
            this.labelTop.TabIndex = 2;
            this.labelTop.Text = "0";
            this.labelTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDown
            // 
            this.panelDown.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelDown.Controls.Add(this.labelDown);
            this.panelDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDown.Location = new System.Drawing.Point(0, 420);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(800, 30);
            this.panelDown.TabIndex = 2;
            // 
            // labelDown
            // 
            this.labelDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDown.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDown.Location = new System.Drawing.Point(383, 0);
            this.labelDown.Name = "labelDown";
            this.labelDown.Size = new System.Drawing.Size(66, 30);
            this.labelDown.TabIndex = 3;
            this.labelDown.Text = "0";
            this.labelDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelLeft.Controls.Add(this.labelLeft);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 80);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(30, 340);
            this.panelLeft.TabIndex = 3;
            // 
            // labelLeft
            // 
            this.labelLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLeft.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLeft.Location = new System.Drawing.Point(0, 114);
            this.labelLeft.Name = "labelLeft";
            this.labelLeft.Size = new System.Drawing.Size(30, 50);
            this.labelLeft.TabIndex = 0;
            this.labelLeft.Text = "0";
            this.labelLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelRight.Controls.Add(this.labelRight);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(770, 80);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(30, 340);
            this.panelRight.TabIndex = 4;
            // 
            // labelRight
            // 
            this.labelRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRight.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRight.Location = new System.Drawing.Point(0, 114);
            this.labelRight.Name = "labelRight";
            this.labelRight.Size = new System.Drawing.Size(30, 50);
            this.labelRight.TabIndex = 1;
            this.labelRight.Text = "0";
            this.labelRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.Color.Gainsboro;
            this.panelGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGame.Location = new System.Drawing.Point(30, 80);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(740, 340);
            this.panelGame.TabIndex = 5;
            // 
            // BilliardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelDown);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelTopMain);
            this.Name = "BilliardForm";
            this.Text = "Billiard";
            this.panelTopMain.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelDown.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelTopMain;
        private Button buttonStart;
        private Panel panelTop;
        private Panel panelDown;
        private Panel panelLeft;
        private Panel panelRight;
        private Panel panelGame;
        private Label labelTop;
        private Label labelDown;
        private Label labelLeft;
        private Label labelRight;
    }
}