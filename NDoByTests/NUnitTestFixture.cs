using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using NDoBy;

namespace NDoByTests
{
    [TestFixture]
    public class NUnitTestFixture
    {
        [Test]
        public void PastTodoShouldThrowExceptionWithNDoByEnabled()
        {
            Environment.SetEnvironmentVariable("NDoByEnabled", "1");
            Assert.Throws<Exception>(delegate { new ToDo("Test ToDo", DateTime.Now.AddSeconds(-1)); });
        }

        [Test]
        public void FutureTodoShouldntThrowExceptionWithNDoByEnabled()
        {
            Environment.SetEnvironmentVariable("NDoByEnabled", "1");
            Assert.DoesNotThrow(delegate { new ToDo("Test ToDo", DateTime.Now.AddDays(1)); });
        }

        [Test]
        public void PastTodoShouldntThrowExceptionWithNDoByDisabled()
        {
            Environment.SetEnvironmentVariable("NDoByEnabled", "0");
            Assert.DoesNotThrow(delegate { new ToDo("Test ToDo", DateTime.Now.AddSeconds(-1)); });
        }
    }
}

