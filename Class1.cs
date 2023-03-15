using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BinaryNotes
{
    internal class Class1
    {
        // Fields
        string _name;

        // Constructors
        public Class1(string name)
        {
            _name = name;
        }

        // Properties
        public string Name { get => _name; Set => _data } //... more code missing }


        // Methods? any methods?
        // Override
        public override string ToString()
        {
            return $"{_name}, more code here if wanted";
        }



    }
}
