/**************************************************************************
 *                                                                        *
 *  File:        Form1.cs                                                 *
 *  Copyright:   (c) 2008-2019, Florin Leon                               *
 *  E-mail:      florin.leon@tuiasi.ro                                    *
 *  Website:     http://florinleon.byethost24.com/lab_ip.htm              *
 *  Description: Secret documents application with Protection Proxy.      *
 *               Main form (Software Engineering lab 9)                   *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProtectionProxy
{
    public partial class MainForm : Form
    {
        private ProxyDocumentManager _proxyDocumentManager;

        public MainForm()
        {
            InitializeComponent();
            groupBoxAdmin.Enabled = false;

            _proxyDocumentManager = new ProxyDocumentManager();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string user = textBoxUserName.Text;
            string password = textBoxPassword.Text;

            if(!_proxyDocumentManager.Login(user, password))
            {
                MessageBox.Show("Conectare esuata");
                return;
            }

            listBoxDocList.Items.Clear();
            richTextBoxDocument.Clear();

            int accesLevel = _proxyDocumentManager.CurrentAccessLevel();
            if(accesLevel == -1)
            {
                textBoxAccessLevel.Text = "Administrator";
                groupBoxAdmin.Enabled = true;
            }
            else
            {
                textBoxAccessLevel.Text = _proxyDocumentManager.Levels()[accesLevel];
                groupBoxDocs.Enabled = true;
                groupBoxContent.Enabled = true;
                listBoxDocList.Enabled = true;
                List<string> documents = _proxyDocumentManager.GetDocumentList();

                foreach( string doc in documents)
                {
                    listBoxDocList.Items.Add(doc);
                }
            }
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxDocList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string documentName = (string)listBoxDocList.SelectedItem;
            richTextBoxDocument.Rtf = _proxyDocumentManager.GetDocument(documentName);
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            _proxyDocumentManager.AddUser(textBoxNewUser.Text, textBoxNewPassword.Text, comboBoxAccessLevel.SelectedIndex);
        }
    }
}