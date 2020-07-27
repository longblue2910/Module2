using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Phone
    {
        public abstract void InsertPhone(string Name, string Phone);
        public abstract void RemovePhone(string Name);
        public abstract void UpdatePhone(string Name, string newPhone);
    }
}
