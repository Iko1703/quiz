namespace NNGASU_TEST
{
    partial class Form2
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
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(95, 46);
            button1.TabIndex = 0;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(159, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(461, 272);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(250, 370);
            label1.Name = "label1";
            label1.Size = new Size(291, 27);
            label1.TabIndex = 2;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(621, 360);
            button2.Name = "button2";
            button2.Size = new Size(146, 37);
            button2.TabIndex = 3;
            button2.Text = "Вперед";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(12, 360);
            button3.Name = "button3";
            button3.Size = new Size(146, 37);
            button3.TabIndex = 4;
            button3.Text = "Назад";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(677, 12);
            label2.Name = "label2";
            label2.Size = new Size(0, 27);
            label2.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 450);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Label label2;
    }
}