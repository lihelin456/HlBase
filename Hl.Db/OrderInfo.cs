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
    
    public partial class OrderInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderInfo()
        {
            this.OrderGoods = new HashSet<OrderGoods>();
            this.OrderPresaleItem = new HashSet<OrderPresaleItem>();
        }
    
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public Nullable<int> AdId { get; set; }
        public int OrderType { get; set; }
        public string OrderKey { get; set; }
        public string OrderCode { get; set; }
        public string Consignee { get; set; }
        public string Sex { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public string DeliveryTime { get; set; }
        public bool IfInvoice { get; set; }
        public string InvoiceType { get; set; }
        public string InvoicePayable { get; set; }
        public string InvoiceContent { get; set; }
        public Nullable<decimal> InvoiceAmount { get; set; }
        public decimal GoodsAmount { get; set; }
        public decimal NeedPayAmount { get; set; }
        public decimal PayAmount { get; set; }
        public decimal OrderFreight { get; set; }
        public decimal OrderAmount { get; set; }
        public Nullable<decimal> OrderOffAmount { get; set; }
        public string CouponCode { get; set; }
        public Nullable<decimal> CouponAmount { get; set; }
        public decimal Integral { get; set; }
        public decimal IntegralAmount { get; set; }
        public decimal Balance { get; set; }
        public int SendIntegral { get; set; }
        public int SendCouponId { get; set; }
        public int DeliveryWay { get; set; }
        public int PayWay { get; set; }
        public int PayMode { get; set; }
        public string PayBank { get; set; }
        public int PayState { get; set; }
        public Nullable<System.DateTime> PayTime { get; set; }
        public int SendState { get; set; }
        public Nullable<System.DateTime> SendTime { get; set; }
        public string ExpressCode { get; set; }
        public string LogisticsCoCode { get; set; }
        public string LogisticsCoName { get; set; }
        public int OrderState { get; set; }
        public Nullable<int> ProduceState { get; set; }
        public System.DateTime OrderStateTime { get; set; }
        public System.DateTime OrderTime { get; set; }
        public string OrderRemark { get; set; }
        public Nullable<bool> IsPush { get; set; }
        public Nullable<System.DateTime> PushTime { get; set; }
        public Nullable<bool> IsSendNoPayMsg { get; set; }
        public Nullable<System.DateTime> SendNoPayMsgTime { get; set; }
        public Nullable<bool> IsPresale { get; set; }
        public Nullable<int> PresaleId { get; set; }
        public Nullable<decimal> EarnestAmount { get; set; }
        public Nullable<System.DateTime> PresaleLastPayTime { get; set; }
        public Nullable<bool> IsSplitOrder { get; set; }
        public string ParentOrderCode { get; set; }
        public string OrderPageState { get; set; }
        public System.DateTime LastUpdateTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderGoods> OrderGoods { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderPresaleItem> OrderPresaleItem { get; set; }
    }
}
