using System;

namespace InterfaceSample1
{
    class AddFive : IChanger
    {
        public int Changer(int source)
        {
            return source + 5;
        }
    }
}


