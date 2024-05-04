using System;

class Program
{
    static int NumRescueBoats(int[] people, int limit)
    {
        // Sort the people array
        Array.Sort(people);

        int left = 0; // Pointer to the lightest person
        int right = people.Length - 1; // Pointer to the heaviest person
        int boats = 0; // To keep track of the number of boats used

        // Use a two-pointer approach
        while (left <= right)
        {
            // If the combined weight of the lightest and heaviest person is within the limit,
            // move both pointers inward
            if (people[left] + people[right] <= limit)
            {
                left++;
                right--;
            }
            else
            {
                // If they can't be paired, the heaviest person goes alone
                right--;
            }
            
            // Increment the boat count
            boats++;
        }

        return boats;
    }

    static void Main()
    {
        // Example usage:
        int[] people = { 3, 2, 2, 1 };
        int limit = 3;
        
        // Call the function and print the result
        int result = NumRescueBoats(people, limit);
        Console.WriteLine($"Minimum number of boats needed: {result}");
    }
}
