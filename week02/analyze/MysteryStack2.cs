/*
 * CSE212 
 * (c) BYU-Idaho
 * 03-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code
 * with others or to post it online.  Storage into a personal and private
 * repository (e.g. private GitHub repository, unshared Google Drive
 * folder) is acceptable.
 */
public static class MysteryStack2 {
    private static bool IsFloat(string text) {
        return float.TryParse(text, out _);
    }

    public static float Run(string text) {
        var stack = new Stack<float>(); // Makes a new stack
        foreach (var item in text.Split(' ')) { // This looks like it splits the input into parts
            if (item == "+" || item == "-" || item == "*" || item == "/") { // This checks for each part having a mathematical operator
                if (stack.Count < 2) // Checks to make sure the stack is at least 2
                    throw new ApplicationException("Invalid Case 1!"); // It seems it's not allowed to be less than 2

                var op2 = stack.Pop(); // This pulls the top of the stack and sets it as "op2"
                var op1 = stack.Pop(); // This pulls the next part of the stack and sets it as "op1"
                float res;
                if (item == "+") {
                    res = op1 + op2; // So item is the operator, and these set the logic for op1 and op2, which are clearly intended to be numbers
                }
                else if (item == "-") {
                    res = op1 - op2;
                }
                else if (item == "*") {
                    res = op1 * op2;
                }
                else {
                    if (op2 == 0)
                        throw new ApplicationException("Invalid Case 2!"); // This is a check for divide by 0

                    res = op1 / op2;
                }

                stack.Push(res); // This pushes the result back in the stack.
            }
            else if (IsFloat(item)) {
                stack.Push(float.Parse(item)); // If there's no mathematical operator it checks if the input is a float
            }
            else if (item == "") { // Does nothing if item is blank
            }
            else {
                throw new ApplicationException("Invalid Case 3!"); // Catchest anything else
            }
        }

        if (stack.Count != 1)
            throw new ApplicationException("Invalid Case 4!"); // There can only be one object in the end, otherwise something went wrong

        return stack.Pop(); // return the result
    }
}

// If the input is something like "5 + 2" then it will push 5 as a float, then it will
// see "+" and try to add them together, but it will fail because it hasn't seen 2 yet.
// This code will not work



// INPUT: "5 3 7 + *"
// Sees 5, 3, and 7 and pushes them
    // Stack: 5, 3, 7

// Sees "+", op2 = pop 7, op1 = pop 3, result: 3 + 7 = 10
    // Pushes 10
    // New stack: 5, 10

// Sees "*", op2 = pop 5, op1 = pop 10, result: 5 * 10 = 50
    // Pushes 50
    // New stack: 50

// Returns 50



// INPUT: "6 2 + 5 3 - /"
// Sees 6 and 2 and pushes them
    // Stack: 6, 2

// Sees "+", op2 = pop 2, op1 = pop 6, result: 6 + 2 = 8
    // Pushes 8
    // Stack: 8

// Sees 5 and 3 and pushes them
    // Stack: 8, 5, 3

// Sees "-", op2 = 3, op1 = 5, result: 5 - 3 = 2
    // Pushes 2
    // Stack: 8, 2

// Sees "/", op2 = 2, op1 = 8, result: 8 / 2 = 4
    // Pushes 4
    // Stack: 4

// Returns 4



// Invalid Case 1 Input: "3"
// Invalid Case 2 Input: "2 0 /"
// Invalid Case 3 Input: " "
// Invalid Case 4 Input: "1 2 3 4 5 +"