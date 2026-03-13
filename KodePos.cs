using System;
using System.Collections.Generic;
using System.Text;

namespace tpmodul4_103082400005
{
    internal class KodePos
    {
        public enum Kelurahan 
            {
            Batununggal, 
            Kujangsari, 
            Mengger, 
            Wates, 
            Cijaura, 
            Jatisari, 
            Margasari, 
            Sekejati, 
            Kebonwaru, 
            Maleer, 
            Samoja
            };
        static readonly String[] kodePos = 
            {
            "40266", 
            "40287", 
            "40267", 
            "40256", 
            "40287",
            "40286",
            "40286",
            "40286",
            "40272",
            "40274",
            "40273"
            };
        public static string GetKodePos(Kelurahan search)
        {
            return kodePos[(int)search];
             
        }
    }
}
