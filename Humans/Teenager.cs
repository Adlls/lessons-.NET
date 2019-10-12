using System;
namespace Humans
{
    public class Teenager: Man
    {

        public override int Age {
            get => base.Age;

            set
            {
                if (value >= 13 && value <= 19) base.Age = value;
                else throw new Exception("Invalid age value");
            }
        }

        public Teenager():base()
        {
        }

        public Teenager(string name, int age) : base(name, age)
        {
        }

        public Teenager(Teenager prev): base(prev)
        {
        }

        public override string ToString() => $"Teenager {this.Name} {this.Age}";
        public override bool Equals(object obj) => base.Equals(obj);

        public override int GetHashCode()
        {
            return Name.Length * Age * Age;
        }
    }
}
