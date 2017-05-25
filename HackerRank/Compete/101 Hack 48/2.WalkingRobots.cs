using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int howManyCollisions(string s)
    {
        // Complete this function
        int crashStart = -1;
        int crashEnd = -1;
        int numberStopped = 0;
        for (int x = 0; x < s.Length; x++)
        {
            if (s[x] == 'r' || s[x] == 'd')
            {
                crashStart = x;
                break;
            }
        }
        if (crashStart == -1) { return 0; }
        for (int x = (s.Length-1); x > 0; x--)
        {
            if (s[x] == 'l' || s[x] =='d')
            {
                crashEnd = x+1;
                break;
            }
        }
        if (crashEnd == -1) { return 0; }
        for(int x = crashStart; x < crashEnd; x++)
        {
            if (s[x] == 'd'){ numberStopped++; }
        }
        return (crashEnd - crashStart - numberStopped);
    }

    static void Main(String[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < q; a0++)
        {
            string s = Console.ReadLine();
            // Returns the number of times moving robots collide.
            int result = howManyCollisions(s);
            Console.WriteLine(result);
        }
        //string s = "dddrddrrrlddrrrrrdlddldllrlldlllrlrrrddllrrrldldrlldlldllddlldldddldldrrddlrrrrdrdddllrrddddrdddlrdlldlldrldldlrrrldlrrrllrldlrrrdlrrldrldrlrlddrlllrddrdlrlrrdrllddllddrdrdddddlrrdrrldrdldlrrrdlrlddrddlrrlrrrdddldddrdllddlrlrlllrldrlllllrrrlrrdrrlllldldldddrllrldlllddlldlrldldrrrrdrrdrdlrllrdddddlddrddllrrdrrrlddrdldddddrrlldlrdddlrrdllrddrddllrrdrlrlrddddrrrlrlddldrrdrrddlrddrdddllrdddrlrlddlrdrdllrdrdrdldrddlldlddddddldrrddrrrdlrrdldrlldddldrldldlldrrrrrddlrldlddlrrldddlrlrldrldlddlddddlrddlrldrlrllllldrlrldddrdddlrlrllddlldlrdlrdrdldlrrrlrrrdrrddlldrdlrrdldlldrrrrldddlllrldddldrdrdlllrrdlrrdrrdddrllrrldlllllldrddlrrrrrrdrdrddldlddrdlllddddldldrdlldrdddldlldrdllldrdlrdrdllldrrlldrldrrdldrlrlrlddrddrrlrdrldrlrdrldldlldlddlddddrrlrldrdlldddlrrrrrlddrdrldlrdrdrdrdrddldrrdldrldldrldlrldlllddlrdllllrddrrdddldldrrlrlldrldrlrdddddrlllrddllrrrlddldlddlrrdlrrldddllrrlrdddrrrldrrldrlldlldlrdldrdrllrddrddlrddddld";
        //Console.WriteLine(howManyCollisions(s));
    }
}