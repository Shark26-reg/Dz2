
using Dz2;
public class Program
{
    

    public static void Main(string[] args)
    {
        
        Bits bits = new(4);


        //bits.SetBitByIndex(0, true);
        //Console.WriteLine(bits.GetBitByIndex(2));

        Console.WriteLine(bits);
        byte val = (byte)bits;
        Console.WriteLine(val);
    }

}