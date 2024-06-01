namespace WinFormsMath1
{
    partial class DivisionForm
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
            labelQstnDivision = new Label();
            labelScoreDivision = new Label();
            textBoxDivision = new TextBox();
            sendAnswerDivision = new Button();
            backToMenuDivision = new Button();
            SuspendLayout();
            // 
            // labelQstnDivision
            // 
            labelQstnDivision.AutoSize = true;
            labelQstnDivision.Location = new Point(214, 9);
            labelQstnDivision.Name = "labelQstnDivision";
            labelQstnDivision.Size = new Size(38, 15);
            labelQstnDivision.TabIndex = 0;
            labelQstnDivision.Text = "label1";
            // 
            // labelScoreDivision
            // 
            labelScoreDivision.AutoSize = true;
            labelScoreDivision.Location = new Point(214, 54);
            labelScoreDivision.Name = "labelScoreDivision";
            labelScoreDivision.Size = new Size(38, 15);
            labelScoreDivision.TabIndex = 1;
            labelScoreDivision.Text = "label2";
            // 
            // textBoxDivision
            // 
            textBoxDivision.Location = new Point(185, 28);
            textBoxDivision.Name = "textBoxDivision";
            textBoxDivision.Size = new Size(100, 23);
            textBoxDivision.TabIndex = 2;
            // 
            // sendAnswerDivision
            // 
            sendAnswerDivision.Location = new Point(291, 27);
            sendAnswerDivision.Name = "sendAnswerDivision";
            sendAnswerDivision.Size = new Size(86, 23);
            sendAnswerDivision.TabIndex = 3;
            sendAnswerDivision.Text = "Send Answer";
            sendAnswerDivision.UseVisualStyleBackColor = true;
            sendAnswerDivision.Click += checkAnswer;
            // 
            // backToMenuDivision
            // 
            backToMenuDivision.Location = new Point(185, 207);
            backToMenuDivision.Name = "backToMenuDivision";
            backToMenuDivision.Size = new Size(100, 33);
            backToMenuDivision.TabIndex = 4;
            backToMenuDivision.Text = "Back to Menu";
            backToMenuDivision.UseVisualStyleBackColor = true;
            backToMenuDivision.Click += backToMenuDivision_Click;
            // 
            // DivisionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 252);
            Controls.Add(backToMenuDivision);
            Controls.Add(sendAnswerDivision);
            Controls.Add(textBoxDivision);
            Controls.Add(labelScoreDivision);
            Controls.Add(labelQstnDivision);
            Name = "DivisionForm";
            Text = "DivisionForm";
            Load += DivisionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelQstnDivision;
        private Label labelScoreDivision;
        private TextBox textBoxDivision;
        private Button sendAnswerDivision;
        private Button backToMenuDivision;
    }
}