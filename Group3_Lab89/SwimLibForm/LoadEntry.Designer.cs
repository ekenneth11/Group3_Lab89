namespace SwimLibForm
{
    partial class LoadEntry
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
            Entries = new ListBox();
            modify_entry = new Button();
            remove_entry = new Button();
            entryLoad = new Button();
            entryGroupBox = new GroupBox();
            addEntry = new Button();
            sexName = new ComboBox();
            Sex = new Label();
            birthdayName = new DateTimePicker();
            Birthday = new Label();
            maskedTextBox1 = new MaskedTextBox();
            seedTimeName = new Label();
            IdName = new TextBox();
            Id = new Label();
            clubName = new TextBox();
            clubLabel = new Label();
            nameLabel = new Label();
            Name = new TextBox();
            entryGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // Entries
            // 
            Entries.FormattingEnabled = true;
            Entries.Location = new Point(380, 12);
            Entries.Name = "Entries";
            Entries.Size = new Size(231, 304);
            Entries.TabIndex = 0;
            Entries.SelectedIndexChanged += entries_SelectedIndexChanged;
            // 
            // modify_entry
            // 
            modify_entry.Location = new Point(514, 322);
            modify_entry.Name = "modify_entry";
            modify_entry.Size = new Size(97, 27);
            modify_entry.TabIndex = 1;
            modify_entry.Text = "Modify";
            modify_entry.UseVisualStyleBackColor = true;
            // 
            // remove_entry
            // 
            remove_entry.Location = new Point(380, 322);
            remove_entry.Name = "remove_entry";
            remove_entry.Size = new Size(97, 25);
            remove_entry.TabIndex = 2;
            remove_entry.Text = "Delete";
            remove_entry.UseVisualStyleBackColor = true;
            // 
            // entryLoad
            // 
            entryLoad.Location = new Point(83, 228);
            entryLoad.Name = "entryLoad";
            entryLoad.Size = new Size(165, 120);
            entryLoad.TabIndex = 3;
            entryLoad.Text = "Load Entry";
            entryLoad.UseVisualStyleBackColor = true;
            // 
            // entryGroupBox
            // 
            entryGroupBox.Controls.Add(addEntry);
            entryGroupBox.Controls.Add(sexName);
            entryGroupBox.Controls.Add(Sex);
            entryGroupBox.Controls.Add(birthdayName);
            entryGroupBox.Controls.Add(Birthday);
            entryGroupBox.Controls.Add(maskedTextBox1);
            entryGroupBox.Controls.Add(seedTimeName);
            entryGroupBox.Controls.Add(IdName);
            entryGroupBox.Controls.Add(Id);
            entryGroupBox.Controls.Add(clubName);
            entryGroupBox.Controls.Add(clubLabel);
            entryGroupBox.Controls.Add(nameLabel);
            entryGroupBox.Controls.Add(Name);
            entryGroupBox.Location = new Point(26, 12);
            entryGroupBox.Name = "entryGroupBox";
            entryGroupBox.Size = new Size(332, 196);
            entryGroupBox.TabIndex = 4;
            entryGroupBox.TabStop = false;
            entryGroupBox.Text = "Entry";
            // 
            // addEntry
            // 
            addEntry.Location = new Point(123, 146);
            addEntry.Name = "addEntry";
            addEntry.Size = new Size(78, 35);
            addEntry.TabIndex = 12;
            addEntry.Text = "Add Entry";
            addEntry.UseVisualStyleBackColor = true;
            // 
            // sexName
            // 
            sexName.FormattingEnabled = true;
            sexName.Location = new Point(248, 16);
            sexName.Name = "sexName";
            sexName.Size = new Size(74, 23);
            sexName.TabIndex = 11;
            // 
            // Sex
            // 
            Sex.AutoSize = true;
            Sex.Location = new Point(215, 19);
            Sex.Name = "Sex";
            Sex.Size = new Size(27, 15);
            Sex.TabIndex = 10;
            Sex.Text = "Sex:";
            // 
            // birthdayName
            // 
            birthdayName.Location = new Point(195, 106);
            birthdayName.Name = "birthdayName";
            birthdayName.Size = new Size(131, 23);
            birthdayName.TabIndex = 9;
            // 
            // Birthday
            // 
            Birthday.AutoSize = true;
            Birthday.Location = new Point(135, 109);
            Birthday.Name = "Birthday";
            Birthday.Size = new Size(54, 15);
            Birthday.TabIndex = 8;
            Birthday.Text = "Birthday:";
            Birthday.Click += label1_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(77, 106);
            maskedTextBox1.Mask = "00:00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(48, 23);
            maskedTextBox1.TabIndex = 7;
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
            IdName.Size = new Size(113, 23);
            IdName.TabIndex = 5;
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
            clubName.Size = new Size(246, 23);
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
            // Name
            // 
            Name.Location = new Point(76, 45);
            Name.Name = "Name";
            Name.Size = new Size(246, 23);
            Name.TabIndex = 0;
            Name.TextChanged += textBox1_TextChanged;
            // 
            // LoadEntry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 408);
            Controls.Add(entryGroupBox);
            Controls.Add(entryLoad);
            Controls.Add(remove_entry);
            Controls.Add(modify_entry);
            Controls.Add(Entries);
            //Name = "LoadEntry";
            Text = "LoadEntry";
            Load += Form1_Load;
            entryGroupBox.ResumeLayout(false);
            entryGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox Entries;
        private Button modify_entry;
        private Button remove_entry;
        private Button entryLoad;
        private GroupBox entryGroupBox;
        private TextBox Name;
        private Label clubLabel;
        private Label nameLabel;
        private TextBox clubName;
        private TextBox IdName;
        private Label Id;
        private Label seedTimeName;
        private MaskedTextBox maskedTextBox1;
        private Label Birthday;
        private DateTimePicker birthdayName;
        private ComboBox sexName;
        private Label Sex;
        private Button addEntry;
    }
}
