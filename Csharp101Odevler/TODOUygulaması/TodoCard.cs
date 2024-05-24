using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOUygulaması
{
    public class TodoCard
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string AssignedTo { get; set; }
        public TodoSize Size { get; set; }
        public TodoLine Line { get; set; }
    }
}
