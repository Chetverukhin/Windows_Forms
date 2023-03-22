namespace Game2048WinForms
{
    partial class FormSettings
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
            this.textBoxMapSize = new System.Windows.Forms.TextBox();
            this.textBoxGridMap = new System.Windows.Forms.TextBox();
            this.labelSizeMap = new System.Windows.Forms.Label();
            this.labelGridMap = new System.Windows.Forms.Label();
            this.labelInfoStyleMap = new System.Windows.Forms.Label();
            this.buttonAcceptStyle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMapSize
            // 
            this.textBoxMapSize.ForeColor = System.Drawing.Color.Silver;
            this.textBoxMapSize.Location = new System.Drawing.Point(332, 166);
            this.textBoxMapSize.Name = "textBoxMapSize";
            this.textBoxMapSize.Size = new System.Drawing.Size(100, 23);
            this.textBoxMapSize.TabIndex = 0;
            this.textBoxMapSize.Text = "Введите число";
            this.textBoxMapSize.Click += new System.EventHandler(this.textBoxMapSize_Click);
            // 
            // textBoxGridMap
            // 
            this.textBoxGridMap.ForeColor = System.Drawing.Color.Silver;
            this.textBoxGridMap.Location = new System.Drawing.Point(332, 211);
            this.textBoxGridMap.Name = "textBoxGridMap";
            this.textBoxGridMap.Size = new System.Drawing.Size(100, 23);
            this.textBoxGridMap.TabIndex = 1;
            this.textBoxGridMap.Text = "Введите число";
            this.textBoxGridMap.Click += new System.EventHandler(this.textBoxGridMap_Click);
            // 
            // labelSizeMap
            // 
            this.labelSizeMap.AutoSize = true;
            this.labelSizeMap.Location = new System.Drawing.Point(42, 169);
            this.labelSizeMap.Name = "labelSizeMap";
            this.labelSizeMap.Size = new System.Drawing.Size(259, 15);
            this.labelSizeMap.TabIndex = 2;
            this.labelSizeMap.Text = "Выберите количество ячеек на игровом поле";
            // 
            // labelGridMap
            // 
            this.labelGridMap.AutoSize = true;
            this.labelGridMap.Location = new System.Drawing.Point(42, 211);
            this.labelGridMap.Name = "labelGridMap";
            this.labelGridMap.Size = new System.Drawing.Size(231, 15);
            this.labelGridMap.TabIndex = 3;
            this.labelGridMap.Text = "Выберите толщину сетки игрового поля";
            // 
            // labelInfoStyleMap
            // 
            this.labelInfoStyleMap.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelInfoStyleMap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInfoStyleMap.ForeColor = System.Drawing.Color.Brown;
            this.labelInfoStyleMap.Location = new System.Drawing.Point(0, 0);
            this.labelInfoStyleMap.Name = "labelInfoStyleMap";
            this.labelInfoStyleMap.Size = new System.Drawing.Size(800, 119);
            this.labelInfoStyleMap.TabIndex = 4;
            this.labelInfoStyleMap.Text = "Правила стиля игрового поля";
            this.labelInfoStyleMap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAcceptStyle
            // 
            this.buttonAcceptStyle.BackColor = System.Drawing.Color.Tomato;
            this.buttonAcceptStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAcceptStyle.Location = new System.Drawing.Point(332, 254);
            this.buttonAcceptStyle.Name = "buttonAcceptStyle";
            this.buttonAcceptStyle.Size = new System.Drawing.Size(100, 35);
            this.buttonAcceptStyle.TabIndex = 5;
            this.buttonAcceptStyle.Text = "ПРИНЯТЬ";
            this.buttonAcceptStyle.UseVisualStyleBackColor = false;
            this.buttonAcceptStyle.Click += new System.EventHandler(this.buttonAcceptStyle_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAcceptStyle);
            this.Controls.Add(this.labelInfoStyleMap);
            this.Controls.Add(this.labelGridMap);
            this.Controls.Add(this.labelSizeMap);
            this.Controls.Add(this.textBoxGridMap);
            this.Controls.Add(this.textBoxMapSize);
            this.Name = "FormSettings";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxMapSize;
        private TextBox textBoxGridMap;
        private Label labelSizeMap;
        private Label labelGridMap;
        private Label labelInfoStyleMap;
        private Button buttonAcceptStyle;
    }
}