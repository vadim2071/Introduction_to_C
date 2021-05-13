using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class ToDo
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }

        //конструктор
        public ToDo(string title, bool isdone)
        {
            Title = title;
            IsDone = isdone;
        }
    }
}
