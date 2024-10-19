namespace To_Do_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_Adicionar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(text_Tarefa.Text))
            {
                ListBox.Items.Add(text_Tarefa.Text);

                text_Tarefa.Clear();
            }
            else
            {
                MessageBox.Show("Digite uma tarefa antes de adicionar.", "Aten��o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            if (ListBox.SelectedIndex >= 0)
            {

                ListBox.Items.RemoveAt(ListBox.SelectedIndex);
                MessageBox.Show("Tarefa removida com sucesso.", "Informa��o", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                MessageBox.Show("Selecione uma tarefa na lista para remover.", "Aten��o", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(text_Tarefa.Text))
            {
                using (StreamWriter writer = new StreamWriter("C:\\Users\\Loure\\Desktop\\Trabalho\\arquivo.txt", false))
                {
                    foreach (var item in ListBox.Items)
                    {
                        bool concluida = ListBox.GetItemChecked(ListBox.Items.IndexOf(item));
                        string estado = concluida ? "conclu�da" : "pendente";
                        writer.WriteLine($"{item} | {estado}");
                    }
                }
                MessageBox.Show("Tarefas salvas com sucesso.", "Informa��o", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                MessageBox.Show("Primeiro adicione a tarefa a lista.", "Aten��o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_Carregar_Click(object sender, EventArgs e)
        {
            if (File.Exists("C:\\Users\\Loure\\Desktop\\Trabalho\\arquivo.txt"))
            {
                ListBox.Items.Clear();

                using (StreamReader reader = new StreamReader("C:\\Users\\Loure\\Desktop\\Trabalho\\arquivo.txt"))
                {
                    string linha;
                    while ((linha = reader.ReadLine()) != null)
                    {
                        string[] partes = linha.Split('|');

                        if (partes.Length == 2)
                        {
                            string tarefa = partes[0].Trim();
                            string estado = partes[1].Trim();

                            int index = ListBox.Items.Add(tarefa);

                            if (estado == "conclu�da")
                            {
                                ListBox.SetItemChecked(index, true);
                            }
                        }
                    }
                }

                MessageBox.Show("Tarefas carregadas com sucesso.", "Informa��o", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O arquivo de tarefas n�o foi encontrado.", "Aten��o", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {

            if (ListBox.Items.Count > 0)
            {
                ListBox.Items.Clear();

                MessageBox.Show("Todas as tarefas foram removidas da lista.", "Informa��o", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("A lista j� est� vazia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
