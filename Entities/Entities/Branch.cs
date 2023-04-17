using System;
using System.Collections.Generic;

#nullable disable

namespace TestLearning.Entities
{
    public partial class Branch
    {
        public decimal BranchId { get; set; }
        public string FullName { get; set; }
        public string BranchCode { get; set; }
        public string RoutingNo { get; set; }
        public string BankCode { get; set; }
        public string BankName { get; set; }
        public string DistCode { get; set; }
        public string DistName { get; set; }
        public string ReportName { get; set; }
        public string SwiftCode { get; set; }
        public string ShortName { get; set; }
        public string Country { get; set; }
        public string BaseCurrency { get; set; }
        public string City { get; set; }
        public string BbReg { get; set; }
        public decimal? DivisionId { get; set; }
        public decimal? BankId { get; set; }
        public long? CountryId { get; set; }
        public long? CurrencyId { get; set; }
        public DateTime? OpenDate { get; set; }
        public string RecStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string BbDistrictName { get; set; }
    }
}
