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
    
    public partial class SalesActivityGift
    {
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public int ActivityRuleId { get; set; }
        public int GroupMark { get; set; }
        public int GoodsId { get; set; }
        public decimal Amount { get; set; }
        public int GiftNum { get; set; }
        public int GiftMaxNum { get; set; }
        public System.DateTime CreateTime { get; set; }
    
        public virtual SalesActivity SalesActivity { get; set; }
        public virtual SalesActivityRule SalesActivityRule { get; set; }
    }
}