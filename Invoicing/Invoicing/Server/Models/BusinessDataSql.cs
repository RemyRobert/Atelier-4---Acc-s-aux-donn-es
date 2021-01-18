using Dapper;
using Invoicing.Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Invoicing.Server.Models
{
    public class BusinessDataSql : IBusinessData, IDisposable
    {
        private SqlConnection cnct;

        public BusinessDataSql(string connectionString)
        {
            cnct = new SqlConnection(connectionString);
        }

        public void Dispose()
        {
            cnct.Dispose();
        }

        public IEnumerable<Invoice> AllInvoices => cnct.Query<Invoice>("SELECT * FROM Factures ORDER BY Created DESC");

        public decimal SalesRevenue => cnct.QueryFirst<decimal>("SELECT SUM(amount) FROM Factures");

        public decimal Outstanding => SalesRevenue - cnct.QueryFirst<decimal>("SELECT SUM(amount) FROM Factures");

        public void Add(Invoice newInvoice)
        {
            var insert = @"INSERT INTO Factures(Reference,Customer,Amount,Created,Paid,Expected) values (@reference,@customer,@amount,@created,@paid,@expected)";

            newInvoice.Expected = newInvoice.Created.AddMonths(1);

            cnct.Query(insert, newInvoice);
        }
    }
}