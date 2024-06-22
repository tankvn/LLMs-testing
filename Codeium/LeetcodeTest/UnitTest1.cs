using Leetcode;

namespace LeetcodeTest;

public class UnitTest1
{
	[Fact]
	public void TwoSum_WhenGivenAnInputOfTwoElementsThatSumToEight_ReturnsTheIndices()
	{
		// Arrange
		int[] nums = { 2, 6 };
		int target = 8;
		int[] expected = { 0, 1 };

		// Act
		int[] result = Program.TwoSum(nums, target);

		// Assert
		Assert.Equal(expected, result);
	}

	[Fact]
	public void TwoSum_WhenGivenAnInputOfThreeElementsThatSumToSeven_ReturnsTheIndices()
	{
		// Arrange
		int[] nums = { 2, 3, 4 };
		int target = 7;
		// Assert.Equal() Failure: Collections differ Expected: [0, 2], Actual: [1, 2]
		// int[] expected = { 0, 2 };
		int[] expected = { 1, 2 };

		// Act
		int[] result = Program.TwoSum(nums, target);

		// Assert
		Assert.Equal(expected, result);
	}

	[Fact]
	public void TwoSum_WhenGivenAnInputOfFourElementsThatSumToThree_ReturnsTheIndices()
	{
		// Arrange
		int[] nums = { 3, 2, 4 };
		int target = 6;
		int[] expected = { 1, 2 };

		// Act
		int[] result = Program.TwoSum(nums, target);

		// Assert
		Assert.Equal(expected, result);
	}

	[Fact]
	public void TwoSum_WhenGivenAnInputOfNoSolution_ThrowsException()
	{
		// Arrange
		int[] nums = { 3, 2, 4 };
		int target = 10;

		// Act & Assert
		Assert.Throws<Exception>(() => Program.TwoSum(nums, target));
	}
}
