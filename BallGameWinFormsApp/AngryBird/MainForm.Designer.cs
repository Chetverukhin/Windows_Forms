namespace AngryBird
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
            this.panelGame = new System.Windows.Forms.Panel();
            this.labelScrores = new System.Windows.Forms.Label();
            this.panelGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGame
            // 
            this.panelGame.Controls.Add(this.labelScrores);
            this.panelGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGame.Location = new System.Drawing.Point(0, 0);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(1584, 861);
            this.panelGame.TabIndex = 0;
            this.panelGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelGame_MouseDown);
            // 
            // labelScrores
            // 
            this.labelScrores.BackColor = System.Drawing.Color.IndianRed;
            this.labelScrores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelScrores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelScrores.ForeColor = System.Drawing.SystemColors.Control;
            this.labelScrores.Location = new System.Drawing.Point(12, 9);
            this.labelScrores.Name = "labelScrores";
            this.labelScrores.Size = new System.Drawing.Size(122, 44);
            this.labelScrores.TabIndex = 0;
            this.labelScrores.Text = "SCORES: 0";
            this.labelScrores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.panelGame);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Angry Bird";
            this.panelGame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelGame;
        private Label labelScrores;
    }
}