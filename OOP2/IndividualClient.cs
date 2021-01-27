using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class IndividualClient:Client
    {               
        public string ClientId { get; set; }        
        public string Name { get; set; }
        public string Surname { get; set; }
        public string NationalId { get; set; }
    }
}
