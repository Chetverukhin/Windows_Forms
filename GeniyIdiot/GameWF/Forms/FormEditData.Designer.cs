namespace GameWF.Forms
{
    partial class FormEditData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridTestQuestion = new System.Windows.Forms.DataGridView();
            this.textBoxAddQuestion = new System.Windows.Forms.TextBox();
            this.buttonAddTest = new System.Windows.Forms.Button();
            this.textBoxAddAnswer = new System.Windows.Forms.TextBox();
            this.buttonDelTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTestQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTestQuestion
            // 
            this.dataGridTestQuestion.AllowUserToAddRows = false;
            this.dataGridTestQuestion.AllowUserToDeleteRows = false;
            this.dataGridTestQuestion.AllowUserToResizeColumns = false;
            this.dataGridTestQuestion.AllowUserToResizeRows = false;
            this.dataGridTestQuestion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTestQuestion.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridTestQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTestQuestion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridTestQuestion.ColumnHeadersHeight = 30;
            this.dataGridTestQuestion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridTestQuestion.EnableHeadersVisualStyles = false;
            this.dataGridTestQuestion.GridColor = System.Drawing.Color.DimGray;
            this.dataGridTestQuestion.Location = new System.Drawing.Point(0, 106);
            this.dataGridTestQuestion.Name = "dataGridTestQuestion";
            this.dataGridTestQuestion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridTestQuestion.RowHeadersVisible = false;
            this.dataGridTestQuestion.RowTemplate.Height = 25;
            this.dataGridTestQuestion.Size = new System.Drawing.Size(668, 341);
            this.dataGridTestQuestion.TabIndex = 0;
            // 
            // textBoxAddQuestion
            // 
            this.textBoxAddQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAddQuestion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAddQuestion.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxAddQuestion.Location = new System.Drawing.Point(12, 12);
            this.textBoxAddQuestion.Multiline = true;
            this.textBoxAddQuestion.Name = "textBoxAddQuestion";
            this.textBoxAddQuestion.Size = new System.Drawing.Size(520, 30);
            this.textBoxAddQuestion.TabIndex = 1;
            this.textBoxAddQuestion.Text = "Введите вопрос";
            this.textBoxAddQuestion.Click += new System.EventHandler(this.textBoxAddQuestion_Click);
            // 
            // buttonAddTest
            // 
            this.buttonAddTest.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonAddTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTest.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddTest.Location = new System.Drawing.Point(546, 12);
            this.buttonAddTest.Name = "buttonAddTest";
            this.buttonAddTest.Size = new System.Drawing.Size(110, 30);
            this.buttonAddTest.TabIndex = 2;
            this.buttonAddTest.Text = "ДОБАВИТЬ";
            this.buttonAddTest.UseVisualStyleBackColor = false;
            this.buttonAddTest.Click += new System.EventHandler(this.buttonAddTest_Click);
            // 
            // textBoxAddAnswer
            // 
            this.textBoxAddAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAddAnswer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAddAnswer.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxAddAnswer.Location = new System.Drawing.Point(12, 60);
            this.textBoxAddAnswer.Multiline = true;
            this.textBoxAddAnswer.Name = "textBoxAddAnswer";
            this.textBoxAddAnswer.Size = new System.Drawing.Size(520, 30);
            this.textBoxAddAnswer.TabIndex = 1;
            this.textBoxAddAnswer.Text = "Введите ответ";
            this.textBoxAddAnswer.Click += new System.EventHandler(this.textBoxAddAnswer_Click);
            // 
            // buttonDelTest
            // 
            this.buttonDelTest.BackColor = System.Drawing.Color.DarkSalmon;
            this.buttonDelTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelTest.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelTest.Location = new System.Drawing.Point(546, 60);
            this.buttonDelTest.Name = "buttonDelTest";
            this.buttonDelTest.Size = new System.Drawing.Size(110, 30);
            this.buttonDelTest.TabIndex = 2;
            this.buttonDelTest.Text = "УДАЛИТЬ";
            this.buttonDelTest.UseVisualStyleBackColor = false;
            this.buttonDelTest.Click += new System.EventHandler(this.buttonDelTest_Click);
            // 
            // FormEditData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(668, 447);
            this.Controls.Add(this.buttonDelTest);
            this.Controls.Add(this.buttonAddTest);
            this.Controls.Add(this.textBoxAddAnswer);
            this.Controls.Add(this.textBoxAddQuestion);
            this.Controls.Add(this.dataGridTestQuestion);
            this.Name = "FormEditData";
            this.Text = "РЕДАКТИРОВАНИЕ ТЕСТОВ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTestQuestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridTestQuestion;
        private TextBox textBoxAddQuestion;
        private Button buttonAddTest;
        private TextBox textBoxAddAnswer;
        private Button buttonDelTest;
    }
}