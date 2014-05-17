using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NDoBy
{
    public class ToDo
    {
        public ToDo(string message, DateTime deadline)
        {
            if (deadline.CompareTo(DateTime.Now) <= 0 && Environment.GetEnvironmentVariable("NDoByEnabled").Equals("1"))
            {
                throw new Exception("The following ToDo's deadline has passed: " + message);
            }
        }
    }
}
