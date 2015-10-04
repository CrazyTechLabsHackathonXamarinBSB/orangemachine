using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDionisio.Models
{
    public class Usuario
    {
        public string Id
        {
            get { return _Id; }
            set { _Id = value; }
        }private string _Id;
        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }private string _Nome;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }private string _Email;
        public string Senha
        {
            get { return _Senha; }
            set { _Senha = value; }
        }private string _Senha;
        public string Facebook
        {
            get { return _Facebook; }
            set { _Facebook = value; }
        }private string _Facebook;

    }
}
