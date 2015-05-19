using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bijcorp.Base
{
    public class LinkGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class LinkModule
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public string ClassName { get; set; }
        public Delegate View{ get; set; }
        public int LinkType { get; set; } //agrupador = 1, modulo = 2
        public LinkGroup Group { get; set; }
    }

    public static class Modules
    {
        public static Dictionary<int, Delegate> DicModules = new Dictionary<int, Delegate>();
    }
}
