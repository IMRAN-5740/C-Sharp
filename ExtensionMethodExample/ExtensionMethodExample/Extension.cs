using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethodExample
{
    static class Extension
    {
        public static string GetInfo(this Person person)
        {
            return "Person ID :" + person.Id + Environment.NewLine+ "Person Name :" + person.Name + Environment.NewLine + "Person Address :" + person.Address + Environment.NewLine;
        }
    }
}
