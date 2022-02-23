namespace Module3HW1
{
    public static class IntGeneric
    {
        public static void ShowIntGeneric()
        {
            // create list
            Console.WriteLine("IntGeneric");
            Console.WriteLine("List creation result:");
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            var generic = new MyGeneric<int>(arr);
            generic.PrintArray();
            Console.WriteLine();

            // add new elements to list
            Console.WriteLine();
            Console.WriteLine("The result of adding element from list (added 12, 24):");
            generic.Add(12);
            generic.Add(24);
            generic.PrintArray();
            Console.WriteLine();

            // add array to list
            Console.WriteLine();
            int[] arr2 = { 11, 12, 13 };
            Console.WriteLine("The result of adding array from list (added 11, 12, 13):");
            generic.AddRange(arr2);
            generic.PrintArray();
            Console.WriteLine();

            // remove element from list
            Console.WriteLine();
            Console.WriteLine("The result of removing element from list (removed 12):");
            bool isDelete = generic.Remove(12);
            generic.PrintArray();
            Console.WriteLine();

            // remove element from list by index
            Console.WriteLine();
            try
            {
                Console.WriteLine("The result of removing element from list by index (removed index 5):");
                generic.RemoveAt(5);
                generic.PrintArray();
                Console.WriteLine();
                Console.WriteLine("The result of removing element from list by index (removed index 29):");
                generic.RemoveAt(29);
                generic.PrintArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();

            // sort list
            Console.WriteLine("List sorting result:");
            generic.Sort();
            generic.PrintArray();
            Console.WriteLine();
        }
    }
}
