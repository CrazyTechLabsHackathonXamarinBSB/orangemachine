using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDionisio.Models
{
    public class Evento
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
        public string IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }private string _IdUsuario;
        public string Logradouro
        {
            get { return _Logradouro; }
            set { _Logradouro = value; }
        }private string _Logradouro;
        public int Numero
        {
            get { return _Numero; }
            set { _Numero = value; }
        }private int _Numero;
        public string Complemento
        {
            get { return _Complemento; }
            set { _Complemento = value; }
        }private string _Complemento;
        public string CEP
        {
            get { return _CEP; }
            set { _CEP = value; }
        }private string _CEP;
        public string Bairro
        {
            get { return _Bairro; }
            set { _Bairro = value; }
        }private string _Bairro;
        public string Cidade
        {
            get { return _Cidade; }
            set { _Cidade = value; }
        }private string _Cidade;
        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }private string _Estado;
        public string Latitude
        {
            get { return _Latitude; }
            set { _Latitude = value; }
        }private string _Latitude;
        public string Longitude
        {
            get { return _Longitude; }
            set { _Longitude = value; }
        }private string _Longitude;
    }
}
