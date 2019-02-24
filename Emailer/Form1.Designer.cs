namespace Emailer
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
            this.SendEmailButton = new System.Windows.Forms.Button();
            this.BodyTextBox = new System.Windows.Forms.RichTextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.SubjectTextBox = new System.Windows.Forms.RichTextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SetuprecipientsButton = new System.Windows.Forms.Button();
            this.RecipientPanel = new System.Windows.Forms.Panel();
            this.RecipientsTextBox = new System.Windows.Forms.TextBox();
            this.SaveRecipientsButton = new System.Windows.Forms.Button();
            this.RecipientLabelsPanel = new System.Windows.Forms.Panel();
            this.CloseRecipientButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RecipientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendEmailButton
            // 
            this.SendEmailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SendEmailButton.Location = new System.Drawing.Point(622, 370);
            this.SendEmailButton.Name = "SendEmailButton";
            this.SendEmailButton.Size = new System.Drawing.Size(119, 45);
            this.SendEmailButton.TabIndex = 0;
            this.SendEmailButton.Text = "Send";
            this.SendEmailButton.UseVisualStyleBackColor = true;
            this.SendEmailButton.Click += new System.EventHandler(this.SendEmailButton_Click);
            // 
            // BodyTextBox
            // 
            this.BodyTextBox.Location = new System.Drawing.Point(107, 88);
            this.BodyTextBox.Name = "BodyTextBox";
            this.BodyTextBox.Size = new System.Drawing.Size(580, 228);
            this.BodyTextBox.TabIndex = 2;
            this.BodyTextBox.Text = "<h1 style = \"text-align: center\">Heading</h1>\n<p style = \"color: blue\">This works" +
    " with HTML!</p>";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(107, 23);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(129, 20);
            this.EmailTextBox.TabIndex = 3;
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.AccessibleDescription = "";
            this.SubjectTextBox.AccessibleName = "";
            this.SubjectTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SubjectTextBox.Location = new System.Drawing.Point(291, 55);
            this.SubjectTextBox.Multiline = false;
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.Size = new System.Drawing.Size(195, 27);
            this.SubjectTextBox.TabIndex = 4;
            this.SubjectTextBox.Text = "";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(359, 20);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '•';
            this.PasswordTextBox.Size = new System.Drawing.Size(157, 20);
            this.PasswordTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email from";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(278, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // SetuprecipientsButton
            // 
            this.SetuprecipientsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SetuprecipientsButton.Location = new System.Drawing.Point(33, 370);
            this.SetuprecipientsButton.Name = "SetuprecipientsButton";
            this.SetuprecipientsButton.Size = new System.Drawing.Size(119, 45);
            this.SetuprecipientsButton.TabIndex = 8;
            this.SetuprecipientsButton.Text = "Setup recipients";
            this.SetuprecipientsButton.UseVisualStyleBackColor = true;
            this.SetuprecipientsButton.Click += new System.EventHandler(this.SetuprecipientsButton_Click);
            // 
            // RecipientPanel
            // 
            this.RecipientPanel.Controls.Add(this.label3);
            this.RecipientPanel.Controls.Add(this.CloseRecipientButton);
            this.RecipientPanel.Controls.Add(this.RecipientLabelsPanel);
            this.RecipientPanel.Controls.Add(this.SaveRecipientsButton);
            this.RecipientPanel.Controls.Add(this.RecipientsTextBox);
            this.RecipientPanel.Location = new System.Drawing.Point(98, 12);
            this.RecipientPanel.Name = "RecipientPanel";
            this.RecipientPanel.Size = new System.Drawing.Size(619, 383);
            this.RecipientPanel.TabIndex = 9;
            // 
            // RecipientsTextBox
            // 
            this.RecipientsTextBox.Location = new System.Drawing.Point(33, 21);
            this.RecipientsTextBox.Multiline = true;
            this.RecipientsTextBox.Name = "RecipientsTextBox";
            this.RecipientsTextBox.Size = new System.Drawing.Size(369, 221);
            this.RecipientsTextBox.TabIndex = 0;
            // 
            // SaveRecipientsButton
            // 
            this.SaveRecipientsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SaveRecipientsButton.Location = new System.Drawing.Point(33, 310);
            this.SaveRecipientsButton.Name = "SaveRecipientsButton";
            this.SaveRecipientsButton.Size = new System.Drawing.Size(86, 51);
            this.SaveRecipientsButton.TabIndex = 1;
            this.SaveRecipientsButton.Text = "Save recipients";
            this.SaveRecipientsButton.UseVisualStyleBackColor = true;
            this.SaveRecipientsButton.Click += new System.EventHandler(this.SaveRecipientsButton_Click);
            // 
            // RecipientLabelsPanel
            // 
            this.RecipientLabelsPanel.Location = new System.Drawing.Point(420, 39);
            this.RecipientLabelsPanel.Name = "RecipientLabelsPanel";
            this.RecipientLabelsPanel.Size = new System.Drawing.Size(179, 313);
            this.RecipientLabelsPanel.TabIndex = 2;
            // 
            // CloseRecipientButton
            // 
            this.CloseRecipientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.CloseRecipientButton.Location = new System.Drawing.Point(592, 5);
            this.CloseRecipientButton.Name = "CloseRecipientButton";
            this.CloseRecipientButton.Size = new System.Drawing.Size(24, 28);
            this.CloseRecipientButton.TabIndex = 3;
            this.CloseRecipientButton.Text = "X";
            this.CloseRecipientButton.UseVisualStyleBackColor = true;
            this.CloseRecipientButton.Click += new System.EventHandler(this.CloseRecipientButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(459, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "All recipients";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RecipientPanel);
            this.Controls.Add(this.SetuprecipientsButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.SubjectTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.BodyTextBox);
            this.Controls.Add(this.SendEmailButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.RecipientPanel.ResumeLayout(false);
            this.RecipientPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendEmailButton;
        private System.Windows.Forms.RichTextBox BodyTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.RichTextBox SubjectTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SetuprecipientsButton;
        private System.Windows.Forms.Panel RecipientPanel;
        private System.Windows.Forms.Button SaveRecipientsButton;
        private System.Windows.Forms.TextBox RecipientsTextBox;
        private System.Windows.Forms.Panel RecipientLabelsPanel;
        private System.Windows.Forms.Button CloseRecipientButton;
        private System.Windows.Forms.Label label3;
    }
}

