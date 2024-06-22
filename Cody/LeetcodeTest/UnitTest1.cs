using Leetcode;

namespace LeetcodeTest;

[TestClass]
public class UnitTest1
{
	[TestMethod]
	public void TwoSum_ValidInput_ReturnsCorrectIndices()
	{
		int[] nums = { 2, 7, 11, 15 };
		int target = 9;
		int[] expected = { 0, 1 };

		int[] result = Program.TwoSum(nums, target);

		CollectionAssert.AreEqual(expected, result);
	}

	[TestMethod]
	public void TwoSum_EmptyArray_ReturnsNull()
	{
		int[] nums = { };
		int target = 9;

		int[] result = Program.TwoSum(nums, target);

		Assert.IsNull(result);
	}

	[TestMethod]
	public void TwoSum_NoSolution_ReturnsNull()
	{
		int[] nums = { 1, 2, 3 };
		int target = 10;

		int[] result = Program.TwoSum(nums, target);

		Assert.IsNull(result);
	}

	[TestMethod]
	public void TwoSum_DuplicateNumbers_ReturnsCorrectIndices()
	{
		int[] nums = { 3, 2, 4, 2 };
		int target = 6;
		// CollectionAssert.AreEqual failed. (Element at index 1 do not match.)
		// int[] expected = { 1, 3 };
		int[] expected = { 1, 2 };

		int[] result = Program.TwoSum(nums, target);

		CollectionAssert.AreEqual(expected, result);
	}
}