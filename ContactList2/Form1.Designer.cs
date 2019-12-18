namespace ContactList2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.lstContacts = new System.Windows.Forms.ListBox();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.btnSortList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone:";
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(151, 163);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(236, 22);
            this.textPhone.TabIndex = 3;
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(151, 120);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(236, 22);
            this.textLastName.TabIndex = 4;
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(151, 72);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(236, 22);
            this.textFirstName.TabIndex = 5;
            this.textFirstName.TextChanged += new System.EventHandler(this.textFirstName_TextChanged);
            // 
            // lstContacts
            // 
            this.lstContacts.FormattingEnabled = true;
            this.lstContacts.ItemHeight = 16;
            this.lstContacts.Location = new System.Drawing.Point(446, 72);
            this.lstContacts.Name = "lstContacts";
            this.lstContacts.Size = new System.Drawing.Size(243, 244);
            this.lstContacts.TabIndex = 6;
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(92, 213);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(118, 41);
            this.btnAddContact.TabIndex = 7;
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // btnSortList
            // 
            this.btnSortList.Location = new System.Drawing.Point(238, 213);
            this.btnSortList.Name = "btnSortList";
            this.btnSortList.Size = new System.Drawing.Size(110, 41);
            this.btnSortList.TabIndex = 8;
            this.btnSortList.Text = "Sort List";
            this.btnSortList.UseVisualStyleBackColor = true;
            this.btnSortList.Click += new System.EventHandler(this.btnSortList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSortList);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.lstContacts);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.ListBox lstContacts;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Button btnSortList;
    }
}

