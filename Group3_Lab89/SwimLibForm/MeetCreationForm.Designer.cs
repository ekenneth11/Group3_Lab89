namespace SwimLibForm
{
    partial class MeetCreationForm
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
            createButton = new Button();
            eventList = new ListBox();
            modifyButton = new Button();
            addButton = new Button();
            loadEventButton = new Button();
            SuspendLayout();
            // 
            // createButton
            // 
            createButton.Location = new Point(36, 12);
            createButton.Name = "createButton";
            createButton.Size = new Size(132, 110);
            createButton.TabIndex = 0;
            createButton.Text = "Create Meet";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // eventList
            // 
            eventList.FormattingEnabled = true;
            eventList.Location = new Point(221, 12);
            eventList.Name = "eventList";
            eventList.Size = new Size(356, 259);
            eventList.TabIndex = 1;
            eventList.SelectedIndexChanged += eventList_SelectedIndexChanged;
            // 
            // modifyButton
            // 
            modifyButton.Location = new Point(240, 277);
            modifyButton.Name = "modifyButton";
            modifyButton.Size = new Size(75, 23);
            modifyButton.TabIndex = 2;
            modifyButton.Text = "Modify";
            modifyButton.UseVisualStyleBackColor = true;
            modifyButton.Visible = false;
            modifyButton.Click += modifyButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(485, 277);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 3;
            addButton.Text = "Add Event";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // loadEventButton
            // 
            loadEventButton.Location = new Point(36, 161);
            loadEventButton.Name = "loadEventButton";
            loadEventButton.Size = new Size(132, 110);
            loadEventButton.TabIndex = 4;
            loadEventButton.Text = "Load Events";
            loadEventButton.UseVisualStyleBackColor = true;
            loadEventButton.Click += loadEventButton_Click;
            // 
            // MeetCreationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 348);
            Controls.Add(loadEventButton);
            Controls.Add(addButton);
            Controls.Add(modifyButton);
            Controls.Add(eventList);
            Controls.Add(createButton);
            Name = "MeetCreationForm";
            Text = "MeetCreationForm";
            Load += MeetCreationForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button createButton;
        private ListBox eventList;
        private Button modifyButton;
        private Button addButton;
        private Button loadEventButton;
    }
}