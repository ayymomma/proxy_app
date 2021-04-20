/**************************************************************************
 *                                                                        *
 *  File:        DocumentManager.cs                                       *
 *  Copyright:   (c) 2008-2019, Florin Leon                               *
 *  E-mail:      florin.leon@tuiasi.ro                                    *
 *  Website:     http://florinleon.byethost24.com/lab_ip.htm              *
 *  Description: Secret documents application with Protection Proxy.      *
 *               The Protection Proxy (Software Engineering lab 9)        *
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
using System.IO;
using System.Windows.Forms;

namespace ProtectionProxy
{
    public class ProxyDocumentManager : IDocumentManager
    {
        private User _currentUser;
        private RealDocumentManager _realDocumentManager;
        private List<User> _users;
        private List<string> _levels;
        private const string Path = "Secure\\";

        public struct User
        {
            public readonly string Name;
            public readonly string PassHash;
            public readonly int AccessLevel;

            public User(string name, string passHash, int accessLevel)
            {
                Name = name;
                PassHash = passHash;
                AccessLevel = accessLevel;
            }
        }

        public ProxyDocumentManager()
        {
            try
            {
                _levels = new List<string>();
                StreamReader sr = new StreamReader(Path + "niveluri.txt");
                string[] lvls = sr.ReadToEnd().Split(" \t\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                sr.Close();

                for (int i = 0; i < lvls.Length; i++)
                    _levels.Add(lvls[i]);

                _users = new List<User>();
                sr = new StreamReader(Path + "utilizatori.txt");
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] toks = line.Split('\t');
                    User user = new User(toks[0], toks[1], Convert.ToInt32(toks[2]));
                    _users.Add(user);
                }
                sr.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public List<string> GetDocumentList()
        {
            return _realDocumentManager.GetDocumentList();
        }

        public string GetDocument(string documentName)
        {
            // documentul primit trebuie decriptat inainte de a-i fi trimis clientului
            return _realDocumentManager.GetDocument(documentName);
        }
        public int CurrentAccessLevel()
        {
            return _currentUser.AccessLevel;
        }
        public List<string> Levels()
        {
            return _levels;
        }

        public bool Login(string username, string password)
        {
            foreach (var user in _users)
            {
                if (user.Name.Equals(username) && user.PassHash.Equals(Cryptography.HashString(password)))
                {
                    _currentUser = user;
                    _realDocumentManager = new RealDocumentManager(_currentUser.AccessLevel);
                    return true;
                }
            }
            return false;
        }

        public void AddUser(string user, string pass, int level)
        {
            foreach( User u in _users)
            {
                if (u.Name.Equals(user))
                {
                    MessageBox.Show("Utilizator existent!");
                    return;
                }
            }

            User newUser = new User(user, Cryptography.HashString(pass), level);
            _users.Add(newUser);
            MessageBox.Show("Utilizator adaugat!");
            SaveUser();
         }
        public void SaveUser()
        {
            StreamWriter streamWriter = new StreamWriter(Path + "utilizatori.txt");
            foreach(User u in _users)
            {
                streamWriter.WriteLine(u.Name + "\t" + u.PassHash + "\t" + u.AccessLevel);
            }
            streamWriter.Close();
        }

    }
}