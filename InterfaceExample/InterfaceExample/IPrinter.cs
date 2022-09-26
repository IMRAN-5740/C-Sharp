using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    interface IPrinter
    {
        void SetIPAddress(string ip);
        void Print();
        string GetBasicInformation();
    }
}
