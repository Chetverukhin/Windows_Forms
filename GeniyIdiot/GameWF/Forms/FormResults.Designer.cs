namespace GameWF.Forms
{
    partial class FormResults
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridResullts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResullts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridResullts
            // 
            this.dataGridResullts.AllowUserToAddRows = false;
            this.dataGridResullts.AllowUserToDeleteRows = false;
            this.dataGridResullts.AllowUserToResizeColumns = false;
            this.dataGridResullts.AllowUserToResizeRows = false;
            this.dataGridResullts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridResullts.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridResullts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridResullts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridResullts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridResullts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridResullts.ColumnHeadersHeight = 65;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridResullts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridResullts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridResullts.EnableHeadersVisualStyles = false;
            this.dataGridResullts.GridColor = System.Drawing.Color.DimGray;
            this.dataGridResullts.Location = new System.Drawing.Point(0, 0);
            this.dataGridResullts.Name = "dataGridResullts";
            this.dataGridResullts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridResullts.RowHeadersVisible = false;
            this.dataGridResullts.RowTemplate.Height = 25;
            this.dataGridResullts.Size = new System.Drawing.Size(668, 447);
            this.dataGridResullts.TabIndex = 0;
            // 
            // FormResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 447);
            this.Controls.Add(this.dataGridResullts);
            this.Name = "FormResults";
            this.Text = "РЕЗУЛЬТАТЫ ТЕСТИРОВАНИЯ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResullts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridResullts;
    }
}