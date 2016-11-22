using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectToAFile
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private Owner owner;
        public Car()
        {
        }
    }

    public class Owner
    {
        private string firstname;
        private string lastname;

        public Owner()
        {

        }
    }

    public class ObjectToSerialize
    {
        private List<Car> cars;
        public List<Car> Cars
        {
            get { return this.cars; }
            set { this.cars = value; }
        }
        public ObjectToSerialize()
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
