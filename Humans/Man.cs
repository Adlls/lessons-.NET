using System;
namespace Humans
{
    public class Man
    {
        private string name;
        private int age;

        public virtual string Name { get => name; set => name = value; }
        public virtual int Age { get => age; set => age = value; }

        public Man()
        {
        }

        public override string ToString() => $"Human {name} {age}";
        public override bool Equals(object obj) => base.Equals(obj);
        public override int GetHashCode() => base.GetHashCode();
    }
}
