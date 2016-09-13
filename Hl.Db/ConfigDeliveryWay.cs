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
    
    public partial class ConfigDeliveryWay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ConfigDeliveryWay()
        {
            this.ConfigDeliveryArea = new HashSet<ConfigDeliveryArea>();
        }
    
        public int Id { get; set; }
        public string DeliveryWayName { get; set; }
        public decimal BasePrice { get; set; }
        public Nullable<decimal> StepPrice { get; set; }
        public string DeliveryTime { get; set; }
        public bool IsCOD { get; set; }
        public decimal FreePrice { get; set; }
        public Nullable<decimal> BaseWeight { get; set; }
        public Nullable<decimal> StepWeight { get; set; }
        public Nullable<bool> IsProtect { get; set; }
        public Nullable<decimal> ProtectRate { get; set; }
        public Nullable<decimal> ProtectMinPrice { get; set; }
        public string LogisticsCode { get; set; }
        public string LogisticsUrl { get; set; }
        public string Remark { get; set; }
        public bool IsEnable { get; set; }
        public int DisplayOrder { get; set; }
        public System.DateTime CreateTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConfigDeliveryArea> ConfigDeliveryArea { get; set; }
    }
}
