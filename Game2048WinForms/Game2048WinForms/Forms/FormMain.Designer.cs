namespace Game2048WinForms
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTextBestScore = new System.Windows.Forms.Label();
            this.labelUserScore = new System.Windows.Forms.Label();
            this.labelBestScore = new System.Windows.Forms.Label();
            this.labelTextCurrentScores = new System.Windows.Forms.Label();
            this.labelTextUserName = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonResetGame = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonScores = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelGame = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.LightGray;
            this.panelTop.Controls.Add(this.labelTextBestScore);
            this.panelTop.Controls.Add(this.labelUserScore);
            this.panelTop.Controls.Add(this.labelBestScore);
            this.panelTop.Controls.Add(this.labelTextCurrentScores);
            this.panelTop.Controls.Add(this.labelTextUserName);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(519, 70);
            this.panelTop.TabIndex = 0;
            // 
            // labelTextBestScore
            // 
            this.labelTextBestScore.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTextBestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTextBestScore.Location = new System.Drawing.Point(351, 0);
            this.labelTextBestScore.Name = "labelTextBestScore";
            this.labelTextBestScore.Size = new System.Drawing.Size(80, 70);
            this.labelTextBestScore.TabIndex = 0;
            this.labelTextBestScore.Text = "Рекорд игры";
            this.labelTextBestScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUserScore
            // 
            this.labelUserScore.BackColor = System.Drawing.Color.PeachPuff;
            this.labelUserScore.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelUserScore.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUserScore.Location = new System.Drawing.Point(266, 0);
            this.labelUserScore.Name = "labelUserScore";
            this.labelUserScore.Size = new System.Drawing.Size(85, 70);
            this.labelUserScore.TabIndex = 0;
            this.labelUserScore.Text = "0";
            this.labelUserScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBestScore
            // 
            this.labelBestScore.BackColor = System.Drawing.Color.IndianRed;
            this.labelBestScore.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBestScore.ForeColor = System.Drawing.Color.Transparent;
            this.labelBestScore.Location = new System.Drawing.Point(431, 0);
            this.labelBestScore.Name = "labelBestScore";
            this.labelBestScore.Size = new System.Drawing.Size(85, 70);
            this.labelBestScore.TabIndex = 0;
            this.labelBestScore.Text = "2048";
            this.labelBestScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTextCurrentScores
            // 
            this.labelTextCurrentScores.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTextCurrentScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTextCurrentScores.Location = new System.Drawing.Point(186, 0);
            this.labelTextCurrentScores.Name = "labelTextCurrentScores";
            this.labelTextCurrentScores.Size = new System.Drawing.Size(80, 70);
            this.labelTextCurrentScores.TabIndex = 0;
            this.labelTextCurrentScores.Text = "Текущий счет";
            this.labelTextCurrentScores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTextUserName
            // 
            this.labelTextUserName.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTextUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTextUserName.Location = new System.Drawing.Point(0, 0);
            this.labelTextUserName.Name = "labelTextUserName";
            this.labelTextUserName.Size = new System.Drawing.Size(186, 70);
            this.labelTextUserName.TabIndex = 0;
            this.labelTextUserName.Text = "Игрок";
            this.labelTextUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightGray;
            this.panelMenu.Controls.Add(this.buttonResetGame);
            this.panelMenu.Controls.Add(this.buttonExit);
            this.panelMenu.Controls.Add(this.label5);
            this.panelMenu.Controls.Add(this.buttonScores);
            this.panelMenu.Controls.Add(this.label4);
            this.panelMenu.Controls.Add(this.buttonInfo);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.buttonSettings);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.buttonGame);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 70);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(70, 451);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonResetGame
            // 
            this.buttonResetGame.BackColor = System.Drawing.Color.LightCoral;
            this.buttonResetGame.FlatAppearance.BorderSize = 0;
            this.buttonResetGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetGame.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonResetGame.Location = new System.Drawing.Point(0, 236);
            this.buttonResetGame.Name = "buttonResetGame";
            this.buttonResetGame.Size = new System.Drawing.Size(70, 41);
            this.buttonResetGame.TabIndex = 0;
            this.buttonResetGame.Text = "RESET GAME";
            this.buttonResetGame.UseVisualStyleBackColor = false;
            this.buttonResetGame.Visible = false;
            this.buttonResetGame.Click += new System.EventHandler(this.buttonResetGame_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(0, 401);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(70, 35);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Location = new System.Drawing.Point(0, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 0;
            // 
            // buttonScores
            // 
            this.buttonScores.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonScores.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonScores.FlatAppearance.BorderSize = 0;
            this.buttonScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScores.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonScores.Location = new System.Drawing.Point(0, 135);
            this.buttonScores.Name = "buttonScores";
            this.buttonScores.Size = new System.Drawing.Size(70, 35);
            this.buttonScores.TabIndex = 0;
            this.buttonScores.Text = "SCORES";
            this.buttonScores.UseVisualStyleBackColor = false;
            this.buttonScores.Click += new System.EventHandler(this.buttonScores_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 5);
            this.label4.TabIndex = 0;
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInfo.FlatAppearance.BorderSize = 0;
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonInfo.Location = new System.Drawing.Point(0, 95);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(70, 35);
            this.buttonInfo.TabIndex = 0;
            this.buttonInfo.Text = "INFO";
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 5);
            this.label3.TabIndex = 0;
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSettings.Location = new System.Drawing.Point(0, 55);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(70, 35);
            this.buttonSettings.TabIndex = 0;
            this.buttonSettings.Text = "SETTINGS";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 5);
            this.label2.TabIndex = 0;
            // 
            // buttonGame
            // 
            this.buttonGame.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGame.FlatAppearance.BorderSize = 0;
            this.buttonGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGame.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGame.Location = new System.Drawing.Point(0, 15);
            this.buttonGame.Name = "buttonGame";
            this.buttonGame.Size = new System.Drawing.Size(70, 35);
            this.buttonGame.TabIndex = 0;
            this.buttonGame.Text = "GAME";
            this.buttonGame.UseVisualStyleBackColor = false;
            this.buttonGame.Click += new System.EventHandler(this.buttonGame_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelGame);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(70, 70);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(449, 451);
            this.panelMain.TabIndex = 1;
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.Color.White;
            this.panelGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGame.Enabled = false;
            this.panelGame.Location = new System.Drawing.Point(0, 0);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(449, 451);
            this.panelGame.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 521);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTop);
            this.MinimumSize = new System.Drawing.Size(535, 560);
            this.Name = "FormMain";
            this.Text = "Game 2048";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.panelTop.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelTop;
        private Panel panelMenu;
        private Panel panelMain;
        private Label labelBestScore;
        private Label labelTextCurrentScores;
        private Label labelTextUserName;
        private Label labelTextBestScore;
        private Label labelUserScore;
        private Panel panelGame;
        private Button buttonExit;
        private Label label5;
        private Button buttonScores;
        private Label label4;
        private Button buttonInfo;
        private Label label3;
        private Button buttonSettings;
        private Label label2;
        private Button buttonGame;
        private Label label1;
        private Button buttonResetGame;
    }
}