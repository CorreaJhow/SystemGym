using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemGym.Domain.Entities.v1.Client
{
    public class ClientBenefits : BaseEntity
    {
        public bool? VIP { get; set; }
        public bool? Nutritionist { get; set; }
    }
}
