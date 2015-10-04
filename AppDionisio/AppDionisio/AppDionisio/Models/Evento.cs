using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDionisio.Models
{
    public class Evento : BaseModel
    {
        public string Id
        {
            get { return _Id; }

            set
            {
                if (value != this._Id)
                {
                    this._Id = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private string _Id;

        public string Nome
        {
            get { return _Nome; }

            set
            {
                if (value != this._Nome)
                {
                    this._Nome = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private string _Nome;

        public string Descricao
        {
            get { return _Descricao; }

            set
            {
                if (value != this._Descricao)
                {
                    this._Descricao = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private string _Descricao;

        public string IdUsuario
        {
            get { return _IdUsuario; }

            set
            {
                if (value != this._IdUsuario)
                {
                    this._IdUsuario = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private string _IdUsuario;

        public string Logradouro
        {
            get { return _Logradouro; }

            set
            {
                if (value != this._Logradouro)
                {
                    this._Logradouro = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private string _Logradouro;

        public int Numero
        {
            get { return _Numero; }

            set
            {
                if (value != this._Numero)
                {
                    this._Numero = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private int _Numero;

        public string Complemento
        {
            get { return _Complemento; }

            set
            {
                if (value != this._Complemento)
                {
                    this._Complemento = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private string _Complemento;

        public string CEP
        {
            get { return _CEP; }

            set
            {
                if (value != this._CEP)
                {
                    this._CEP = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private string _CEP;

        public string Bairro
        {
            get { return _Bairro; }

            set
            {
                if (value != this._Bairro)
                {
                    this._Bairro = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private string _Bairro;

        public string Cidade
        {
            get { return _Cidade; }

            set
            {
                if (value != this._Cidade)
                {
                    this._Cidade = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private string _Cidade;

        public string Estado
        {
            get { return _Estado; }

            set
            {
                if (value != this._Estado)
                {
                    this._Estado = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private string _Estado;

        public string Latitude
        {
            get { return _Latitude; }

            set
            {
                if (value != this._Latitude)
                {
                    this._Latitude = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private string _Latitude;

        public string Longitude
        {
            get { return _Longitude; }

            set
            {
                if (value != this._Longitude)
                {
                    this._Longitude = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private string _Longitude;

        public DateTime DiaDoEvento
        {
            get { return _DiaDoEvento; }

            set
            {
                if (value != this._DiaDoEvento)
                {
                    this._DiaDoEvento = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private DateTime _DiaDoEvento;
    }
}
