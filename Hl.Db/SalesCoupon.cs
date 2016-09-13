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
    
    public partial class SalesCoupon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SalesCoupon()
        {
            this.SalesCouponRange = new HashSet<SalesCouponRange>();
            this.SalesCouponUserLevel = new HashSet<SalesCouponUserLevel>();
            this.UserCoupon = new HashSet<UserCoupon>();
        }
    
        public int Id { get; set; }
        public string CouponName { get; set; }
        public int CouponType { get; set; }
        public bool IsMultiple { get; set; }
        public bool IsDay { get; set; }
        public int CouponDay { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public string CouponPrefix { get; set; }
        public decimal RangeAmount { get; set; }
        public bool IsDiscount { get; set; }
        public bool IsGeometric { get; set; }
        public decimal DiscountAmount { get; set; }
        public int CouponMax { get; set; }
        public bool IsEnable { get; set; }
        public string Remarks { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime LastUpdateTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesCouponRange> SalesCouponRange { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesCouponUserLevel> SalesCouponUserLevel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserCoupon> UserCoupon { get; set; }
    }
}