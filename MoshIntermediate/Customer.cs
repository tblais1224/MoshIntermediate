using System.Collections.Generic;

namespace MoshIntermediate
{
    public class Customer
    {
        public int Id;
        public string Name;
        //store objects of type Order
        public List<Order> Orders;

        public Customer()
        {
            //always initialize empty list of objects within class 
            Orders = new List<Order>();
        }
        public Customer(int id) : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name) : this(id)
        {
            this.Name = name;
        }

    }


}