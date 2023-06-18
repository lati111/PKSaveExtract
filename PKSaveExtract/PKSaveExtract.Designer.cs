namespace PKSaveExtract
{
    partial class PKSaveExtract
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PKSaveExtract));
            title = new Label();
            SaveFilePathDisplay = new TextBox();
            BrowseSaveFileButton = new Button();
            saveFileLabel = new Label();
            FormatPicker = new ComboBox();
            FormatLabel = new Label();
            ExtractButton = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(32, 9);
            title.Name = "title";
            title.Size = new Size(292, 32);
            title.TabIndex = 0;
            title.Text = "Extract Pokemon Save File";
            title.TextAlign = ContentAlignment.TopCenter;
            // 
            // SaveFilePathDisplay
            // 
            SaveFilePathDisplay.AccessibleRole = AccessibleRole.None;
            SaveFilePathDisplay.Enabled = false;
            SaveFilePathDisplay.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SaveFilePathDisplay.Location = new Point(12, 71);
            SaveFilePathDisplay.Name = "SaveFilePathDisplay";
            SaveFilePathDisplay.ReadOnly = true;
            SaveFilePathDisplay.Size = new Size(246, 27);
            SaveFilePathDisplay.TabIndex = 1;
            // 
            // BrowseSaveFileButton
            // 
            BrowseSaveFileButton.Location = new Point(258, 71);
            BrowseSaveFileButton.Name = "BrowseSaveFileButton";
            BrowseSaveFileButton.Size = new Size(89, 27);
            BrowseSaveFileButton.TabIndex = 2;
            BrowseSaveFileButton.Text = "Browse";
            BrowseSaveFileButton.UseVisualStyleBackColor = true;
            BrowseSaveFileButton.Click += BrowseSaveFileButton_Click;
            // 
            // saveFileLabel
            // 
            saveFileLabel.AutoSize = true;
            saveFileLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            saveFileLabel.Location = new Point(22, 50);
            saveFileLabel.Name = "saveFileLabel";
            saveFileLabel.Size = new Size(67, 20);
            saveFileLabel.TabIndex = 3;
            saveFileLabel.Text = "Save File";
            // 
            // FormatPicker
            // 
            FormatPicker.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            FormatPicker.FormattingEnabled = true;
            FormatPicker.Location = new Point(12, 134);
            FormatPicker.Name = "FormatPicker";
            FormatPicker.Size = new Size(335, 28);
            FormatPicker.TabIndex = 4;
            // 
            // FormatLabel
            // 
            FormatLabel.AutoSize = true;
            FormatLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            FormatLabel.Location = new Point(22, 111);
            FormatLabel.Name = "FormatLabel";
            FormatLabel.Size = new Size(56, 20);
            FormatLabel.TabIndex = 5;
            FormatLabel.Text = "Format";
            // 
            // ExtractButton
            // 
            ExtractButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ExtractButton.Location = new Point(100, 179);
            ExtractButton.Name = "ExtractButton";
            ExtractButton.Size = new Size(158, 27);
            ExtractButton.TabIndex = 6;
            ExtractButton.Text = "Extract";
            ExtractButton.UseVisualStyleBackColor = true;
            ExtractButton.Click += ExtractButton_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // PKSaveExtract
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 224);
            Controls.Add(ExtractButton);
            Controls.Add(FormatLabel);
            Controls.Add(FormatPicker);
            Controls.Add(saveFileLabel);
            Controls.Add(BrowseSaveFileButton);
            Controls.Add(SaveFilePathDisplay);
            Controls.Add(title);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PKSaveExtract";
            Text = "PKSaveExtract";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private TextBox SaveFilePathDisplay;
        private Button BrowseSaveFileButton;
        private Label saveFileLabel;
        private ComboBox FormatPicker;
        private Label FormatLabel;
        private Button ExtractButton;
        private ErrorProvider errorProvider1;
    }
}