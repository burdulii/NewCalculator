namespace CalculatorApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            b0 = new Button();
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            b4 = new Button();
            b5 = new Button();
            b6 = new Button();
            b7 = new Button();
            b8 = new Button();
            b9 = new Button();
            bClear = new Button();
            bEquals = new Button();
            bAddition = new Button();
            bSubtraction = new Button();
            bMultiplication = new Button();
            bSlash = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(42, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(510, 95);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // b0
            // 
            b0.BackColor = SystemColors.ButtonHighlight;
            b0.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            b0.Location = new Point(184, 470);
            b0.Name = "b0";
            b0.Size = new Size(94, 92);
            b0.TabIndex = 1;
            b0.Text = "0";
            b0.UseVisualStyleBackColor = false;
            b0.Click += no_click;
            // 
            // b1
            // 
            b1.BackColor = SystemColors.ButtonHighlight;
            b1.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            b1.Location = new Point(42, 361);
            b1.Name = "b1";
            b1.Size = new Size(94, 92);
            b1.TabIndex = 2;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = false;
            b1.Click += no_click;
            // 
            // b2
            // 
            b2.BackColor = SystemColors.ButtonHighlight;
            b2.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            b2.Location = new Point(184, 351);
            b2.Name = "b2";
            b2.Size = new Size(94, 92);
            b2.TabIndex = 3;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = false;
            b2.Click += no_click;
            // 
            // b3
            // 
            b3.BackColor = SystemColors.ButtonHighlight;
            b3.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            b3.Location = new Point(330, 361);
            b3.Name = "b3";
            b3.Size = new Size(94, 92);
            b3.TabIndex = 4;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = false;
            b3.Click += no_click;
            // 
            // b4
            // 
            b4.BackColor = SystemColors.ButtonHighlight;
            b4.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            b4.Location = new Point(42, 250);
            b4.Name = "b4";
            b4.Size = new Size(94, 92);
            b4.TabIndex = 5;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = false;
            b4.Click += no_click;
            // 
            // b5
            // 
            b5.BackColor = SystemColors.ButtonHighlight;
            b5.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            b5.Location = new Point(184, 250);
            b5.Name = "b5";
            b5.Size = new Size(94, 92);
            b5.TabIndex = 6;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = false;
            b5.Click += no_click;
            // 
            // b6
            // 
            b6.BackColor = SystemColors.ButtonHighlight;
            b6.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            b6.Location = new Point(330, 250);
            b6.Name = "b6";
            b6.Size = new Size(94, 92);
            b6.TabIndex = 7;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = false;
            b6.Click += no_click;
            // 
            // b7
            // 
            b7.BackColor = SystemColors.ButtonHighlight;
            b7.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            b7.Location = new Point(42, 142);
            b7.Name = "b7";
            b7.Size = new Size(94, 92);
            b7.TabIndex = 8;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = false;
            b7.Click += no_click;
            // 
            // b8
            // 
            b8.BackColor = SystemColors.ButtonHighlight;
            b8.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            b8.Location = new Point(184, 141);
            b8.Name = "b8";
            b8.Size = new Size(94, 92);
            b8.TabIndex = 9;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = false;
            b8.Click += no_click;
            // 
            // b9
            // 
            b9.BackColor = SystemColors.ButtonHighlight;
            b9.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            b9.Location = new Point(330, 142);
            b9.Name = "b9";
            b9.Size = new Size(94, 92);
            b9.TabIndex = 10;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = false;
            b9.Click += no_click;
            // 
            // bClear
            // 
            bClear.BackColor = Color.FromArgb(210, 7, 9);
            bClear.Font = new Font("Segoe UI", 21.2F, FontStyle.Bold);
            bClear.ForeColor = SystemColors.ButtonFace;
            bClear.Location = new Point(42, 470);
            bClear.Name = "bClear";
            bClear.Size = new Size(94, 92);
            bClear.TabIndex = 11;
            bClear.Text = "C";
            bClear.UseVisualStyleBackColor = false;
            bClear.Click += bClear_click;
            // 
            // bEquals
            // 
            bEquals.BackColor = Color.FromArgb(64, 64, 64);
            bEquals.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold);
            bEquals.ForeColor = SystemColors.ButtonHighlight;
            bEquals.Location = new Point(330, 476);
            bEquals.Name = "bEquals";
            bEquals.Size = new Size(94, 92);
            bEquals.TabIndex = 12;
            bEquals.Text = "=";
            bEquals.UseVisualStyleBackColor = false;
            bEquals.Click += bEqual_Click;
            // 
            // bAddition
            // 
            bAddition.BackColor = Color.FromArgb(64, 64, 64);
            bAddition.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold);
            bAddition.ForeColor = SystemColors.ButtonHighlight;
            bAddition.Location = new Point(458, 141);
            bAddition.Name = "bAddition";
            bAddition.Size = new Size(94, 92);
            bAddition.TabIndex = 13;
            bAddition.Text = "+";
            bAddition.UseVisualStyleBackColor = false;
            bAddition.Click += op_click;
            // 
            // bSubtraction
            // 
            bSubtraction.BackColor = Color.FromArgb(64, 64, 64);
            bSubtraction.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold);
            bSubtraction.ForeColor = SystemColors.ButtonHighlight;
            bSubtraction.Location = new Point(458, 249);
            bSubtraction.Name = "bSubtraction";
            bSubtraction.Size = new Size(94, 92);
            bSubtraction.TabIndex = 14;
            bSubtraction.Text = "-";
            bSubtraction.UseVisualStyleBackColor = false;
            bSubtraction.Click += op_click;
            // 
            // bMultiplication
            // 
            bMultiplication.BackColor = Color.FromArgb(64, 64, 64);
            bMultiplication.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold);
            bMultiplication.ForeColor = SystemColors.ButtonHighlight;
            bMultiplication.Location = new Point(458, 353);
            bMultiplication.Name = "bMultiplication";
            bMultiplication.Size = new Size(94, 92);
            bMultiplication.TabIndex = 15;
            bMultiplication.Text = "X";
            bMultiplication.UseVisualStyleBackColor = false;
            bMultiplication.Click += op_click;
            // 
            // bSlash
            // 
            bSlash.BackColor = Color.FromArgb(64, 64, 64);
            bSlash.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold);
            bSlash.ForeColor = SystemColors.ButtonHighlight;
            bSlash.Location = new Point(458, 476);
            bSlash.Name = "bSlash";
            bSlash.Size = new Size(94, 92);
            bSlash.TabIndex = 16;
            bSlash.Text = "/";
            bSlash.UseVisualStyleBackColor = false;
            bSlash.Click += op_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(625, 592);
            Controls.Add(bSlash);
            Controls.Add(bMultiplication);
            Controls.Add(bSubtraction);
            Controls.Add(bAddition);
            Controls.Add(bEquals);
            Controls.Add(bClear);
            Controls.Add(b9);
            Controls.Add(b8);
            Controls.Add(b7);
            Controls.Add(b6);
            Controls.Add(b5);
            Controls.Add(b4);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(b0);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button b0;
        private Button b1;
        private Button b2;
        private Button b3;
        private Button b4;
        private Button b5;
        private Button b6;
        private Button b7;
        private Button b8;
        private Button b9;
        private Button bClear;
        private Button bEquals;
        private Button bAddition;
        private Button bSubtraction;
        private Button bMultiplication;
        private Button bSlash;
    }
}
