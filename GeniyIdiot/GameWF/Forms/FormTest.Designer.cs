namespace GameWF.Forms
{
    partial class FormTest
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
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.labelTestNumber = new System.Windows.Forms.Label();
            this.buttonAcceptAnswer = new System.Windows.Forms.Button();
            this.labelTestQuestion = new System.Windows.Forms.Label();
            this.labelCountDown = new System.Windows.Forms.Label();
            this.timerCountDown = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAnswer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAnswer.ForeColor = System.Drawing.Color.Silver;
            this.textBoxAnswer.Location = new System.Drawing.Point(62, 200);
            this.textBoxAnswer.Multiline = true;
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(222, 30);
            this.textBoxAnswer.TabIndex = 0;
            this.textBoxAnswer.Text = "введите ответ";
            this.textBoxAnswer.Click += new System.EventHandler(this.textBoxAnswer_Click);
            // 
            // labelTestNumber
            // 
            this.labelTestNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTestNumber.AutoSize = true;
            this.labelTestNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTestNumber.Location = new System.Drawing.Point(62, 56);
            this.labelTestNumber.Name = "labelTestNumber";
            this.labelTestNumber.Size = new System.Drawing.Size(51, 21);
            this.labelTestNumber.TabIndex = 1;
            this.labelTestNumber.Text = "label1";
            // 
            // buttonAcceptAnswer
            // 
            this.buttonAcceptAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAcceptAnswer.BackColor = System.Drawing.Color.DimGray;
            this.buttonAcceptAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAcceptAnswer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAcceptAnswer.ForeColor = System.Drawing.Color.White;
            this.buttonAcceptAnswer.Location = new System.Drawing.Point(290, 200);
            this.buttonAcceptAnswer.Name = "buttonAcceptAnswer";
            this.buttonAcceptAnswer.Size = new System.Drawing.Size(50, 30);
            this.buttonAcceptAnswer.TabIndex = 2;
            this.buttonAcceptAnswer.Text = "OK";
            this.buttonAcceptAnswer.UseVisualStyleBackColor = false;
            this.buttonAcceptAnswer.Click += new System.EventHandler(this.buttonAcceptAnswer_Click);
            // 
            // labelTestQuestion
            // 
            this.labelTestQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTestQuestion.AutoSize = true;
            this.labelTestQuestion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTestQuestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTestQuestion.Location = new System.Drawing.Point(62, 113);
            this.labelTestQuestion.Name = "labelTestQuestion";
            this.labelTestQuestion.Size = new System.Drawing.Size(52, 21);
            this.labelTestQuestion.TabIndex = 1;
            this.labelTestQuestion.Text = "label1";
            this.labelTestQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCountDown
            // 
            this.labelCountDown.AutoSize = true;
            this.labelCountDown.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCountDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.labelCountDown.Location = new System.Drawing.Point(116, 269);
            this.labelCountDown.Name = "labelCountDown";
            this.labelCountDown.Size = new System.Drawing.Size(111, 86);
            this.labelCountDown.TabIndex = 3;
            this.labelCountDown.Text = "10";
            this.labelCountDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerCountDown
            // 
            this.timerCountDown.Interval = 1000;
            this.timerCountDown.Tick += new System.EventHandler(this.timerCountDown_Tick);
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(684, 486);
            this.Controls.Add(this.labelCountDown);
            this.Controls.Add(this.buttonAcceptAnswer);
            this.Controls.Add(this.labelTestQuestion);
            this.Controls.Add(this.labelTestNumber);
            this.Controls.Add(this.textBoxAnswer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTest";
            this.Text = "ТЕСТИРОВАНИЕ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxAnswer;
        private Label labelTestNumber;
        private Button buttonAcceptAnswer;
        private Label labelTestQuestion;
        private Label labelCountDown;
        private System.Windows.Forms.Timer timerCountDown;
    }
}