using System;

namespace CSharpExtensibleListsAndOrders.Models
{
    public class CurrentAccount : IComparable
    {

        public CurrentAccount(int number, int agency)
        {
            this.Number = number;
            this.Agency = agency;
        }

        public int Number { get; set; }
        public int Agency { get; set; }

        public int CompareTo(object? obj)
        {
            //Retornar um número negativo quando sua instância(this) possuir precedência sobre o objeto obj;
            //Retornar 0 quando a instância e obj forem equivalentes na ordenação;
            //Retornar um número positivo diferente de 0 quando a precedência for do obj.

            var otherCurrentAccount = (CurrentAccount) obj;

            if (otherCurrentAccount == null)
            {
                return -1;
            }

            if (Number < otherCurrentAccount.Number)
            {
                return -1;
            }

            if (Number == otherCurrentAccount.Number)
            {
                return 0;
            }

            return 1;
        }
    }
}