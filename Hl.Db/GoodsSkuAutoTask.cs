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
    
    public partial class GoodsSkuAutoTask
    {
        public int Id { get; set; }
        public int GoodsId { get; set; }
        public string GoodsNo { get; set; }
        public int SkuId { get; set; }
        public string SkuNo { get; set; }
        public int ActionType { get; set; }
        public System.DateTime StartTime { get; set; }
        public bool IsTask { get; set; }
        public Nullable<System.DateTime> TaskTime { get; set; }
        public System.DateTime CreateTime { get; set; }
    }
}
