/*
 * CSE212 
 * (c) BYU-Idaho
 * 03-Prove - Problem 1
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code
 * with others or to post it online.  Storage into a personal and private
 * repository (e.g. private GitHub repository, unshared Google Drive
 * folder) is acceptable.
 */
public static class MysteryStack1 {
    public static string Run(string text) { // Takes input text
        var stack = new Stack<char>(); // Creates a new stack
        foreach (var letter in text) // Iterates through each letter of the input text
            stack.Push(letter); // Each letter gets pushed to the top of the stack

        var result = "";
        while (stack.Count > 0) // Repeats until there's nothing left
            result += stack.Pop(); // The top stack is removed and added to the result

        return result; // The letters are pushed from bottom to top, then popped from top to bottom. This will reverse the input.
    }
}

// RACECAR INPUT
// push r, push a, push c, push e, push c, push a, push r
// pop r, pop a, pop c, pop e, pop c, pop a, pop r
// result: "racecar"

// STRESSED INPUT
// push s, push t, push r, push e, push s, push s, push e, push d
// pop d, pop e, pop s, pop s, pop e, pop r, pop t, pop s
// result: "desserts"

// A NUT FOR A JAR OF TUNA INPUT
// push a, push " ", push n, push u, push t, push " ", push f, push o, push r, push " ", push a, push " ", push j, push a, push r, push " ", push o, push f, push " ", push t, push u, push n, push a
// pop a, pop " ", pop n, pop u, pop t, pop " ", pop f, pop o, pop r, pop " ", pop a, pop " ", pop j, pop a, pop r, pop " ", pop o, pop f, pop " ", pop t, pop u, pop n, pop a
// result: "anut fo raj a rof tun a"