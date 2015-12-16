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
    
    public partial class BorrowInfo
    {
        public BorrowInfo()
        {
            this.BorrowInfo_InvestRecord = new HashSet<BorrowInfo_InvestRecord>();
            this.BorrowInfoOperation = new HashSet<BorrowInfoOperation>();
        }
    
        public int Id { get; set; }
        public string BorrowTitle { get; set; }
        public string ContractNo { get; set; }
        public string BorrowParty { get; set; }
        public string GuaranteeParty { get; set; }
        public Nullable<int> GuaranteeTypeId { get; set; }
        public double BorrowAmount { get; set; }
        public double FinishAmount { get; set; }
        public int BorrowDay { get; set; }
        public System.DateTime EndDate { get; set; }
        public double Yield { get; set; }
        public int PayMethodId { get; set; }
        public double LendRate { get; set; }
        public double LendRateAmount { get; set; }
        public double BorrowRate { get; set; }
        public double BorrowRateAmount { get; set; }
        public System.DateTime RaiseBeginDate { get; set; }
        public System.DateTime RaiseEndDate { get; set; }
        public double MinAmount { get; set; }
        public double increment { get; set; }
        public bool IsHot { get; set; }
        public string Description { get; set; }
        public byte Status { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string BasicContractNo { get; set; }
        public string BasicBorrowPerson { get; set; }
        public string BasicLoanPerson { get; set; }
        public Nullable<System.DateTime> BasicLoanStartDate { get; set; }
        public Nullable<System.DateTime> BasicLoanEndDate { get; set; }
        public Nullable<System.DateTime> BasicInterestDate { get; set; }
        public Nullable<double> LoanAmount { get; set; }
        public Nullable<double> LoanRate { get; set; }
        public Nullable<int> IsCreate { get; set; }
        public Nullable<double> ProfitTotal { get; set; }
    
        public virtual GuaranteeType GuaranteeType { get; set; }
        public virtual ICollection<BorrowInfo_InvestRecord> BorrowInfo_InvestRecord { get; set; }
        public virtual PayMehod PayMehod { get; set; }
        public virtual ICollection<BorrowInfoOperation> BorrowInfoOperation { get; set; }
    }
}