using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonica.DAO.Model
{
    public class ClienteTelefone
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Numero { get; set; }
        public ExceptionFull exceptionFull = new ExceptionFull();
        public Cliente cliente = new Cliente();
    }
}
