namespace WinFormsMath1
{
    partial class MathGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MathGame));
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.HighlightText;
            label1.Font = new Font("Segoe UI Emoji", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(330, 9);
            label1.Name = "label1";
            label1.Size = new Size(242, 113);
            label1.TabIndex = 0;
            label1.Text = "Math Game!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.ForeColor = SystemColors.Desktop;
            button1.Location = new Point(263, 128);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Addition";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.ForeColor = SystemColors.Desktop;
            button2.Location = new Point(566, 128);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Division";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGray;
            button3.ForeColor = SystemColors.Desktop;
            button3.Location = new Point(459, 128);
            button3.Name = "button3";
            button3.Size = new Size(90, 23);
            button3.TabIndex = 3;
            button3.Text = "Multiplication";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkGray;
            button4.ForeColor = SystemColors.Desktop;
            button4.Location = new Point(359, 128);
            button4.Name = "button4";
            button4.Size = new Size(80, 23);
            button4.TabIndex = 4;
            button4.Text = "Subtraction";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(289, 167);
            button5.Name = "button5";
            button5.Size = new Size(332, 26);
            button5.TabIndex = 5;
            button5.Text = "View Previous Games";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // MathGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(734, 492);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "MathGame";
            Text = "MathGame";
            Load += MathGame_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}
