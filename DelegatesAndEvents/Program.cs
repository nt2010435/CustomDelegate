using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    //public delegate int BizRulesDelegate(int x, int y);

    class Program
    {

        static void Main(string[] args)
        {
            //Lambdas with custom delegates to pass in Business rule instead of concrete defining business rules in 'ProcessData' class
            //BizRulesDelegate addDel = (x, y) => x + y;
            //BizRulesDelegate multiplyDel = (x, y) => x * y;

            var data = new ProcessData();
            //data.Process(2, 3, addDel);
            //data.Process(4, 6, multiplyDel);

            //Action<T> delegates
            Action<int, int> myAction = (x, y) => Console.WriteLine(x + y);
            Action<int, int> myMultiplyAction = (x, y) => Console.WriteLine(x * y);
            data.ProcessAction(2, 3, myAction);


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
