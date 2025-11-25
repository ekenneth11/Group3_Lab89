namespace SwimLibForm
{
    partial class HeatSheetForm
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
            heatSheetBox = new RichTextBox();
            heatSheetButton = new Button();
            groupBox1 = new GroupBox();
            fileNameLabel = new Label();
            timedButton = new Button();
            randomButton = new Button();
            seedingServiceName = new Label();
            label1 = new Label();
            fileName = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // heatSheetBox
            // 
            heatSheetBox.Location = new Point(419, 12);
            heatSheetBox.Name = "heatSheetBox";
            heatSheetBox.Size = new Size(369, 426);
            heatSheetBox.TabIndex = 0;
            heatSheetBox.Text = "Heat Sheet Box";
            // 
            // heatSheetButton
            // 
            heatSheetButton.Location = new Point(118, 186);
            heatSheetButton.Name = "heatSheetButton";
            heatSheetButton.Size = new Size(171, 63);
            heatSheetButton.TabIndex = 1;
            heatSheetButton.Text = "Generate Heat Sheet";
            heatSheetButton.UseVisualStyleBackColor = true;
            heatSheetButton.Click += heatSheetButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(fileName);
            groupBox1.Controls.Add(fileNameLabel);
            groupBox1.Controls.Add(timedButton);
            groupBox1.Controls.Add(randomButton);
            groupBox1.Controls.Add(seedingServiceName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(heatSheetButton);
            groupBox1.Location = new Point(12, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(401, 255);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Heat Sheet";
            // 
            // fileNameLabel
            // 
            fileNameLabel.AutoSize = true;
            fileNameLabel.Location = new Point(6, 138);
            fileNameLabel.Name = "fileNameLabel";
            fileNameLabel.Size = new Size(66, 15);
            fileNameLabel.TabIndex = 6;
            fileNameLabel.Text = "File Name: ";
            // 
            // timedButton
            // 
            timedButton.Location = new Point(224, 73);
            timedButton.Name = "timedButton";
            timedButton.Size = new Size(134, 33);
            timedButton.TabIndex = 5;
            timedButton.Text = "Time Final Seeding";
            timedButton.UseVisualStyleBackColor = true;
            timedButton.Click += timedButton_Click;
            // 
            // randomButton
            // 
            randomButton.Location = new Point(38, 73);
            randomButton.Name = "randomButton";
            randomButton.Size = new Size(134, 33);
            randomButton.TabIndex = 4;
            randomButton.Text = "Random Seeding";
            randomButton.UseVisualStyleBackColor = true;
            randomButton.Click += randomButton_Click;
            // 
            // seedingServiceName
            // 
            seedingServiceName.AutoSize = true;
            seedingServiceName.Font = new Font("Segoe UI", 15F);
            seedingServiceName.Location = new Point(146, 32);
            seedingServiceName.Name = "seedingServiceName";
            seedingServiceName.Size = new Size(60, 28);
            seedingServiceName.TabIndex = 3;
            seedingServiceName.Text = "None";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 2;
            label1.Text = "Curent Seeding Service: ";
            // 
            // fileName
            // 
            fileName.Location = new Point(78, 135);
            fileName.Name = "fileName";
            fileName.Size = new Size(134, 23);
            fileName.TabIndex = 7;
            // 
            // HeatSheetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(heatSheetBox);
            Name = "HeatSheetForm";
            Text = "HeatSheetForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox heatSheetBox;
        private Button heatSheetButton;
        private GroupBox groupBox1;
        private Label label1;
        private Button timedButton;
        private Button randomButton;
        private Label seedingServiceName;
        private Label fileNameLabel;
        private TextBox fileName;
    }
}