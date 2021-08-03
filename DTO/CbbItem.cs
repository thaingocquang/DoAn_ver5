using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_ver5.DTO
{
    public class CbbItem
    {
        public string ID { get; set; }

        public string Name { get; set; }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
