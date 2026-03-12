// See https://aka.ms/new-console-template for more information
using tpmodul4_103082400005;


public class Program
{
    public static void Main(string[] args)
    {
        String kelurahan = "Maleer";
        String kodePos =  KodePos.GetKodePos(kelurahan);

        Console.WriteLine(kodePos);
    }
}