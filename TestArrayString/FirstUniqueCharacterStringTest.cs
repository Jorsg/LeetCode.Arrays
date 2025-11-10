using LeetCode.HashTable;
namespace TestArrayString
{
    [TestClass]
    public sealed class FirstUniqueCharacterStringTest
    {
        [TestMethod]
        public void firstUniquCharTest()
        {
            //Example 1:	
            //Input: s = "leetcode"
            //Output: 0
            var result1 = FirstUniqueCharacterString.firstUniqChar("leetcode");
            Assert.AreEqual(0, result1);
            //Example 2:		
            //Input: s = "loveleetcode"
            //Output: 2
            var result2 = FirstUniqueCharacterString.firstUniqChar("loveleetcode");
            Assert.AreEqual(2, result2);
            //Example 3:		
            //Input: s = "aabb"
            //Output: -1
            var result3 = FirstUniqueCharacterString.firstUniqChar("aabb");
            Assert.AreEqual(-1, result3);
        }

        [TestMethod]
        public void IsUniqueTest()
        {
            var result1 = FirstUniqueCharacterString.IsUnique("letcod");
            Assert.IsTrue(result1);
            var result2 = FirstUniqueCharacterString.IsUnique("loveleetcode");
            Assert.IsFalse(result2);
            var result3 = FirstUniqueCharacterString.IsUnique("aabb");
            Assert.IsFalse(result3);
        }

        [TestMethod]
        public void MajorityElementTest()
        {
            var result1 = FirstUniqueCharacterString.MajorityElement(new int[] { 3, 2, 3 });
            Assert.AreEqual(3, result1);
            var result2 = FirstUniqueCharacterString.MajorityElement(new int[] { 2, 2, 1, 5, 1, 2, 2 });
            Assert.AreEqual(2, result2);
        }
    }
}
