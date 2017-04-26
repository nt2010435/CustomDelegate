using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate int WorkPerformedHandler(int hours, WorkType workType);

    public class Worker
    {
        public event WorkPerformedHandler WorkPerformed;
        public event EventHandler WorkCompleted;

        public void DoWork(int hours, WorkType workType)
        {

        }
    }
}
