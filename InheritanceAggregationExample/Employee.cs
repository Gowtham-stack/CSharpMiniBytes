using System;

namespace InheritanceAggregationExample
{
     class Employee : Person //Employee IS-A Person (Inheritance:IS-A relationship)
    {
        public string IsMorningShift { get; private set; }
        
        
        public Employee(string IsMorningShift, string FirstName, string LastName, int Id, Address Address) : base(FirstName, LastName, Id, Address)  
        {
            this.IsMorningShift = IsMorningShift;
            //base.FirstName = "Hari"; this will throw compile time  error because it is Private
        }
        static void Main(string[] args)
        {
            Address MyAddress = new Address("7/3","Arimuthu Street",23);
            Employee employee = new Employee("yes","Gowtham","R",1,MyAddress);
            employee.IsMorningShift = "No";
            Console.WriteLine($"Employee Details:\n{employee.FirstName}");
        }
    }

    class Person
    {
        public string FirstName;
        public string LastName;
        public int Id;
        public Address Address; //Person HAS-A Address (Aggregation:HAS-A relationship)

        public Person(string FirstName, string LastName, int Id, Address Address)
        {
            this.Address = Address;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Id = Id;
        }
    }

    class Address
    {
        public string AddressLine1;
        public string AddressLine2;
        public int Id;

        public Address(String AddressLine1, string AddressLine2, int Id)
        {
            this.AddressLine1 = AddressLine1;
            this.AddressLine2 = AddressLine2;
            this.Id = Id;
        }

    }
}
