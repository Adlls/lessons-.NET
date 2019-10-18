using System;
using System.Collections.Generic;

namespace Humans
{
    public class ListHumans
    {
       private Man[] mans;
        //LinkedList<string> linkedList = new LinkedList<string>();
        

        public Man this[int index] {
            get
            {
                try { return mans[index]; }
                catch (Exception ex)
                {
                    Console.WriteLine("Cannot find human for index - " + index);
                    return null;
                }
            }

            set
            {
                Man[] oldmans = mans;
                mans = new Man[index+1];
                for (int i = 0; i < index; i++) mans[i] = oldmans[i];
                mans[index] = value;
            }
        }

        public ListHumans()
        {
            //mans = new Man[3];

            
        }

        public override string ToString()
        {
            string str = "";
            foreach (Man man in mans)  str += man + " | ";
            return str;
        }

    }
}
