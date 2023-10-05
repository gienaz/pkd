namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn1 = new System.Windows.Forms.Button();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnumn = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn1.Location = new System.Drawing.Point(12, 66);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(109, 48);
            this.Btn1.TabIndex = 0;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.BtnText_Click);
            // 
            // TB1
            // 
            this.TB1.BackColor = System.Drawing.SystemColors.InfoText;
            this.TB1.Enabled = false;
            this.TB1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TB1.Location = new System.Drawing.Point(12, 12);
            this.TB1.Multiline = true;
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(339, 48);
            this.TB1.TabIndex = 1;
            this.TB1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TB1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB1_KeyDown);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(127, 66);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(109, 48);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnplus
            // 
            this.btnplus.Location = new System.Drawing.Point(357, 66);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(109, 48);
            this.btnplus.TabIndex = 3;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(242, 66);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(109, 48);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(242, 120);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(109, 48);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnminus
            // 
            this.btnminus.Location = new System.Drawing.Point(357, 120);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(109, 48);
            this.btnminus.TabIndex = 7;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(127, 120);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(109, 48);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn4.Location = new System.Drawing.Point(12, 120);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(109, 48);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(242, 174);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(109, 48);
            this.btn9.TabIndex = 12;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnumn
            // 
            this.btnumn.Location = new System.Drawing.Point(357, 174);
            this.btnumn.Name = "btnumn";
            this.btnumn.Size = new System.Drawing.Size(109, 48);
            this.btnumn.TabIndex = 11;
            this.btnumn.Text = "*";
            this.btnumn.UseVisualStyleBackColor = true;
            this.btnumn.Click += new System.EventHandler(this.btnumn_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(127, 174);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(109, 48);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn7.Location = new System.Drawing.Point(12, 174);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(109, 48);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(242, 228);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(109, 48);
            this.button9.TabIndex = 16;
            this.button9.Text = "=";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(357, 228);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(109, 48);
            this.btndel.TabIndex = 15;
            this.btndel.Text = "/";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(127, 228);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(109, 48);
            this.btn0.TabIndex = 14;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button12.Location = new System.Drawing.Point(12, 228);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(109, 48);
            this.button12.TabIndex = 13;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btndelete.Location = new System.Drawing.Point(357, 12);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(109, 48);
            this.btndelete.TabIndex = 17;
            this.btndelete.Text = "DEL";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 297);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnumn);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.Btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnumn;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button btndelete;
    }
}

