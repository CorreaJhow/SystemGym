using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemGym.Application.InputModels.v1.Client
{
    public class UpdateClientInputModel
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Phone { get; private set; }
        public string Document { get; private set; }
    }
}
