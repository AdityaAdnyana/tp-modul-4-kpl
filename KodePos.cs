using System;
using System.Collections.Generic;
using System.Text;

namespace tpmodul4_103082400005
{
    internal class KodePos
    {
        static String[] kelurahan = 
            {
            "Batununggal", 
            "Kujangsari", 
            "Mengger", 
            "Wates", 
            "Cijaura", 
            "Jatisari", 
            "Margasari", 
            "Sekejati", 
            "Kebonwaru", 
            "Maleer", 
            "Samoja"
            };
        static String[] kodePos = 
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
        public static string GetKodePos(String search)
        {
            int currentIndex = -1;
            foreach (String currentLurah in kelurahan)
            {
                currentIndex++;
                if (currentLurah.Equals(search)) break;
            }

            if (currentIndex < 0 || currentIndex >= kodePos.Length || kelurahan.Equals(search))
            {
                return "Not Found";
            }

            return kodePos[currentIndex];
             
        }
    }
}
