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
            addEntry = new Button();
            SuspendLayout();
            // 
            // Entries
            // 
            Entries.FormattingEnabled = true;
            Entries.Location = new Point(183, 12);
            Entries.Name = "Entries";
            Entries.Size = new Size(428, 349);
            Entries.TabIndex = 0;
            Entries.SelectedIndexChanged += entries_SelectedIndexChanged;
            // 
            // modify_entry
            // 
            modify_entry.Location = new Point(514, 369);
            modify_entry.Name = "modify_entry";
            modify_entry.Size = new Size(97, 27);
            modify_entry.TabIndex = 1;
            modify_entry.Text = "Modify";
            modify_entry.UseVisualStyleBackColor = true;
            modify_entry.Visible = false;
            modify_entry.Click += modify_entry_Click;
            // 
            // remove_entry
            // 
            remove_entry.Location = new Point(183, 369);
            remove_entry.Name = "remove_entry";
            remove_entry.Size = new Size(97, 25);
            remove_entry.TabIndex = 2;
            remove_entry.Text = "Delete";
            remove_entry.UseVisualStyleBackColor = true;
            remove_entry.Visible = false;
            remove_entry.Click += remove_entry_Click;
            // 
            // entryLoad
            // 
            entryLoad.Location = new Point(12, 220);
            entryLoad.Name = "entryLoad";
            entryLoad.Size = new Size(165, 120);
            entryLoad.TabIndex = 3;
            entryLoad.Text = "Load Entry";
            entryLoad.UseVisualStyleBackColor = true;
            entryLoad.Click += entryLoad_Click;
            // 
            // addEntry
            // 
            addEntry.Location = new Point(12, 41);
            addEntry.Name = "addEntry";
            addEntry.Size = new Size(165, 119);
            addEntry.TabIndex = 4;
            addEntry.Text = "Add New Entry";
            addEntry.UseVisualStyleBackColor = true;
            addEntry.Click += addEntry_Click;
            // 
            // LoadEntry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 408);
            Controls.Add(addEntry);
            Controls.Add(entryLoad);
            Controls.Add(remove_entry);
            Controls.Add(modify_entry);
            Controls.Add(Entries);
            Name = "LoadEntry";
            Text = "LoadEntry";
            ResumeLayout(false);
        }

        #endregion

        private ListBox Entries;
        private Button modify_entry;
        private Button remove_entry;
        private Button entryLoad;
        private Button addEntry;
    }
}
