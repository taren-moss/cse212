public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Create a queue with the following data: (one, 3), (five, 1), (four, 4), (three, 2)
        // Expected Result: four, one, three, five
        Console.WriteLine("Test 1");
        var data = new PriorityQueue();
        data.Enqueue("one", 3);
        data.Enqueue("five", 1);
        data.Enqueue("four", 4);
        data.Enqueue("three", 2);
        
        Console.WriteLine(data.Dequeue());
        Console.WriteLine(data.Dequeue());
        Console.WriteLine(data.Dequeue());
        Console.WriteLine(data.Dequeue());

        // Defect(s) Found: Dequeue doesn't remove anything from the queue. I found and fixed the issue in PriorityQueue.cs
        // After fixing that I also found another issue; Dequeue was failing to check index 0. I fixed that as well.

        Console.WriteLine("---------");

        // Test 2
        // Scenario: (one, 5), (two, 3), (three, 1), (four, 5), (five, 3) 
        // Expected Result: one, four, two, five, three
        Console.WriteLine("Test 2");
        data.Enqueue("one", 5);
        data.Enqueue("two", 3);
        data.Enqueue("three", 1);
        data.Enqueue("four", 5);
        data.Enqueue("five", 3);

        Console.WriteLine(data.Dequeue());
        Console.WriteLine(data.Dequeue());
        Console.WriteLine(data.Dequeue());
        Console.WriteLine(data.Dequeue());
        Console.WriteLine(data.Dequeue());

        // Defect(s) Found: The code got the order of same-priority objects backwards. I fixed it by changing ">=" to ">" in Dequeue

        Console.WriteLine("---------");

        // Test 3
        // Scenario: just dequeue with empty data
        // Expected Result: Error Message ("The queue is empty.")
        Console.WriteLine("Test 2");
        Console.WriteLine(data.Dequeue());
    }
}