using System.Collections.Generic;

namespace CSharpExtensibleListsAndOrders.Extensions
{
    public static partial class ExtensionList
    {
        public static void AddSeveral(this List<int> listOfIntegers, params int[] items)
        {
            foreach (var item in items)
            {
                listOfIntegers.Add(item);
            }

        }

    }
}