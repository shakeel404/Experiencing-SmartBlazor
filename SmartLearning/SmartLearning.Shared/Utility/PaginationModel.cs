using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLearning.Shared.Utility
{
    public class PaginationModel<T> where T:class
    {
        
        public string Filter { get;  set; }
        public int Page { get;  set; }
        public int Count { get;  set; }
        public int Size { get;  set; } 
        public bool Previous => Page > 1;
        public bool Next => Page < Pages;
        public bool First => Page != 1;
        public bool Last => Page != Pages;
        public int Pages => (int)Math.Ceiling(decimal.Divide(Count, Size));

        public IEnumerable<T> Items { get; set; }
    }
}
