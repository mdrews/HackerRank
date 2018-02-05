using System;
using System.Collections.Generic;

namespace _1.Acid_Naming
{
    class Program
    {
        static string AcidNaming(string acid_name)
        {
            acid_name = acid_name.ToLower();
            string acidType = "not an acid";
            if (acid_name.EndsWith("ic"))
            {
                if (acid_name.StartsWith("hydro"))
                {
                    return "non-metal acid";
                }
                return "polyatomic acid";
            }
            return acidType;
        }
        static void Main(string[] args)
        {
            List<string> acids = new List<string>()
            {
                "3",
                "hydrochloric",
                "rainbowic",
                "idontevenknow"
            };
            foreach (var acid in acids)
            {
                Console.WriteLine(AcidNaming(acid));
            }
            
        }
    }
}
