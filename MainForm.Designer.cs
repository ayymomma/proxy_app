/**************************************************************************
 *                                                                        *
 *  File:        Form1.Designer.cs                                        *
 *  Copyright:   (c) 2008, Florin Leon                                    *
 *  E-mail:      fleon@cs.tuiasi.ro                                       *
 *  Website:     http://eureka.cs.tuiasi.ro/~fleon/lab_ip.htm             *
 *  Description: http://eureka.cs.tuiasi.ro/~fleon                        *
 *               Secret documents application with Protection Proxy.      *
 *               Main form designer (Software Engineering lab 9)          *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/


namespace ProtectionProxy
{
    partial class MainForm
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
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.textBoxAccessLevel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxDocs = new System.Windows.Forms.GroupBox();
            this.listBoxDocList = new System.Windows.Forms.ListBox();
            this.groupBoxContent = new System.Windows.Forms.GroupBox();
            this.richTextBoxDocument = new System.Windows.Forms.RichTextBox();
            this.groupBoxAdmin = new System.Windows.Forms.GroupBox();
            this.comboBoxAccessLevel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNewUser = new System.Windows.Forms.TextBox();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxLogin.SuspendLayout();
            this.groupBoxDocs.SuspendLayout();
            this.groupBoxContent.SuspendLayout();
            this.groupBoxAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utilizator";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(83, 18);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(106, 20);
            this.textBoxUserName.TabIndex = 1;
            this.textBoxUserName.TextChanged += new System.EventHandler(this.textBoxUserName_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(83, 44);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(106, 20);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parola";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(83, 70);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(106, 22);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Intra";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.textBoxAccessLevel);
            this.groupBoxLogin.Controls.Add(this.label3);
            this.groupBoxLogin.Controls.Add(this.textBoxUserName);
            this.groupBoxLogin.Controls.Add(this.buttonLogin);
            this.groupBoxLogin.Controls.Add(this.label1);
            this.groupBoxLogin.Controls.Add(this.textBoxPassword);
            this.groupBoxLogin.Controls.Add(this.label2);
            this.groupBoxLogin.Location = new System.Drawing.Point(13, 12);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(206, 130);
            this.groupBoxLogin.TabIndex = 5;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Autentificare";
            // 
            // textBoxAccessLevel
            // 
            this.textBoxAccessLevel.Location = new System.Drawing.Point(83, 98);
            this.textBoxAccessLevel.Name = "textBoxAccessLevel";
            this.textBoxAccessLevel.ReadOnly = true;
            this.textBoxAccessLevel.Size = new System.Drawing.Size(106, 20);
            this.textBoxAccessLevel.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nivel acces";
            // 
            // groupBoxDocs
            // 
            this.groupBoxDocs.Controls.Add(this.listBoxDocList);
            this.groupBoxDocs.Location = new System.Drawing.Point(225, 12);
            this.groupBoxDocs.Name = "groupBoxDocs";
            this.groupBoxDocs.Size = new System.Drawing.Size(237, 130);
            this.groupBoxDocs.TabIndex = 6;
            this.groupBoxDocs.TabStop = false;
            this.groupBoxDocs.Text = "Documente disponibile";
            // 
            // listBoxDocList
            // 
            this.listBoxDocList.Enabled = false;
            this.listBoxDocList.FormattingEnabled = true;
            this.listBoxDocList.Location = new System.Drawing.Point(6, 18);
            this.listBoxDocList.Name = "listBoxDocList";
            this.listBoxDocList.Size = new System.Drawing.Size(216, 95);
            this.listBoxDocList.TabIndex = 0;
            this.listBoxDocList.SelectedIndexChanged += new System.EventHandler(this.listBoxDocList_SelectedIndexChanged);
            // 
            // groupBoxContent
            // 
            this.groupBoxContent.Controls.Add(this.richTextBoxDocument);
            this.groupBoxContent.Location = new System.Drawing.Point(13, 148);
            this.groupBoxContent.Name = "groupBoxContent";
            this.groupBoxContent.Size = new System.Drawing.Size(662, 285);
            this.groupBoxContent.TabIndex = 7;
            this.groupBoxContent.TabStop = false;
            this.groupBoxContent.Text = "Continut";
            // 
            // richTextBoxDocument
            // 
            this.richTextBoxDocument.Enabled = false;
            this.richTextBoxDocument.Location = new System.Drawing.Point(13, 18);
            this.richTextBoxDocument.Name = "richTextBoxDocument";
            this.richTextBoxDocument.Size = new System.Drawing.Size(632, 260);
            this.richTextBoxDocument.TabIndex = 0;
            this.richTextBoxDocument.Text = "";
            // 
            // groupBoxAdmin
            // 
            this.groupBoxAdmin.Controls.Add(this.comboBoxAccessLevel);
            this.groupBoxAdmin.Controls.Add(this.label4);
            this.groupBoxAdmin.Controls.Add(this.textBoxNewUser);
            this.groupBoxAdmin.Controls.Add(this.buttonAddNew);
            this.groupBoxAdmin.Controls.Add(this.label5);
            this.groupBoxAdmin.Controls.Add(this.textBoxNewPassword);
            this.groupBoxAdmin.Controls.Add(this.label6);
            this.groupBoxAdmin.Location = new System.Drawing.Point(468, 12);
            this.groupBoxAdmin.Name = "groupBoxAdmin";
            this.groupBoxAdmin.Size = new System.Drawing.Size(206, 130);
            this.groupBoxAdmin.TabIndex = 8;
            this.groupBoxAdmin.TabStop = false;
            this.groupBoxAdmin.Text = "Administrator";
            // 
            // comboBoxAccessLevel
            // 
            this.comboBoxAccessLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccessLevel.FormattingEnabled = true;
            this.comboBoxAccessLevel.Items.AddRange(new object[] {
            "Public",
            "Privat",
            "Confidential",
            "Secret"});
            this.comboBoxAccessLevel.Location = new System.Drawing.Point(83, 70);
            this.comboBoxAccessLevel.Name = "comboBoxAccessLevel";
            this.comboBoxAccessLevel.Size = new System.Drawing.Size(106, 21);
            this.comboBoxAccessLevel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nivel acces";
            // 
            // textBoxNewUser
            // 
            this.textBoxNewUser.Location = new System.Drawing.Point(83, 18);
            this.textBoxNewUser.Name = "textBoxNewUser";
            this.textBoxNewUser.Size = new System.Drawing.Size(106, 20);
            this.textBoxNewUser.TabIndex = 1;
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Location = new System.Drawing.Point(83, 102);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(106, 22);
            this.buttonAddNew.TabIndex = 4;
            this.buttonAddNew.Text = "Adauga";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Utilizator";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(83, 44);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(106, 20);
            this.textBoxNewPassword.TabIndex = 3;
            this.textBoxNewPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Parola";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(688, 444);
            this.Controls.Add(this.groupBoxAdmin);
            this.Controls.Add(this.groupBoxContent);
            this.Controls.Add(this.groupBoxDocs);
            this.Controls.Add(this.groupBoxLogin);
            this.Name = "MainForm";
            this.Text = "Drepturi de acces";
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.groupBoxDocs.ResumeLayout(false);
            this.groupBoxContent.ResumeLayout(false);
            this.groupBoxAdmin.ResumeLayout(false);
            this.groupBoxAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.GroupBox groupBoxDocs;
        private System.Windows.Forms.TextBox textBoxAccessLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxDocList;
        private System.Windows.Forms.GroupBox groupBoxContent;
        private System.Windows.Forms.RichTextBox richTextBoxDocument;
        private System.Windows.Forms.GroupBox groupBoxAdmin;
        private System.Windows.Forms.ComboBox comboBoxAccessLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNewUser;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Label label6;

    }
}

