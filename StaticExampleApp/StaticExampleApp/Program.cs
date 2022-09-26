using System;

namespace StaticExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Training.NumOfTrainee = 30;
            Training.GetInfo("Mohammad Abdullah Al Imran","Dot Net Explorer");
            Training training = new Training();
            training.ID = 1;
            training.Name = "BITM-67";
            training.SessionName = "ASP  Dot Net";
            training.TotalHour =90;
            //training.NumOfTrainee =30; 

            Training training1 = new Training();
            training1.ID = 2;
            training1.Name = "BITM-68";
            training1.SessionName = "Java";
            training1.TotalHour = 120;
            //training1.NumOfTrainee = 30;
           // training.GetInfo();

        }
    }
}
