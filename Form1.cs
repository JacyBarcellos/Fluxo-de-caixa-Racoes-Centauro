using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json; 
using System.Windows.Forms;

namespace FluxoCaixaApp
{
    public partial class Form1 : Form
    {
        private decimal saldoAtual = 0;
        private decimal totalReceitas = 0;
        private decimal totalDespesas = 0;
        private List<Transacao> historicoReceitas = new List<Transacao>();
        private List<Transacao> historicoDespesas = new List<Transacao>();
        private const string CaminhoArquivo = "fluxoCaixa.json"; 

        public Form1()
        {
            InitializeComponent();
            CarregarDados(); 
        }

        private void btnAdicionarReceita_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtValor.Text, out decimal valorReceita) && !string.IsNullOrWhiteSpace(txtNome.Text))
            {
                string nomeReceita = txtNome.Text.Trim();
                DateTime dataOperacao = dtpData.Value;

                saldoAtual += valorReceita;
                totalReceitas += valorReceita;

                Transacao novaReceita = new Transacao(dataOperacao, valorReceita, nomeReceita);
                lstReceitas.Items.Add(novaReceita.ToString());
                historicoReceitas.Add(novaReceita);

                AtualizarSaldo();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Por favor, insira um nome válido e um valor válido para a receita.");
            }
        }

        private void btnAdicionarDespesa_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtValor.Text, out decimal valorDespesa) && !string.IsNullOrWhiteSpace(txtNome.Text))
            {
                string nomeDespesa = txtNome.Text.Trim();
                DateTime dataOperacao = dtpData.Value;

                saldoAtual -= valorDespesa;
                totalDespesas += valorDespesa;

                Transacao novaDespesa = new Transacao(dataOperacao, -valorDespesa, nomeDespesa);
                lstDespesas.Items.Add(novaDespesa.ToString());
                historicoDespesas.Add(novaDespesa);

                AtualizarSaldo();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Por favor, insira um nome válido e um valor válido para a despesa.");
            }
        }

        private void AtualizarSaldo()
        {
            lblSaldo.Text = $"Saldo Atual: {saldoAtual:C}";
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtValor.Clear();
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            DateTime dataInicio = dtpFiltroInicio.Value.Date;
            DateTime dataFim = dtpFiltroFim.Value.Date;

            if (dataInicio > dataFim)
            {
                MessageBox.Show("A data inicial não pode ser maior que a data final.", "Erro de Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var receitasFiltradas = historicoReceitas
                .Where(r => r.Data.Date >= dataInicio && r.Data.Date <= dataFim)
                .ToList();

            var despesasFiltradas = historicoDespesas
                .Where(d => d.Data.Date >= dataInicio && d.Data.Date <= dataFim)
                .ToList();

            string relatorio = $"Relatório de {dataInicio:dd/MM/yyyy} até {dataFim:dd/MM/yyyy}:\n\n";
            relatorio += "Receitas:\n";

            if (receitasFiltradas.Count > 0)
            {
                foreach (var receita in receitasFiltradas)
                {
                    relatorio += $"{receita}\n";
                }
            }
            else
            {
                relatorio += "Nenhuma receita encontrada no período.\n";
            }

            relatorio += "\nDespesas:\n";

            if (despesasFiltradas.Count > 0)
            {
                foreach (var despesa in despesasFiltradas)
                {
                    relatorio += $"{despesa}\n";
                }
            }
            else
            {
                relatorio += "Nenhuma despesa encontrada no período.\n";
            }

            relatorio += $"\nSaldo Final: {saldoAtual:C}\n";

            try
            {
                string caminhoArquivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "RelatorioFluxoCaixa.txt");
                File.WriteAllText(caminhoArquivo, relatorio);

                MessageBox.Show($"Relatório gerado com sucesso!\nO arquivo foi salvo em: {caminhoArquivo}", "Relatório Gerado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar o relatório: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluirReceita_Click(object sender, EventArgs e)
        {
            if (lstReceitas.SelectedIndex >= 0)
            {
                int index = lstReceitas.SelectedIndex;

                Transacao receitaRemovida = historicoReceitas[index];
                saldoAtual -= receitaRemovida.Valor;
                totalReceitas -= receitaRemovida.Valor;

                historicoReceitas.RemoveAt(index);
                lstReceitas.Items.RemoveAt(index);

                AtualizarSaldo();
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma receita para excluir.");
            }
        }

        private void btnExcluirDespesa_Click(object sender, EventArgs e)
        {
            if (lstDespesas.SelectedIndex >= 0)
            {
                int index = lstDespesas.SelectedIndex;

                Transacao despesaRemovida = historicoDespesas[index];
                saldoAtual += Math.Abs(despesaRemovida.Valor);
                totalDespesas -= Math.Abs(despesaRemovida.Valor);

                historicoDespesas.RemoveAt(index);
                lstDespesas.Items.RemoveAt(index);

                AtualizarSaldo();
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma despesa para excluir.");
            }
        }

        
        private void SalvarDados()
        {
            var dados = new DadosSalvos
            {
                SaldoAtual = saldoAtual,
                TotalReceitas = totalReceitas,
                TotalDespesas = totalDespesas,
                Receitas = historicoReceitas ?? new List<Transacao>(), // Garante que as listas não sejam nulas
                Despesas = historicoDespesas ?? new List<Transacao>() // Garante que as listas não sejam nulas
            };

            string json = JsonSerializer.Serialize(dados);
            File.WriteAllText(CaminhoArquivo, json);
        }

        
        private void CarregarDados()
        {
            if (File.Exists(CaminhoArquivo))
            {
                string json = File.ReadAllText(CaminhoArquivo);
                var dados = JsonSerializer.Deserialize<DadosSalvos>(json);

                saldoAtual = dados?.SaldoAtual ?? 0;
                totalReceitas = dados?.TotalReceitas ?? 0;
                totalDespesas = dados?.TotalDespesas ?? 0;

                historicoReceitas = dados?.Receitas ?? new List<Transacao>();
                historicoDespesas = dados?.Despesas ?? new List<Transacao>();

                foreach (var receita in historicoReceitas)
                {
                    lstReceitas.Items.Add(receita.ToString());
                }

                foreach (var despesa in historicoDespesas)
                {
                    lstDespesas.Items.Add(despesa.ToString());
                }

                AtualizarSaldo();
            }
        }

        
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            SalvarDados();
            base.OnFormClosing(e);
        }
    }

    public class Transacao
    {
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }

        public Transacao(DateTime data, decimal valor, string descricao)
        {
            Data = data;
            Valor = valor;
            Descricao = descricao;
        }

        public override string ToString()
        {
            string sinal = Valor >= 0 ? "+" : "-";
            return $"{Data:dd/MM/yyyy} - {sinal}{Math.Abs(Valor):C} - {Descricao}";
        }
    }

    
    public class DadosSalvos
    {
        public decimal SaldoAtual { get; set; }
        public decimal TotalReceitas { get; set; }
        public decimal TotalDespesas { get; set; }
        public List<Transacao> Receitas { get; set; } = new List<Transacao>(); 
        public List<Transacao> Despesas { get; set; } = new List<Transacao>(); 
    }
}
