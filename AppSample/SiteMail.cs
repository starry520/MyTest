//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppSample
{
    using System;
    using System.Collections.Generic;
    
    public partial class SiteMail
    {
        public int Id { get; set; }
        public Nullable<System.Guid> Sender { get; set; }
        public string SenderName { get; set; }
        public Nullable<System.Guid> Reciver { get; set; }
        public string ReciverName { get; set; }
        public Nullable<bool> IsRead { get; set; }
        public string Title { get; set; }
        public string MsgContent { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> ReadDate { get; set; }
    }
}
