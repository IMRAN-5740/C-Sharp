using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExampleApp
{
    class Training
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SessionName { get; set; }
        public int TotalHour { get; set; }
        public static int NumOfTrainee { get; set; }

        public static string GetInfo(string name,string sesson)
        {
            return "Name :"+name+ "Session Name : "+sesson+Environment.NewLine;
        }



    }
}
