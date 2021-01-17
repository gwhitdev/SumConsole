This is a console programme that generates 5 random numbers from a range, enters them into a List<int> and generates 3 lists into an array.
Then, main executes an algorithm to check:
	a) If a new list of complements has a Count > 0 
	b) Has the num in data been seen before as a complement? 
	c) Does num == the last element of the list of complements?
	If all these are TRUE then return true is logically equivalent to there being a pair of the current number and the previous number in data totalling the target sum.
	d) If not a ^ b ^ c then return FALSE

This is written in C# targeting .NET 5.