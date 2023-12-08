using System;
namespace Homework
{
	public class DelegatePredicate
	{
        public delegate bool CheckNums(int a);

        //public bool CheckOddNums(int num) => num % 2 == 1;
        

        //public bool CheckEvenNums(int num) => num % 2 == 0;
       

        public void SumNumsWithConditions(List<int> nums, Predicate<int> func)
        {
            int sum = 0;
            foreach (int item in nums)
            {
                if(func(item)) 
                {
                    sum += item;
                }

                
            }
            Console.WriteLine(sum);
        }

        public void ShowResult()
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6 };

            SumNumsWithConditions(nums, num => num % 2 == 1);
            SumNumsWithConditions(nums, num => num % 2 == 0);
        }
    }
}

