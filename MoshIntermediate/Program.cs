using System;
using System.Collections.Generic;

namespace MoshIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkFlow workflow = new WorkFlow();
            workflow.Add(new VideoUploader());
            workflow.Add(new CallWebService());
            workflow.Add(new SendEmail());
            workflow.Add(new ChangeStatus());


            var engine = new WorkFlowEngine();
            engine.Run(workflow);

            Console.ReadLine();
        }
    }

    public interface ITask
    {
        void Execute();
    }

    public interface IWorkFlow
    {
        void Add(ITask task);
        void Remove(ITask task);
        IEnumerable<ITask> GetTasks();
    }

    public class WorkFlow : IWorkFlow
    {
        private readonly List<ITask> _tasks;

        public WorkFlow()
        {
            _tasks = new List<ITask>();
        }

        public void Add(ITask task)
        {
            _tasks.Add(task);
        }

        public void Remove(ITask task)
        {
            _tasks.Remove(task);
        }

        public IEnumerable<ITask> GetTasks()
        {
            return _tasks;
        }
    }

    class VideoUploader : ITask
    {
        public void Execute()
        {
            Console.WriteLine("uploading video");
        }
    }
    class CallWebService : ITask
    {
        public void Execute()
        {
            Console.WriteLine("calling the web service");
        }
    }
    class SendEmail : ITask
    {
        public void Execute()
        {
            Console.WriteLine("sending email");
        }
    }
    class ChangeStatus : ITask
    {
        public void Execute()
        {
            Console.WriteLine("video status changed");
        }
    }

    public class WorkFlowEngine
    {
        public void Run(IWorkFlow workFlow)
        {
            foreach (ITask I in workFlow.GetTasks())
            {
                I.Execute();
            }
        }
    }

}
