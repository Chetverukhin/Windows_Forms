namespace GameWF.Forms
{
    partial class FormRating
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridTop = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTop)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTop
            // 
            this.dataGridTop.AllowUserToAddRows = false;
            this.dataGridTop.AllowUserToDeleteRows = false;
            this.dataGridTop.AllowUserToResizeColumns = false;
            this.dataGridTop.AllowUserToResizeRows = false;
            this.dataGridTop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTop.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridTop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridTop.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridTop.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridTop.ColumnHeadersHeight = 65;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridTop.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridTop.EnableHeadersVisualStyles = false;
            this.dataGridTop.GridColor = System.Drawing.Color.DimGray;
            this.dataGridTop.Location = new System.Drawing.Point(0, 0);
            this.dataGridTop.Name = "dataGridTop";
            this.dataGridTop.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridTop.RowHeadersVisible = false;
            this.dataGridTop.RowTemplate.Height = 25;
            this.dataGridTop.Size = new System.Drawing.Size(668, 447);
            this.dataGridTop.TabIndex = 0;
            // 
            // FormRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 447);
            this.Controls.Add(this.dataGridTop);
            this.Name = "FormRating";
            this.Text = "РЕЙТИНГ ПОЛЬЗОВАТЕЛЕЙ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridTop;
    }
}