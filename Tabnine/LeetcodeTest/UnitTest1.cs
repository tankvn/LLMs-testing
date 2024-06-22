using NUnit.Framework;
using Leetcode;

namespace LeetcodeTest;

[TestFixture]
public class ProgramTests
{
	[SetUp]
	public void Setup()
	{
	}

	[Test]
	public void TwoSum_NoValidPair_ThrowsArgumentException1()
	{
		int[] nums = { 1, 2, 3, 4 };
		int target = 10;
		Assert.Throws<ArgumentException>(() => Program.TwoSum(nums, target));
	}

	[Test]
	public void TwoSum_NoValidPair_ThrowsArgumentException2()
	{
		int[] nums = { 5, 7, 11, 15 };
		int target = 20;
		int[] expected = { 0, 3 };
		// Assert.Throws<ArgumentException>(() => Program.TwoSum(nums, target));
		int[] result = Program.TwoSum(nums, target);
		Assert.That(result, Is.EqualTo(expected));
	}

	[Test]
	public void TwoSum_NoValidPair_ThrowsArgumentException3()
	{
		int[] nums = { -1, -2, -3, -4 };
		int target = -10;
		Assert.Throws<ArgumentException>(() => Program.TwoSum(nums, target));
	}

	[Test]
	public void TwoSum_NoValidPair_ThrowsArgumentException4()
	{
		int[] nums = { 0, 0, 0, 0 };
		int target = 1;
		Assert.Throws<ArgumentException>(() => Program.TwoSum(nums, target));
	}

	[Test]
	public void TwoSum_NoValidPair_ThrowsArgumentException5()
	{
		int[] nums = { 1, 3, 5, 7 };
		int target = 2;
		Assert.Throws<ArgumentException>(() => Program.TwoSum(nums, target));
	}
}