namespace Game2048WinForms
{
    partial class FormScores
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
            this.dataGridScores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridScores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridScores
            // 
            this.dataGridScores.AllowUserToAddRows = false;
            this.dataGridScores.AllowUserToDeleteRows = false;
            this.dataGridScores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridScores.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridScores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridScores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridScores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridScores.EnableHeadersVisualStyles = false;
            this.dataGridScores.GridColor = System.Drawing.Color.Black;
            this.dataGridScores.Location = new System.Drawing.Point(0, 0);
            this.dataGridScores.Name = "dataGridScores";
            this.dataGridScores.RowHeadersVisible = false;
            this.dataGridScores.RowTemplate.Height = 25;
            this.dataGridScores.Size = new System.Drawing.Size(800, 450);
            this.dataGridScores.TabIndex = 0;
            // 
            // FormScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridScores);
            this.Name = "FormScores";
            this.Text = "FormScores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridScores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridScores;
    }
}