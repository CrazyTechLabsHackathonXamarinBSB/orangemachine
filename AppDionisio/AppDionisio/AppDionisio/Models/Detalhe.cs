using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDionisio.Models
{
    public class Detalhe
    {
        public string Id
        {
            get { return _Id; }
            set { _Id = value; }
        }private string _Id;
        public int Checkins
        {
            get { return _Checkins; }
            set { _Checkins = value; }
        }private int _Checkins;
        public int Likes
        {
            get { return _Likes; }
            set { _Likes = value; }
        }private int _Likes;
        public int Deslike
        {
            get { return _Deslike; }
            set { _Deslike = value; }
        }private int _Deslike;
    }
}
