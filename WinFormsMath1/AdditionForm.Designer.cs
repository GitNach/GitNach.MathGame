namespace WinFormsMath1
{
    partial class AdditionForm
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
            labelQstn = new Label();
            textBoxAnswer = new TextBox();
            button1 = new Button();
            backMenu = new Button();
            labelResult = new Label();
            SuspendLayout();
            // 
            // labelQstn
            // 
            labelQstn.AutoSize = true;
            labelQstn.Location = new Point(208, 12);
            labelQstn.Name = "labelQstn";
            labelQstn.Size = new Size(38, 15);
            labelQstn.TabIndex = 0;
            labelQstn.Text = "label1";
            // 
            // textBoxAnswer
            // 
            textBoxAnswer.Location = new Point(178, 30);
            textBoxAnswer.Name = "textBoxAnswer";
            textBoxAnswer.Size = new Size(100, 23);
            textBoxAnswer.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(284, 30);
            button1.Name = "button1";
            button1.Size = new Size(89, 23);
            button1.TabIndex = 2;
            button1.Text = "Send Answer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += checkAnswer;
            // 
            // backMenu
            // 
            backMenu.Location = new Point(178, 196);
            backMenu.Name = "backMenu";
            backMenu.Size = new Size(100, 40);
            backMenu.TabIndex = 3;
            backMenu.Text = "Back to Menu";
            backMenu.UseVisualStyleBackColor = true;
            backMenu.Click += btnBackToMenu;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(208, 65);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(38, 15);
            labelResult.TabIndex = 4;
            labelResult.Text = "label2";
            // 
            // AdditionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 248);
            Controls.Add(labelResult);
            Controls.Add(backMenu);
            Controls.Add(button1);
            Controls.Add(textBoxAnswer);
            Controls.Add(labelQstn);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "AdditionForm";
            Text = "Addition";
            Load += AdditionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelQstn;
        private TextBox textBoxAnswer;
        private Button button1;
        private Button backMenu;
        private Label labelResult;
    }
}