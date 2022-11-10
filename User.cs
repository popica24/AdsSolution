﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AdsSolution
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get;private set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public User(string _Username,string _Password, string _Email,string _Phone)
        {
            Username = _Username;
            Password = _Password;
            Email = _Email;
            Phone = _Phone;
        }
        
        public bool PhoneIsValid(string Phone)//DE IMPLEMENTAT
        {
            throw new NotImplementedException();
        }
        public bool EmailIsValid(string email)
        {
            string EmailFormat = @"^[a-zA-Z0-9@.]*$";
            if (string.IsNullOrEmpty(email)) return false;
            if (Regex.Matches(email, Regex.Escape(".")).Count == 1 &&
                Regex.Matches(email, Regex.Escape("@")).Count == 1 &&
                Regex.IsMatch(email, EmailFormat))//Step 1
            {
                var tail = email.Substring(email.IndexOf("@"));
                return (tail == "@gmail.com" || tail == "@yahoo.com" || tail == "hotmail.com" || tail == "outlook.com");//Pasul 2 (De Implementat JSON) !!!!!!!!
                
            }

            return false;

        }
        public bool PaswordIsValid(string password)
        {
            string PassFormat = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#_?!@$%^&*-]).{8,}$"; 
            //https://uibakery.io/regex-library/password-regex-csharp
            if (string.IsNullOrEmpty(password)) return false;
            if(Regex.IsMatch(password, PassFormat))
            {
                if (password.Any(c => !char.IsWhiteSpace(c))) return true;
            }
            return false;
        }
        public bool NameIsValid(string name)
        {
            string NameFormat = @"^[a-zA-Z0-9]*$";
            if (string.IsNullOrEmpty(name)) return false;
            return (Regex.IsMatch(name, NameFormat));
        }
        
        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType())) return false;

            User other = (User)obj;
            return this.Username == other.Username && this.Password == other.Password;
        }
        public override string ToString()
        {
            return $"Username : {Username}\nPassword : {Password}\nEmail : {Email}";
        }
        public override int GetHashCode()
        {
            int hash = 7;
            hash = (hash * 3) + Username.GetHashCode();
            hash = (hash * 4) + Password.GetHashCode();
            hash = (hash * 5) + Email.GetHashCode();
            return hash;
        }
    }
}