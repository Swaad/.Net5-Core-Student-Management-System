using System;
using System.Collections.Generic;

#nullable disable

namespace TestLearning.Entities
{
    public partial class Bank
    {
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public decimal BankId { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string ReportName { get; set; }
        public string BbCode { get; set; }
        public string SwiftCode { get; set; }
        public string BbReg { get; set; }
        public string Country { get; set; }
        public DateTime OpenDate { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string DepCompId { get; set; }
        public string CntrBankAgent { get; set; }
        public string ForeignInstitute { get; set; }
        public string DepositoryPart { get; set; }
        public string ContactPerson { get; set; }
        public string Web { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Currency { get; set; }
        public string Upzilla { get; set; }
        public decimal? DistrictId { get; set; }
        public string RecStatus { get; set; }
        public decimal? DivisionId { get; set; }
    }
}
