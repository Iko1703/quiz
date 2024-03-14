namespace NNGASU_TEST
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 71);
            label1.Margin = new Padding(30, 0, 30, 0);
            label1.Name = "label1";
            label1.Size = new Size(300, 40);
            label1.TabIndex = 0;
            label1.Text = "Добро пожаловать!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(240, 149);
            label2.Margin = new Padding(30, 0, 30, 0);
            label2.Name = "label2";
            label2.Size = new Size(300, 116);
            label2.TabIndex = 1;
            label2.Text = "Для начала пройдите обучение, затем проверьте свои знания в тесте!";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(75, 331);
            button1.Name = "button1";
            button1.Size = new Size(161, 48);
            button1.TabIndex = 2;
            button1.Text = "Обучение";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(552, 331);
            button2.Name = "button2";
            button2.Size = new Size(165, 48);
            button2.TabIndex = 3;
            button2.Text = "Тестирование";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}
