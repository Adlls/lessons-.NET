using System;
namespace Humans
{
    public class Worker: Man
    {
        public override int Age
        {
            get => base.Age;

            set
            {
                if (value >= 16 && value <= 70) base.Age = value;
                else throw new Exception("Invalid age value");
            }
        }

        public Worker():base()
        {
        }

        public Worker(string name, int age) : base(name, age)
        {
        }

        public Worker(Worker prev) : base(prev)
        {
        }


        public override string ToString() => $"Worker {this.Name} {this.Age}";

        public override bool Equals(object obj) => base.Equals(obj);
        public override int GetHashCode()
        {
            return Name.Length * Age * Age * Age;
        }
    }
}
