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
    
    public partial class UserInfo_Score
    {
        public int Id { get; set; }
        public System.Guid UserId { get; set; }
        public int ScoreType { get; set; }
        public int Score { get; set; }
        public int Remain { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string Remark { get; set; }
    
        public virtual ScoreGet ScoreGet { get; set; }
        public virtual UserInfo UserInfo { get; set; }
    }
}
