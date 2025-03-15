namespace TI_Lab2
{
    partial class Form1
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
            ResultButton = new Button();
            LengthLabel = new Label();
            RegisterTextBox = new TextBox();
            PlainTextBox = new TextBox();
            PlainLabel = new Label();
            KeyTextBox = new TextBox();
            KeyLabel = new Label();
            LabelCipherText = new Label();
            CipherTextBox = new TextBox();
            SaveFileDialog = new SaveFileDialog();
            OpenFileDialog = new OpenFileDialog();
            OpenFileButton = new Button();
            SaveFileButton = new Button();
            StartStateLabel = new Label();
            SuspendLayout();
            // 
            // ResultButton
            // 
            ResultButton.Location = new Point(462, 121);
            ResultButton.Name = "ResultButton";
            ResultButton.Size = new Size(159, 43);
            ResultButton.TabIndex = 0;
            ResultButton.Text = "Зашифровать";
            ResultButton.UseVisualStyleBackColor = true;
            ResultButton.Click += ResultButton_Click;
            // 
            // LengthLabel
            // 
            LengthLabel.AutoSize = true;
            LengthLabel.Location = new Point(462, 80);
            LengthLabel.Name = "LengthLabel";
            LengthLabel.Size = new Size(177, 15);
            LengthLabel.TabIndex = 1;
            LengthLabel.Text = "Длина введённых состояний: 0";
            // 
            // RegisterTextBox
            // 
            RegisterTextBox.Location = new Point(462, 54);
            RegisterTextBox.Name = "RegisterTextBox";
            RegisterTextBox.Size = new Size(331, 23);
            RegisterTextBox.TabIndex = 2;
            RegisterTextBox.TextChanged += RegisterTextBox_TextChanged;
            // 
            // PlainTextBox
            // 
            PlainTextBox.Location = new Point(12, 54);
            PlainTextBox.Multiline = true;
            PlainTextBox.Name = "PlainTextBox";
            PlainTextBox.Size = new Size(414, 166);
            PlainTextBox.TabIndex = 3;
            // 
            // PlainLabel
            // 
            PlainLabel.AutoSize = true;
            PlainLabel.Location = new Point(12, 36);
            PlainLabel.Name = "PlainLabel";
            PlainLabel.Size = new Size(95, 15);
            PlainLabel.TabIndex = 4;
            PlainLabel.Text = "Исходный текст";
            // 
            // KeyTextBox
            // 
            KeyTextBox.Location = new Point(462, 294);
            KeyTextBox.Multiline = true;
            KeyTextBox.Name = "KeyTextBox";
            KeyTextBox.Size = new Size(414, 166);
            KeyTextBox.TabIndex = 5;
            // 
            // KeyLabel
            // 
            KeyLabel.AutoSize = true;
            KeyLabel.Location = new Point(462, 276);
            KeyLabel.Name = "KeyLabel";
            KeyLabel.Size = new Size(38, 15);
            KeyLabel.TabIndex = 6;
            KeyLabel.Text = "Ключ";
            // 
            // LabelCipherText
            // 
            LabelCipherText.AutoSize = true;
            LabelCipherText.Location = new Point(17, 276);
            LabelCipherText.Name = "LabelCipherText";
            LabelCipherText.Size = new Size(76, 15);
            LabelCipherText.TabIndex = 8;
            LabelCipherText.Text = "Шифротекст";
            // 
            // CipherTextBox
            // 
            CipherTextBox.Location = new Point(17, 294);
            CipherTextBox.Multiline = true;
            CipherTextBox.Name = "CipherTextBox";
            CipherTextBox.Size = new Size(414, 166);
            CipherTextBox.TabIndex = 7;
            // 
            // OpenFileDialog
            // 
            OpenFileDialog.FileName = "openFileDialog1";
            // 
            // OpenFileButton
            // 
            OpenFileButton.Location = new Point(293, 25);
            OpenFileButton.Name = "OpenFileButton";
            OpenFileButton.Size = new Size(123, 23);
            OpenFileButton.TabIndex = 9;
            OpenFileButton.Text = "Открыть файл";
            OpenFileButton.UseVisualStyleBackColor = true;
            OpenFileButton.Click += OpenFileButton_Click;
            // 
            // SaveFileButton
            // 
            SaveFileButton.Location = new Point(288, 265);
            SaveFileButton.Name = "SaveFileButton";
            SaveFileButton.Size = new Size(128, 23);
            SaveFileButton.TabIndex = 10;
            SaveFileButton.Text = "Сохранить файл";
            SaveFileButton.UseVisualStyleBackColor = true;
            SaveFileButton.Click += SaveFileButton_Click;
            // 
            // StartStateLabel
            // 
            StartStateLabel.AutoSize = true;
            StartStateLabel.Location = new Point(462, 36);
            StartStateLabel.Name = "StartStateLabel";
            StartStateLabel.Size = new Size(180, 15);
            StartStateLabel.TabIndex = 11;
            StartStateLabel.Text = "Начальное состояние регистра";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 481);
            Controls.Add(StartStateLabel);
            Controls.Add(SaveFileButton);
            Controls.Add(OpenFileButton);
            Controls.Add(LabelCipherText);
            Controls.Add(CipherTextBox);
            Controls.Add(KeyLabel);
            Controls.Add(KeyTextBox);
            Controls.Add(PlainLabel);
            Controls.Add(PlainTextBox);
            Controls.Add(RegisterTextBox);
            Controls.Add(LengthLabel);
            Controls.Add(ResultButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ResultButton;
        private Label LengthLabel;
        private TextBox RegisterTextBox;
        private TextBox PlainTextBox;
        private Label PlainLabel;
        private TextBox KeyTextBox;
        private Label KeyLabel;
        private Label LabelCipherText;
        private TextBox CipherTextBox;
        private SaveFileDialog SaveFileDialog;
        private OpenFileDialog OpenFileDialog;
        private Button OpenFileButton;
        private Button SaveFileButton;
        private Label StartStateLabel;
    }
}
