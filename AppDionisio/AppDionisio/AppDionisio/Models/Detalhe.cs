using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDionisio.Models
{
    public class Detalhe : BaseModel
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

        public string IdEvento
        {
            get { return _IdEvento; }

            set
            {
                if (value != this._IdEvento)
                {
                    this._IdEvento = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private string _IdEvento;
        public int Checkins
        {
            get { return _Checkins; }

            set
            {
                if (value != this._Checkins)
                {
                    this._Checkins = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private int _Checkins;
        public int Likes
        {
            get { return _Likes; }

            set
            {
                if (value != this._Likes)
                {
                    this._Likes = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private int _Likes;
        public int Deslike
        {
            get { return _Deslike; }

            set
            {
                if (value != this._Deslike)
                {
                    this._Deslike = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private int _Deslike;

        [JsonIgnore]
        public List<Usuario_Evento> UsuariosEvento { get; set; }

        [JsonIgnore]
        public Evento Evento { get; set; }
        [JsonIgnore]
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
        [JsonIgnore]
        public string Local
        {
            get { return _Local; }

            set
            {
                if (value != this._Local)
                {
                    this._Local = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private string _Local;
    }
}
