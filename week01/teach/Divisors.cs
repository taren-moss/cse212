public static class Divisors {
    /// <summary>
    /// Entry point for the Divisors class
    /// </summary>
    public static void Run() {
        List<int> list = FindDivisors(80);
        Console.WriteLine("<List>{" + string.Join(", ", list) + "}"); // <List>{1, 2, 4, 5, 8, 10, 16, 20, 40}
        List<int> list1 = FindDivisors(79);
        Console.WriteLine("<List>{" + string.Join(", ", list1) + "}"); // <List>{1}
    }

    /// <summary>
    /// Create a list of all divisors for a number including 1
    /// and excluding the number itself. Modulo will be used //
    /// to test divisibility.
    /// </summary>
    /// <param name="number">The number to find the divisor</param>
    /// <returns>List of divisors</returns>
    
    // What is Modulo?
    // Oh, it's "%"
    // So the remainder checky thing
    // That makes sense

    private static List<int> FindDivisors(int number) {
        List<int> results = new List<int>();
        for (int num = 1; num < number; num++) // Don't set num to 0, it will try to divide by 0 and it will die
        {
            if (number % num == 0) {
                // Console.WriteLine(num);
                results.Add(num); // Append doesn't seem to work here
            }
        }
        return results;
    }
}