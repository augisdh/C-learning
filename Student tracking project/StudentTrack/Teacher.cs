using System;
using System.Collections.Generic;
using System.Text;

namespace StudentTrack
{
    class Teacher : Member, IPayee
    {
        public string Subject { get; set; }

        public void Pay()
        {
            Console.WriteLine("Paying teacher");
        }
    }
}
