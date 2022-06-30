using System;
namespace UnderstandingTypes
{
    public class DataTypeProperties
    {
        public void GetTypeProperties()
        {
            Console.WriteLine($"The number of bytes in memory of 'sbyte' is {sizeof(sbyte)}, its min value is {sbyte.MinValue}, its max value is {sbyte.MaxValue}.");
            Console.WriteLine($"The number of bytes in memory of 'byte' is {sizeof(byte)}, its min value is {byte.MinValue}, its max value is {byte.MaxValue}.");
            Console.WriteLine($"The number of bytes in memory of 'short' is {sizeof(short)}, its min value is {short.MinValue}, its max value is {short.MaxValue}.");
            Console.WriteLine($"The number of bytes in memory of 'ushort' is {sizeof(ushort)}, its min value is {ushort.MinValue}, its max value is {ushort.MaxValue}.");
            Console.WriteLine($"The number of bytes in memory of 'int' is {sizeof(int)}, its min value is {int.MinValue}, its max value is {int.MaxValue}.");
            Console.WriteLine($"The number of bytes in memory of 'uint' is {sizeof(uint)}, its min value is {uint.MinValue}, its max value is {uint.MaxValue}.");
            Console.WriteLine($"The number of bytes in memory of 'long' is {sizeof(long)}, its min value is {long.MinValue}, its max value is {long.MaxValue}.");
            Console.WriteLine($"The number of bytes in memory of 'ulong' is {sizeof(ulong)}, its min value is {ulong.MinValue}, its max value is {ulong.MaxValue}.");
            Console.WriteLine($"The number of bytes in memory of 'float' is {sizeof(float)}, its min value is {float.MinValue}, its max value is {float.MaxValue}.");
            Console.WriteLine($"The number of bytes in memory of 'double' is {sizeof(double)}, its min value is {double.MinValue}, its max value is {double.MaxValue}.");
            Console.WriteLine($"The number of bytes in memory of 'decimal' is {sizeof(decimal)}, its min value is {decimal.MinValue}, its max value is {decimal.MaxValue}.");
        }
    }
}

