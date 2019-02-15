using System;
using System.Collections.Generic;
using System.Text;

namespace StudentTrack
{
    class Principal : Member, IPayee
    {
        public void Pay()
        {
            Console.WriteLine("Paying principal");
        }
    }
}
