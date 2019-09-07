using System.Collections.Generic;

namespace MoshIntermediate
{
    public interface IWorkflow
    {
        void RegisterActivity(IActivity activity);
        //ienumerator is a iteration over a collection
        IEnumerable<IActivity> GetActivities();
        void UnRegisterActivity(IActivity activity);

    }
}