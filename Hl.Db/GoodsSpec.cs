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
    
    public partial class GoodsSpec
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GoodsSpec()
        {
            this.GoodsSpecValue = new HashSet<GoodsSpecValue>();
        }
    
        public int Id { get; set; }
        public string SpecName { get; set; }
        public string SpecRemark { get; set; }
        public bool IsPicture { get; set; }
        public bool IsFilter { get; set; }
        public bool IsEnable { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime LastUpdateTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoodsSpecValue> GoodsSpecValue { get; set; }
    }
}
