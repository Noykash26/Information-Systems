using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scouts
{
    public class Query
    {
        public MyForm form;
        public string queryType;
        public string queryname;
        public string queryvalue;

        public Query(MyForm inForm, string queryType, string queryname)
        {
            this.form = inForm;
            this.queryType = queryType;
            this.queryname = queryname;
        }
        public Query(string queryType, string queryname)
        {
            this.queryType = queryType;
            this.queryname = queryname;
        }
        public void setForm(MyForm form) { this.form = form; }
        public void setValue(string value)
        {
            this.queryvalue = value;
        }
        public Boolean Equals(string queryType, string queryname)
        {
            if ((this.queryname.Equals(queryname)) && this.queryType.Equals(queryType))
            {
                return true;
            }
            return false;
        }
        public Boolean isGood()
        {
            if (queryType != null && queryname != null)
                return true;
            return false;
        }
    }
}
