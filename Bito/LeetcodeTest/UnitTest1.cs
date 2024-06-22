using NUnit.Framework;
using Leetcode;

namespace LeetcodeTest;

public class Tests
{
	[SetUp]
	public void Setup()
	{
	}

	/* 1. Two Sum
	Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
	You may assume that each input would have exactly one solution, and you may not use the same element twice.
	You can return the answer in any order.

	Example 1:
	Input: nums = [2,7,11,15], target = 9
	Output: [0,1]
	Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

	Example 2:
	Input: nums = [3,2,4], target = 6
	Output: [1,2]

	Example 3:
	Input: nums = [3,3], target = 6
	Output: [0,1]
	*/
	[Test]
	public void TwoSum_WithValidInput_ShouldReturnCorrectIndices()
	{
		int[] nums = { 2, 7, 11, 15 };
		int target = 9;
		int[] expected = { 0, 1 };

		int[] result = Program.TwoSum(nums, target);

		Assert.AreEqual(expected, result);
	}

	[Test]
	public void TwoSum_WithNoSolution_ShouldReturnNull()
	{
		int[] nums = { 2, 7, 11, 15 };
		int target = 3;

		int[] result = Program.TwoSum(nums, target);

		Assert.IsNull(result);
	}

	[Test]
	public void TwoSum_WithDuplicateNumbers_ShouldReturnCorrectIndices()
	{
		int[] nums = { 3, 3 };
		int target = 6;
		int[] expected = { 0, 1 };

		int[] result = Program.TwoSum(nums, target);

		Assert.AreEqual(expected, result);
	}

	[Test]
	public void TwoSum_WithEmptyArray_ShouldReturnNull()
	{
		int[] nums = {};
		int target = 9;

		int[] result = Program.TwoSum(nums, target);

		Assert.IsNull(result);
	}
}