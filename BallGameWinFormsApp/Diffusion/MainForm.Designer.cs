namespace Diffusion
{
    partial class MainForm
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelFirstPackTop = new System.Windows.Forms.Label();
            this.labelSecondPackTop = new System.Windows.Forms.Label();
            this.panelDown = new System.Windows.Forms.Panel();
            this.labelFirstPackDown = new System.Windows.Forms.Label();
            this.labelSecondPackDown = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.labelSecondPackLeft = new System.Windows.Forms.Label();
            this.labelFirstPackLeft = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFirstPackRight = new System.Windows.Forms.Label();
            this.labelSecondPackRight = new System.Windows.Forms.Label();
            this.panelGame = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panelDown.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DarkGray;
            this.panelTop.Controls.Add(this.buttonStart);
            this.panelTop.Controls.Add(this.labelFirstPackTop);
            this.panelTop.Controls.Add(this.labelSecondPackTop);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(684, 40);
            this.panelTop.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStart.Location = new System.Drawing.Point(307, 0);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 40);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "START!";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelFirstPackTop
            // 
            this.labelFirstPackTop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFirstPackTop.ForeColor = System.Drawing.Color.Blue;
            this.labelFirstPackTop.Location = new System.Drawing.Point(148, 0);
            this.labelFirstPackTop.Name = "labelFirstPackTop";
            this.labelFirstPackTop.Size = new System.Drawing.Size(100, 40);
            this.labelFirstPackTop.TabIndex = 1;
            this.labelFirstPackTop.Text = "0";
            this.labelFirstPackTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSecondPackTop
            // 
            this.labelSecondPackTop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSecondPackTop.ForeColor = System.Drawing.Color.Red;
            this.labelSecondPackTop.Location = new System.Drawing.Point(460, 0);
            this.labelSecondPackTop.Name = "labelSecondPackTop";
            this.labelSecondPackTop.Size = new System.Drawing.Size(100, 40);
            this.labelSecondPackTop.TabIndex = 2;
            this.labelSecondPackTop.Text = "0";
            this.labelSecondPackTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDown
            // 
            this.panelDown.BackColor = System.Drawing.Color.DarkGray;
            this.panelDown.Controls.Add(this.labelFirstPackDown);
            this.panelDown.Controls.Add(this.labelSecondPackDown);
            this.panelDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDown.Location = new System.Drawing.Point(0, 621);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(684, 40);
            this.panelDown.TabIndex = 1;
            // 
            // labelFirstPackDown
            // 
            this.labelFirstPackDown.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFirstPackDown.ForeColor = System.Drawing.Color.Blue;
            this.labelFirstPackDown.Location = new System.Drawing.Point(148, 0);
            this.labelFirstPackDown.Name = "labelFirstPackDown";
            this.labelFirstPackDown.Size = new System.Drawing.Size(100, 40);
            this.labelFirstPackDown.TabIndex = 7;
            this.labelFirstPackDown.Text = "0";
            this.labelFirstPackDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSecondPackDown
            // 
            this.labelSecondPackDown.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSecondPackDown.ForeColor = System.Drawing.Color.Red;
            this.labelSecondPackDown.Location = new System.Drawing.Point(460, 0);
            this.labelSecondPackDown.Name = "labelSecondPackDown";
            this.labelSecondPackDown.Size = new System.Drawing.Size(100, 40);
            this.labelSecondPackDown.TabIndex = 8;
            this.labelSecondPackDown.Text = "0";
            this.labelSecondPackDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.DarkGray;
            this.panelLeft.Controls.Add(this.labelSecondPackLeft);
            this.panelLeft.Controls.Add(this.labelFirstPackLeft);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 40);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(50, 581);
            this.panelLeft.TabIndex = 2;
            // 
            // labelSecondPackLeft
            // 
            this.labelSecondPackLeft.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSecondPackLeft.ForeColor = System.Drawing.Color.Red;
            this.labelSecondPackLeft.Location = new System.Drawing.Point(0, 298);
            this.labelSecondPackLeft.Name = "labelSecondPackLeft";
            this.labelSecondPackLeft.Size = new System.Drawing.Size(50, 23);
            this.labelSecondPackLeft.TabIndex = 4;
            this.labelSecondPackLeft.Text = "0";
            this.labelSecondPackLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFirstPackLeft
            // 
            this.labelFirstPackLeft.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFirstPackLeft.ForeColor = System.Drawing.Color.Blue;
            this.labelFirstPackLeft.Location = new System.Drawing.Point(0, 179);
            this.labelFirstPackLeft.Name = "labelFirstPackLeft";
            this.labelFirstPackLeft.Size = new System.Drawing.Size(50, 23);
            this.labelFirstPackLeft.TabIndex = 3;
            this.labelFirstPackLeft.Text = "0";
            this.labelFirstPackLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.labelFirstPackRight);
            this.panel1.Controls.Add(this.labelSecondPackRight);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(634, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 581);
            this.panel1.TabIndex = 3;
            // 
            // labelFirstPackRight
            // 
            this.labelFirstPackRight.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFirstPackRight.ForeColor = System.Drawing.Color.Blue;
            this.labelFirstPackRight.Location = new System.Drawing.Point(3, 179);
            this.labelFirstPackRight.Name = "labelFirstPackRight";
            this.labelFirstPackRight.Size = new System.Drawing.Size(47, 23);
            this.labelFirstPackRight.TabIndex = 5;
            this.labelFirstPackRight.Text = "0";
            this.labelFirstPackRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSecondPackRight
            // 
            this.labelSecondPackRight.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSecondPackRight.ForeColor = System.Drawing.Color.Red;
            this.labelSecondPackRight.Location = new System.Drawing.Point(0, 298);
            this.labelSecondPackRight.Name = "labelSecondPackRight";
            this.labelSecondPackRight.Size = new System.Drawing.Size(50, 23);
            this.labelSecondPackRight.TabIndex = 6;
            this.labelSecondPackRight.Text = "0";
            this.labelSecondPackRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.Color.Gainsboro;
            this.panelGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGame.Location = new System.Drawing.Point(50, 40);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(584, 581);
            this.panelGame.TabIndex = 4;
            this.panelGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelGame_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelDown);
            this.Controls.Add(this.panelTop);
            this.Name = "MainForm";
            this.Text = "Diffusion";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelDown.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelTop;
        private Label labelFirstPackTop;
        private Label labelSecondPackTop;
        private Panel panelDown;
        private Label labelFirstPackDown;
        private Label labelSecondPackDown;
        private Panel panelLeft;
        private Label labelSecondPackLeft;
        private Label labelFirstPackLeft;
        private Panel panel1;
        private Label labelFirstPackRight;
        private Label labelSecondPackRight;
        private Panel panelGame;
        private Button buttonStart;
    }
}