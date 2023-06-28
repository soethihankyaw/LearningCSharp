using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal class AnimalInfoId
    {
        private int idNum;
        private string owner;

        public int IdNum { get => idNum; set => idNum = value; }
        public string Owner { get => owner; set => owner = value; }
    }
}
