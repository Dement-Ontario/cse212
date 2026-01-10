using System.Diagnostics;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Problem 1
        // 1. Make a result array that's as long as length
        // 2. Make a for loop where i counts upwards from 1 and stops when i = length
        // 3. Every loop, add number * i to result[i - 1]
        // 4. Return result

        var result = new double[length];

        for (int i = 1; i <= length; ++i)
        {
            result[i - 1] = number * i;
        }
        
        Debug.WriteLine(string.Join(", ", result));
        return result; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Problem 2
        // 1. Use GetRange to copy the last items in the list based on the amount
        //    and put them in their own "last items" array
        // 2. Use RemoveRange to remove the items copied from the original list
        // 3. Use InsertRange to insert the items from the
        //    "last items" array into the start of the list

        var lastItems = data.GetRange(data.Count - amount, amount).ToArray();
        data.RemoveRange(data.Count - amount, amount);
        data.InsertRange(0, lastItems);

        Debug.WriteLine(string.Join(", ", lastItems));
        Debug.WriteLine(string.Join(", ", data));
    }
}
