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
    
    public partial class GoodsCategory
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryEnName { get; set; }
        public int ParentId { get; set; }
        public string PCategoryIds { get; set; }
        public bool IsEnable { get; set; }
        public bool IsHot { get; set; }
        public Nullable<bool> IsNew { get; set; }
        public Nullable<bool> IsPromotion { get; set; }
        public Nullable<bool> IsParentGoods { get; set; }
        public int DisplayOrder { get; set; }
        public string Description { get; set; }
        public string MarkIcon { get; set; }
        public string SaleIcon { get; set; }
        public string KeyTitle { get; set; }
        public string KeyWords { get; set; }
        public string KeyDecription { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime LastUpdateTime { get; set; }
    }
}
