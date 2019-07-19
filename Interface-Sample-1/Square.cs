using System;

namespace InterfaceSample1
{
    class Square : IChanger
    {
        public int Changer(int source)
        {
            return source * source;
        }
    }

}

