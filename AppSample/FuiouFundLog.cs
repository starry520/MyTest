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
    
    public partial class FuiouFundLog
    {
        public int Id { get; set; }
        public string busi_tp { get; set; }
        public string busi_tp_desc { get; set; }
        public string ext_tp { get; set; }
        public string txn_date { get; set; }
        public string txn_time { get; set; }
        public Nullable<System.DateTime> d_txn_date { get; set; }
        public string src_tp { get; set; }
        public string mchnt_ssn { get; set; }
        public Nullable<decimal> txn_amt { get; set; }
        public Nullable<decimal> txn_amt_suc { get; set; }
        public string contract_no { get; set; }
        public string out_fuiou_acct_no { get; set; }
        public string out_cust_no { get; set; }
        public string out_artif_nm { get; set; }
        public string in_fuiou_acct_no { get; set; }
        public string in_cust_no { get; set; }
        public string in_artif_nm { get; set; }
        public string remark { get; set; }
        public string txn_rsp_cd { get; set; }
        public string rsp_cd_desc { get; set; }
        public Nullable<int> OLogId { get; set; }
    }
}
