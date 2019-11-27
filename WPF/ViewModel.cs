using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class ViewModel
    {
        public ViewModel()
        {
            DataTableCollection = GetDataTable();
        }
        public DataTable DataTableCollection { get; set; }

        private DataTable GetDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Order ID", typeof(int));
            dataTable.Columns.Add("Customer Name", typeof(string));
            dataTable.Columns.Add("Customer ID", typeof(string));
            dataTable.Columns.Add("Country", typeof(string));
            dataTable.Rows.Add(1001, "Maria Anders", "ALFKI", "Germany");
            dataTable.Rows.Add(1002, "Ana Trujilo", "ANATR", "Mexico");
            dataTable.Rows.Add(1003, "Antonio Moreno", "ENDGY", "Mexico");
            dataTable.Rows.Add(1004, "Thomas Hardy", "ANTON", "UK");
            dataTable.Rows.Add(1005, "Christina Berglund", "BERGS", "Sweden");
            dataTable.Rows.Add(1006, "Hanna Moos", "BLAUS", "Germany");
            dataTable.Rows.Add(1007, "Frederique Citeaux", "BLONP", "France");
            dataTable.Rows.Add(1008, "Martin Sommer", "BOLID", "Spain");
            dataTable.Rows.Add(1009, "Laurence Lebihan", "BONAP", "France");
            dataTable.Rows.Add(1010, "Kathryn", "BOTTM", "Canada");
            dataTable.Rows.Add(1011, "Tamer", "XDKLF", "UK");
            dataTable.Rows.Add(1012, "Martin", "QEUDJ", "US");
            dataTable.Rows.Add(1013, "Nancy", "ALOPS", "France");
            dataTable.Rows.Add(1014, "Janet", "KSDIO", "Canada");
            dataTable.Rows.Add(1015, "Dodsworth", "AWSDE", "Canada");
            dataTable.Rows.Add(1016, "Buchanan", "CDFKL", "Germany");
            dataTable.Rows.Add(1017, "Therasa", "WSCJD", "Canada");
            dataTable.Rows.Add(1018, "Margaret", "PLSKD", "UK");
            dataTable.Rows.Add(1019, "Anto", "CCDSE", "Sweden");
            dataTable.Rows.Add(1020, "Edward", "EWUJG", "Germany");
            return dataTable;
        }
    }
}
