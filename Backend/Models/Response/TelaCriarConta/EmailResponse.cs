using System;

namespace backend.Models.Response
{
    public class EmailResponse
    {
        public int idlogin {get;set;}
        public string email {get;set;}
        public string senha {get;set;}
        public string perfil {get;set;}
    }
}