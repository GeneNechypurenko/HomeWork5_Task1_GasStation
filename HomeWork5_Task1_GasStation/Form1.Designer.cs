namespace HomeWork5_Task1_GasStation
{
    partial class bestOilGasStationForm
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
            calculateGroupBox = new GroupBox();
            calculateOutputLabel = new Label();
            calculateButton = new Button();
            gasStationGroupBox = new GroupBox();
            gasStationOutputGroupBox = new GroupBox();
            gasStationOutputLabel = new Label();
            petrolAmountTotalGroupBox = new GroupBox();
            totalNumeric = new NumericUpDown();
            amountNumeric = new NumericUpDown();
            petrolTotalRadioButton = new RadioButton();
            petrolAmountRadioButton = new RadioButton();
            label2 = new Label();
            label1 = new Label();
            petrolPriceOtputTextBox = new TextBox();
            petrolTypeComboBox = new ComboBox();
            cafeGroupBox = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            cafeOutputLabel = new Label();
            calculateGroupBox.SuspendLayout();
            gasStationGroupBox.SuspendLayout();
            gasStationOutputGroupBox.SuspendLayout();
            petrolAmountTotalGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)totalNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amountNumeric).BeginInit();
            cafeGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // calculateGroupBox
            // 
            calculateGroupBox.BackColor = SystemColors.ButtonFace;
            calculateGroupBox.BackgroundImageLayout = ImageLayout.Zoom;
            calculateGroupBox.Controls.Add(calculateOutputLabel);
            calculateGroupBox.Controls.Add(calculateButton);
            calculateGroupBox.Dock = DockStyle.Bottom;
            calculateGroupBox.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            calculateGroupBox.Location = new Point(0, 333);
            calculateGroupBox.Name = "calculateGroupBox";
            calculateGroupBox.Size = new Size(512, 100);
            calculateGroupBox.TabIndex = 1;
            calculateGroupBox.TabStop = false;
            calculateGroupBox.Text = "ВСЬОГО ДО СПЛАТИ";
            // 
            // calculateOutputLabel
            // 
            calculateOutputLabel.AutoSize = true;
            calculateOutputLabel.Dock = DockStyle.Right;
            calculateOutputLabel.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point);
            calculateOutputLabel.ForeColor = Color.FromArgb(64, 64, 64);
            calculateOutputLabel.Location = new Point(509, 28);
            calculateOutputLabel.Name = "calculateOutputLabel";
            calculateOutputLabel.Size = new Size(0, 72);
            calculateOutputLabel.TabIndex = 2;
            // 
            // calculateButton
            // 
            calculateButton.BackColor = Color.FromArgb(64, 64, 64);
            calculateButton.BackgroundImageLayout = ImageLayout.Stretch;
            calculateButton.Dock = DockStyle.Left;
            calculateButton.FlatStyle = FlatStyle.Popup;
            calculateButton.Font = new Font("Bahnschrift SemiBold Condensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            calculateButton.ForeColor = Color.Ivory;
            calculateButton.Location = new Point(3, 28);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(152, 69);
            calculateButton.TabIndex = 1;
            calculateButton.Text = "РОЗРАХУВАТИ";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // gasStationGroupBox
            // 
            gasStationGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gasStationGroupBox.BackColor = SystemColors.ButtonFace;
            gasStationGroupBox.BackgroundImageLayout = ImageLayout.Zoom;
            gasStationGroupBox.Controls.Add(gasStationOutputGroupBox);
            gasStationGroupBox.Controls.Add(petrolAmountTotalGroupBox);
            gasStationGroupBox.Controls.Add(label2);
            gasStationGroupBox.Controls.Add(label1);
            gasStationGroupBox.Controls.Add(petrolPriceOtputTextBox);
            gasStationGroupBox.Controls.Add(petrolTypeComboBox);
            gasStationGroupBox.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gasStationGroupBox.Location = new Point(5, 8);
            gasStationGroupBox.Name = "gasStationGroupBox";
            gasStationGroupBox.Size = new Size(250, 315);
            gasStationGroupBox.TabIndex = 3;
            gasStationGroupBox.TabStop = false;
            gasStationGroupBox.Text = "АВТОЗАПРАВКА";
            // 
            // gasStationOutputGroupBox
            // 
            gasStationOutputGroupBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            gasStationOutputGroupBox.Controls.Add(gasStationOutputLabel);
            gasStationOutputGroupBox.Location = new Point(4, 230);
            gasStationOutputGroupBox.Name = "gasStationOutputGroupBox";
            gasStationOutputGroupBox.Size = new Size(240, 80);
            gasStationOutputGroupBox.TabIndex = 7;
            gasStationOutputGroupBox.TabStop = false;
            gasStationOutputGroupBox.Text = "ДО СПЛАТИ";
            // 
            // gasStationOutputLabel
            // 
            gasStationOutputLabel.AutoSize = true;
            gasStationOutputLabel.Dock = DockStyle.Right;
            gasStationOutputLabel.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point);
            gasStationOutputLabel.ForeColor = Color.FromArgb(64, 64, 64);
            gasStationOutputLabel.Location = new Point(237, 24);
            gasStationOutputLabel.Name = "gasStationOutputLabel";
            gasStationOutputLabel.Size = new Size(0, 48);
            gasStationOutputLabel.TabIndex = 0;
            // 
            // petrolAmountTotalGroupBox
            // 
            petrolAmountTotalGroupBox.Controls.Add(totalNumeric);
            petrolAmountTotalGroupBox.Controls.Add(amountNumeric);
            petrolAmountTotalGroupBox.Controls.Add(petrolTotalRadioButton);
            petrolAmountTotalGroupBox.Controls.Add(petrolAmountRadioButton);
            petrolAmountTotalGroupBox.Location = new Point(5, 115);
            petrolAmountTotalGroupBox.Name = "petrolAmountTotalGroupBox";
            petrolAmountTotalGroupBox.Size = new Size(240, 115);
            petrolAmountTotalGroupBox.TabIndex = 4;
            petrolAmountTotalGroupBox.TabStop = false;
            // 
            // totalNumeric
            // 
            totalNumeric.Location = new Point(114, 65);
            totalNumeric.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            totalNumeric.Name = "totalNumeric";
            totalNumeric.Size = new Size(120, 28);
            totalNumeric.TabIndex = 3;
            totalNumeric.ValueChanged += totalNumeric_ValueChanged;
            // 
            // amountNumeric
            // 
            amountNumeric.Location = new Point(114, 30);
            amountNumeric.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            amountNumeric.Name = "amountNumeric";
            amountNumeric.Size = new Size(120, 28);
            amountNumeric.TabIndex = 2;
            amountNumeric.ValueChanged += amountNumeric_ValueChanged;
            // 
            // petrolTotalRadioButton
            // 
            petrolTotalRadioButton.AutoSize = true;
            petrolTotalRadioButton.Location = new Point(6, 65);
            petrolTotalRadioButton.Name = "petrolTotalRadioButton";
            petrolTotalRadioButton.Size = new Size(62, 25);
            petrolTotalRadioButton.TabIndex = 1;
            petrolTotalRadioButton.Text = "СУМА";
            petrolTotalRadioButton.UseVisualStyleBackColor = true;
            petrolTotalRadioButton.CheckedChanged += SwitchRadioButton_CheckedChanged;
            // 
            // petrolAmountRadioButton
            // 
            petrolAmountRadioButton.AutoSize = true;
            petrolAmountRadioButton.Checked = true;
            petrolAmountRadioButton.Location = new Point(6, 30);
            petrolAmountRadioButton.Name = "petrolAmountRadioButton";
            petrolAmountRadioButton.Size = new Size(86, 25);
            petrolAmountRadioButton.TabIndex = 0;
            petrolAmountRadioButton.TabStop = true;
            petrolAmountRadioButton.Text = "КІЛЬКІСТЬ";
            petrolAmountRadioButton.UseVisualStyleBackColor = true;
            petrolAmountRadioButton.CheckedChanged += SwitchRadioButton_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(6, 75);
            label2.Name = "label2";
            label2.Size = new Size(36, 21);
            label2.TabIndex = 3;
            label2.Text = "ЦІНА";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(6, 40);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 2;
            label1.Text = "ПАЛИВО";
            // 
            // petrolPriceOtputTextBox
            // 
            petrolPriceOtputTextBox.BackColor = Color.AntiqueWhite;
            petrolPriceOtputTextBox.BorderStyle = BorderStyle.FixedSingle;
            petrolPriceOtputTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            petrolPriceOtputTextBox.Location = new Point(119, 75);
            petrolPriceOtputTextBox.Name = "petrolPriceOtputTextBox";
            petrolPriceOtputTextBox.ReadOnly = true;
            petrolPriceOtputTextBox.Size = new Size(120, 28);
            petrolPriceOtputTextBox.TabIndex = 1;
            // 
            // petrolTypeComboBox
            // 
            petrolTypeComboBox.BackColor = Color.Ivory;
            petrolTypeComboBox.FlatStyle = FlatStyle.Popup;
            petrolTypeComboBox.ForeColor = Color.FromArgb(64, 64, 64);
            petrolTypeComboBox.FormattingEnabled = true;
            petrolTypeComboBox.IntegralHeight = false;
            petrolTypeComboBox.Location = new Point(119, 40);
            petrolTypeComboBox.MaxDropDownItems = 6;
            petrolTypeComboBox.Name = "petrolTypeComboBox";
            petrolTypeComboBox.RightToLeft = RightToLeft.No;
            petrolTypeComboBox.Size = new Size(120, 29);
            petrolTypeComboBox.TabIndex = 0;
            petrolTypeComboBox.SelectedIndexChanged += petrolTypeComboBox_SelectedIndexChanged;
            // 
            // cafeGroupBox
            // 
            cafeGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            cafeGroupBox.BackColor = SystemColors.ButtonFace;
            cafeGroupBox.Controls.Add(label5);
            cafeGroupBox.Controls.Add(label4);
            cafeGroupBox.Controls.Add(groupBox1);
            cafeGroupBox.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cafeGroupBox.Location = new Point(257, 8);
            cafeGroupBox.Name = "cafeGroupBox";
            cafeGroupBox.Size = new Size(250, 315);
            cafeGroupBox.TabIndex = 4;
            cafeGroupBox.TabStop = false;
            cafeGroupBox.Text = "МІНІ-КАФЕ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(179, 40);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 10;
            label5.Text = "КІЛЬКІСТЬ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(142, 40);
            label4.Name = "label4";
            label4.Size = new Size(36, 21);
            label4.TabIndex = 9;
            label4.Text = "ЦІНА";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox1.Controls.Add(cafeOutputLabel);
            groupBox1.Location = new Point(4, 230);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(240, 80);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "ДО СПЛАТИ";
            // 
            // cafeOutputLabel
            // 
            cafeOutputLabel.AutoSize = true;
            cafeOutputLabel.Dock = DockStyle.Right;
            cafeOutputLabel.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point);
            cafeOutputLabel.ForeColor = Color.FromArgb(64, 64, 64);
            cafeOutputLabel.Location = new Point(237, 24);
            cafeOutputLabel.Name = "cafeOutputLabel";
            cafeOutputLabel.Size = new Size(0, 48);
            cafeOutputLabel.TabIndex = 0;
            // 
            // bestOilGasStationForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(512, 433);
            Controls.Add(cafeGroupBox);
            Controls.Add(gasStationGroupBox);
            Controls.Add(calculateGroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "bestOilGasStationForm";
            Text = "Best Oil";
            Load += bestOilGasStationForm_Load;
            calculateGroupBox.ResumeLayout(false);
            calculateGroupBox.PerformLayout();
            gasStationGroupBox.ResumeLayout(false);
            gasStationGroupBox.PerformLayout();
            gasStationOutputGroupBox.ResumeLayout(false);
            gasStationOutputGroupBox.PerformLayout();
            petrolAmountTotalGroupBox.ResumeLayout(false);
            petrolAmountTotalGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)totalNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)amountNumeric).EndInit();
            cafeGroupBox.ResumeLayout(false);
            cafeGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox calculateGroupBox;
        private Button calculateButton;
        private Label calculateOutputLabel;
        private GroupBox gasStationGroupBox;
        private GroupBox cafeGroupBox;
        private TextBox petrolPriceOtputTextBox;
        private ComboBox petrolTypeComboBox;
        private Label label2;
        private Label label1;
        private GroupBox petrolAmountTotalGroupBox;
        private RadioButton petrolTotalRadioButton;
        private RadioButton petrolAmountRadioButton;
        private GroupBox gasStationOutputGroupBox;
        private Label gasStationOutputLabel;
        private GroupBox groupBox1;
        private Label cafeOutputLabel;
        private Label label5;
        private Label label4;
        private NumericUpDown totalNumeric;
        private NumericUpDown amountNumeric;
    }
}