namespace GameWF
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
            this.panelSlideMenu = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAddTest = new System.Windows.Forms.Button();
            this.buttonTop = new System.Windows.Forms.Button();
            this.buttonResults = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelUserName = new System.Windows.Forms.Label();
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.labelCurrentMenu = new System.Windows.Forms.Label();
            this.panelActiveForm = new System.Windows.Forms.Panel();
            this.panelSlideMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSlideMenu
            // 
            this.panelSlideMenu.BackColor = System.Drawing.Color.DimGray;
            this.panelSlideMenu.Controls.Add(this.buttonExit);
            this.panelSlideMenu.Controls.Add(this.buttonAddTest);
            this.panelSlideMenu.Controls.Add(this.buttonTop);
            this.panelSlideMenu.Controls.Add(this.buttonResults);
            this.panelSlideMenu.Controls.Add(this.buttonTest);
            this.panelSlideMenu.Controls.Add(this.panelLogo);
            this.panelSlideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSlideMenu.Name = "panelSlideMenu";
            this.panelSlideMenu.Size = new System.Drawing.Size(200, 561);
            this.panelSlideMenu.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.DimGray;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.Location = new System.Drawing.Point(0, 511);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(200, 50);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "ВЫХОД";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click_1);
            // 
            // buttonAddTest
            // 
            this.buttonAddTest.BackColor = System.Drawing.Color.DimGray;
            this.buttonAddTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddTest.FlatAppearance.BorderSize = 0;
            this.buttonAddTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTest.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddTest.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAddTest.Location = new System.Drawing.Point(0, 225);
            this.buttonAddTest.Name = "buttonAddTest";
            this.buttonAddTest.Size = new System.Drawing.Size(200, 50);
            this.buttonAddTest.TabIndex = 4;
            this.buttonAddTest.Text = "РЕДАКТОР ТЕСТОВ";
            this.buttonAddTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddTest.UseVisualStyleBackColor = false;
            this.buttonAddTest.Click += new System.EventHandler(this.buttonAddTest_Click);
            // 
            // buttonTop
            // 
            this.buttonTop.BackColor = System.Drawing.Color.DimGray;
            this.buttonTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTop.FlatAppearance.BorderSize = 0;
            this.buttonTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTop.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTop.ForeColor = System.Drawing.Color.Transparent;
            this.buttonTop.Location = new System.Drawing.Point(0, 175);
            this.buttonTop.Name = "buttonTop";
            this.buttonTop.Size = new System.Drawing.Size(200, 50);
            this.buttonTop.TabIndex = 3;
            this.buttonTop.Text = "РЕЙТИНГ";
            this.buttonTop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTop.UseVisualStyleBackColor = false;
            this.buttonTop.Click += new System.EventHandler(this.buttonTop_Click);
            // 
            // buttonResults
            // 
            this.buttonResults.BackColor = System.Drawing.Color.DimGray;
            this.buttonResults.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonResults.FlatAppearance.BorderSize = 0;
            this.buttonResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResults.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonResults.ForeColor = System.Drawing.Color.Transparent;
            this.buttonResults.Location = new System.Drawing.Point(0, 125);
            this.buttonResults.Name = "buttonResults";
            this.buttonResults.Size = new System.Drawing.Size(200, 50);
            this.buttonResults.TabIndex = 2;
            this.buttonResults.Text = "РЕЗУЛЬТАТЫ ТЕСТОВ";
            this.buttonResults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonResults.UseVisualStyleBackColor = false;
            this.buttonResults.Click += new System.EventHandler(this.buttonResults_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.BackColor = System.Drawing.Color.DimGray;
            this.buttonTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTest.FlatAppearance.BorderSize = 0;
            this.buttonTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTest.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTest.ForeColor = System.Drawing.Color.Transparent;
            this.buttonTest.Location = new System.Drawing.Point(0, 75);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(200, 50);
            this.buttonTest.TabIndex = 1;
            this.buttonTest.Text = "ПРОЙТИ ТЕСТ";
            this.buttonTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTest.UseVisualStyleBackColor = false;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.labelUserName);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 75);
            this.panelLogo.TabIndex = 0;
            // 
            // labelUserName
            // 
            this.labelUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUserName.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUserName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelUserName.Location = new System.Drawing.Point(0, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(200, 70);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "label1";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.BackColor = System.Drawing.Color.DimGray;
            this.panelTopMenu.Controls.Add(this.labelCurrentMenu);
            this.panelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenu.Location = new System.Drawing.Point(200, 0);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(684, 75);
            this.panelTopMenu.TabIndex = 1;
            // 
            // labelCurrentMenu
            // 
            this.labelCurrentMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCurrentMenu.AutoSize = true;
            this.labelCurrentMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCurrentMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentMenu.ForeColor = System.Drawing.Color.White;
            this.labelCurrentMenu.Location = new System.Drawing.Point(228, 20);
            this.labelCurrentMenu.Name = "labelCurrentMenu";
            this.labelCurrentMenu.Size = new System.Drawing.Size(223, 30);
            this.labelCurrentMenu.TabIndex = 0;
            this.labelCurrentMenu.Text = "ГЛАВНАЯ СТРАНИЦА";
            this.labelCurrentMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelActiveForm
            // 
            this.panelActiveForm.BackColor = System.Drawing.Color.LightGray;
            this.panelActiveForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelActiveForm.Location = new System.Drawing.Point(200, 75);
            this.panelActiveForm.Name = "panelActiveForm";
            this.panelActiveForm.Size = new System.Drawing.Size(684, 486);
            this.panelActiveForm.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panelActiveForm);
            this.Controls.Add(this.panelTopMenu);
            this.Controls.Add(this.panelSlideMenu);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ГЛАВНАЯ СТРАНИЦА";
            this.panelSlideMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTopMenu.ResumeLayout(false);
            this.panelTopMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelSlideMenu;
        private Panel panelTopMenu;
        private Panel panelActiveForm;
        private Button buttonExit;
        private Button buttonAddTest;
        private Button buttonTop;
        private Button buttonResults;
        private Button buttonTest;
        private Panel panelLogo;
        private Label labelCurrentMenu;
        private Label labelUserName;
    }
}