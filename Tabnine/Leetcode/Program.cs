namespace Leetcode;

public class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Hello, World!");
	}

	/* 1. Two Sum
	Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
	You may assume that each input would have exactly one solution, and you may not use the same element twice.
	You can return the answer in any order.
	*/
	public static int[] TwoSum(int[] nums, int target)
	{
		Dictionary<int, int> numDict = new Dictionary<int, int>();
		for (int i = 0; i < nums.Length; i++)
		{
			int complement = target - nums[i];
			if (numDict.ContainsKey(complement))
			{
				return new int[] { numDict[complement], i };
			}
			numDict[nums[i]] = i;
		}
		throw new ArgumentException("No two sum solution");
	}
}