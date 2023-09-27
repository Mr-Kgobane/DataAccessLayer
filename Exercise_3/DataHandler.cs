using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Exercise_3
{
    internal class DataHandler
    {
        public DataHandler() { }
        static string connect = "Data Source=DESKTOP-I2J8MUI;Initial Catalog=BCDB;Integrated Security=True";

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public void register(int stid, string n, string l, string c)
        {
            string query = $"INSERT INTO tblStudents VALUES ('{stid}','{l}','{n}','{c}')";
            conn = new SqlConnection(connect);
            conn.Open();
            cmd = new SqlCommand(query, conn);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Details Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details NOT Saved" + ex.Message);

            }
            finally
            {
                conn.Close();
            }
        }

        public void update(int stid, string n, string l, string c)
        {
            string query = $"UPDATE tblStudents SET [StudentID] = '{stid}', [LastName] = '{l}'," +
                $" [FirstName] = '{n}', [CourseID] = '{c}')";
            conn = new SqlConnection(connect);
            conn.Open();
            cmd = new SqlCommand(query, conn);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Details Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details NOT Updated" + ex.Message);

            }
            finally
            {
                conn.Close();
            }

        }

        public void Delete(int stid)
        {
            string query = $"DELETE FROM tblStudents WHERE StudentID = '{stid}'";
            conn = new SqlConnection(connect);
            conn.Open();
            cmd = new SqlCommand(query, conn);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Details Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details NOT Deleted" + ex.Message);

            }
            finally
            {
                conn.Close();
            }
        }


        public DataTable Search(int stid)
        {
            string query = $"SELECT * FROM tblStudents WHERE StudentID = '{stid}'";
            conn = new SqlConnection(connect);
            adapt = new SqlDataAdapter(query, conn);

            DataTable table = new DataTable();
            adapt.Fill(table);

            return table;
        }
    }
}
