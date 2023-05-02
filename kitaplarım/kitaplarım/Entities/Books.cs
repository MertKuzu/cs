using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_template.Entities
{
    public class Books
    {
        public int ID { get; set; }

        public string NAME { get; set; }

        public int ISBN { get; set; }

        public string AUTHOR { get; set; }

        public int CATEGORYID { get; set; }

        public Categories Categories { get; set; }
    }
}
