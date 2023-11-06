namespace Task3_SalaryCalculator
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
            NameTextBox = new TextBox();
            CalculateButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            WorkHoursNumeric = new NumericUpDown();
            HourlyRateNumeric = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WorkHoursNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HourlyRateNumeric).BeginInit();
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
            DataGridView.Size = new Size(554, 278);
            DataGridView.TabIndex = 0;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(222, 284);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(320, 27);
            NameTextBox.TabIndex = 2;
            // 
            // CalculateButton
            // 
            CalculateButton.Dock = DockStyle.Bottom;
            CalculateButton.Location = new Point(0, 397);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(554, 53);
            CalculateButton.TabIndex = 5;
            CalculateButton.Text = "РАСЧИТАТЬ СОТРУДНИКА";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 284);
            label1.Name = "label1";
            label1.Size = new Size(186, 20);
            label1.TabIndex = 6;
            label1.Text = "Фамилия Имя Отчество";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 321);
            label2.Name = "label2";
            label2.Size = new Size(206, 20);
            label2.TabIndex = 7;
            label2.Text = "Количество рабочих часов";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 356);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 8;
            label3.Text = "Почасовой тариф";
            // 
            // WorkHoursNumeric
            // 
            WorkHoursNumeric.Location = new Point(222, 319);
            WorkHoursNumeric.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            WorkHoursNumeric.Name = "WorkHoursNumeric";
            WorkHoursNumeric.Size = new Size(320, 27);
            WorkHoursNumeric.TabIndex = 9;
            // 
            // HourlyRateNumeric
            // 
            HourlyRateNumeric.Location = new Point(222, 352);
            HourlyRateNumeric.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            HourlyRateNumeric.Name = "HourlyRateNumeric";
            HourlyRateNumeric.Size = new Size(320, 27);
            HourlyRateNumeric.TabIndex = 10;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 450);
            Controls.Add(HourlyRateNumeric);
            Controls.Add(WorkHoursNumeric);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CalculateButton);
            Controls.Add(NameTextBox);
            Controls.Add(DataGridView);
            Name = "MainForm";
            Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)WorkHoursNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)HourlyRateNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridView;
        private TextBox NameTextBox;
        private Button CalculateButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown WorkHoursNumeric;
        private NumericUpDown HourlyRateNumeric;
    }
}