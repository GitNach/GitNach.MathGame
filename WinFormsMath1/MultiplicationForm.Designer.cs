namespace WinFormsMath1
{
    partial class MultiplicationForm
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
            labelQstnMultiplication = new Label();
            labelScoreMultiplication = new Label();
            textBoxMultiplication = new TextBox();
            buttonCheckMultiplication = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // labelQstnMultiplication
            // 
            labelQstnMultiplication.AutoSize = true;
            labelQstnMultiplication.Location = new Point(208, 0);
            labelQstnMultiplication.Name = "labelQstnMultiplication";
            labelQstnMultiplication.Size = new Size(38, 15);
            labelQstnMultiplication.TabIndex = 0;
            labelQstnMultiplication.Text = "label1";
            // 
            // labelScoreMultiplication
            // 
            labelScoreMultiplication.AutoSize = true;
            labelScoreMultiplication.Location = new Point(208, 59);
            labelScoreMultiplication.Name = "labelScoreMultiplication";
            labelScoreMultiplication.Size = new Size(38, 15);
            labelScoreMultiplication.TabIndex = 1;
            labelScoreMultiplication.Text = "label2";
            // 
            // textBoxMultiplication
            // 
            textBoxMultiplication.Location = new Point(176, 18);
            textBoxMultiplication.Name = "textBoxMultiplication";
            textBoxMultiplication.Size = new Size(100, 23);
            textBoxMultiplication.TabIndex = 2;
            // 
            // buttonCheckMultiplication
            // 
            buttonCheckMultiplication.Location = new Point(282, 18);
            buttonCheckMultiplication.Name = "buttonCheckMultiplication";
            buttonCheckMultiplication.Size = new Size(85, 23);
            buttonCheckMultiplication.TabIndex = 3;
            buttonCheckMultiplication.Text = "Send Answer";
            buttonCheckMultiplication.UseVisualStyleBackColor = true;
            buttonCheckMultiplication.Click += checkAnswer;
            // 
            // button2
            // 
            button2.Location = new Point(176, 205);
            button2.Name = "button2";
            button2.Size = new Size(100, 35);
            button2.TabIndex = 4;
            button2.Text = "Back to Menu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnBackToMenu;
            // 
            // MultiplicationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 252);
            Controls.Add(button2);
            Controls.Add(buttonCheckMultiplication);
            Controls.Add(textBoxMultiplication);
            Controls.Add(labelScoreMultiplication);
            Controls.Add(labelQstnMultiplication);
            Name = "MultiplicationForm";
            Text = "MultiplicationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelQstnMultiplication;
        private Label labelScoreMultiplication;
        private TextBox textBoxMultiplication;
        private Button buttonCheckMultiplication;
        private Button button2;
    }
}