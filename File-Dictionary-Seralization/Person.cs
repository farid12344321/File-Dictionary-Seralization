using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Dictionary_Seralization
{
    [Serializable]
    internal class Person
    {
        public string FullName { get; set; }
        public byte Age { get; set; }


        public override string ToString()
        {
            return "FullName: " +FullName +" - "+"Age:" + Age;
        }
    }
}
