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
    
    public partial class OutsideVisitLog
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public int AdId { get; set; }
        public string VisitToken { get; set; }
        public int ActionType { get; set; }
        public Nullable<int> WebUserId { get; set; }
        public Nullable<int> WebOrderId { get; set; }
        public string SourceIp { get; set; }
        public string SourceUrl { get; set; }
        public System.DateTime CreateTime { get; set; }
    }
}
