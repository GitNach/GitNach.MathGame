namespace WinFormsMath1
{
    partial class GamesHistoryForm
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
            refreshButton = new Button();
            dataGridHistory = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridHistory).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(204, 267);
            button1.Name = "button1";
            button1.Size = new Size(86, 39);
            button1.TabIndex = 0;
            button1.Text = "Back to Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(424, 227);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(61, 23);
            refreshButton.TabIndex = 2;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // dataGridHistory
            // 
            dataGridHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridHistory.Location = new Point(12, 27);
            dataGridHistory.Name = "dataGridHistory";
            dataGridHistory.Size = new Size(473, 194);
            dataGridHistory.TabIndex = 3;
            // 
            // GamesHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(497, 318);
            Controls.Add(dataGridHistory);
            Controls.Add(refreshButton);
            Controls.Add(button1);
            Name = "GamesHistoryForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button refreshButton;
        private DataGridView dataGridHistory;
    }
}