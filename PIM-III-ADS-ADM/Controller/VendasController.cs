using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_III_ADS_ADM.Controller
{
    internal class VendasController
    {
        private bool inteiro;
        private bool meia;
        private bool isento;

        public VendasController()
        {
        }

        public VendasController(bool inteiro, bool meia, bool isento)
        {
            this.inteiro = inteiro;
            this.meia = meia;
            this.isento = isento;

        }


        public string TipoDeIngresso()
        {
            if (Inteiro)
            {
                return "Inteiro";
            }
            else if (Meia)
            {
                return "Meia";
            }
            else
            {
                return "Isento";
            }
        }

        public string Valor()
        {
            if (Inteiro)
            {
                return "10.00";
            }
            else if (Meia)
            {
                return "5.00";
            }
            else if (Isento)
            {
                return "0.00";
            }

            return "0.00";
        }



        public bool Isento
    {
        get
        {
            return isento;
        }
        set
        {
            isento = value;
        }
    }

    public bool Meia
    {
        get
        {
            return meia;
        }
        set
        {
            meia = value;
        }
    }

    public bool Inteiro
    {
        get
        {
            return inteiro;
        }
        set
        {
            inteiro = value;
        }
    }
}
}
