using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var t = new GymTrainingDiary.Model.GymTrainingContext();
                var t2 = t.Users.ToList();
            }
            catch (Exception e)
            {

            }
            Console.ReadKey();
        }
    }
}
