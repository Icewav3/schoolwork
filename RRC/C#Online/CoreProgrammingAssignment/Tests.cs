using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CoreProgrammingAssignment
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void YourNameTest()
        {
            String name = "Cole Dorman";
            String expected = "Cole Dorman";
            String actual = name;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RetirementTest()
        {
            int num1 = 7, num2 = 8;
            int age = num1 * num2;
            if (age >= 55)
            {
                Console.WriteLine("Time to retire");
            }
            else
            {
                Console.WriteLine("You have a little more work ahead");
            }
            int expected = 56;
            int actual = age;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FactorsOf32ArrayTest()
        {
            int[] array1 = { 1, 2, 4, 8, 16, 32 };
            int[] array2 = { 32, 16, 8, 4, 2, 1 };
            int expected = 32;
            for (int i=0; i<array1.Length; i++)
            {
                Assert.AreEqual(expected, array1[i]*array2[i]);
            }
        }
        [TestMethod]
        public void FactorsOf32DictionaryCatchErrorTest()
        {
            Dictionary<int, int> Dictionary1 = new Dictionary<int, int>();
            int[] array1 = { 1, 2, 4, 8, 16, 32 };
            int[] array2 = { 32, 16, 8, 4, 2, 1 };
            int expected = 32;
            int actual;
            int count = 0;
            for (int i=0; i<array1.Length; i++)
            {
                Dictionary1.Add(array1[i], array2[i]);
            }
            //extra testing-->
            //Assert.AreEqual(6, Dictionary1.Count);
            for (int i=0; i<33; i++)
            {
                try 
                {
                    actual = Dictionary1[i] * i;
                    Assert.AreEqual(expected, actual); 
                    count++; 
                }
                catch {}
            }
            Assert.AreEqual(6, count);
        }
        [TestMethod]
        public void FactorsOf32DictionaryProactiveTest()
        {
            Dictionary<int, int> Dictionary1 = new Dictionary<int, int>();
            int[] array1 = { 1, 2, 4, 8, 16, 32 };
            int[] array2 = { 32, 16, 8, 4, 2, 1 };
            int expected = 32;
            for (int i = 0; i < array1.Length; i++)
            {
                Dictionary1.Add(array1[i], array2[i]);
            }
            for (int i = 0; i < 33; i++)
            {
                if (Dictionary1.ContainsKey(i))
                {
                    Assert.AreEqual(expected, Dictionary1[i] * i);
                }
            }
        }
    }
}
