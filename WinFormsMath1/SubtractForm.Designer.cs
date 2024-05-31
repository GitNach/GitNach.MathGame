namespace WinFormsMath1
{
    partial class SubtractForm
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
            checkAnswerSubtract = new Button();
            textBoxSubtract = new TextBox();
            labelQstnSubtract = new Label();
            labelScoreSubtract = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // checkAnswerSubtract
            // 
            checkAnswerSubtract.Location = new Point(283, 33);
            checkAnswerSubtract.Name = "checkAnswerSubtract";
            checkAnswerSubtract.Size = new Size(91, 23);
            checkAnswerSubtract.TabIndex = 0;
            checkAnswerSubtract.Text = "Send Answer";
            checkAnswerSubtract.UseVisualStyleBackColor = true;
            checkAnswerSubtract.Click += button1_Click;
            // 
            // textBoxSubtract
            // 
            textBoxSubtract.Location = new Point(177, 33);
            textBoxSubtract.Name = "textBoxSubtract";
            textBoxSubtract.Size = new Size(100, 23);
            textBoxSubtract.TabIndex = 1;
            // 
            // labelQstnSubtract
            // 
            labelQstnSubtract.AutoSize = true;
            labelQstnSubtract.Location = new Point(211, 15);
            labelQstnSubtract.Name = "labelQstnSubtract";
            labelQstnSubtract.Size = new Size(38, 15);
            labelQstnSubtract.TabIndex = 2;
            labelQstnSubtract.Text = "label1";
            // 
            // labelScoreSubtract
            // 
            labelScoreSubtract.AutoSize = true;
            labelScoreSubtract.Location = new Point(211, 71);
            labelScoreSubtract.Name = "labelScoreSubtract";
            labelScoreSubtract.Size = new Size(38, 15);
            labelScoreSubtract.TabIndex = 3;
            labelScoreSubtract.Text = "label2";
            // 
            // button1
            // 
            button1.Location = new Point(177, 196);
            button1.Name = "button1";
            button1.Size = new Size(100, 44);
            button1.TabIndex = 4;
            button1.Text = "Back to Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // SubtractForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 252);
            Controls.Add(button1);
            Controls.Add(labelScoreSubtract);
            Controls.Add(labelQstnSubtract);
            Controls.Add(textBoxSubtract);
            Controls.Add(checkAnswerSubtract);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "SubtractForm";
            Text = "SubtractForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button checkAnswerSubtract;
        private TextBox textBoxSubtract;
        private Label labelQstnSubtract;
        private Label labelScoreSubtract;
        private Button button1;
    }
}