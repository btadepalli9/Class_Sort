/*
Author: Bhavana Tadepalli
Date: 2/28/2024
Comments: Used the selection sort process for sorting the numbers
*/

int[] selection_sort_numbers = { 3, 62, 5, 16, 4, 10 };
Console.WriteLine("the Selection Sort Algorithm: ");
for (int i = 0; i < selection_sort_numbers.Length; i++)
{
    Console.Write("  " + selection_sort_numbers[i]);
}
Console.WriteLine("");
Console.WriteLine("Here is the array after the execution of the Selection Sort Algorithm: ");
Selection_Sort(selection_sort_numbers);
Console.WriteLine("");

static void Selection_Sort(int[] ss_arr)
{
    // low value
    int min_position;
    // used to store the temp value
    int temp;

    for (int i = 0; i < ss_arr.Length; i++)
    {
        // Min position
        min_position = i;
        //  next element is smaller
        for (int x = i + 1; x < ss_arr.Length; x++)
        {
           
            if (ss_arr[x] < ss_arr[min_position])
            {
                
                min_position = x;
            }
        } 
        //end
       
        if (min_position != i)
        {
            temp = ss_arr[i];
            ss_arr[i] = ss_arr[min_position];
            ss_arr[min_position] = temp;
        }
        Console.Write("  " + ss_arr[i]);
    } 
} 

