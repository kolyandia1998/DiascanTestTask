namespace DiascanTestTask
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
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Multiselect = true;
            // 
            // button1
            // 
            button1.Location = new Point(320, 309);
            button1.Name = "button1";
            button1.Size = new Size(149, 29);
            button1.TabIndex = 0;
            button1.Text = "Calculate hash";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(549, 175);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Choose file";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveBorder;
            textBox1.Location = new Point(199, 175);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(344, 27);
            textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Hash calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
    }
}
