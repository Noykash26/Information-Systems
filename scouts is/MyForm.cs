using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scouts
{
    public class MyForm
    {
        public String formName;
        public User filldByUser;
        public List<Query> queries;
        public MyForm(String formName)
        {
            this.formName = formName;
            this.queries = new List<Query>();
        }
        public MyForm()
        {
            this.queries = new List<Query>();
        }
        public void insertQuery(Query query)
        {
            if (!queries.Contains(query))
            {
                queries.Add(query);
            }
        }
        public void insertToFormQuere()
        {
            SQL_CON sc = new SQL_CON();
            SqlCommand scc = new SqlCommand();
            foreach (Query q in queries)
            {
                string insertToFormList = "INSERT INTO[dbo].[formQuerys]([queryName],[queryType],[formName])VALUES(";
                insertToFormList = insertToFormList + "'" + q.queryname + "','" + q.queryType + "','" + formName + "')";
                scc.CommandText = insertToFormList;
                sc.execute_non_query(scc);
            }
        }
        public void setQueryValue(string queryName, string value)
        {
            foreach (Query q in queries)
            {
                if (q.queryname.Equals(queryName))
                {
                    q.setValue(value);
                }
            }

        }

    }
}
