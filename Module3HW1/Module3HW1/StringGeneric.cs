namespace Module3HW1
{
    public static class StringGeneric
    {
        public static void ShowStringGeneric()
        {
            Console.WriteLine("StringGeneric");
            Console.WriteLine("List creation result:");
            string[] myString = { "txt", "word", "pdf" };
            var generic = new MyGeneric<string>(myString);
            generic.PrintArray();
            Console.WriteLine();

            // add new elements to list
            Console.WriteLine();
            Console.WriteLine("The result of adding element from list (added img, jpg):");
            generic.Add("img");
            generic.Add("jpg");
            generic.PrintArray();
            Console.WriteLine();

            // add array to list
            Console.WriteLine();
            string[] myString2 = { "pdf", "epub", "xml" };
            Console.WriteLine("The result of adding array from list (added pdf, epub, xml):");
            generic.AddRange(myString2);
            generic.PrintArray();
            Console.WriteLine();

            // remove element from list
            Console.WriteLine();
            Console.WriteLine("The result of removing element from list (removed pdf):");
            bool isDelete = generic.Remove("pdf");
            generic.PrintArray();
            Console.WriteLine();

            // remove element from list by index
            try
            {
                Console.WriteLine();
                Console.WriteLine("The result of removing element from list by index (removed index 5):");
                generic.RemoveAt(5);
                generic.PrintArray();
                Console.WriteLine();
                Console.WriteLine("The result of removing element from list by index (removed index 29):");
                generic.RemoveAt(29);
                generic.PrintArray();
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // sort list
            Console.WriteLine();
            Console.WriteLine("List sorting result:");
            generic.Sort();
            generic.PrintArray();
        }
    }
}
