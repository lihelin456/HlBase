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
    
    public partial class UserGift
    {
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public string Mark { get; set; }
        public int SkuId { get; set; }
        public int Quantity { get; set; }
        public int UserId { get; set; }
        public bool IsReceive { get; set; }
        public int IsDelete { get; set; }
        public Nullable<System.DateTime> EndDateTime { get; set; }
        public Nullable<System.DateTime> ReceiveDate { get; set; }
        public System.DateTime CreateTime { get; set; }
    }
}
