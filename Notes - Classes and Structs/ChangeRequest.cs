using System;
using System.Collections.Generic;
using System.Text;

namespace Notes___Classes_and_Structs
{
    // ChangeRequest derives from WorkItem and adds a property (originalItemID) and two constructors
    public class ChangeRequest: WorkItem
    {
        protected int originalItemID { get; set; }

        // Constructors. Because neither constructor calls a base-class constructor explicitly, the default
        // constructor in the base class is called implicitly. The base class must contain a default constructor

        // Default constructor for the derived class
        public ChangeRequest() { }

        // Instance constructor that has four parameters
        public ChangeRequest(string title, string desc, TimeSpan jobLen, int originalID)
        {
            // The following properties and the GetNextID method are inherited from WorkItem
            this.ID = GetNextID();
            this.Title = title;
            this.Description = desc;
            this.jobLength = jobLen;

            // Property originalItemId is a member of ChangeRequest, but not of WorkItem
            this.originalItemID = originalID;
        }







    }
}
