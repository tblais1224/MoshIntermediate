namespace MoshIntermediate
{
    //takes list of activities from the workflow and runs them
    public class WorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (var activity in workflow.GetActivities())
            {
                activity.Execute();
            }
        }
    }
}