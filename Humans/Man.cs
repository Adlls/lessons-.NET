using System;
namespace Humans
{
    public class Man
    {
        private string name;
        private int age;

        public virtual string Name { get => name; set => name = value; }
        public virtual int Age { get => age; set => age = value; }

        public Man(Man prev)
        {
            age = prev.age;
            name = prev.name;
        }

        public Man(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Man()
        {
            age = -1;
            name = null;
        }



        public override string ToString() => $"Human {name} {age}";

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            Man man = (Man)obj;
            return this.name == man.Name && this.name == man.Name;
        }
        public override int GetHashCode()
        {
            return Name.Length * Age;
        }

    }
}
