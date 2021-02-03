using System;
using System.Data;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAPI.Models
{
    public partial class symportalSPsContext : DbContext
    {

        public symportalSPsContext()
        {
        }

        //public symportalSPsContext(DbContextOptions<symportalSPsContext> options)
        //    : base(options)
        //{
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
                       => options.UseSqlServer("Server=SYM-CITY-DB;;Initial Catalog=SymPortal;Persist Security Info=True;User ID=admsymportal;Password=symportal05");

        private DbSet<Open_Orders__ByShipToResult> Open_Orders__ByShipTo { get; set; }
        private DbSet<Open_Orders__ByShipToResult> Open_Orders__ByPO_BillTo { get; set; }
        private DbSet<Shipment_TrackingResult> Shipment_Tracking { get; set; }
        private DbSet<Customer_InfoResult> Customer_Info { get; set; }
        private DbSet<Address_Book__GetAddressWithEmailResult> Address_Book__GetAddressWithEmail { get; set; }
        private DbSet<Address_Book__GetComboRepsResult> Address_Book__GetComboReps { get; set; }
        private DbSet<Address_Book__GetNameResult> Address_Book__GetName { get; set; }


        [Obsolete]
#pragma warning disable CS0809 // Obsolete member overrides non-obsolete member
        protected override void OnModelCreating(ModelBuilder modelBuilder)
#pragma warning restore CS0809 // Obsolete member overrides non-obsolete member
        {
            // No key            
            modelBuilder.Query<Open_Orders__ByShipToResult>().HasNoKey();
            modelBuilder.Query<Shipment_TrackingResult>().HasNoKey();
            modelBuilder.Query<Customer_InfoResult>().HasNoKey();
            modelBuilder.Query<Address_Book__GetAddressWithEmailResult>().HasNoKey();
            modelBuilder.Query<Address_Book__GetComboRepsResult>().HasNoKey();
            modelBuilder.Query<Address_Book__GetNameResult>().HasNoKey();

            base.OnModelCreating(modelBuilder);
        }


        public async Task<List<Open_Orders__ByShipToResult>> Open_Orders__ByShipToAsync(int? addrNum, DateTime? fromDate, string userName)
        {
            //Initialize Result 
            List<Open_Orders__ByShipToResult> lst = new List<Open_Orders__ByShipToResult>();
            try
            {
                // Parameters   @addrNum int, @fromDate datetime, @userName nvarchar(100)
                SqlParameter p_addrNum = new SqlParameter("@addrNum", addrNum ?? (object)DBNull.Value);
                p_addrNum.Direction = ParameterDirection.Input;
                p_addrNum.DbType = DbType.Int32;
                p_addrNum.Size = 4;

                SqlParameter p_fromDate = new SqlParameter("@fromDate", fromDate ?? (object)DBNull.Value);
                p_fromDate.Direction = ParameterDirection.Input;
                p_fromDate.DbType = DbType.DateTime;
                p_fromDate.Size = 25;

                SqlParameter p_userName = new SqlParameter("@userName", userName ?? (object)DBNull.Value);
                p_userName.Direction = ParameterDirection.Input;
                p_userName.DbType = DbType.String;
                p_userName.Size = 100;


                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Open_Orders__ByShipTo_CP] @addrNum, @fromDate, @userName";

                //var productCategory = "Electronics";

                // var product = await this.Open_Orders__ByShipTo.FromSqlRaw("EXECUTE [dbo].[Open_Orders__ByShipTo] {0},{1},{2}", 69249, Convert.ToDateTime("12/26/2019"), "mmartino").ToListAsync();

                //Output Data
                lst = await this.Open_Orders__ByShipTo.FromSqlRaw(sqlQuery, p_addrNum, p_fromDate, p_userName).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<Open_Orders__ByShipToResult>> Open_Orders__ByPO_BillToAsync(string PONbr, DateTime? fromDate, string userName, int? billToID)
        {
            //Open_Orders__ByShipToResult class will be used because output is same as ShipTo Controller
            //Initialize Result 
            List<Open_Orders__ByShipToResult> lst = new List<Open_Orders__ByShipToResult>();
            try
            {
                // Parameters 
                SqlParameter p_PONbr = new SqlParameter("@poNbr", PONbr ?? (object)DBNull.Value);
                p_PONbr.Direction = ParameterDirection.Input;
                p_PONbr.DbType = DbType.String;
                p_PONbr.Size = 100;

                SqlParameter p_fromDate = new SqlParameter("@fromDate", fromDate ?? (object)DBNull.Value);
                p_fromDate.Direction = ParameterDirection.Input;
                p_fromDate.DbType = DbType.DateTime;
                p_fromDate.Size = 25;

                SqlParameter p_userName = new SqlParameter("@userName", userName ?? (object)DBNull.Value);
                p_userName.Direction = ParameterDirection.Input;
                p_userName.DbType = DbType.String;
                p_userName.Size = 100;

                SqlParameter p_billToID = new SqlParameter("@billToAcctNbr", billToID ?? (object)DBNull.Value);
                p_billToID.Direction = ParameterDirection.Input;
                p_billToID.DbType = DbType.Int32;
                p_billToID.Size = 4;


                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Open_Orders__ByPO_ByBillTo_CP] @poNbr, @fromDate, @userName, @billToAcctNbr";

                //Output Data
                lst = await this.Open_Orders__ByPO_BillTo.FromSqlRaw(sqlQuery, p_PONbr, p_fromDate, p_userName, p_billToID).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<Shipment_TrackingResult>> Shipment_TrackingAsync(int? OrderNbr, String Doc_Type, string user, DateTime? Invoice_Dt)
        {

            //Initialize Result 
            List<Shipment_TrackingResult> lst = new List<Shipment_TrackingResult>();
            try
            {
                // Parameters 
                SqlParameter p_OrderNbr = new SqlParameter("@orderNumber", OrderNbr ?? (object)DBNull.Value);
                p_OrderNbr.Direction = ParameterDirection.Input;
                p_OrderNbr.DbType = DbType.Int32;
                p_OrderNbr.Size = 4;

                SqlParameter p_Doc_Type = new SqlParameter("@documentType", Doc_Type ?? (object)DBNull.Value);
                p_Doc_Type.Direction = ParameterDirection.Input;
                p_Doc_Type.DbType = DbType.String;
                p_Doc_Type.Size = 10;

                SqlParameter p_user = new SqlParameter("@userName", user ?? (object)DBNull.Value);
                p_user.Direction = ParameterDirection.Input;
                p_user.DbType = DbType.String;
                p_user.Size = 100;

                SqlParameter p_Invoice_Dt = new SqlParameter("@InvDate", Invoice_Dt ?? (object)DBNull.Value);
                p_Invoice_Dt.Direction = ParameterDirection.Input;
                p_Invoice_Dt.DbType = DbType.DateTime;
                p_Invoice_Dt.Size = 25;


                // Processing 
                string sqlQuery = $@"EXEC [dbo].[OrderSearch_ShipmentTrackingByOrderNumberandInvoiceDt_CP] @orderNumber, @documentType, @userName, @InvDate";

                //Output Data
                lst = await Shipment_Tracking.FromSqlRaw(sqlQuery, p_OrderNbr, p_Doc_Type, p_user, p_Invoice_Dt).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<Customer_InfoResult>> GetCustomerInfo_ByBillToAsync(string BillToID, string StateProv)
        {
            //Open_Orders__ByShipToResult class will be used because output is same as ShipTo Controller
            //Initialize Result 
            List<Customer_InfoResult> lst = new List<Customer_InfoResult>();
            try
            {
                // Parameters 
                SqlParameter p_billToID = new SqlParameter("@ParentAcctNbr", BillToID ?? (object)DBNull.Value);
                p_billToID.Direction = ParameterDirection.Input;
                p_billToID.DbType = DbType.String;
                p_billToID.Size = 25;

                SqlParameter p_StateProv = new SqlParameter("@State_Prov", StateProv ?? (object)DBNull.Value);
                p_StateProv.Direction = ParameterDirection.Input;
                p_StateProv.DbType = DbType.String;
                p_StateProv.Size = 3;

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Get_Customers_CP] @ParentAcctNbr, @State_Prov";

                //Output Data
                lst = await this.Customer_Info.FromSqlRaw(sqlQuery,  p_billToID, p_StateProv).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<Address_Book__GetAddressWithEmailResult>> Address_Book__GetAddressWithEmailAsync(string userName, int? addrNum)
        {
            //Initialize Result 
            List<Address_Book__GetAddressWithEmailResult> lst = new List<Address_Book__GetAddressWithEmailResult>();
            try
            {
                // Parameters
                SqlParameter p_userName = new SqlParameter("@userName", userName ?? (object)DBNull.Value);
                p_userName.Direction = ParameterDirection.Input;
                p_userName.DbType = DbType.String;
                p_userName.Size = 200;

                SqlParameter p_addrNum = new SqlParameter("@addrNum", addrNum ?? (object)DBNull.Value);
                p_addrNum.Direction = ParameterDirection.Input;
                p_addrNum.DbType = DbType.Int32;
                p_addrNum.Size = 4;


                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Address_Book__GetAddressWithEmail] @userName, @addrNum";

                //Output Data
                lst = await this.Address_Book__GetAddressWithEmail.FromSqlRaw(sqlQuery, p_userName, p_addrNum).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<Address_Book__GetComboRepsResult>> Address_Book__GetComboRepsAsync(string userName, string taxID)
        {
            //Initialize Result 
            List<Address_Book__GetComboRepsResult> lst = new List<Address_Book__GetComboRepsResult>();
            try
            {
                // Parameters
                SqlParameter p_userName = new SqlParameter("@userName", userName ?? (object)DBNull.Value);
                p_userName.Direction = ParameterDirection.Input;
                p_userName.DbType = DbType.String;
                p_userName.Size = 200;

                SqlParameter p_taxID = new SqlParameter("@taxID", taxID ?? (object)DBNull.Value);
                p_taxID.Direction = ParameterDirection.Input;
                p_taxID.DbType = DbType.String;
                p_taxID.Size = 20;


                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Address_Book__GetComboReps] @userName, @taxID";

                //Output Data
                lst = await this.Address_Book__GetComboReps.FromSqlRaw(sqlQuery, p_userName, p_taxID).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<Address_Book__GetNameResult>> Address_Book__GetNameAsync(string userName, int? addrNum)
        {
            //Initialize Result 
            List<Address_Book__GetNameResult> lst = new List<Address_Book__GetNameResult>();
            try
            {
                // Parameters
                SqlParameter p_userName = new SqlParameter("@userName", userName ?? (object)DBNull.Value);
                p_userName.Direction = ParameterDirection.Input;
                p_userName.DbType = DbType.String;
                p_userName.Size = 200;

                SqlParameter p_addrNum = new SqlParameter("@addrNum", addrNum ?? (object)DBNull.Value);
                p_addrNum.Direction = ParameterDirection.Input;
                p_addrNum.DbType = DbType.Int32;
                p_addrNum.Size = 4;


                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Address_Book__GetName] @userName, @addrNum";

                //Output Data
                lst = await this.Address_Book__GetName.FromSqlRaw(sqlQuery, p_userName, p_addrNum).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public class Open_Orders__ByShipToResult
        {
            public int? Order_Nbr { get; set; }
            public string Order_Type { get; set; }
            public int? Line_Nbr { get; set; }
            public string Branch { get; set; }
            public int? BillTo_ID { get; set; }
            public int? ShipTo_ID { get; set; }
            public DateTime? Order_Date { get; set; }
            public DateTime? Scheduled_Pick_Date { get; set; }
            public DateTime? Actual_Ship_Date { get; set; }
            public DateTime? Expected_Ship_Date { get; set; }
            public string PO_Nbr { get; set; }
            public string SKU { get; set; }
            public string SKU_Desc { get; set; }
            public string Line_Type { get; set; }
            public string Next_Order_Status { get; set; }
            public string Next_Order_Status_Desc { get; set; }
            public string Last_Order_Status { get; set; }
            public string Last_Order_Status_Desc { get; set; }
            public string Item_Number_Related_Kit { get; set; }
            public int? Order_Qty { get; set; }
            public int? Units_Qty_Shipped { get; set; }
            public decimal? Unit_Price { get; set; }
            public decimal? Extended_Price { get; set; }
            public string Route_Code { get; set; }
            public string Order_Entered_By { get; set; }
            public decimal? Order_Entered_Date { get; set; }
            public string Sold_To_Name { get; set; }
            public string Ship_To_Name { get; set; }
            public string Ship_To_Region { get; set; }
            public int? SalesCount { get; set; }
            public int? Salesman_ID { get; set; }
            public string Salesman { get; set; }
            public string Region { get; set; }
            public string Territory { get; set; }
            public int? Unit_List_Price { get; set; }
            public DateTime? Expected_Delivery_Date { get; set; }
            public decimal? Multiplier { get; set; }
            public string Order_Status_Desc { get; set; }
        }

        public class Shipment_TrackingResult
        {
            public int? Order_Nbr { get; set; }
            public string Carrier { get; set; }
            public string Tracking_Nbr { get; set; }
            public string URL { get; set; }
        }

        public class Customer_InfoResult
        {
            public int? ShipTo_Acct { get; set; }
            public string Customer_Name { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip_Code { get; set; }

        }

        public class Open_Orders__ByShip2ToResult
        {
            public int? SDDOCO { get; set; }
            public string SDDCTO { get; set; }
            public int? SDLNID { get; set; }
            public string SDMCU { get; set; }
            public int? SDAN8 { get; set; }
            public int? SDSHAN { get; set; }
            public DateTime? SDTRDJ_GR { get; set; }
            public DateTime? SDPDDJ_GR { get; set; }
            public DateTime? SDADDJ_GR { get; set; }
            public DateTime? SDPPDJ_GR { get; set; }
            public string SDVR01 { get; set; }
            public string SDLITM { get; set; }
            public string SDDSC1 { get; set; }
            public string SDLNTY { get; set; }
            public string SDNXTR { get; set; }
            public string SDNXTR_TXT { get; set; }
            public string SDLTTR { get; set; }
            public string SDLTTR_TXT { get; set; }
            public string SDRLIT { get; set; }
            public int? SDUORG { get; set; }
            public int? SDSOQS { get; set; }
            public decimal? SDUPRC { get; set; }
            public decimal? SDAEXP { get; set; }
            public string SDROUT { get; set; }
            public string SDTORG { get; set; }
            public decimal? SDTDAY { get; set; }
            public string SoldTo { get; set; }
            public string ShipTo { get; set; }
            public string ShipTo_ABAC01 { get; set; }
            public int? SalesCount { get; set; }
            public int? SDSLSM { get; set; }
            public string Salesman { get; set; }
            public string Salesman_ABAC01 { get; set; }
            public string Salesman_ABAC02 { get; set; }
            public int? SDLPRC { get; set; }
            public DateTime? SDRSDJ_GR { get; set; }
            public decimal? Multiplier { get; set; }
            public string Status_TXT { get; set; }
        }

        public class Address_Book__GetAddressWithEmailResult
        {
            public string ABALPH { get; set; }
            public string ALADD1 { get; set; }
            public string ALADD2 { get; set; }
            public string ALADD3 { get; set; }
            public string ALADD4 { get; set; }
            public string ALADDZ { get; set; }
            public string ALCTY1 { get; set; }
            public string ALADDS { get; set; }
            public string ALCTR { get; set; }
            public string EAEMAL { get; set; }
        }

        public class Address_Book__GetComboRepsResult
        {
            public string SDSLSM { get; set; }
            public string SalesRep { get; set; }
        }

        public class Address_Book__GetNameResult
        {
            public decimal? ABAN8 { get; set; }
            public string ABALPH { get; set; }
        }
    }
        
}