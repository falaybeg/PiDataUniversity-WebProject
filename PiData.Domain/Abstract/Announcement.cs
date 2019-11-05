using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Domain.Abstract
{
    public class Announcement
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string Context { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
