namespace SelectRaw
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
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            JPGTargetButton = new Button();
            RawSourceButton = new Button();
            RawTargetButton = new Button();
            JPGTargetBox = new TextBox();
            RawSourceBox = new TextBox();
            RawTargetBox = new TextBox();
            JPGLabel = new Label();
            JPGBox = new TextBox();
            RawLabel = new Label();
            RawBox = new TextBox();
            StartButton = new Button();
            CopyProgressBar = new ProgressBar();
            SuspendLayout();
            // 
            // JPGTargetButton
            // 
            JPGTargetButton.Location = new Point(12, 12);
            JPGTargetButton.Name = "JPGTargetButton";
            JPGTargetButton.Size = new Size(160, 40);
            JPGTargetButton.TabIndex = 0;
            JPGTargetButton.Text = "JPG Target";
            JPGTargetButton.UseVisualStyleBackColor = true;
            JPGTargetButton.Click += JPGTargetButton_Click;
            // 
            // RawSourceButton
            // 
            RawSourceButton.Location = new Point(12, 58);
            RawSourceButton.Name = "RawSourceButton";
            RawSourceButton.Size = new Size(160, 40);
            RawSourceButton.TabIndex = 2;
            RawSourceButton.Text = "Raw Source Folder";
            RawSourceButton.UseVisualStyleBackColor = true;
            RawSourceButton.Click += RawSourceButton_Click;
            // 
            // RawTargetButton
            // 
            RawTargetButton.Location = new Point(12, 104);
            RawTargetButton.Name = "RawTargetButton";
            RawTargetButton.Size = new Size(160, 40);
            RawTargetButton.TabIndex = 4;
            RawTargetButton.Text = "Raw Target Folder";
            RawTargetButton.UseVisualStyleBackColor = true;
            RawTargetButton.Click += RawTargetButton_Click;
            // 
            // JPGTargetBox
            // 
            JPGTargetBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            JPGTargetBox.Location = new Point(178, 15);
            JPGTargetBox.Name = "JPGTargetBox";
            JPGTargetBox.Size = new Size(394, 34);
            JPGTargetBox.TabIndex = 1;
            // 
            // RawSourceBox
            // 
            RawSourceBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RawSourceBox.Location = new Point(178, 61);
            RawSourceBox.Name = "RawSourceBox";
            RawSourceBox.Size = new Size(394, 34);
            RawSourceBox.TabIndex = 3;
            // 
            // RawTargetBox
            // 
            RawTargetBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RawTargetBox.Location = new Point(178, 107);
            RawTargetBox.Name = "RawTargetBox";
            RawTargetBox.Size = new Size(394, 34);
            RawTargetBox.TabIndex = 5;
            // 
            // JPGLabel
            // 
            JPGLabel.AutoSize = true;
            JPGLabel.Location = new Point(12, 156);
            JPGLabel.Name = "JPGLabel";
            JPGLabel.Size = new Size(79, 28);
            JPGLabel.TabIndex = 6;
            JPGLabel.Text = "JPG Ext:";
            // 
            // JPGBox
            // 
            JPGBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            JPGBox.Location = new Point(178, 153);
            JPGBox.Name = "JPGBox";
            JPGBox.Size = new Size(394, 34);
            JPGBox.TabIndex = 7;
            JPGBox.Text = ".JPG";
            JPGBox.LostFocus += TextBox_CheckExt;
            // 
            // RawLabel
            // 
            RawLabel.AutoSize = true;
            RawLabel.Location = new Point(12, 202);
            RawLabel.Name = "RawLabel";
            RawLabel.Size = new Size(83, 28);
            RawLabel.TabIndex = 8;
            RawLabel.Text = "Raw Ext:";
            // 
            // RawBox
            // 
            RawBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RawBox.Location = new Point(178, 199);
            RawBox.Name = "RawBox";
            RawBox.Size = new Size(394, 34);
            RawBox.TabIndex = 9;
            RawBox.Text = ".ARW";
            RawBox.LostFocus += TextBox_CheckExt;
            // 
            // StartButton
            // 
            StartButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StartButton.Location = new Point(12, 245);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(560, 40);
            StartButton.TabIndex = 10;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // CopyProgressBar
            // 
            CopyProgressBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CopyProgressBar.Location = new Point(12, 300);
            CopyProgressBar.Name = "CopyProgressBar";
            CopyProgressBar.Size = new Size(558, 35);
            CopyProgressBar.Step = 1;
            CopyProgressBar.Style = ProgressBarStyle.Continuous;
            CopyProgressBar.TabIndex = 11;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 353);
            Controls.Add(CopyProgressBar);
            Controls.Add(StartButton);
            Controls.Add(RawBox);
            Controls.Add(RawLabel);
            Controls.Add(JPGBox);
            Controls.Add(JPGLabel);
            Controls.Add(RawTargetBox);
            Controls.Add(RawSourceBox);
            Controls.Add(JPGTargetBox);
            Controls.Add(RawTargetButton);
            Controls.Add(RawSourceButton);
            Controls.Add(JPGTargetButton);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "SelectRaw";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button JPGTargetButton;
        private Button RawSourceButton;
        private Button RawTargetButton;
        private TextBox JPGTargetBox;
        private TextBox RawSourceBox;
        private TextBox RawTargetBox;
        private Label JPGLabel;
        private TextBox JPGBox;
        private Label RawLabel;
        private TextBox RawBox;
        private Button StartButton;
        private ProgressBar CopyProgressBar;
    }
}