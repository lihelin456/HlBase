//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ECS.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class SysModule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SysModule()
        {
            this.SysAdminPrivilege = new HashSet<SysAdminPrivilege>();
            this.SysRole_Module = new HashSet<SysRole_Module>();
        }
    
        public int Id { get; set; }
        public string ModuleName { get; set; }
        public string Area { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public int ParentId { get; set; }
        public bool IsMenu { get; set; }
        public bool IsVisible { get; set; }
        public int DisplayOrder { get; set; }
        public string Remark { get; set; }
        public System.DateTime CreateTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SysAdminPrivilege> SysAdminPrivilege { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SysRole_Module> SysRole_Module { get; set; }
    }
}
