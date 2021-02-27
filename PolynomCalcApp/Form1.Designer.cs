namespace PolynomCalcApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textQ = new System.Windows.Forms.TextBox();
            this.textX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.resultP = new System.Windows.Forms.Label();
            this.resultQ = new System.Windows.Forms.Label();
            this.resultPQ = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(122, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите P";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textP
            // 
            this.textP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textP.Location = new System.Drawing.Point(264, 115);
            this.textP.Name = "textP";
            this.textP.Size = new System.Drawing.Size(407, 34);
            this.textP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(122, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите Q";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textQ
            // 
            this.textQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textQ.Location = new System.Drawing.Point(264, 180);
            this.textQ.Name = "textQ";
            this.textQ.Size = new System.Drawing.Size(407, 34);
            this.textQ.TabIndex = 3;
            // 
            // textX
            // 
            this.textX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textX.Location = new System.Drawing.Point(264, 243);
            this.textX.Name = "textX";
            this.textX.Size = new System.Drawing.Size(114, 34);
            this.textX.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(122, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите x";
            // 
            // textY
            // 
            this.textY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textY.Location = new System.Drawing.Point(557, 243);
            this.textY.Name = "textY";
            this.textY.Size = new System.Drawing.Size(114, 34);
            this.textY.TabIndex = 7;
            this.textY.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(423, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Введите y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(126, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "P(x)=";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(443, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Q(y)=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(126, 486);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "P(x)*Q(y)-P(Q(x+y))=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(232, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(345, 29);
            this.label8.TabIndex = 11;
            this.label8.Text = "Вычисление многочленов";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(338, 379);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 29);
            this.label9.TabIndex = 12;
            this.label9.Text = "Результат";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.YellowGreen;
            this.submitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitButton.Location = new System.Drawing.Point(296, 303);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(220, 46);
            this.submitButton.TabIndex = 13;
            this.submitButton.Text = "Вычислить";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultP
            // 
            this.resultP.AutoSize = true;
            this.resultP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultP.Location = new System.Drawing.Point(202, 428);
            this.resultP.Name = "resultP";
            this.resultP.Size = new System.Drawing.Size(0, 29);
            this.resultP.TabIndex = 14;
            // 
            // resultQ
            // 
            this.resultQ.AutoSize = true;
            this.resultQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultQ.Location = new System.Drawing.Point(531, 428);
            this.resultQ.Name = "resultQ";
            this.resultQ.Size = new System.Drawing.Size(0, 29);
            this.resultQ.TabIndex = 15;
            // 
            // resultPQ
            // 
            this.resultPQ.AutoSize = true;
            this.resultPQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultPQ.Location = new System.Drawing.Point(378, 486);
            this.resultPQ.Name = "resultPQ";
            this.resultPQ.Size = new System.Drawing.Size(0, 29);
            this.resultPQ.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(146, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(519, 29);
            this.label10.TabIndex = 17;
            this.label10.Text = "Вводите многочлен вида: 3x^5+2x^4+5x^2+7";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.resultPQ);
            this.Controls.Add(this.resultQ);
            this.Controls.Add(this.resultP);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Вычисление многочленов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textQ;
        private System.Windows.Forms.TextBox textX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label resultP;
        private System.Windows.Forms.Label resultQ;
        private System.Windows.Forms.Label resultPQ;
        private System.Windows.Forms.Label label10;
    }
}

