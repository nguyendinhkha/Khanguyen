namespace _20520562_Lab1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textB = new System.Windows.Forms.TextBox();
            this.textC = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.text_max = new System.Windows.Forms.TextBox();
            this.text_min = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ nhất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số thứ hai";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textA
            // 
            this.textA.Location = new System.Drawing.Point(83, 118);
            this.textA.Name = "textA";
            this.textA.Size = new System.Drawing.Size(100, 22);
            this.textA.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số thứ ba";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textB
            // 
            this.textB.Location = new System.Drawing.Point(292, 118);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(100, 22);
            this.textB.TabIndex = 7;
            // 
            // textC
            // 
            this.textC.Location = new System.Drawing.Point(490, 118);
            this.textC.Name = "textC";
            this.textC.Size = new System.Drawing.Size(100, 22);
            this.textC.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 64);
            this.button1.TabIndex = 9;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số lớn nhất";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Số nhỏ nhất";
            // 
            // text_max
            // 
            this.text_max.Location = new System.Drawing.Point(92, 348);
            this.text_max.Name = "text_max";
            this.text_max.ReadOnly = true;
            this.text_max.Size = new System.Drawing.Size(80, 22);
            this.text_max.TabIndex = 14;
            // 
            // text_min
            // 
            this.text_min.Location = new System.Drawing.Point(276, 348);
            this.text_min.Name = "text_min";
            this.text_min.ReadOnly = true;
            this.text_min.Size = new System.Drawing.Size(80, 22);
            this.text_min.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 722);
            this.Controls.Add(this.text_min);
            this.Controls.Add(this.text_max);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textC);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Simple Sum";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.TextBox textC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_max;
        private System.Windows.Forms.TextBox text_min;
    }
}

