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
    
    public partial class GoodsBrand
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string BrandEnName { get; set; }
        public string BrandLink { get; set; }
        public string BrandLogo { get; set; }
        public string BrandNote { get; set; }
        public bool IsEnable { get; set; }
        public int DisplayOrder { get; set; }
        public string KeyTitle { get; set; }
        public string KeyWords { get; set; }
        public string KeyDecription { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.DateTime LastUpdateTime { get; set; }
    }
}
