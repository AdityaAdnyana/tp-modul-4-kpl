using System;
using System.Collections.Generic;
using System.Text;

namespace tpmodul4_103082400005
{
    internal class DoorMachine
    {
        enum State { Terkunci, Terbuka};
        readonly String[] screenName = {"terkunci", "tidak terkunci"};

        public DoorMachine()
        {

            State currentState = State.Terkunci;

            while (true)
            {
                Console.Clear();
                
                Console.WriteLine($"Pintu " + screenName[(int)currentState]);
                Console.WriteLine("Aksi Tersedia: KunciPintu, BukaPintu, Keluar");
                Console.Write("Input Command: ");

                string input = Console.ReadLine();

                
                if (input == "KunciPintu")
                {
                    currentState = State.Terkunci;
                }
                else if (input == "BukaPintu")
                {
                    currentState = State.Terbuka;
                }
                else if(input == "Keluar")
                {
                    Console.WriteLine("Pintu Dihancurkan");
                    return;
                }


            }
        }
    }
}
