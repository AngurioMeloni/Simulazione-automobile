namespace simulazione_automobile
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button11 = new Button();
            button12 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(302, 33);
            button1.Name = "button1";
            button1.Size = new Size(31, 29);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(339, 32);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Start/Stop";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(448, 64);
            button3.Name = "button3";
            button3.Size = new Size(27, 29);
            button3.TabIndex = 2;
            button3.Text = "1";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(448, 99);
            button4.Name = "button4";
            button4.Size = new Size(27, 29);
            button4.TabIndex = 3;
            button4.Text = "2";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(481, 64);
            button5.Name = "button5";
            button5.Size = new Size(27, 29);
            button5.TabIndex = 4;
            button5.Text = "3";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(481, 99);
            button6.Name = "button6";
            button6.Size = new Size(27, 29);
            button6.TabIndex = 5;
            button6.Text = "4";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(514, 66);
            button7.Name = "button7";
            button7.Size = new Size(27, 29);
            button7.TabIndex = 6;
            button7.Text = "5";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(514, 99);
            button8.Name = "button8";
            button8.Size = new Size(27, 29);
            button8.TabIndex = 7;
            button8.Text = "6";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(514, 134);
            button9.Name = "button9";
            button9.Size = new Size(27, 29);
            button9.TabIndex = 8;
            button9.Text = "0";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(565, 33);
            button10.Name = "button10";
            button10.Size = new Size(123, 29);
            button10.TabIndex = 9;
            button10.Text = "Cambio Marcia";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(358, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 10;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(439, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 27);
            textBox1.TabIndex = 11;
            // 
            // button11
            // 
            button11.Location = new Point(358, 68);
            button11.Name = "button11";
            button11.Size = new Size(27, 95);
            button11.TabIndex = 12;
            button11.Text = "Acce";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(391, 68);
            button12.Name = "button12";
            button12.Size = new Size(27, 95);
            button12.TabIndex = 13;
            button12.Text = "Freno";
            button12.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(469, 10);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 14;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label2);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Label label1;
        private TextBox textBox1;
        private Button button11;
        private Button button12;
        private Label label2;
    }
}