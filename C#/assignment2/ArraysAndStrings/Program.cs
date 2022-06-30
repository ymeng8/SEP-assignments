using ArraysAndStrings;

// Copy an array
CopyArray ca = new CopyArray();
ca.Run();

// Manage a list
List<string> list = new List<string> { "item1" };
ManageList ml = new ManageList();
ml.List = list;
ml.Run();

// Find all prime numbers in given range
int[] res = FindPrime.FindPrimesInRange(2, 100);
Console.WriteLine(String.Join(", ", res));

// Rotate integer array right k times and sum each array after rotation
RotateAndSum ras = new RotateAndSum();
ras.Run();

// Find the longest sequence of equal elements in an array of integers
LongestSequence ls = new LongestSequence();
ls.Run(new int[] { 0, 1, 1, 5, 2, 2, 6, 3, 3 });

// Find the most frequent number in an array of integers
MostFreqNum mfn = new MostFreqNum();
mfn.Run(new int[] { 7, 7, 7, 0, 2, 2, 2, 0, 10, 10, 10 });

// Reverse string
ReverseString rs = new ReverseString();
rs.Run();

// Reverse words in a given string
string s = "The quick brown fox jumps over the lazy dog /Yes! Really!!!/.";
ReverseWords rw = new ReverseWords();
rw.Run(s);

// Extract palindromes from a given string
string s2 = "Hi,exe? ABBA! ABBA,Hog fully a string: ExE. Bob";
ExtractPalindromes ep = new ExtractPalindromes();
ep.Run(s2);

// Parse a given URL
string url = "www.apple.com";
ParseURL p = new ParseURL();
p.Run(url);