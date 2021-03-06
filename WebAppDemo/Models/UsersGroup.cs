//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppDemo.Models
{
    using System;
    using System.Collections.Generic;
	using System.Linq;

	public partial class UsersGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UsersGroup()
        {
            this.Users = new HashSet<User>();
        }
    
        public string UniqueID { get; set; }
        public string GroupName { get; set; }
        public string GroupPermissions { get; set; }
        public bool IsHost { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
        public UsersGroup GetObject_Usergroup(string groupid)
        {
            DemoMVCEntities1 haha = new DemoMVCEntities1();
            return haha.UsersGroups.Where(a => a.UniqueID == groupid).FirstOrDefault();
        }
    }
}
