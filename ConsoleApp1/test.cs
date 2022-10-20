using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Project
{
    internal class test
    {
        private string paramstring;

        public string Paramstring { get => paramstring; set => paramstring = value; }

        public void LabTesting(string str)
        {
            Console.WriteLine(this.paramstring);
            Console.WriteLine(str);
        }

    }
}
