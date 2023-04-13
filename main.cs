// Sort Analyzer Start Code

using System;
using System.IO;
using System.Diagnostics;
 
Console.Clear();
#nullable disable


        // LOAD DATA FILES INTO ARRAYS
        int[] randomData = loadDataArray("data-files/random-values.txt");
        int[] reversedData = loadDataArray("data-files/reversed-values.txt");
        int[] nearlySortedData = loadDataArray("data-files/nearly-sorted-values.txt");
        int[] fewUniqueData = loadDataArray("data-files/few-unique-values.txt");
        
        // VERIFY LOADED DATA BY PRINTING 50 ELEMENTS
        printIntArray(randomData, 0, 50);
        printIntArray(reversedData, 0, 50);
        printIntArray(nearlySortedData, 0, 50);
        printIntArray(fewUniqueData, 0, 50);

        // EXAMPLE OF TIMING DURATION OF A SORT ALGORITHM
        // var timer = new Stopwatch();
        // timer.Start();
        // bubbleSort(randomData);
        // timer.Stop();
        // Console.WriteLine($"Bubble Sort Random Data: {timer.Elapsed}");
        
    
    // Function to create an array of integers from provided data file
     static int[] loadDataArray(string fileName) {
        // Read Text File by Line 
        string[] lines = File.ReadAllLines(fileName);

        // Create Array of Integers
        int[] tempData = new int[lines.Length];
        for (int i = 0; i < lines.Length; i++) {
            tempData[i] = Convert.ToInt32(lines[i]);
        }

        // Return Array of Integers
        return tempData;
    }
    
     static void printIntArray(int[] array, int start, int stop) {
        // Print out array elements at index values from start to stop 
        for (int i = start; i < stop; i++) {
            Console.WriteLine(array[i]);
        }
    }

// Bubble Sort
    static void bubbleSort(int[] arr) {
    for (int i = 0; i < arr.Length - 1; i++) {
        for (int j = 0; j < arr.Length - i - 1; j++) {
            if (arr[j] > arr[j + 1]) {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}
    // Selection Sort
static void selectionSort(int[] anArray)
{
    int n = anArray.Length;
    for (int i = 0; i < n - 1; i++)
    {
        int minIndex = i;
        for (int j = i + 1; j < n; j++)
        {
            if (anArray[j] < anArray[minIndex])
            {
                minIndex = j;
            }
        }
        if (minIndex != i)
        {
            int temp = anArray[i];
            anArray[i] = anArray[minIndex];
            anArray[minIndex] = temp;
        }
    }
}

    // Insertion Sort
    static void insertionSort(int[] anArray)
{
    int n = anArray.Length;
    for (int i = 1; i < n; i++)
    {
        int current = anArray[i];
        int j = i - 1;
        while (j >= 0 && anArray[j] > current)
        {
            anArray[j + 1] = anArray[j];
            j--;
        }
        anArray[j + 1] = current;
    }
}


bool loop = true;
           while (loop) {
    Console.WriteLine("1. Run Algorithms for Random Array");
    Console.WriteLine("2. Run Algorithms for Reversed Array");
    Console.WriteLine("3. Run Algorithms for Nearly Sorted Array");
    Console.WriteLine("4. Run Algorithms for Few Unique Array");
    Console.WriteLine("5. Exit");
    string selection = Console.ReadLine();
    if (selection == "1") {
        var timerBubble = new Stopwatch();
        var timerSelection = new Stopwatch();
        var timerInsertion = new Stopwatch();
        timerBubble.Start();
        timerSelection.Start();
        timerInsertion.Start();
        bubbleSort(randomData);
        timerBubble.Stop();
        Console.WriteLine($"Bubble Sort Random Data: {timerBubble.Elapsed}");
        selectionSort(randomData);
        timerSelection.Stop();
        Console.WriteLine($"Selection Sort Random Data: {timerSelection.Elapsed}");
        insertionSort(randomData);
        timerInsertion.Stop();
        Console.WriteLine($"Insertion Sort Random Data: {timerInsertion.Elapsed}");
    } else if (selection == "2") {
        var timerBubble = new Stopwatch();
        var timerSelection = new Stopwatch();
        var timerInsertion = new Stopwatch();
        timerBubble.Start();
        timerSelection.Start();
        timerInsertion.Start();
        bubbleSort(reversedData);
        timerBubble.Stop();
        Console.WriteLine($"Bubble Sort Reversed Data: {timerBubble.Elapsed}");
        selectionSort(reversedData);
        timerSelection.Stop();
        Console.WriteLine($"Selection Sort Reversed Data: {timerSelection.Elapsed}");
        insertionSort(reversedData);
        timerInsertion.Stop();
        Console.WriteLine($"Insertion Sort Reversed Data: {timerInsertion.Elapsed}");
    } else if (selection == "3") {
        var timerBubble = new Stopwatch();
        var timerSelection = new Stopwatch();
        var timerInsertion = new Stopwatch();
        timerBubble.Start();
        timerSelection.Start();
        timerInsertion.Start();
        bubbleSort(nearlySortedData);
        timerBubble.Stop();
        Console.WriteLine($"Bubble Sort Nearly Sorted Data: {timerBubble.Elapsed}");
        selectionSort(nearlySortedData);
        timerSelection.Stop();
        Console.WriteLine($"Selection Sort Nearly Sorted Data: {timerSelection.Elapsed}");
        insertionSort(nearlySortedData);
        timerInsertion.Stop();
        Console.WriteLine($"Insertion Sort Nearly Sorted Data: {timerInsertion.Elapsed}");
    } else if (selection == "4") {
        var timerBubble = new Stopwatch();
        var timerSelection = new Stopwatch();
        var timerInsertion = new Stopwatch();
        timerBubble.Start();
        timerSelection.Start();
        timerInsertion.Start();
        bubbleSort(fewUniqueData);
        timerBubble.Stop();
        Console.WriteLine($"Bubble Sort Few Unique Data: {timerBubble.Elapsed}");
        selectionSort(fewUniqueData);
        timerSelection.Stop();
        Console.WriteLine($"Selection Sort Few Unique Data: {timerSelection.Elapsed}");
        insertionSort(fewUniqueData);
        timerInsertion.Stop();
        Console.WriteLine($"Insertion Sort Few Unique Data: {timerInsertion.Elapsed}");
    } else if (selection == "5") {
        Console.WriteLine("Ending Program...");
        loop = false;
    }
}
