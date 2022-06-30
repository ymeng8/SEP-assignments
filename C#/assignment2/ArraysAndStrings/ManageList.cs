using System;
namespace ArraysAndStrings
{
	public class ManageList
	{
		public List<string> List { get; set; }

		public void Run()
        {
			string command, action, item;

			Console.Write("Enter command (+ item, - item, -- to clear, exit to stop): ");
			command = Console.ReadLine();

			while (command!="exit")
			{
				action = command.Substring(0, 2);

                switch (action)
                {
					case "+ ":
						item = command.Substring(2);
						List.Add(item);
						break;
					case "- ":
						item = command.Substring(2);
						List.Remove(item);
						break;
					case "--":
						List.Clear();
						break;
					default:
						Console.WriteLine("Invalid command.");
						break;
				}

				Console.WriteLine($"Current list: {String.Join(", ", List)}");
				Console.WriteLine();
				Console.Write("Enter command to continue: ");
				command = Console.ReadLine();
			} 	
        }
	}
}

