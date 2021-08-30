using System;

namespace backend.Utils
{
    public class ConversorparaMesesUtils
    {
        public string mesescolhido(int mes)
        {
            string mesresponse = "";
            if(mes == 01)
                mesresponse = "janeiro";
            
            else if(mes == 02)
                mesresponse = "fevereiro";
            
            else if(mes == 03)
                mesresponse = "março";
            
            else if(mes == 04)
                mesresponse = "abril";
            
            else if(mes == 05)
                mesresponse = "maio";
            
            else if(mes == 06)
                mesresponse = "junho";
            
            else if(mes == 07)
                mesresponse = "julho";
            
            else if(mes == 08)
                mesresponse = "agosto";
            
            else if(mes == 09)
                mesresponse = "setembro";
            
            else if(mes == 10)
                mesresponse = "outubro";
            
            else if(mes == 11)
                mesresponse = "novembro";
            
            else if(mes == 12)
                mesresponse = "dezembro";

            else
                mesresponse = "mes inválido";

            return mesresponse;
                
        }
    }
}