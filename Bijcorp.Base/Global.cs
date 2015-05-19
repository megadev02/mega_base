using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bijcorp.Base
{
    public static class Global
    {
        public static User UserLogin { get; set; }
    }

    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Pwd { get; set; }
    }
}
