using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Entity
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string NormalizedUserName { get; set; }

        public string Email { get; set; }

        public string NormalizedEmail { get; set; }

        public bool EmailConfirmed { get; set; }

        public string PasswordHash { get; set; }

        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public bool TwoFactorEnabled { get; set; }

        internal User(string firstname, string username, string normaliedusername, string email, bool confirmemail, string phonenumber,
            bool isnumberconfirmed, bool twofactorauthentication, int id = 0, string passwordhash = null)
        {
            Id = id;
            UserName = username; ;
            NormalizedUserName = normaliedusername;
            Email = email;
            EmailConfirmed = confirmemail;
            PasswordHash = passwordhash;
            PhoneNumberConfirmed = isnumberconfirmed;
            TwoFactorEnabled = twofactorauthentication;
            PhoneNumber = phonenumber;
        }
    }
}
