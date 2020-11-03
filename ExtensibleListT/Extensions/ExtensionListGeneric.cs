using System.Collections.Generic;

namespace CSharpExtensibleListsAndOrders.Extensions
{
    public static partial class ExtensionListGeneric
    {
        public static void AddSeveralGeneric<T>(this List<T> listOfIntegers, params T[] items)
        {
            foreach (var item in items)
            {
                listOfIntegers.Add(item);
            }
        }
    }
}