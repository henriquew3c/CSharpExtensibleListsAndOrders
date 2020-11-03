using System.Collections.Generic;
using CSharpExtensibleListsAndOrders.Models;

namespace CSharpExtensibleListsAndOrders.Comparators
{
    public class ComparatorCurrentAccountByAgency : IComparer<CurrentAccount>
    {
        
        public int Compare(CurrentAccount x, CurrentAccount y)
        {
            if (x == y)
            {
                return 0;
            }

            if (x == null)
            {
                return 1;
            }

            if (y == null)
            {
                return -1;
            }

            return x.Agency.CompareTo(y.Agency);

        }
    }
}