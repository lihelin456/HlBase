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
    
    public partial class OrderLog
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public int OrderId { get; set; }
        public string OrderCode { get; set; }
        public string State { get; set; }
        public string Title { get; set; }
        public string Remark { get; set; }
        public string OperUser { get; set; }
        public Nullable<bool> IsProduce { get; set; }
        public Nullable<System.DateTime> ProduceTime { get; set; }
        public System.DateTime CreateTime { get; set; }
    }
}
