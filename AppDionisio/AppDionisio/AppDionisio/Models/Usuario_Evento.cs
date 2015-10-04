using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDionisio.Models
{
    public class Usuario_Evento
    {
        public string Id
        {
            get { return _Id; }
            set { _Id = value; }
        }private string _Id;
        public string IdUsuario
        {
            get { return _IdIdUsuario; }
            set { _IdIdUsuario = value; }
        }private string _IdIdUsuario;
        public string IdEvento
        {
            get { return _IdEvento; }
            set { _IdEvento = value; }
        }private string _IdEvento;
        public int Status
        {
            get { return _Status; }
            set { _Status = value; }
        }private int _Status;

        public StatatusEnum StatusEnum
        {
            get
            {
                return ((StatatusEnum)this.Status);
            }
        }


    }

    public enum StatatusEnum
    {
        Defaut = 0,
        Like = 1,
        Deslike = 2
    }
}
