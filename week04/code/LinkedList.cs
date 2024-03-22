using System.Collections;

public class LinkedList : IEnumerable<int> {
    private Node? _head;
    private Node? _tail;

    /// <summary>
    /// Insert a new node at the front (i.e. the head) of the linked list.
    /// </summary>
    public void InsertHead(int value) {
        // Create new node
        Node newNode = new Node(value);
        // If the list is empty, then point both head and tail to the new node.
        if (_head is null) {
            _head = newNode;
            _tail = newNode;
        }
        // If the list is not empty, then only head will be affected.
        else {
            newNode.Next = _head; // Connect new node to the previous head
            _head.Prev = newNode; // Connect the previous head to the new node
            _head = newNode; // Update the head to point to the new node
        }
    } // I think this function is O(1)

    /// <summary>
    /// Insert a new node at the back (i.e. the tail) of the linked list.
    /// </summary>
    public void InsertTail(int value) {
        Node newTail = new Node(value);
        if (_tail is null) { // If there's nothing, the new tail will also be the new head
            _head = newTail;
            _tail = newTail;
        }
        else { 
            newTail.Prev = _tail; // The new tail's previous is the current tail
            _tail.Next = newTail; // The current tail's next if the new tail
            _tail = newTail; // The new tail officially becomes the current tail
        }
    } // I think this function is O(1)


    /// <summary>
    /// Remove the first node (i.e. the head) of the linked list.
    /// </summary>
    public void RemoveHead() {
        // If the list has only one item in it, then set head and tail 
        // to null resulting in an empty list.  This condition will also
        // cover an empty list.  Its okay to set to null again.
        if (_head == _tail) {
            _head = null;
            _tail = null;
        }
        // If the list has more than one item in it, then only the head
        // will be affected.
        else if (_head is not null) {
            _head.Next!.Prev = null; // Disconnect the second node from the first node
            _head = _head.Next; // Update the head to point to the second node
        }
    } // I think this function is O(1)


    /// <summary>
    /// Remove the last node (i.e. the tail) of the linked list.
    /// </summary>
    public void RemoveTail() {
        if (_tail == _head) { // The list will be empty if there's only one thing and it gets deleted
            _tail = null;
            _head = null;
        }
        else if (_tail is not null) {
            _tail.Prev!.Next = null; // I suppose this looks at the tail, moves back 1, and then changes the new target's next pointer
            _tail = _tail.Prev; // I assume without any pointers, the old data is basically invisible and will be overwritten with new data eventually
        }
    } // I think this function is O(1)

    /// <summary>
    /// Insert 'newValue' after the first occurrence of 'value' in the linked list.
    /// </summary>
    public void InsertAfter(int value, int newValue) {
        // Search for the node that matches 'value' by starting at the 
        // head of the list.
        Node? curr = _head;
        while (curr is not null) {
            if (curr.Data == value) {
                // If the location of 'value' is at the end of the list,
                // then we can call insert_tail to add 'new_value'
                if (curr == _tail) {
                    InsertTail(newValue);
                }
                // For any other location of 'value', need to create a 
                // new node and reconnect the links to insert.
                else {
                    Node newNode = new(newValue);
                    newNode.Prev = curr; // Connect new node to the node containing 'value'
                    newNode.Next = curr.Next; // Connect new node to the node after 'value'
                    curr.Next!.Prev = newNode; // Connect node after 'value' to the new node
                    curr.Next = newNode; // Connect the node containing 'value' to the new node
                }

                return; // We can exit the function after we insert
            }

            curr = curr.Next; // Go to the next node to search for 'value'
        }
    } // This function is O(n)

    /// <summary>
    /// Remove the first node that contains 'value'.
    /// </summary>
    public void Remove(int value) {
        Node? current = _head; // I don't even know if this will work
        var valueRemoved = false; // This one was tricky. I needed to add this check so it would stop removing information after the first time
        while (current is not null) {
            if (current.Data == value) { // If the current value is the target value, do the thing
                if (valueRemoved == false) {
                    if (current == _head) {
                        RemoveHead(); // Remove the head if the current value that is the target value is the head
                    }
                    else if (current == _tail) {
                        RemoveTail(); // Remove the tail if the current value that is the target value is the tail
                    }
                    else {
                        current.Next!.Prev = current.Prev; // I'm attempting to connect the previous node's next pointer to the next node
                        current.Prev!.Next = current.Next; // And here to connect the next node's previous pointer to the previous node
                    }
                }
                valueRemoved = true;
            }

            current = current.Next; // Go to the next node to repeat the check
        }   
    } // I believe this function is O(n)

    /// <summary>
    /// Search for all instances of 'oldValue' and replace the value to 'newValue'.
    /// </summary>
    public void Replace(int oldValue, int newValue) {
        Node? current = _head;
        while (current is not null) {
            if (current.Data == oldValue) {
                current.Data = newValue;
            }

            current = current.Next;
        }
    } // This function is O(n)

    /// <summary>
    /// Yields all values in the linked list
    /// </summary>
    IEnumerator IEnumerable.GetEnumerator() {
        // call the generic version of the method
        return this.GetEnumerator();
    }

    /// <summary>
    /// Iterate forward through the Linked List
    /// </summary>
    public IEnumerator<int> GetEnumerator() {
        var curr = _head; // Start at the beginning since this is a forward iteration.
        while (curr is not null) {
            yield return curr.Data; // Provide (yield) each item to the user
            curr = curr.Next; // Go forward in the linked list
        }
    } // This function is O(n)

    /// <summary>
    /// Iterate backward through the Linked List
    /// </summary>
    public IEnumerable Reverse() {
        var current = _tail;
        while (current is not null) {
            yield return current.Data;
            current = current.Prev;
        }
    } // This function is O(n)

    public override string ToString() {
        return "<LinkedList>{" + string.Join(", ", this) + "}";
    }

    // Just for testing.
    public Boolean HeadAndTailAreNull() {
        return _head is null && _tail is null;
    }

    // Just for testing.
    public Boolean HeadAndTailAreNotNull() {
        return _head is not null && _tail is not null;
    }
}
// All the tests pass so I think that's everything for this assignment? That was surprisingly quick and easy.
// Maybe too quick and easy. Did I miss or forget something?