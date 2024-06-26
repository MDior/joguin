using System.Linq.Expressions;

namespace JogoGenius
{
    public partial class Form1 : Form
    {

        int SequênciaSelecionada = -1;
        int SequênciaAtual = 0;
        int aux = 0;
        List<Button> sequência;
        Color corPadrao;
        Color corPiscando;
        bool piscando = false;
        int nivel = 0;

        string corVerdePadrao = "#004700";
        string corAmareloPadrao = "#F0B200";
        string corVermelhoPadrao = "#A80A00";
        string corAzulPadrao = "#06006B";

        string corVerdePiscando = "#008A00";
        string corAmareloPiscando = "#FFD047";
        string corVermelhoPiscando = "#F50E00";
        string corAzulPiscando = "#0C00D6";

        public
            Form1()
        {
            InitializeComponent();

            btVERDE.BackColor = ColorTranslator.FromHtml(corVerdePadrao);
            btAMARELO.BackColor = ColorTranslator.FromHtml(corAmareloPadrao);
            btVERMELHO.BackColor = ColorTranslator.FromHtml(corVermelhoPadrao);
            btAZUL.BackColor = ColorTranslator.FromHtml(corAzulPadrao);

            btVERDE.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(corVerdePadrao);
            btAMARELO.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(corAmareloPadrao);
            btVERMELHO.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(corVermelhoPadrao);
            btAZUL.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(corAzulPadrao);

            btVERDE.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml(corVerdePiscando);
            btAMARELO.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml(corAmareloPiscando);
            btVERMELHO.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml(corVermelhoPiscando);
            btAZUL.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml(corAzulPiscando);

            btVERDE.Cursor = Cursors.Hand;
            btAMARELO.Cursor = Cursors.Hand;
            btVERMELHO.Cursor = Cursors.Hand;
            btAZUL.Cursor = Cursors.Hand;
        }


        private void btINICIAR_Click(object sender, EventArgs e)
        {
            SequênciaSelecionada = -1;
            sequência = new List<Button>();
            btINICIAR.Enabled = false;

            nivel++;

            lblNivel.Text = nivel.ToString();

            GerarSequência();
            Piscando();
            HabilitaDesabilitaBotao(true);
        }

        private void GerarSequência()
        {
            Random random = new Random();
            int num = random.Next(0, 4);

            Button bt = null;

            switch (num)
            {
                case 0:
                    bt = btVERDE;
                    break;

                case 1:
                    bt = btAMARELO;
                    break;

                case 2:
                    bt = btVERMELHO;
                    break;
                case 3:
                    bt = btAZUL;
                    break;
           }
            sequência.Add(bt);
        }

        private void Piscando()
        {
            aux = 0;

            for (int i = 0; i < sequência.Count; i++)
            {
                SequênciaAtual = i;

                corPadrao = sequência[i].BackColor;

                if (sequência[i] == btVERDE)
                    _ = corPiscando == ColorTranslator.FromHtml(corVerdePiscando);
                else if (sequência[i] == btAMARELO)
                    _ = corPiscando == ColorTranslator.FromHtml(corAmareloPiscando);
                else if (sequência[i] == btVERMELHO)
                    _ = corPiscando == ColorTranslator.FromHtml(corVermelhoPiscando);
                else if (sequência[i] == btAZUL)
                    _ = corPiscando == ColorTranslator.FromHtml(corAzulPiscando);

                timer1.Start();

                while (aux == i)
                {
                    Application.DoEvents();
                }
            }
        }

        private void HabilitaDesabilitaBotao(bool habilita)
        {
            btVERDE.Enabled = habilita;
            btAMARELO.Enabled = habilita;
            btVERMELHO.Enabled = habilita;
            btAZUL.Enabled = habilita;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!piscando)
            {
                sequência[SequênciaAtual].BackColor = corPiscando;
                piscando = true;
            }
            else
            {
                sequência[SequênciaAtual].BackColor = corPadrao;
                piscando = false;
                aux++;
                timer1.Stop();
            }
        }

        private void bt_Click(object sender, EventArgs e)
        {
            SequênciaSelecionada++;

            if (sequência[SequênciaSelecionada] == (Button)sender)
            {
                if(sequência.Count - 1 == SequênciaSelecionada)
                {
                    nivel++;
                    lblNivel.Text = nivel.ToString();
                    SequênciaSelecionada = -1;
                    HabilitaDesabilitaBotao(false);
                    GerarSequência();
                    Thread.Sleep(500);
                    Piscando();
                    HabilitaDesabilitaBotao(true);

                }
            }
            else
            {
                btINICIAR.Enabled = true;
                HabilitaDesabilitaBotao(false);
                nivel = 0;
                lblNivel.Text = "";
                MessageBox.Show("Sequência incorreta! Fim de jogo!");
            }
        }
    }
}
