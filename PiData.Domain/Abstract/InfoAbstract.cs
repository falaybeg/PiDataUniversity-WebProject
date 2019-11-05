using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiData.Domain.Abstract
{
    public class InfoAbstract
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string History { get; set; }

        public string Mission { get; set; }

        public string Vission { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }
        public string FaxNo { get; set; }
        public string Email { get; set; }
    }
}
