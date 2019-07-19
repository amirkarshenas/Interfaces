using System;

namespace InterfaceSample1
{

    class Utility
    {
        public static int[] Change(int[] source, IChanger c)
        { 
                int[] newSource = new int[source.Length];
                for(int i = 0 ; i< source.Length;i++)
                {
                    newSource[i] = c.Changer(source[i]);
                }
            return newSource;
        }
    }

}