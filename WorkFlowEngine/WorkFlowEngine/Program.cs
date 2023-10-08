using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var workflow = new WorkFlow();
            workflow.Add(new UploadVideo());
            workflow.Add(new CallWebServices());
            workflow.Add(new SendNofication());
            workflow.Add(new ChangeStatus());

            var runwork = new WorkFlowEngine();
            runwork.Run(workflow);


        }
    }
}
