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
    
    public partial class UserCoupon
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CouponId { get; set; }
        public string CouponCode { get; set; }
        public bool IsUse { get; set; }
        public System.DateTime UseTime { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public System.DateTime CreateTime { get; set; }
        public Nullable<int> IsSend { get; set; }
    
        public virtual SalesCoupon SalesCoupon { get; set; }
    }
}
