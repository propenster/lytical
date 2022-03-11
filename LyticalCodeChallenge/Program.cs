using System;
using System.Collections.Generic;

namespace LyticalCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
        // A transaction is possibly invalid if:

        //the amount exceeds $1000, or;
        //if it occurs within(and including) 60 minutes of another transaction with the same name in a different city.

        //You are given an array of strings transaction where transactions[i] consists of comma - separated values
        //representing the name, time (in minutes), amount, and city of the transaction.

        //Return a list of transactions that are possibly invalid. You may return the answer in any order.

        //Input: transactions = ["alice,20,800,ph", "alice,50,100,lagos"]
        //Output:["alice,20,800,ph","alice,50,100,lagos"]
        //Input: transactions = ["alice,20,800,ph", "alice,50,1200,ph"]
        //Output:["alice,50,1200,ph"]

            Console.WriteLine("Hello World!");
            var transactions = new string[] { "alice,20,800,ph", "alice,50,100,lagos" };

            // Time: On Space: On
            var res = new List<string>();
            foreach(var item in trans)




            


        }



        private bool CheckAmountIsValid(decimal amount)
        {
            bool amountIsValid = true;
            if (amount > 1000) amountIsValid = false;


            return amountIsValid;
        }
        private bool CheckNamesAreValid(string firstName, string lastName)
        {
            bool namesAreValid = true;
            if (firstName.ToLower().Equals(lastName.ToLower())) namesAreValid = false;

            return namesAreValid;
        }
        private List<string> FetchStringsFromArray(string[] list)
        {
            var resultString = new List<string>();
            for(int i = 0; i<list.Length; i++)
            {
                resultString.Add(list[i]);
            }

            return resultString;
        }
    }
}
