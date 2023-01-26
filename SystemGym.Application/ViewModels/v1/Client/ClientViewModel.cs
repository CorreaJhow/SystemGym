using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemGym.Application.ViewModels.v1.Client
{
    public class ClientViewModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; private set; }
        public bool Active { get; private set; }

    }
}
