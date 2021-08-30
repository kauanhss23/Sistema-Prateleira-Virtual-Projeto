using System;


namespace backend.Controllers.Business.FuncoesFuncionario
{
    public class ResgitroExistente
    {
        Database.TabelasdoModeloDataBase verificarregistro = new Database.TabelasdoModeloDataBase();
        Database.FuncoesFuncionarioDataBase funcoesfuncionario = new Database.FuncoesFuncionarioDataBase();
        public Models.TbLivro VerificarRegistro (int id)
        {
            if(id <= 0)
                throw new ArgumentException("Esse Registro é inválido");

            Models.TbLivro entrada = verificarregistro.VerificarExistenciaTbLivro(id);

            if(entrada == null)
                throw new ArgumentException("Esse Registro não existe");

            Models.TbLivro result = funcoesfuncionario.apagar(entrada);
            return result;
        }
    }
}