namespace Frogs
{
    partial class EndGame
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
            this.labelScores = new System.Windows.Forms.Label();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelScores
            // 
            this.labelScores.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelScores.Location = new System.Drawing.Point(0, 315);
            this.labelScores.Name = "labelScores";
            this.labelScores.Size = new System.Drawing.Size(300, 62);
            this.labelScores.TabIndex = 0;
            this.labelScores.Text = "Вы закончили игру за 250 шагов!";
            this.labelScores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(95, 391);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(99, 15);
            this.labelQuestion.TabIndex = 1;
            this.labelQuestion.Text = "Повторить игру?";
            // 
            // buttonYes
            // 
            this.buttonYes.Location = new System.Drawing.Point(12, 426);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(75, 23);
            this.buttonYes.TabIndex = 2;
            this.buttonYes.Text = "YES";
            this.buttonYes.UseVisualStyleBackColor = true;
            // 
            // buttonNo
            // 
            this.buttonNo.Location = new System.Drawing.Point(212, 426);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(75, 23);
            this.buttonNo.TabIndex = 3;
            this.buttonNo.Text = "NO";
            this.buttonNo.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Frogs.Properties.Resources.win;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(300, 300);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 461);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.labelScores);
            this.MaximumSize = new System.Drawing.Size(315, 500);
            this.MinimumSize = new System.Drawing.Size(315, 500);
            this.Name = "EndGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WIN!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelScores;
        private Label labelQuestion;
        private Button buttonYes;
        private Button buttonNo;
        private PictureBox pictureBox;
    }
}