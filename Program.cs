// See https://aka.ms/new-console-template for more information
using tpmodul4_103082400005;


public class Program
{
    public static void Main(string[] args)
    {
        //Kode Pos
        KodePos.Kelurahan SearchLurah = KodePos.Kelurahan.Maleer;
        String kodePos =  KodePos.GetKodePos(SearchLurah);

        Console.WriteLine(kodePos);


        //Pintu
        //DoorMachine door = new DoorMachine();
    }
}