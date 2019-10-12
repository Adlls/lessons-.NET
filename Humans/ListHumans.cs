using System;
namespace Humans
{
    public class ListHumans
    {
       private Man[] mans;
       //public class LinkedList<T> : IEnumerable<T>  // односвязный список

       public Man this[int index] { get =>  mans[index]; set => mans[index] = value; }

        public ListHumans()
        {
            mans = new Man[3];
        }

        public override string ToString()
        {
            string str = "";
            foreach (Man man in mans)  str += man + " | ";
            return str;
        }

    }
}
