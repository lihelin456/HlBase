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
    
    public partial class ReceiptRefund
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int OrderId { get; set; }
        public string OrderCode { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int RefundType { get; set; }
        public string RefundTypeName { get; set; }
        public decimal RefundAmount { get; set; }
        public System.DateTime RefundTime { get; set; }
        public int RefundWay { get; set; }
        public string RefundWayName { get; set; }
        public string RefundNumber { get; set; }
        public string BankName { get; set; }
        public string BankUserName { get; set; }
        public string BankAccount { get; set; }
        public string Remark { get; set; }
        public string OperUser { get; set; }
        public System.DateTime CreateTime { get; set; }
    }
}
