using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Notes___Classes_and_Structs
{
    // WorkItem implicitly inherits from the Object class
    public class WorkItem
    {
        // Static field CurrentID stores the job ID of the last WorkItem that has been created. 
        private static int currentID;

        // Properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string Description { get; set; }
        protected TimeSpan jobLength { get; set; }

        // Default constructor. If a derived class does not invoke a baseclass constructor explicitly, the
        // default constructor is called implicitly

        public WorkItem()
        {
            ID = 0;
            Title = "Default title";
            Description = "Default description";
            jobLength = new TimeSpan();
        }

        // Instance constructor that has three parameters
        public WorkItem(string title, string desc, TimeSpan jobLen)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.Description = desc;
            this.jobLength = jobLen;
        }

        // Static constructor to initialize the static member, currentID. This constructor is called one time,
        // automatically, before any instance of WorkItem or ChangeRequest is created, or currentID is referenced
        static WorkItem() => currentID = 0;

        // CurrentID is a static field. It is incremented each time a new instance of WorkItem is create
        protected int GetNextID() => ++currentID;

        // Method Update enables you to update the title and job length of an existing WorkItem object
        public void Update(string title, TimeSpan jobLen)
        {
            this.Title = title;
            this.jobLength = jobLen;
        }

        // Override the ToString method inherited from System.Object
        public override string ToString() => $"{this.ID} - {this.Title} \t\n" +
                                             $"    {this.Description}";
    }

}
