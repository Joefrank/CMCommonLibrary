using System;
using System.Collections.Generic;
using System.Linq;

namespace CMCommon.Authentication.Models
{
    public class ClientUser
    {
        public List<string> Profiles { get; set; }

        public List<string> Roles { get; set; }

        public string FullName { get; set; }
       
        public string UserName { get; set; }

        public string Data { get; set; }

        public int UserId { get; set; }

        public int LanguageId { get; set; }

        public int CompanyId { get; set; }

        public int DepartmentId { get; set; }

        public string Culture { get; set; }

        public TimeSpan CookieDuration { get; set; }

        public bool IsInRole(List<string> roles)
        {
            return !roles.Except(Roles).Any();
        }        

        public bool HasRole(string role)
        {
            return Roles.Contains(role);
        }

        public bool IsInProfile(List<string> profiles)
        {
            return !profiles.Except(Profiles).Any();
        }       

        public bool HasProfile(int profileid)
        {
            return this.Profiles.Contains(profileid.ToString());
        }

        public bool IsLogged()
        {
            return (UserId > 0 && Roles != null && Roles.Any());
        }
    }
}
