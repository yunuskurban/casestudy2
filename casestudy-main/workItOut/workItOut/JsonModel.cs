using System;
using System.Collections.Generic;
using System.Text;

namespace workItOut
{
    public class JsonModel
    {
         public class Root
        {
            public exercise[] exercises { get; set; }
        }
        public class exercise
        {
            public string name { get; set; }
            public string force { get; set; }
            public string level { get; set; }
            public string mechanic { get; set; }
            public string equipment { get; set; }
            public string[] primaryMuscles { get; set; }
            public string[] secondaryMuscles { get; set; }
            public string[] instructions { get; set; }
            public string category { get; set; }
        }

       
    }
}
