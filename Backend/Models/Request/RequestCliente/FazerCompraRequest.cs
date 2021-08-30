using System;

namespace backend.Models.Request.RequestCliente
{
    public class FazerCompraRequest
    {
        public int? idcliente {get;set;}
        public decimal preco {get;set;}
        public DateTime compra {get;set;}
    }
}