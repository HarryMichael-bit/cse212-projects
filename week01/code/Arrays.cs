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
        // Plan:
        // 1) Create a new array of size 'length' to hold the multiples. 
        // 2) The first element should be 'number' itself.
        // 3) Each subsequent element is number * (index + 1).
        // 4) Use a for loop from i = 0 to i < length:
        //    - Compute currentMultiple = number * (i + 1).
        //    - Store it in result[i].
        // 5) Return the filled array.
        // 6) Assumptions: 'length' is a positive integer > 0, 'number' can be any double.
        // 7) Example: MultipleOf(7, 5) => {7, 14, 21, 28, 35}.

        var result = new double[length];
        for ( int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        return result;
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
        // Plan: 
        // 1) Normalize 'amount' using modulo: amount = amount % data.Count.
        //    - If ammount == 0, no rotation is needed; return.
        // 2) Identify the split point where the list will be cut: 
        //    - Split index = data.Count - amount.
        // 3) Extract the tail segment that will move to the front:
        //    - tail = data.GetRange(splitIndex, amount).
        // 4) Remove the tail from its original position:
        //    - data.RemoveRange(splitIndex, amount).
        // 5) Insert the tail at the beginning:
        //    - data.InsertRange(0, tail).
        // 6) This modifies 'data' in place as required. 
        // 7) Example: data = {1,2,3,4,5,6,7,8,9}, amount = 3
        //    - splitIndex = 9 - 3 = 6
        //    - tail = {7,8,9}
        //    - result = {7,8,9,1,2,3,4,5,6}

        int n = data.Count;
        if (n == 0) return;

        amount = amount % n;
        if (amount == 0) return;

        int splitIndex = n - amount;
        var tail = data.GetRange(splitIndex, amount);
        data.RemoveRange(splitIndex, amount);
        data.InsertRange(0, tail);
    }
}
