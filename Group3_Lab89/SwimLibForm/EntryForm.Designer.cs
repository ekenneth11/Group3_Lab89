namespace SwimLibForm
{
    partial class EntryForm
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
            entryGroupBox = new GroupBox();
            swimEventBox = new ComboBox();
            label1 = new Label();
            cancelButton = new Button();
            addEntry = new Button();
            sexName = new ComboBox();
            Sex = new Label();
            birthdayName = new DateTimePicker();
            Birthday = new Label();
            seedName = new MaskedTextBox();
            seedTimeName = new Label();
            IdName = new TextBox();
            Id = new Label();
            clubName = new TextBox();
            clubLabel = new Label();
            nameLabel = new Label();
            entryName = new TextBox();
            entryGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // entryGroupBox
            // 
            entryGroupBox.Controls.Add(swimEventBox);
            entryGroupBox.Controls.Add(label1);
            entryGroupBox.Controls.Add(cancelButton);
            entryGroupBox.Controls.Add(addEntry);
            entryGroupBox.Controls.Add(sexName);
            entryGroupBox.Controls.Add(Sex);
            entryGroupBox.Controls.Add(birthdayName);
            entryGroupBox.Controls.Add(Birthday);
            entryGroupBox.Controls.Add(seedName);
            entryGroupBox.Controls.Add(seedTimeName);
            entryGroupBox.Controls.Add(IdName);
            entryGroupBox.Controls.Add(Id);
            entryGroupBox.Controls.Add(clubName);
            entryGroupBox.Controls.Add(clubLabel);
            entryGroupBox.Controls.Add(nameLabel);
            entryGroupBox.Controls.Add(entryName);
            entryGroupBox.Location = new Point(12, 12);
            entryGroupBox.Name = "entryGroupBox";
            entryGroupBox.Size = new Size(386, 224);
            entryGroupBox.TabIndex = 5;
            entryGroupBox.TabStop = false;
            entryGroupBox.Text = "Entry";
            // 
            // swimEventBox
            // 
            swimEventBox.FormattingEnabled = true;
            swimEventBox.Location = new Point(77, 139);
            swimEventBox.Name = "swimEventBox";
            swimEventBox.Size = new Size(286, 23);
            swimEventBox.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 142);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 19;
            label1.Text = "Swim Event: ";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(218, 179);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(78, 35);
            cancelButton.TabIndex = 13;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // addEntry
            // 
            addEntry.Location = new Point(302, 179);
            addEntry.Name = "addEntry";
            addEntry.Size = new Size(78, 35);
            addEntry.TabIndex = 12;
            addEntry.Text = "OK";
            addEntry.UseVisualStyleBackColor = true;
            addEntry.Click += addEntry_Click;
            // 
            // sexName
            // 
            sexName.FormattingEnabled = true;
            sexName.Location = new Point(224, 16);
            sexName.Name = "sexName";
            sexName.Size = new Size(93, 23);
            sexName.TabIndex = 11;
            // 
            // Sex
            // 
            Sex.AutoSize = true;
            Sex.Location = new Point(173, 19);
            Sex.Name = "Sex";
            Sex.Size = new Size(27, 15);
            Sex.TabIndex = 10;
            Sex.Text = "Sex:";
            // 
            // birthdayName
            // 
            birthdayName.Location = new Point(224, 106);
            birthdayName.Name = "birthdayName";
            birthdayName.Size = new Size(139, 23);
            birthdayName.TabIndex = 9;
            // 
            // Birthday
            // 
            Birthday.AutoSize = true;
            Birthday.Location = new Point(164, 109);
            Birthday.Name = "Birthday";
            Birthday.Size = new Size(54, 15);
            Birthday.TabIndex = 8;
            Birthday.Text = "Birthday:";
            // 
            // seedName
            // 
            seedName.Location = new Point(77, 106);
            seedName.Mask = "00:00:00";
            seedName.Name = "seedName";
            seedName.Size = new Size(53, 23);
            seedName.TabIndex = 7;
            // 
            // seedTimeName
            // 
            seedTimeName.AutoSize = true;
            seedTimeName.Location = new Point(6, 109);
            seedTimeName.Name = "seedTimeName";
            seedTimeName.Size = new Size(65, 15);
            seedTimeName.TabIndex = 6;
            seedTimeName.Text = "Seed Time:";
            // 
            // IdName
            // 
            IdName.Location = new Point(76, 16);
            IdName.Name = "IdName";
            IdName.Size = new Size(72, 23);
            IdName.TabIndex = 5;
            IdName.TextChanged += IdName_TextChanged;
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.Location = new Point(6, 19);
            Id.Name = "Id";
            Id.Size = new Size(20, 15);
            Id.TabIndex = 4;
            Id.Text = "Id:";
            // 
            // clubName
            // 
            clubName.Location = new Point(76, 74);
            clubName.Name = "clubName";
            clubName.Size = new Size(287, 23);
            clubName.TabIndex = 3;
            // 
            // clubLabel
            // 
            clubLabel.AutoSize = true;
            clubLabel.Location = new Point(6, 82);
            clubLabel.Name = "clubLabel";
            clubLabel.Size = new Size(35, 15);
            clubLabel.TabIndex = 2;
            clubLabel.Text = "Club:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(6, 48);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(42, 15);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            // 
            // entryName
            // 
            entryName.Location = new Point(76, 45);
            entryName.Name = "entryName";
            entryName.Size = new Size(287, 23);
            entryName.TabIndex = 0;
            entryName.TextChanged += entryName_TextChanged;
            // 
            // EntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(411, 247);
            Controls.Add(entryGroupBox);
            Name = "EntryForm";
            Text = "Entry";
            Load += EntryForm_Load;
            entryGroupBox.ResumeLayout(false);
            entryGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox entryGroupBox;
        private Button cancelButton;
        private Button addEntry;
        private ComboBox sexName;
        private Label Sex;
        private DateTimePicker birthdayName;
        private Label Birthday;
        private MaskedTextBox seedName;
        private Label seedTimeName;
        private TextBox IdName;
        private Label Id;
        private TextBox clubName;
        private Label clubLabel;
        private Label nameLabel;
        private TextBox entryName;
        private ComboBox swimEventBox;
        private Label label1;
    }
}