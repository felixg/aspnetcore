﻿
namespace SimpleMvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Just make sure we have a reference to the MVC 2.2
            var t = typeof(Microsoft.AspNetCore.Mvc.IActionResult);
            System.Console.WriteLine(t.FullName);
        }
    }
}
