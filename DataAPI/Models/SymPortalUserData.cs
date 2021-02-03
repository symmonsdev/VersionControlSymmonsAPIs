using System;
using System.Collections.Generic;

namespace DataAPI.Models
{
    public partial class SymPortalUserData
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string UserDomain { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? UserRoleId { get; set; }
        public string Agency { get; set; }
        public string Trained { get; set; }
        public string EmailAddress { get; set; }
        public string Url { get; set; }
        public string Rep { get; set; }
        public string HomePage { get; set; }
        public string ChangeUser { get; set; }
        public DateTime? ChangeDate { get; set; }

        public virtual SymPortalUserRoles UserRole { get; set; }
    }
}
