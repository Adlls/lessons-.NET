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

        public Worker()
        {
        }

        public override string ToString() => $"Worker {this.Name} {this.Age}";
        public override bool Equals(object obj) => base.Equals(obj);
        public override int GetHashCode() => base.GetHashCode();
    }
}
