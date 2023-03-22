namespace BallGameWinFormsApp
{
    partial class FormMain
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
            this.panelTopGame = new System.Windows.Forms.Panel();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panelGame = new System.Windows.Forms.Panel();
            this.panelTopGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopGame
            // 
            this.panelTopGame.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelTopGame.Controls.Add(this.buttonStop);
            this.panelTopGame.Controls.Add(this.buttonStart);
            this.panelTopGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopGame.Location = new System.Drawing.Point(0, 0);
            this.panelTopGame.Name = "panelTopGame";
            this.panelTopGame.Size = new System.Drawing.Size(900, 60);
            this.panelTopGame.TabIndex = 0;
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.LightCoral;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStop.Location = new System.Drawing.Point(534, 0);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 60);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "STOP!";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Coral;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStart.Location = new System.Drawing.Point(297, 0);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 60);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "START!";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.Color.Gainsboro;
            this.panelGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGame.Location = new System.Drawing.Point(0, 60);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(900, 600);
            this.panelGame.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 660);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.panelTopGame);
            this.MaximumSize = new System.Drawing.Size(916, 699);
            this.MinimumSize = new System.Drawing.Size(916, 699);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CatchBallsGame";
            this.panelTopGame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelTopGame;
        private Panel panelGame;
        private Button buttonStart;
        private Button buttonStop;
    }
}