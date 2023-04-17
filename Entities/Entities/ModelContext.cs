using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TestLearning.Entities
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Testora> Testoras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("User Id=EREMITNEW;Password=eremitnew;Data Source=192.183.155.47:1521/frpsdb;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("EREMITNEW")
                .HasAnnotation("Relational:Collation", "USING_NLS_COMP");

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BANK");

                entity.Property(e => e.BankId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BANK_ID")
                    .HasDefaultValueSql("\"EREMITNEW\".\"BANK_SEQ\".nextval ");

                entity.Property(e => e.BbCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("BB_CODE");

                entity.Property(e => e.BbReg)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("BB_REG");

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CITY");

                entity.Property(e => e.CntrBankAgent)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CNTR_BANK_AGENT");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CONTACT_PERSON");

                entity.Property(e => e.Country)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("COUNTRY");

                entity.Property(e => e.CreatedAt)
                    .HasPrecision(6)
                    .HasColumnName("CREATED_AT")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP     ");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.Currency)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CURRENCY");

                entity.Property(e => e.DepCompId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DEP_COMP_ID");

                entity.Property(e => e.DepositoryPart)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DEPOSITORY_PART");

                entity.Property(e => e.DistrictId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DISTRICT_ID");

                entity.Property(e => e.DivisionId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DIVISION_ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Fax)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FAX");

                entity.Property(e => e.ForeignInstitute)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FOREIGN_INSTITUTE");

                entity.Property(e => e.FullName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FULL_NAME");

                entity.Property(e => e.OpenDate)
                    .HasPrecision(6)
                    .HasColumnName("OPEN_DATE")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP     ");

                entity.Property(e => e.Phone)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PHONE");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("POSTAL_CODE");

                entity.Property(e => e.RecStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("REC_STATUS");

                entity.Property(e => e.ReportName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("REPORT_NAME");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SHORT_NAME");

                entity.Property(e => e.SwiftCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SWIFT_CODE");

                entity.Property(e => e.UpdateAt)
                    .HasPrecision(6)
                    .HasColumnName("UPDATE_AT")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP     ");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");

                entity.Property(e => e.Upzilla)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("UPZILLA");

                entity.Property(e => e.Web)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("WEB");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.ToTable("BRANCH");

                entity.Property(e => e.BranchId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BRANCH_ID")
                    .HasDefaultValueSql("\"EREMITNEW\".\"BRANCH_SEQ\".nextval");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("BANK_CODE");

                entity.Property(e => e.BankId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BANK_ID");

                entity.Property(e => e.BankName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("BANK_NAME");

                entity.Property(e => e.BaseCurrency)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BASE_CURRENCY");

                entity.Property(e => e.BbDistrictName)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("BB_DISTRICT_NAME");

                entity.Property(e => e.BbReg)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BB_REG");

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_CODE");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CITY");

                entity.Property(e => e.Country)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COUNTRY");

                entity.Property(e => e.CountryId)
                    .HasPrecision(19)
                    .HasColumnName("COUNTRY_ID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATED_AT");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CurrencyId)
                    .HasPrecision(19)
                    .HasColumnName("CURRENCY_ID");

                entity.Property(e => e.DistCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DIST_CODE");

                entity.Property(e => e.DistName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DIST_NAME");

                entity.Property(e => e.DivisionId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DIVISION_ID");

                entity.Property(e => e.FullName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FULL_NAME");

                entity.Property(e => e.OpenDate)
                    .HasColumnType("DATE")
                    .HasColumnName("OPEN_DATE");

                entity.Property(e => e.RecStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REC_STATUS")
                    .IsFixedLength(true);

                entity.Property(e => e.ReportName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REPORT_NAME");

                entity.Property(e => e.RoutingNo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ROUTING_NO");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SHORT_NAME");

                entity.Property(e => e.SwiftCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SWIFT_CODE");

                entity.Property(e => e.UpdateAt)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_AT");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UPDATED_BY");
            });

            modelBuilder.Entity<Testora>(entity =>
            {
                entity.ToTable("TESTORA");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.HasSequence("ABS_MONEYGRAM_AUTH_SEQ");

            modelBuilder.HasSequence("ACCOUNT_BALANCE_SEQ");

            modelBuilder.HasSequence("ACCOUNT_INFO_SEQ");

            modelBuilder.HasSequence("ACCOUNT_NATURE_SEQ");

            modelBuilder.HasSequence("ACCOUNT_TYPE_SEQ");

            modelBuilder.HasSequence("BANK_SEQ");

            modelBuilder.HasSequence("BEFTN_RETURN_SEQ");

            modelBuilder.HasSequence("BRANCH_SEQ");

            modelBuilder.HasSequence("COMMON_CODE_SEQ");

            modelBuilder.HasSequence("COUNTRY_SEQ");

            modelBuilder.HasSequence("CURRENCY_SEQ");

            modelBuilder.HasSequence("DEBIT_INFO_SEQ");

            modelBuilder.HasSequence("DISTRICT_SEQ");

            modelBuilder.HasSequence("DIVISION_SEQ");

            modelBuilder.HasSequence("EMPLOYEE_SEQ");

            modelBuilder.HasSequence("EX_HOUSE_API_XML_DATA_SEQ");

            modelBuilder.HasSequence("FILE_NAME_SEQ");

            modelBuilder.HasSequence("FILE_PROCESSING_ACCOUNTS_SEQ");

            modelBuilder.HasSequence("FILE_PROCESSING_SEQ");

            modelBuilder.HasSequence("GL_LIST_SEQ");

            modelBuilder.HasSequence("INCENTIVE_POLICY_SEQ");

            modelBuilder.HasSequence("ISEQ$$_267517");

            modelBuilder.HasSequence("MONEYGRAM_AUTH_SEQ");

            modelBuilder.HasSequence("OFFICER_INFO_SEQ");

            modelBuilder.HasSequence("OFFICER_SETUP_SEQ");

            modelBuilder.HasSequence("PAYMENT_TYPE_SEQ");

            modelBuilder.HasSequence("REMIT_USER_INFO_ARCHIVE_SEQ");

            modelBuilder.HasSequence("REMITTANCE_INFO_ARCHIVE_SEQ");

            modelBuilder.HasSequence("REMITTANCE_INFO_CTSU_ARCHIVE_SEQ");

            modelBuilder.HasSequence("REMITTANCE_INFO_CTSU_SEQ");

            modelBuilder.HasSequence("REMITTANCE_INFO_SEQ");

            modelBuilder.HasSequence("REMITTANCE_SEQ");

            modelBuilder.HasSequence("RM_BENEFICIARY_INFO_SEQ");

            modelBuilder.HasSequence("RM_DAILY_TRANSACTION_SEQ");

            modelBuilder.HasSequence("RM_REMITTER_INFO_SEQ");

            modelBuilder.HasSequence("RM_TRANSACTION_TEMP_SEQ");

            modelBuilder.HasSequence("SEQ_AML_FILE_ID");

            modelBuilder.HasSequence("SEQ_SRLNO");

            modelBuilder.HasSequence("TRANSACTION_LOG_SEQ");

            modelBuilder.HasSequence("TRANSACTON_METHOD_SEQ");

            modelBuilder.HasSequence("TREASURY_FILE_DATA_SEQ");

            modelBuilder.HasSequence("TREASURY_FILE_UPLOAD_SEQ");

            modelBuilder.HasSequence("TREASURY_TRANS_DTL_SEQ");

            modelBuilder.HasSequence("UNLOCK_GENERIC_CASH_API_SEQ");

            modelBuilder.HasSequence("UPAZILLA_SEQ");

            modelBuilder.HasSequence("USD_APPROVE_INFO_SEQ");

            modelBuilder.HasSequence("WEBSERVICE_REQ_ID");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
