
namespace HyattCalculator
{
    partial class CalcApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcApp));
            this.answerBox = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.plus_minus = new System.Windows.Forms.Button();
            this.remainder = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiply_btn = new System.Windows.Forms.Button();
            this.nine_btn = new System.Windows.Forms.Button();
            this.eight_btn = new System.Windows.Forms.Button();
            this.seven_btn = new System.Windows.Forms.Button();
            this.subtract_btn = new System.Windows.Forms.Button();
            this.six_btn = new System.Windows.Forms.Button();
            this.five_btn = new System.Windows.Forms.Button();
            this.four_btn = new System.Windows.Forms.Button();
            this.plus_btn = new System.Windows.Forms.Button();
            this.three_btn = new System.Windows.Forms.Button();
            this.two_btn = new System.Windows.Forms.Button();
            this.one_btn = new System.Windows.Forms.Button();
            this.equal_btn = new System.Windows.Forms.Button();
            this.period_btn = new System.Windows.Forms.Button();
            this.zero_btn = new System.Windows.Forms.Button();
            this.history_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // answerBox
            // 
            this.answerBox.BackColor = System.Drawing.Color.Black;
            this.answerBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.answerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.answerBox.Location = new System.Drawing.Point(13, 11);
            this.answerBox.Multiline = true;
            this.answerBox.Name = "answerBox";
            this.answerBox.ReadOnly = true;
            this.answerBox.Size = new System.Drawing.Size(276, 68);
            this.answerBox.TabIndex = 0;
            this.answerBox.TextChanged += new System.EventHandler(this.answerBox_TextChanged);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.Control;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(10, 97);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(64, 50);
            this.clear.TabIndex = 1;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // plus_minus
            // 
            this.plus_minus.BackColor = System.Drawing.SystemColors.Control;
            this.plus_minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plus_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus_minus.Location = new System.Drawing.Point(82, 97);
            this.plus_minus.Name = "plus_minus";
            this.plus_minus.Size = new System.Drawing.Size(64, 50);
            this.plus_minus.TabIndex = 2;
            this.plus_minus.Text = "+/-";
            this.plus_minus.UseVisualStyleBackColor = false;
            this.plus_minus.Click += new System.EventHandler(this.plus_minus_Click);
            // 
            // remainder
            // 
            this.remainder.BackColor = System.Drawing.SystemColors.Control;
            this.remainder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.remainder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainder.Location = new System.Drawing.Point(152, 97);
            this.remainder.Name = "remainder";
            this.remainder.Size = new System.Drawing.Size(64, 50);
            this.remainder.TabIndex = 3;
            this.remainder.Text = "%";
            this.remainder.UseVisualStyleBackColor = false;
            this.remainder.Click += new System.EventHandler(this.remainder_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.DarkOrange;
            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(222, 97);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(64, 50);
            this.divide.TabIndex = 4;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // multiply_btn
            // 
            this.multiply_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.multiply_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiply_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply_btn.Location = new System.Drawing.Point(222, 154);
            this.multiply_btn.Name = "multiply_btn";
            this.multiply_btn.Size = new System.Drawing.Size(64, 50);
            this.multiply_btn.TabIndex = 8;
            this.multiply_btn.Text = "X";
            this.multiply_btn.UseVisualStyleBackColor = false;
            this.multiply_btn.Click += new System.EventHandler(this.multiply_btn_Click);
            // 
            // nine_btn
            // 
            this.nine_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nine_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nine_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine_btn.Location = new System.Drawing.Point(152, 154);
            this.nine_btn.Name = "nine_btn";
            this.nine_btn.Size = new System.Drawing.Size(64, 50);
            this.nine_btn.TabIndex = 7;
            this.nine_btn.Text = "9";
            this.nine_btn.UseVisualStyleBackColor = false;
            this.nine_btn.Click += new System.EventHandler(this.nine_btn_Click);
            // 
            // eight_btn
            // 
            this.eight_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.eight_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eight_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight_btn.Location = new System.Drawing.Point(82, 154);
            this.eight_btn.Name = "eight_btn";
            this.eight_btn.Size = new System.Drawing.Size(64, 50);
            this.eight_btn.TabIndex = 6;
            this.eight_btn.Text = "8";
            this.eight_btn.UseVisualStyleBackColor = false;
            this.eight_btn.Click += new System.EventHandler(this.eight_btn_Click);
            // 
            // seven_btn
            // 
            this.seven_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.seven_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seven_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven_btn.Location = new System.Drawing.Point(10, 154);
            this.seven_btn.Name = "seven_btn";
            this.seven_btn.Size = new System.Drawing.Size(64, 50);
            this.seven_btn.TabIndex = 5;
            this.seven_btn.Text = "7";
            this.seven_btn.UseVisualStyleBackColor = false;
            this.seven_btn.Click += new System.EventHandler(this.seven_btn_Click);
            // 
            // subtract_btn
            // 
            this.subtract_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.subtract_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subtract_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtract_btn.Location = new System.Drawing.Point(222, 210);
            this.subtract_btn.Name = "subtract_btn";
            this.subtract_btn.Size = new System.Drawing.Size(64, 50);
            this.subtract_btn.TabIndex = 12;
            this.subtract_btn.Text = "-";
            this.subtract_btn.UseVisualStyleBackColor = false;
            this.subtract_btn.Click += new System.EventHandler(this.subtract_btn_Click);
            // 
            // six_btn
            // 
            this.six_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.six_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.six_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six_btn.Location = new System.Drawing.Point(152, 210);
            this.six_btn.Name = "six_btn";
            this.six_btn.Size = new System.Drawing.Size(64, 50);
            this.six_btn.TabIndex = 11;
            this.six_btn.Text = "6";
            this.six_btn.UseVisualStyleBackColor = false;
            this.six_btn.Click += new System.EventHandler(this.six_btn_Click);
            // 
            // five_btn
            // 
            this.five_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.five_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.five_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five_btn.Location = new System.Drawing.Point(82, 210);
            this.five_btn.Name = "five_btn";
            this.five_btn.Size = new System.Drawing.Size(64, 50);
            this.five_btn.TabIndex = 10;
            this.five_btn.Text = "5";
            this.five_btn.UseVisualStyleBackColor = false;
            this.five_btn.Click += new System.EventHandler(this.five_btn_Click);
            // 
            // four_btn
            // 
            this.four_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.four_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.four_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four_btn.Location = new System.Drawing.Point(10, 210);
            this.four_btn.Name = "four_btn";
            this.four_btn.Size = new System.Drawing.Size(64, 50);
            this.four_btn.TabIndex = 9;
            this.four_btn.Text = "4";
            this.four_btn.UseVisualStyleBackColor = false;
            this.four_btn.Click += new System.EventHandler(this.four_btn_Click);
            // 
            // plus_btn
            // 
            this.plus_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.plus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plus_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus_btn.Location = new System.Drawing.Point(222, 267);
            this.plus_btn.Name = "plus_btn";
            this.plus_btn.Size = new System.Drawing.Size(64, 50);
            this.plus_btn.TabIndex = 16;
            this.plus_btn.Text = "+";
            this.plus_btn.UseVisualStyleBackColor = false;
            this.plus_btn.Click += new System.EventHandler(this.plus_btn_Click);
            // 
            // three_btn
            // 
            this.three_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.three_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.three_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three_btn.Location = new System.Drawing.Point(152, 267);
            this.three_btn.Name = "three_btn";
            this.three_btn.Size = new System.Drawing.Size(64, 50);
            this.three_btn.TabIndex = 15;
            this.three_btn.Text = "3";
            this.three_btn.UseVisualStyleBackColor = false;
            this.three_btn.Click += new System.EventHandler(this.three_btn_Click);
            // 
            // two_btn
            // 
            this.two_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.two_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.two_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two_btn.Location = new System.Drawing.Point(82, 267);
            this.two_btn.Name = "two_btn";
            this.two_btn.Size = new System.Drawing.Size(64, 50);
            this.two_btn.TabIndex = 14;
            this.two_btn.Text = "2";
            this.two_btn.UseVisualStyleBackColor = false;
            this.two_btn.Click += new System.EventHandler(this.two_btn_Click);
            // 
            // one_btn
            // 
            this.one_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.one_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.one_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one_btn.Location = new System.Drawing.Point(10, 267);
            this.one_btn.Name = "one_btn";
            this.one_btn.Size = new System.Drawing.Size(64, 50);
            this.one_btn.TabIndex = 13;
            this.one_btn.Text = "1";
            this.one_btn.UseVisualStyleBackColor = false;
            this.one_btn.Click += new System.EventHandler(this.one_btn_Click);
            // 
            // equal_btn
            // 
            this.equal_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.equal_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.equal_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal_btn.Location = new System.Drawing.Point(222, 323);
            this.equal_btn.Name = "equal_btn";
            this.equal_btn.Size = new System.Drawing.Size(64, 50);
            this.equal_btn.TabIndex = 20;
            this.equal_btn.Text = "=";
            this.equal_btn.UseVisualStyleBackColor = false;
            this.equal_btn.Click += new System.EventHandler(this.equal_btn_Click);
            // 
            // period_btn
            // 
            this.period_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.period_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.period_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period_btn.Location = new System.Drawing.Point(152, 323);
            this.period_btn.Name = "period_btn";
            this.period_btn.Size = new System.Drawing.Size(64, 50);
            this.period_btn.TabIndex = 19;
            this.period_btn.Text = ".";
            this.period_btn.UseVisualStyleBackColor = false;
            this.period_btn.Click += new System.EventHandler(this.period_btn_Click);
            // 
            // zero_btn
            // 
            this.zero_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.zero_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zero_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero_btn.Location = new System.Drawing.Point(10, 323);
            this.zero_btn.Name = "zero_btn";
            this.zero_btn.Size = new System.Drawing.Size(134, 50);
            this.zero_btn.TabIndex = 17;
            this.zero_btn.Text = "0";
            this.zero_btn.UseVisualStyleBackColor = false;
            this.zero_btn.Click += new System.EventHandler(this.zero_btn_Click);
            // 
            // history_btn
            // 
            this.history_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.history_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.history_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_btn.Location = new System.Drawing.Point(10, 380);
            this.history_btn.Name = "history_btn";
            this.history_btn.Size = new System.Drawing.Size(75, 21);
            this.history_btn.TabIndex = 21;
            this.history_btn.Text = "History";
            this.history_btn.UseVisualStyleBackColor = false;
            this.history_btn.Click += new System.EventHandler(this.history_btn_Click);
            // 
            // CalcApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(299, 408);
            this.Controls.Add(this.history_btn);
            this.Controls.Add(this.equal_btn);
            this.Controls.Add(this.period_btn);
            this.Controls.Add(this.zero_btn);
            this.Controls.Add(this.plus_btn);
            this.Controls.Add(this.three_btn);
            this.Controls.Add(this.two_btn);
            this.Controls.Add(this.one_btn);
            this.Controls.Add(this.subtract_btn);
            this.Controls.Add(this.six_btn);
            this.Controls.Add(this.five_btn);
            this.Controls.Add(this.four_btn);
            this.Controls.Add(this.multiply_btn);
            this.Controls.Add(this.nine_btn);
            this.Controls.Add(this.eight_btn);
            this.Controls.Add(this.seven_btn);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.remainder);
            this.Controls.Add(this.plus_minus);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.answerBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(317, 455);
            this.MinimumSize = new System.Drawing.Size(317, 455);
            this.Name = "CalcApp";
            this.Text = "Hyatt Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button plus_minus;
        private System.Windows.Forms.Button remainder;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiply_btn;
        private System.Windows.Forms.Button nine_btn;
        private System.Windows.Forms.Button eight_btn;
        private System.Windows.Forms.Button seven_btn;
        private System.Windows.Forms.Button subtract_btn;
        private System.Windows.Forms.Button six_btn;
        private System.Windows.Forms.Button five_btn;
        private System.Windows.Forms.Button four_btn;
        private System.Windows.Forms.Button plus_btn;
        private System.Windows.Forms.Button three_btn;
        private System.Windows.Forms.Button two_btn;
        private System.Windows.Forms.Button one_btn;
        private System.Windows.Forms.Button equal_btn;
        private System.Windows.Forms.Button period_btn;
        private System.Windows.Forms.Button zero_btn;
        private System.Windows.Forms.Button history_btn;
    }
}

