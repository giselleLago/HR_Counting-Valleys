using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s)
    {
        int vall = 0;
        int cont = 0;
        List<int> contVall = new List<int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'D')
            {
                cont--;
                contVall.Add(cont);
            }
            else if (s[i] == 'U')
            {
                cont++;
                contVall.Add(cont);
            }
        }
        for (int j = 0; j < contVall.Count; j++)
        { 
            if (contVall[j] < 0)
            { 
                j++;
                if (contVall[j] == 0)
                {
                    vall++;
                    j--;
                }
                
            }
             
        }
        
        return vall;
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int result = countingValleys(n, s);

        Console.WriteLine(result);
        Console.ReadKey();
    }
}

