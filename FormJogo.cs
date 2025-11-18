using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace JogoDaVelha
{
    public partial class FormJogo : Form
    {
        private string jogador = "X";
        private Button[] botoes;
        private int placarX = 0;
        private int placarO = 0;
        private int placarEmpate = 0;

        public FormJogo()
        {
            InitializeComponent();
        }

        private void FormJogo_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bem-vindo!\nGostaria de Jogar Jogo da Velha?", "Mensagem.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                botoes = new Button[] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9  };
                AtualizaPlacar();
                AtualizarIndicadorJogador();
            }
        }

        private void LimparTabuleiro()
        {
            foreach (Button btn in botoes)
            {
                btn.Text = "";
                btn.BackColor = DefaultBackColor;
            }
            jogador = "X";
            AtualizarIndicadorJogador();
        }

        private bool VerificaLinha()
        {
            for(int i = 0; i < 9; i += 3)
            {
                if (botoes[i].Text != "" &&
                    botoes[i].Text == botoes[i + 1].Text &&
                    botoes[i + 1].Text == botoes[i + 2].Text)
                {
                    MudaCorBotao(botoes[i], botoes[i + 1], botoes[i + 2]);
                    return true;
                }
            }

            return false;
        }

        private bool VerificaColuna()
        {
            for(int i = 0; i < 3; i++)
            {
                if (botoes[i].Text != "" &&
                    botoes[i].Text == botoes[i + 3].Text &&
                    botoes[i + 3].Text == botoes[i + 6].Text)
                {
                    MudaCorBotao(botoes[i], botoes[i + 3], botoes[i + 6]);
                    return true;
                }
            }

            return false;
        }

        private bool VerificaDiagonal()
        {
            for(int i = 0; i <= 2; i += 2)
            {
                if (botoes[i].Text != "" &&
                    botoes[i].Text == botoes[4].Text &&
                    botoes[4].Text == botoes[8 - i].Text)
                {
                    MudaCorBotao(botoes[i], botoes[4], botoes[8 - i]);
                    return true;
                }
            }

            return false;
        }

        private void MudaCorBotao(Button btn1, Button btn2, Button btn3)
        {
            btn1.BackColor = Color.LightGreen;
            btn2.BackColor = Color.LightGreen;
            btn3.BackColor = Color.LightGreen;
        }

        private bool VerificaGanhador()
        {
            return VerificaLinha() || VerificaColuna() || VerificaDiagonal();
        }

        private void AtualizarIndicadorJogador()
        {
            if (jogador == "X")
            {
                lbJogadorX.Font = new Font(lbJogadorX.Font, FontStyle.Bold);
                lbJogadorO.Font = new Font(lbJogadorO.Font, FontStyle.Regular);
            }
            else
            {
                lbJogadorO.Font = new Font(lbJogadorO.Font, FontStyle.Bold);
                lbJogadorX.Font = new Font(lbJogadorX.Font, FontStyle.Regular);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == "")
            {
                button.Text = jogador;
                if (jogador == "X")
                {
                    button.ForeColor = Color.Blue;
                    jogador = "O";
                }
                else
                {
                    button.ForeColor = Color.Red;
                    jogador = "X";
                }
            }

            string text = string.Empty;

            if (VerificaGanhador())
            {
                if(jogador == "X")
                {
                    text = "O jogador O venceu!";
                    placarO++;
                }
                else
                {
                    text = "O jogador X venceu!";
                    placarX++;
                }
            }
            else if (botoes.All(b => b.Text != ""))
            {
                text = "Empate!";
                placarEmpate++;
            }
            else
            {
                AtualizarIndicadorJogador();
                return;
            }

            MessageBox.Show(text, "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tbResultado.Text = text;
            LimparTabuleiro();
            AtualizaPlacar();
        }

        private void AtualizaPlacar()
        {
            lbJogadorX.Text = "Jogador X: " + placarX.ToString();
            lbJogadorO.Text = "Jogador O: " + placarO.ToString();
            lbEmpate.Text = "Empate: " + placarEmpate.ToString();
        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            placarX = 0;
            placarO = 0;
            placarEmpate = 0;

            AtualizaPlacar();
            tbResultado.Text = string.Empty;
        }
    }
}
