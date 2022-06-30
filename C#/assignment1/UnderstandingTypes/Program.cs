using UnderstandingTypes;

//Playing with console app
string temp = "123";
Console.WriteLine($"Hello, World! {temp}");

//Ask user questions and generate custom hacker name
HackerName hn = new HackerName();
hn.GenerateName();

//Output number of bytes in memory, min value, max value of different data types
DataTypeProperties dtp = new DataTypeProperties();
dtp.GetTypeProperties();

//Convert a centry to years, days, hours, minutes...
ConvertCentury cc = new ConvertCentury();
cc.OutputCentury();