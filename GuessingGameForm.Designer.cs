namespace GuessGameToluA
{
    partial class frmGuessingGame
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblGuessNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.picCheckmark = new System.Windows.Forms.PictureBox();
            this.picRedX = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckmark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedX)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(25, 84);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblGuessNumber
            // 
            this.lblGuessNumber.AutoSize = true;
            this.lblGuessNumber.Font = new System.Drawing.Font("Trajan Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessNumber.Location = new System.Drawing.Point(21, 35);
            this.lblGuessNumber.Name = "lblGuessNumber";
            this.lblGuessNumber.Size = new System.Drawing.Size(354, 24);
            this.lblGuessNumber.TabIndex = 1;
            this.lblGuessNumber.Text = "Guess a number between 1 to 10";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(394, 39);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 2;
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Trajan Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.Location = new System.Drawing.Point(390, 84);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(127, 24);
            this.lblCorrect.TabIndex = 3;
            this.lblCorrect.Text = "Good Job!!";
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.Font = new System.Drawing.Font("Trajan Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrect.Location = new System.Drawing.Point(415, 84);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(102, 24);
            this.lblIncorrect.TabIndex = 4;
            this.lblIncorrect.Text = "Wrong!!";
            // 
            // picCheckmark
            // 
            this.picCheckmark.Image = global::GuessGameToluA.Properties.Resources.checkmark;
            this.picCheckmark.Location = new System.Drawing.Point(417, 110);
            this.picCheckmark.Name = "picCheckmark";
            this.picCheckmark.Size = new System.Drawing.Size(100, 50);
            this.picCheckmark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCheckmark.TabIndex = 5;
            this.picCheckmark.TabStop = false;
            // 
            // picRedX
            // 
            this.picRedX.Image = global::GuessGameToluA.Properties.Resources.red_x;
            this.picRedX.Location = new System.Drawing.Point(417, 111);
            this.picRedX.Name = "picRedX";
            this.picRedX.Size = new System.Drawing.Size(100, 50);
            this.picRedX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRedX.TabIndex = 6;
            this.picRedX.TabStop = false;
            // 
            // frmGuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 172);
            this.Controls.Add(this.picRedX);
            this.Controls.Add(this.picCheckmark);
            this.Controls.Add(this.lblIncorrect);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblGuessNumber);
            this.Controls.Add(this.btnCheck);
            this.Name = "frmGuessingGame";
            this.Text = "Guessing Game";
            ((System.ComponentModel.ISupportInitialize)(this.picCheckmark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblGuessNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblIncorrect;
        private System.Windows.Forms.PictureBox picCheckmark;
        private System.Windows.Forms.PictureBox picRedX;
    }
}

