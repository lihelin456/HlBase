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
    
    public partial class CustomizeElement
    {
        public int Id { get; set; }
        public string CustomizeTypes { get; set; }
        public int Type { get; set; }
        public string TypeCode { get; set; }
        public int MaterialId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Intro { get; set; }
        public string Diagram { get; set; }
        public decimal Price { get; set; }
        public double Stock { get; set; }
        public System.DateTime CreateTime { get; set; }
        public double AllocateStock { get; set; }
    }
}
