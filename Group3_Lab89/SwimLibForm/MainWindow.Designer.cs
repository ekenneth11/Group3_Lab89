namespace SwimLibForm
{
    partial class MainWindow
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
            meetButton = new Button();
            label1 = new Label();
            entryButton = new Button();
            heatSheetButton = new Button();
            label2 = new Label();
            meetDetails = new RichTextBox();
            SuspendLayout();
            // 
            // meetButton
            // 
            meetButton.Location = new Point(12, 90);
            meetButton.Name = "meetButton";
            meetButton.Size = new Size(127, 112);
            meetButton.TabIndex = 0;
            meetButton.Text = "Meet";
            meetButton.UseVisualStyleBackColor = true;
            meetButton.Click += meetButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 45F);
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(748, 81);
            label1.TabIndex = 1;
            label1.Text = "Swim Management System";
            // 
            // entryButton
            // 
            entryButton.Location = new Point(12, 208);
            entryButton.Name = "entryButton";
            entryButton.Size = new Size(127, 112);
            entryButton.TabIndex = 2;
            entryButton.Text = "Entry";
            entryButton.UseVisualStyleBackColor = true;
            entryButton.Click += entryButton_Click;
            // 
            // heatSheetButton
            // 
            heatSheetButton.Location = new Point(12, 326);
            heatSheetButton.Name = "heatSheetButton";
            heatSheetButton.Size = new Size(127, 112);
            heatSheetButton.TabIndex = 3;
            heatSheetButton.Text = "Heat Sheet";
            heatSheetButton.UseVisualStyleBackColor = true;
            heatSheetButton.Click += heatSheetButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(450, 107);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 4;
            // 
            // meetDetails
            // 
            meetDetails.Location = new Point(145, 93);
            meetDetails.Name = "meetDetails";
            meetDetails.Size = new Size(643, 345);
            meetDetails.TabIndex = 5;
            meetDetails.Text = "Meet Details";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(meetDetails);
            Controls.Add(label2);
            Controls.Add(heatSheetButton);
            Controls.Add(entryButton);
            Controls.Add(label1);
            Controls.Add(meetButton);
            Name = "MainWindow";
            Text = "MainWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button meetButton;
        private Label label1;
        private Button entryButton;
        private Button heatSheetButton;
        private Label label2;
        private RichTextBox meetDetails;
    }
}