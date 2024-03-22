public static class LinkedListTester {
    public static void Run() {
        // Sample Test Cases (may not be comprehensive) 
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        var ll = new LinkedList();
        ll.InsertTail(1);
        ll.InsertHead(2);
        ll.InsertHead(2);
        ll.InsertHead(2);
        ll.InsertHead(3);
        ll.InsertHead(4);
        ll.InsertHead(5);

        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 4, 3, 2, 2, 2, 1};
        ll.InsertTail(0);
        ll.InsertTail(-1);
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 4, 3, 2, 2, 2, 1, 0, -1};

        var ll2 = new LinkedList();
        ll2.InsertTail(1);
        Console.WriteLine(ll2.HeadAndTailAreNotNull()); // True

        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        ll.RemoveTail();
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 4, 3, 2, 2, 2, 1, 0}
        ll.RemoveTail();
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 4, 3, 2, 2, 2, 1}

        var ll3 = new LinkedList();
        ll3.RemoveTail();
        Console.WriteLine(ll3.ToString()); // <LinkedList>{}
        ll3.InsertHead(2);
        ll3.RemoveTail();
        Console.WriteLine(ll3.ToString()); // <LinkedList>{}
        Console.WriteLine(ll3.HeadAndTailAreNull()); // True

        Console.WriteLine("\n=========== PROBLEM 3 TESTS ===========");
        ll.InsertAfter(3, 35);
        ll.InsertAfter(5, 6);
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 6, 4, 3, 35, 2, 2, 2, 1}
        ll.Remove(-1);
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 6, 4, 3, 35, 2, 2, 2, 1}
        ll.Remove(3);
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 6, 4, 35, 2, 2, 2, 1}
        ll.Remove(6);
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 4, 35, 2, 2, 2, 1}
        ll.Remove(1);
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 4, 35, 2, 2, 2}
        ll.Remove(7);
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 4, 35, 2, 2, 2}
        ll.Remove(5);
        Console.WriteLine(ll.ToString()); // <LinkedList>{4, 35, 2, 2, 2}
        ll.Remove(2);
        Console.WriteLine(ll.ToString()); // <LinkedList>{4, 35, 2, 2}

        var ll4 = new LinkedList();
        ll4.Remove(0);
        Console.WriteLine(ll4.ToString()); // <LinkedList>{}
        ll4.InsertHead(2);
        ll4.Remove(2);
        Console.WriteLine(ll4.ToString()); // <LinkedList>{}
        Console.WriteLine(ll4.HeadAndTailAreNull()); // True

        Console.WriteLine("\n=========== PROBLEM 4 TESTS ===========");
        ll.Replace(2, 10);
        Console.WriteLine(ll.ToString()); // <LinkedList>{4, 35, 10, 10}
        ll.Replace(7, 5);
        Console.WriteLine(ll.ToString()); // <LinkedList>{4, 35, 10, 10}
        ll.Replace(4, 100);
        Console.WriteLine(ll.ToString()); // <LinkedList>{100, 35, 10, 10}


        Console.WriteLine("\n=========== PROBLEM 5 TESTS ===========");
        Console.WriteLine(ll.Reverse().AsString()); // <IEnumerable>[10, 10, 35, 100}


        Console.WriteLine("\n=========== OTHER TESTS ===========");
        var test = new LinkedList();
        Console.WriteLine(test.ToString()); // <LinkedList>{}
        test.InsertHead(9);
        Console.WriteLine(test.ToString()); // <LinkedList>{9}
        test.InsertTail (10);
        Console.WriteLine(test.ToString()); // <LinkedList>{9, 10}
        test.InsertAfter(9, 12);
        Console.WriteLine(test.ToString()); // <LinkedList>{9, 12, 10}
        test.InsertHead(10);
        test.InsertTail(9);
        Console.WriteLine(test.ToString()); // <LinkedList>{10, 9, 12, 10, 9}
        test.Replace(9, -9);
        test.Replace(10, 22);
        test.Remove(22);
        Console.WriteLine(test.ToString()); // <LinkedList>{-9, 12, 22, -9}
        test.Remove(-9);
        Console.WriteLine(test.ToString()); // <LinkedList>{12, 22, -9}
        test.Remove(-9);
        Console.WriteLine(test.ToString()); // <LinkedList>{12, 22}
        test.Remove(12);
        Console.WriteLine(test.ToString()); // <LinkedList>{22}
        test.Remove(22);
        Console.WriteLine(test.ToString()); // <LinkedList>{}
        test.InsertHead(1);
        test.InsertTail(11);
        test.InsertHead(111);
        Console.WriteLine(test.Reverse().AsString()); // <LinkedList>{11, 1, 111}
        // This test was added late. I actually found and fixed an error because of it.
    }
}