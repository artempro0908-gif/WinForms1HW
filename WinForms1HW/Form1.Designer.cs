namespace WinForms1HW
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
            txtMyInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtFileContent = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(618, 39);
            button1.Name = "button1";
            button1.Size = new Size(170, 58);
            button1.TabIndex = 0;
            button1.Text = "Натисни мене";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtMyInput
            // 
            txtMyInput.Location = new Point(12, 53);
            txtMyInput.Name = "txtMyInput";
            txtMyInput.Size = new Size(389, 31);
            txtMyInput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 2;
            label1.Text = "Шлях до файлу";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 117);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 4;
            label2.Text = "Вміст файлу";
            // 
            // txtFileContent
            // 
            txtFileContent.Location = new Point(12, 161);
            txtFileContent.Multiline = true;
            txtFileContent.Name = "txtFileContent";
            txtFileContent.Size = new Size(776, 277);
            txtFileContent.TabIndex = 3;
            txtFileContent.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtFileContent);
            Controls.Add(label1);
            Controls.Add(txtMyInput);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtMyInput;
        private Label label1;
        private Label label2;
        private TextBox txtFileContent;
    }
}
