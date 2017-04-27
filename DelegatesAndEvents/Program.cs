using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{

    class Program
    {

        static void Main(string[] args)
        {
            var worker = new Worker();
            //Lambdas (inline method, parameters, body)
            worker.WorkPerformed += (s, e) =>
            {
                Console.WriteLine("Hours worked: " + e.Hours + " " + e.WorkType);
                Console.WriteLine("Good progress...");
            };
            worker.WorkCompleted += (s,e) => Console.WriteLine("Worker is done!");

            worker.DoWork(8, WorkType.GenerateReports);

            Console.Read();
        }

    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }
}
