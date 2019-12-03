using System;

namespace NullableTypes {
    class Program {
        static void Main (string[] args) {
            DateTime? date = null;
            DateTime? date2 = date.GetValueOrDefault ();
            DateTime? date3 = date2;

            System.Console.WriteLine (date3.GetValueOrDefault ());
            System.Console.WriteLine (date.GetValueOrDefault ());
            System.Console.WriteLine (date.HasValue);
            // System.Console.WriteLine (date.Value); throws an exception
        }
    }
}