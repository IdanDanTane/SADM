using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;//חשוב!
using System.Windows.Forms;//עבור ההודעות!
using System.Data;
using System.IO;

namespace Group_2
{
    class SQL_CON
    {
        SqlConnection conn;

        public SQL_CON()
        {
            conn = new SqlConnection("Data Source = dbcourse.database.windows.net; Initial Catalog = SADM_2; Persist Security Info = True; User ID = idandan@bgufbm.onmicrosoft.com; Password = fqv25217; Authentication = Active Directory Password");//update this!!
        }
        public SqlConnection getConnection()//returns the connection 
        {
            return conn;
        }
        public void Execute_non_query(SqlDataAdapter cmd)
        {

            try
            {
                // open a connection object
                this.conn.Open();
                cmd.SelectCommand.ExecuteNonQuery();
                MessageBox.Show(" השאילתה בוצעה בהצלחה", "המשך", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "המשך", MessageBoxButtons.OK);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public SqlDataReader Execute_query(SqlCommand cmd)
        {
            try
            {
                // open a connection object
                conn.Open();
                cmd.Connection = conn;
                SqlDataReader READER = cmd.ExecuteReader();
                return READER;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "המשך", MessageBoxButtons.OK);
                return null;
            }
            //"שגיאה בביצוע השאילתה"

        }

    }

}