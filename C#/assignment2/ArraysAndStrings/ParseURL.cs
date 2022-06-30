using System;
using System.Text;

namespace ArraysAndStrings
{
	public class ParseURL
	{
		public void Run(string url)
		{
			StringBuilder sb = new StringBuilder();
			string[] output = new string[3];

			int i = 0;
			while (i<url.Length)
            {
				if (url[i] == ':')
                {
					output[0] = sb.ToString();
					sb.Clear();
					i += 3;
                }
				else if (url[i] == '/')
                {
					output[2] = url.Substring(i+1);
					i = url.Length;
                }
				else
                {
					sb.Append(url[i]);
					i++;
                }
            }
			output[1] = sb.ToString();

			Console.WriteLine($"[protocol] = \"{output[0]}\"");
			Console.WriteLine($"[server] = \"{output[1]}\"");
			Console.WriteLine($"[resource] = \"{output[2]}\"");
		}
	}
}

