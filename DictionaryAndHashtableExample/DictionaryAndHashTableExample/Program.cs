using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryAndHashtableExample
{
    class Program
    {
       

        static void Main(string[] args)
        {
            //Dictionary<int, string> aDictionary = new Dictionary<int, string>();
            //aDictionary.Add(1, "Mohammad Abdullah Al Imran");
            //aDictionary.Add(2, "Bashar Ovi");
            //aDictionary.Add(3, "Mohammad Sharif Ahmed");
            //string output;
            //if(aDictionary.TryGetValue(2,out output))
            //{
            //    Console.WriteLine("Yes, Data is Found in the Perspective Key and data is : "+output);
            //}
            //else
            //{
            //    Console.WriteLine("No Data Found in the Perspective Key");
            //}


            //foreach (var data in aDictionary)
            //{
            //    Console.WriteLine("Key is : " + data.Key+" and "+"Corresponding Value is : " + data.Value);
            //}
            //Console.ReadKey();

            Hashtable aHashtable = new Hashtable();
            aHashtable.Add("2", 40);
            aHashtable.Add(3, "Mohammad Imran");
            aHashtable.Add("1","Bashar Ovi");
            aHashtable.Add(3.3, 40.5644);


            foreach(var data in aHashtable.Values)
            {
                Console.WriteLine(data);  
            }
            if (aHashtable.Contains("1"))
            {
                Console.WriteLine("Data Found");
            }
            else
            {
                Console.WriteLine("Data not Found");
            }

            Console.ReadKey();


        }
       
    }
}
