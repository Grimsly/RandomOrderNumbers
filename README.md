# RandomOrderNumbers
 
## Running the program

### Running the program using command prompt

1) To run the program in a Windows machine using the command prompt, first cd in to the folder containing the cs files, enter in 
	
 	C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe /out:RandomOrderNumbers.exe Program.cs Shuffle.cs

2) Then just run the compiled build by entering
	
	RandomOrderNumbers.exe
 
### Running the program in Visual Studio

1) If compatitable with your Visual Studio, open the "RandomOrderNumbers" project by using "RandomOrderNumbers.sln" in the "RandomOrderNumbers" folder.

2) Once the project is opened, press "CTRL + F5".

3) Another way to launch the project is to go to the folder bin > Release and launch RandomOrderNumbers.exe.


## Flowchart

For enquiries on how the program works, I have created a flowchart that is in the same folder as this file, named "RandomOrderNumbersFlowchart.png" in the "Flowchart" folder.

For a basic rundown, it first receives a range of integers, in this program's case 1-10000, and then inserts them all into a list.
Then it would randomly shuffle the integers using the Fisher-Yates shuffle (or the Knuth shuffle).
Finally, it would print out the shuffled list of integers to the console.


## Design

Although the program is relatively simple, I seperated the Shuffle function from the main class to try to follow the Command design pattern.
Other classes can also use the shuffle function if ever the project were to expand.


## Reflection

I will preface this by saying that I have had used this solution before, so it was not really new to me.

There were other different ways that I could have solved it like using the LINQ's OrderBy() method instead and then inserting a random number into it like so, OrderBy(r => rand.Next()).
The entire process would have been done in just one line List<int> list = Enumerable.Range(1, 10000).OrderBy(r => rand.Next()).ToList();
But I did more research into it and found out that OrderBy() uses QuickSort which is O(n log n) and in the worst case, O(n^2)

The other way I thought of then was for efficiency was to go through the entire list, get a random number from 0 to List.Count - 1 (which is the last element of the list),
and then swap the current index's element with the element at the index using the random number.
The runtime is O(n) which is better for much bigger datasets than O(n log n) and O(n^2)
The problem was with that solution, there are chances that I could be swapping the same number multiple times, like for example with a list of 1-5:

**1 2 3 4 5**

**3 2 1 4 5**	Current index is 0 (element being 1) and 1 got swapped with 3

**3 1 2 4 5**	Current index is 1 (element being 2) and 2 got swapped with 1 again

**3 2 1 4 5**	Current index is 2 (element being 2) and 2 got swapped with 1 again

And this can keep going on again and again with 4 being swapped with 1 and then the same with 5.
This can help introduce a bias where certain permutations will appear more often than other randomly ordered sets, instead of all permutations having an even chance.

Then, I found a better solution which helped prevent that sort of bias by moving the index bit by bit.
The Fisher-Yates shuffle or the Knuth shuffle when it was redesigned to be used for computers, works by first starting at the end of the list.
Once a random number has been found in between 0 and the current index, swap the current index's value with the random index's value.
This is to prevent bias with the same number being constantly swapped and making the same permutations again and again.
When it reaches the start of the list, the loop stops as the only element at the start of the list that can swap with it is itself.

Not only was it O(n), but it actually helps make different permutations with an equal chance.
