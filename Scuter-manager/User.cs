﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scuter_manager
{
    public class User
    {
        private int _id;
        private string _email;
        private string _password;
        private int _phone;

        public User(String proprietati)
        {
            String[] token = proprietati.Split(',');    

            this._id = int.Parse(token[0]);
            this._email = token[1];
            this._password = token[2];
            this._phone = int.Parse(token[3]);
        }

        public User(int id, string email, string password, int phone)
        {
            _id = id;
            _email = email;
            _password = password;
            _phone = phone;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public int Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string UserInfo()
        {
            string text = " ";
            text += "Id " + _id + "\n";
            text += "Email " + _email + "\n";
            text += "Password " + _password + "\n";
            text += "Phone " + _phone + "\n";
            return text;
        }

        public string ToSave()
        {
            return this._id + "," + this._email + "," + this._password + "," + this._phone;
        }
    }
}
