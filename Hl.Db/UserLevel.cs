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
    
    public partial class UserLevel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserLevel()
        {
            this.UserInfo = new HashSet<UserInfo>();
        }
    
        public int Id { get; set; }
        public string LevelName { get; set; }
        public string LevelIcon { get; set; }
        public decimal Discount { get; set; }
        public decimal UpGradeAmount { get; set; }
        public int EffectMonth { get; set; }
        public decimal IntegralMultiple { get; set; }
        public Nullable<decimal> IntegralMultiple_Birthday { get; set; }
        public Nullable<int> IntegralRate { get; set; }
        public bool IsFreeFreight { get; set; }
        public decimal FreeFreightAmount { get; set; }
        public bool IsEnable { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime LastUpdateTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserInfo> UserInfo { get; set; }
    }
}
