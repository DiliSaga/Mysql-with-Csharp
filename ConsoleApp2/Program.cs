using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

try
{
    string connstring = "server=localhost;uid=root;pwd=root;database=classicmodels";
    MySqlConnection conn = new MySqlConnection();
    conn.ConnectionString = connstring;
    conn.Open();
    string sql = "select * from employees ";
    string Query = "insert into productlines(productLine,textDescription,htmlDescription,image) " +
       "values('" + "Racing cars" + "','" + "A car goes very fast" + "','" + null + "','" + null + "');";
    MySqlCommand cmd = new MySqlCommand(Query, conn);
    MySqlDataReader reader = cmd.ExecuteReader();

    Console.WriteLine("\n\n----SaveD Data----\n\n");
}
catch (MySqlException ex)
{
    Console.WriteLine(ex.Message);
}