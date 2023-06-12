using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediate
{
    public class Workflow
    {
        private readonly IList<IActivity> _activities;

        public Workflow()
        {
            _activities = new List<IActivity>();
        }

        public void RegisterActivity(IActivity activity)
        {
            _activities.Add(activity);
        }

        public void Execute()
        {
            foreach (var activity in _activities)
                activity.Execute();
        }

    }
}
