using System;

namespace NullableTypes {
    class Program {
        static void Main (string[] args) {
            DateTime? date = null;
            System.Console.WriteLine (date.GetValueOrDefault ());
            System.Console.WriteLine (date.HasValue);
            // System.Console.WriteLine (date.Value); throws an exception
        }
    }
}