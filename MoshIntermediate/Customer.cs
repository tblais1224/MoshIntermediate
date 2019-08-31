using System.Collections.Generic;

namespace MoshIntermediate
{
    public class Customer
    {
        public int Id;
        public string Name;
        //this is the same as initializing list in empty constructor
        //use readonly so the list cannot be reinitialized and lost
        public readonly List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name) : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            //the below line errors due to readonly  
            //Orders = new List<Order>();
        }
    }
}