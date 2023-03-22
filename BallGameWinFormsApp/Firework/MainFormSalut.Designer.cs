namespace Firework
{
    partial class MainFormSalut
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
            this.components = new System.ComponentModel.Container();
            this.panelFirework = new System.Windows.Forms.Panel();
            this.timerLaunch = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panelFirework
            // 
            this.panelFirework.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelFirework.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFirework.Location = new System.Drawing.Point(0, 0);
            this.panelFirework.Name = "panelFirework";
            this.panelFirework.Size = new System.Drawing.Size(800, 450);
            this.panelFirework.TabIndex = 0;
            this.panelFirework.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelFirework_MouseDown);
            // 
            // timerLaunch
            // 
            this.timerLaunch.Enabled = true;
            this.timerLaunch.Interval = 3000;
            this.timerLaunch.Tick += new System.EventHandler(this.timerLaunch_Tick);
            // 
            // MainFormSalut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFirework);
            this.Name = "MainFormSalut";
            this.Text = "Firework";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelFirework;
        private System.Windows.Forms.Timer timerLaunch;
    }
}