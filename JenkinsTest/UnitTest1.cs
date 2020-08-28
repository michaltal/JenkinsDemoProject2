//UnitTestProject.cs - In JenkinsDemoProject solution
using System;
using JenkinsDemoProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace JenkinsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestValid1()
        {
            squareroot TestValid = new JenkinsDemoProject.squareroot();
            TestValid.ClearFile(@"C:\Jenkins\Res.txt");
            double result = TestValid.square_root(4);
            TestValid.LogToFile(result);
            result = TestValid.square_root(100);
            TestValid.LogToFile(result);
        }
    }
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestInvalid1()
        {
            JenkinsDemoProject.squareroot TestInvalid = new JenkinsDemoProject.squareroot();
            //TestInvalid.ClearFile(@"C:\Jenkins\Res.txt");
            double result = TestInvalid.square_root(-10);
            TestInvalid.LogToFile(result);
            result = TestInvalid.square_root(-100);
            TestInvalid.LogToFile(result);
        }
    }

}

