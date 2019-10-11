using System;
namespace Humans
{
    public class ListHumans
    {
       private Man[] mans;
       //private Man<> mans;

       public Man this[int index]
        {
            get
            {
                return mans[index];
            }

            set
            {
                mans[index] = value;
            }
        }

        public ListHumans()
        {
            mans = new Man[6];
        }
    }
}
