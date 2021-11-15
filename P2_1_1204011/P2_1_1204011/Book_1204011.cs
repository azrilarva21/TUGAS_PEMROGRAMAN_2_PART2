using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1204011
{
       public class Book_1204011 : Product_1204011
    {
        protected string pageCount;

        public Book_1204011(string type, string title, string pagecount)
            : base(type, title)
        {
            this.pageCount = pagecount; 
        }

        public string PageCount
        {
            get
            {
                return pageCount;
            }

            set
            {
                pageCount = value; 
            }
        }
    }
}
