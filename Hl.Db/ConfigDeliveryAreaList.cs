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
    
    public partial class ConfigDeliveryAreaList
    {
        public int Id { get; set; }
        public int DeliveryAreaId { get; set; }
        public int AreaId { get; set; }
        public System.DateTime CreateTime { get; set; }
    
        public virtual ConfigArea ConfigArea { get; set; }
        public virtual ConfigDeliveryArea ConfigDeliveryArea { get; set; }
    }
}
