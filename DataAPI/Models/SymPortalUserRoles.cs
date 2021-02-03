using System;
using System.Collections.Generic;

namespace DataAPI.Models
{
    public partial class SymPortalUserRoles
    {
        public SymPortalUserRoles()
        {
            SymPortalUserData = new HashSet<SymPortalUserData>();
        }

        public int UserRoleId { get; set; }
        public string UserRole { get; set; }
        public string StartUrl { get; set; }
        public bool? IsLeadToolManager { get; set; }
        public bool? IsSigToolManager { get; set; }
        public string ChangeUser { get; set; }
        public DateTime? ChangeDate { get; set; }

        public virtual ICollection<SymPortalUserData> SymPortalUserData { get; set; }
    }
}
