using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Domain
{
    class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string FaxNo { get; set; }
        public string Email { get; set; }
        public int DeanId { get; set; }
        public string DeanMessage { get; set; }

    }
}
