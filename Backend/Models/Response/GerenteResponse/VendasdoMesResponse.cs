using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace backend.Models.Response.GerenteResponse
{
    public class VendasdoMesResponse
    {
        public string mes {get;set;}
        public int? qtdvendas {get;set;}
        public decimal? lucromensal {get;set;}
    }
}