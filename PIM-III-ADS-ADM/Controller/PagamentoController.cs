using QRCoder;
using System.Windows.Forms;

using System.Security.Policy;


namespace PIM_III_ADS_ADM.Controller
{
    public class PagamentoController
    {

        private bool credito;
        private bool debito;
        private bool pix;

        private PictureBox ptbQrCode;

        public PagamentoController()
        {

        }

        public PagamentoController(PictureBox pictureBox)
        {
            this.ptbQrCode = ptbQrCode;
        }

        public PagamentoController(bool credito, bool debito, bool pix)
        {
            this.credito = credito;
            this.debito = debito;
            this.pix = pix;
          
        }

        public string FormaDePagamento()
        {
            if (Credito)
            {
                return "Credito";
            }
            else if (Debito)
            {
                return "Debito";
            }
            else if (Pix)
            {
                return "Pix";
            }
            else
            {
                return "Isento";
            }
        }

        public void GerarQrCoder()
        {
            Url generator = new Url("");

            string payload = generator.ToString();

            QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
            QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            QRCode qRCode = new QRCode(qRCodeData);
            ptbQrCode.Image = qRCode.GetGraphic(16);
        }

        public PictureBox PtbQrCode
        {
            get { return ptbQrCode; }
            set { ptbQrCode = value; }
        }
 
        public bool Pix
        {
            get
            {
                return pix;
            }
            set
            {
                pix = value;
            }
        }

        public bool Debito
        {
            get
            {
                return debito;
            }
            set
            {
                debito = value;
            }
        }

        public bool Credito
        {
            get
            {
                return credito;
            }
            set
            {
                credito = value;
            }
        }
    }
}
