namespace FluxoCaixaApp
{
    partial class Form1
    {
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnAdicionarReceita;
        private System.Windows.Forms.Button btnAdicionarDespesa;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.Button btnExcluirReceita;
        private System.Windows.Forms.Button btnExcluirDespesa;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.ListBox lstReceitas;
        private System.Windows.Forms.ListBox lstDespesas;
        private System.Windows.Forms.DateTimePicker dtpFiltroInicio;
        private System.Windows.Forms.DateTimePicker dtpFiltroFim;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblReceitas;
        private System.Windows.Forms.Label lblDespesas;
        private System.Windows.Forms.Label lblFiltroInicio;
        private System.Windows.Forms.Label lblFiltroFim;

        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnAdicionarReceita = new System.Windows.Forms.Button();
            this.btnAdicionarDespesa = new System.Windows.Forms.Button();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.btnExcluirReceita = new System.Windows.Forms.Button();
            this.btnExcluirDespesa = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lstReceitas = new System.Windows.Forms.ListBox();
            this.lstDespesas = new System.Windows.Forms.ListBox();
            this.dtpFiltroInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFiltroFim = new System.Windows.Forms.DateTimePicker();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblReceitas = new System.Windows.Forms.Label();
            this.lblDespesas = new System.Windows.Forms.Label();
            this.lblFiltroInicio = new System.Windows.Forms.Label();
            this.lblFiltroFim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            
            
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 10);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 17);
            this.lblNome.Text = "Descrição:";
            this.txtNome.Location = new System.Drawing.Point(12, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 22);
            
            
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(230, 10);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(41, 17);
            this.lblValor.Text = "Valor:";
            this.txtValor.Location = new System.Drawing.Point(230, 30);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 22);
            
            
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(350, 10);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(38, 17);
            this.lblData.Text = "Data:";
            this.dtpData.Location = new System.Drawing.Point(350, 30);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 22);

            
            this.btnAdicionarReceita.Location = new System.Drawing.Point(12, 70);
            this.btnAdicionarReceita.Name = "btnAdicionarReceita";
            this.btnAdicionarReceita.Size = new System.Drawing.Size(120, 23);
            this.btnAdicionarReceita.Text = "Adicionar Receita";
            this.btnAdicionarReceita.Click += new System.EventHandler(this.btnAdicionarReceita_Click);
            
            
            this.btnAdicionarDespesa.Location = new System.Drawing.Point(150, 70);
            this.btnAdicionarDespesa.Name = "btnAdicionarDespesa";
            this.btnAdicionarDespesa.Size = new System.Drawing.Size(120, 23);
            this.btnAdicionarDespesa.Text = "Adicionar Despesa";
            this.btnAdicionarDespesa.Click += new System.EventHandler(this.btnAdicionarDespesa_Click);

            
            this.lblReceitas.AutoSize = true;
            this.lblReceitas.Location = new System.Drawing.Point(12, 110);
            this.lblReceitas.Name = "lblReceitas";
            this.lblReceitas.Size = new System.Drawing.Size(65, 17);
            this.lblReceitas.Text = "Receitas:";
            
            
            this.lstReceitas.FormattingEnabled = true;
            this.lstReceitas.ItemHeight = 16;
            this.lstReceitas.Location = new System.Drawing.Point(12, 130);
            this.lstReceitas.Name = "lstReceitas";
            this.lstReceitas.Size = new System.Drawing.Size(250, 100);

            
            this.btnExcluirReceita.Location = new System.Drawing.Point(12, 240);
            this.btnExcluirReceita.Name = "btnExcluirReceita";
            this.btnExcluirReceita.Size = new System.Drawing.Size(120, 23);
            this.btnExcluirReceita.Text = "Excluir Receita";
            this.btnExcluirReceita.Click += new System.EventHandler(this.btnExcluirReceita_Click);
            
            
            this.lblDespesas.AutoSize = true;
            this.lblDespesas.Location = new System.Drawing.Point(300, 110);
            this.lblDespesas.Name = "lblDespesas";
            this.lblDespesas.Size = new System.Drawing.Size(74, 17);
            this.lblDespesas.Text = "Despesas:";
            
            
            this.lstDespesas.FormattingEnabled = true;
            this.lstDespesas.ItemHeight = 16;
            this.lstDespesas.Location = new System.Drawing.Point(300, 130);
            this.lstDespesas.Name = "lstDespesas";
            this.lstDespesas.Size = new System.Drawing.Size(250, 100);

            
            this.btnExcluirDespesa.Location = new System.Drawing.Point(300, 240);
            this.btnExcluirDespesa.Name = "btnExcluirDespesa";
            this.btnExcluirDespesa.Size = new System.Drawing.Size(120, 23);
            this.btnExcluirDespesa.Text = "Excluir Despesa";
            this.btnExcluirDespesa.Click += new System.EventHandler(this.btnExcluirDespesa_Click);
            
            
            this.lblFiltroInicio.AutoSize = true;
            this.lblFiltroInicio.Location = new System.Drawing.Point(12, 280);
            this.lblFiltroInicio.Name = "lblFiltroInicio";
            this.lblFiltroInicio.Size = new System.Drawing.Size(85, 17);
            this.lblFiltroInicio.Text = "Data Inicial:";
            this.dtpFiltroInicio.Location = new System.Drawing.Point(12, 300);
            this.dtpFiltroInicio.Name = "dtpFiltroInicio";
            this.dtpFiltroInicio.Size = new System.Drawing.Size(200, 22);
            
            
            this.lblFiltroFim.AutoSize = true;
            this.lblFiltroFim.Location = new System.Drawing.Point(230, 280);
            this.lblFiltroFim.Name = "lblFiltroFim";
            this.lblFiltroFim.Size = new System.Drawing.Size(76, 17);
            this.lblFiltroFim.Text = "Data Final:";
            this.dtpFiltroFim.Location = new System.Drawing.Point(230, 300);
            this.dtpFiltroFim.Name = "dtpFiltroFim";
            this.dtpFiltroFim.Size = new System.Drawing.Size(200, 22);

            
            this.btnGerarRelatorio.Location = new System.Drawing.Point(450, 300);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(120, 23);
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);

            
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(12, 350);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(86, 17);
            this.lblSaldo.Text = "Saldo Atual: 0";

            
            this.ClientSize = new System.Drawing.Size(580, 400);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.btnAdicionarReceita);
            this.Controls.Add(this.btnAdicionarDespesa);
            this.Controls.Add(this.lblReceitas);
            this.Controls.Add(this.lstReceitas);
            this.Controls.Add(this.btnExcluirReceita);
            this.Controls.Add(this.lblDespesas);
            this.Controls.Add(this.lstDespesas);
            this.Controls.Add(this.btnExcluirDespesa);
            this.Controls.Add(this.lblFiltroInicio);
            this.Controls.Add(this.dtpFiltroInicio);
            this.Controls.Add(this.lblFiltroFim);
            this.Controls.Add(this.dtpFiltroFim);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.lblSaldo);
            this.Name = "Form1";
            this.Text = "Fluxo de Caixa Rações Centauro";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
