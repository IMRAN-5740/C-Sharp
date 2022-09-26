using System;

namespace DelegatesExample
{
    class Program
    {
        //public delegate int CalculatorHandeler(int firstNum, int secondNum);
        public delegate void PrintHandeler(string info);
      public  static void Main(string[] args)
        {
            //PrintHandeler handeler = Hello;
            //PrintHandeler handeler1 = GoodBye;
            //PrintHandeler handeler2 = handeler+ handeler1;
            ////handeler2 -= handeler1;
            //handeler2.Invoke("Mohammad Abdullah Al Imran");
            //handeler += GoodBye;
            //handeler("Mohammad Abdullah Al Imran");
            //handeler += GoodBye;

            //Student student = new Student();

            //two ways
            //CalculatorHandeler calculatorHandeler = AddValue;
            //Using Anonymous Method
            //CalculatorHandeler calculatorHandeler = delegate (int fNum, int sNum)
            //{
            //    return fNum + sNum;
            //};


            //CalculatorHandeler calculatorHandeler = new CalculatorHandeler(AddValue);
            // InvokeDelegates(calculatorHandeler, 12, 20);
            //int result= calculatorHandeler.Invoke(12, 20);
            //CalculatorHandeler calculatorHandeler1 = SubValue;


            //Anonymous Method
            //CalculatorHandeler calculatorHandeler1 = delegate (int fNum, int sNum)
            //{
            //    return fNum - sNum;
            //};


            //Lamba Expression:
            //CalculatorHandeler calculatorHandeler1 = 
            //    (int fNum, int sNum)=> fNum - sNum;

            //Lamba Statement
            //CalculatorHandeler calculatorHandeler1=
            //    (int fNum,int sNum)=>
            //    {
            //        return fNum - sNum;
            //    };
            //InvokeDelegates(calculatorHandeler1, 12, 90);
            ////int result = calculatorHandeler1.Invoke(12, 20);
            //// Console.WriteLine(result);
            Console.ReadKey();

        }

        //static void Hello(string name)
        //{
        //    Console.WriteLine("Hello "+name);
        //}
        //static void GoodBye(string name)
        //{
        //    Console.WriteLine("GoodBye " +name);
        //}

        //Single Delegate 
        //public  static int AddValue(int firstNum,int secondNum)
        //  {
        //      return firstNum + secondNum;
        //  }

        //public  static int SubValue(int firstNum, int secondNum)
        //  {
        //      return firstNum - secondNum;
        //  }
        // //Passing Method as a parameter
        //public static void InvokeDelegates(CalculatorHandeler rohim,int fNum,int sNum)
        //  {
        //      int result =rohim.Invoke(fNum,sNum);
        //      Console.WriteLine("The Resultant Value is  :" + result);
        //      //Console.WriteLine("The Total Sub Value :" + result);
        //  }
        


    }
}
