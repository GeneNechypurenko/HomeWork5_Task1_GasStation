namespace task2_DataGridView
{
    partial class MainForm
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
            DataGridView = new DataGridView();
            CountButton = new Button();
            WordsTextBox = new TextBox();
            LettersTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // DataGridView
            // 
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Dock = DockStyle.Top;
            DataGridView.Location = new Point(0, 0);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersWidth = 51;
            DataGridView.RowTemplate.Height = 29;
            DataGridView.Size = new Size(428, 188);
            DataGridView.TabIndex = 0;
            // 
            // CountButton
            // 
            CountButton.Dock = DockStyle.Bottom;
            CountButton.Location = new Point(0, 264);
            CountButton.Name = "CountButton";
            CountButton.Size = new Size(428, 29);
            CountButton.TabIndex = 1;
            CountButton.Text = "COUNT";
            CountButton.UseVisualStyleBackColor = true;
            CountButton.Click += CountButton_Click;
            // 
            // WordsTextBox
            // 
            WordsTextBox.Location = new Point(85, 194);
            WordsTextBox.Name = "WordsTextBox";
            WordsTextBox.Size = new Size(273, 27);
            WordsTextBox.TabIndex = 2;
            // 
            // LettersTextBox
            // 
            LettersTextBox.Location = new Point(85, 227);
            LettersTextBox.Name = "LettersTextBox";
            LettersTextBox.Size = new Size(273, 27);
            LettersTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 197);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 4;
            label1.Text = "WORDS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 230);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 5;
            label2.Text = "LETTERS";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 293);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LettersTextBox);
            Controls.Add(WordsTextBox);
            Controls.Add(CountButton);
            Controls.Add(DataGridView);
            Name = "MainForm";
            Text = "Main Form";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridView;
        private Button CountButton;
        private TextBox WordsTextBox;
        private TextBox LettersTextBox;
        private Label label1;
        private Label label2;
    }
}