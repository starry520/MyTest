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
    
    public partial class UserDetail
    {
        public System.Guid UserId { get; set; }
        public string UAddress { get; set; }
        public string GraduationSchool { get; set; }
        public string Education { get; set; }
        public string CompanyIndustry { get; set; }
        public string CompanySize { get; set; }
        public string MonthIncome { get; set; }
        public bool Marry { get; set; }
        public Nullable<bool> HaveHouse { get; set; }
        public Nullable<bool> HaveCar { get; set; }
        public string Position { get; set; }
        public string Sex { get; set; }
        public string SecondLinkMan { get; set; }
        public string EmergencyContactor { get; set; }
        public string EmergencyPhoneNumber { get; set; }
    
        public virtual UserInfo UserInfo { get; set; }
    }
}