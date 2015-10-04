using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDionisio.Models
{
    public class EventosItem
    {
        public string IdEvento
        {
            get { return _IdEvento; }
            set { _IdEvento = value; }
        }
        private string _IdEvento;
        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }
        private string _Nome;
        public string KM
        {
            get { return _KM; }
            set { _KM = value; }
        }private string _KM;
    }
}
