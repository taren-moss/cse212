using System.ComponentModel.DataAnnotations;

public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}

        var la = new[] {'A', 'B', 'C', 'D', 'E'}; // Apparently these are seen as characters rather than strings
        var lb = new[] {'Z', 'Y', 'X', 'W', 'V'};
        select = new[] {1, 2, 2, 1, 2, 1, 1, 2, 2, 1};
        var charResult = ListSelector(la, lb, select);
        Console.WriteLine("<char[]>{" + string.Join(", ", charResult) + "}"); // <str[]>{A, Z, Y, B, X, C, D, W, V, E}
    }

    // This one's a bit straightforward

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        var listLength = select.Length;
        var output = new int[listLength];
        var index1 = 0; 
        var index2 = 0;

        for (int i = 0; i < listLength; i++) {
            if (select[i] == 1) {
                output[i] = list1[index1];
                index1 += 1;
            }
            else {
                output[i] = list2[index2];
                index2 += 1;
            }

        }
        return output;
    }

    private static char[] ListSelector(char[] list1, char[] list2, int[] select)
    {
        var listLength = select.Length;
        var output = new char[listLength];
        var index1 = 0; 
        var index2 = 0;

        for (int i = 0; i < listLength; i++) {
            if (select[i] == 1) {
                output[i] = list1[index1];
                index1 += 1;
            }
            else {
                output[i] = list2[index2];
                index2 += 1;
            }

        }
        return output;
    }
}