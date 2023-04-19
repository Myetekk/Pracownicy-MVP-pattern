using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy_MVP.Model
{
    class MainModel
    {
        private Info_Builder infoBuildetTmp;
        public Info_Builder InfoBuildetTmp
        {
            get => infoBuildetTmp;
            set { infoBuildetTmp = value; }
        }

        public MainModel()
        {
            infoBuildetTmp = new Info_Builder();
        }
    }
}
