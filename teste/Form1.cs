using System.Windows.Forms;

namespace teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams parametro = base.CreateParams;
                parametro.ExStyle |= 0x08000000;
                return parametro;
            }
        }
        private void Alfabeto(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (chkCapsLock.Checked == true || chkShiftL.Checked == true || chkShiftR.Checked == true)
            {
                SendKeys.Send((btn.Text).ToUpper());
                chkShiftL.Checked = false;
                chkShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send(btn.Text.ToLower());
            }
        }
        private void SendKey(string normalKey, string shiftKey)
        {
            if (chkShiftL.Checked || chkShiftR.Checked)
            {
                SendKeys.Send(shiftKey);
                chkShiftL.Checked = false;
                chkShiftR.Checked = false;
            }
            else
            {
                SendKeys.Send(normalKey);
            }
        }

        private void btnEnter_Click(object sender, EventArgs e) => SendKeys.Send("{ENTER}");

        private void btnEspaço_Click(object sender, EventArgs e) => SendKeys.Send(((char)32).ToString());

        private void btnBackspace_Click(object sender, EventArgs e) => SendKeys.Send("\x08");

        private void btnHifenUnder_Click(object sender, EventArgs e) => SendKey("-", "{_}");

        private void btnIgualAdi_Click(object sender, EventArgs e) => SendKey("=", "{+}");

        private void btnAguCrase_Click(object sender, EventArgs e) => SendKey("´", "{`}");

        private void btnTilCircun_Click(object sender, EventArgs e) => SendKey("~", "{^}");

        private void btnPVirgulaDoisP_Click(object sender, EventArgs e) => SendKey(";", "{:}");

        private void btnBarraInterroga_Click(object sender, EventArgs e) => SendKey("/", "{?}");

        private void btnChaveColcheFecha_Click(object sender, EventArgs e) => SendKey("]", "{}}");

        private void btnChaveColcheAbre_Click(object sender, EventArgs e) => SendKey("[", "{{}");

        private void btnPontoMaior_Click(object sender, EventArgs e) => SendKey(".", "{>}");

        private void btnVirgulaMenor_Click(object sender, EventArgs e) => SendKey(",", "{<}");

        private void btnBarraInvVerti_Click(object sender, EventArgs e) => SendKey("\\", "{|}");

        private void btnEsc_Click(object sender, EventArgs e) => SendKeys.Send("{ESC}");

        private void btnExclamaUm_Click(object sender, EventArgs e) => SendKey("1", "{!}");

        private void btnArrobaDois_Click(object sender, EventArgs e) => SendKey("2", "{@}");

        private void btnHashtagTres_Click(object sender, EventArgs e) => SendKey("3", "{#}");

        private void btnSifraoQuatro_Click(object sender, EventArgs e) => SendKey("4", "{$}");

        private void btnPorcentoCinco_Click(object sender, EventArgs e) => SendKey("5", "{%}");

        private void btnTremaSeis_Click(object sender, EventArgs e) => SendKey("6", "{¨}");

        private void btnEcomSete_Click(object sender, EventArgs e) => SendKey("7", "{&}");

        private void btnAsterisOito_Click(object sender, EventArgs e) => SendKey("8", "{*}");

        private void btnAbreBarraNove_Click(object sender, EventArgs e) => SendKey("9", "{(}");

        private void btnBarraFechaZero_Click(object sender, EventArgs e) => SendKey("0", "{)}");

        private void btnTab_Click(object sender, EventArgs e) => SendKeys.Send("{ENTER}");

    }
}
