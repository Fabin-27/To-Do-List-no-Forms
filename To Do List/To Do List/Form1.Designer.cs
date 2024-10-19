namespace To_Do_List
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Adicionar = new Button();
            btn_Remover = new Button();
            btn_Carregar = new Button();
            ListBox = new CheckedListBox();
            text_Tarefa = new TextBox();
            label1 = new Label();
            btn_Salvar = new Button();
            btn_Limpar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // btn_Adicionar
            // 
            btn_Adicionar.BackColor = SystemColors.ActiveCaption;
            btn_Adicionar.Location = new Point(73, 200);
            btn_Adicionar.Name = "btn_Adicionar";
            btn_Adicionar.Size = new Size(194, 23);
            btn_Adicionar.TabIndex = 0;
            btn_Adicionar.Text = "Adicionar";
            btn_Adicionar.UseVisualStyleBackColor = false;
            btn_Adicionar.Click += btn_Adicionar_Click;
            // 
            // btn_Remover
            // 
            btn_Remover.BackColor = SystemColors.ActiveCaption;
            btn_Remover.Location = new Point(73, 255);
            btn_Remover.Name = "btn_Remover";
            btn_Remover.Size = new Size(194, 23);
            btn_Remover.TabIndex = 3;
            btn_Remover.Text = "Remover";
            btn_Remover.UseVisualStyleBackColor = false;
            btn_Remover.Click += btn_Remover_Click;
            // 
            // btn_Carregar
            // 
            btn_Carregar.BackColor = SystemColors.ActiveCaption;
            btn_Carregar.Location = new Point(78, 398);
            btn_Carregar.Name = "btn_Carregar";
            btn_Carregar.Size = new Size(189, 23);
            btn_Carregar.TabIndex = 4;
            btn_Carregar.Text = "Carregar";
            btn_Carregar.UseVisualStyleBackColor = false;
            btn_Carregar.Click += btn_Carregar_Click;
            // 
            // ListBox
            // 
            ListBox.BackColor = SystemColors.ActiveCaption;
            ListBox.FormattingEnabled = true;
            ListBox.Location = new Point(355, 43);
            ListBox.Name = "ListBox";
            ListBox.Size = new Size(332, 436);
            ListBox.TabIndex = 7;
            // 
            // text_Tarefa
            // 
            text_Tarefa.BackColor = SystemColors.ActiveCaption;
            text_Tarefa.Location = new Point(12, 44);
            text_Tarefa.Multiline = true;
            text_Tarefa.Name = "text_Tarefa";
            text_Tarefa.Size = new Size(321, 122);
            text_Tarefa.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 26);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 9;
            label1.Text = "Digite a tarefa:";
            // 
            // btn_Salvar
            // 
            btn_Salvar.BackColor = SystemColors.ActiveCaption;
            btn_Salvar.Location = new Point(73, 345);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Size = new Size(194, 23);
            btn_Salvar.TabIndex = 10;
            btn_Salvar.Text = "Salvar";
            btn_Salvar.UseVisualStyleBackColor = false;
            btn_Salvar.Click += btn_Salvar_Click;
            // 
            // btn_Limpar
            // 
            btn_Limpar.BackColor = SystemColors.ActiveCaption;
            btn_Limpar.Location = new Point(73, 456);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(194, 23);
            btn_Limpar.TabIndex = 11;
            btn_Limpar.Text = "Limpar Tudo";
            btn_Limpar.UseVisualStyleBackColor = false;
            btn_Limpar.Click += btn_Limpar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDark;
            label2.Location = new Point(106, 182);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 12;
            label2.Text = "Adicione a tarefa a lista";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlDark;
            label3.Location = new Point(106, 237);
            label3.Name = "label3";
            label3.Size = new Size(132, 15);
            label3.TabIndex = 13;
            label3.Text = "Remova a tarefa da lista";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlDark;
            label4.Location = new Point(106, 327);
            label4.Name = "label4";
            label4.Size = new Size(146, 15);
            label4.TabIndex = 14;
            label4.Text = "Salva as tarefas no arquivo";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlDark;
            label5.Location = new Point(73, 380);
            label5.Name = "label5";
            label5.Size = new Size(194, 15);
            label5.TabIndex = 15;
            label5.Text = "Carrega as tarefas salvas no arquivo";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlDark;
            label6.Location = new Point(106, 438);
            label6.Name = "label6";
            label6.Size = new Size(132, 15);
            label6.TabIndex = 16;
            label6.Text = "Limpa as tarefas da lista";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(699, 491);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_Limpar);
            Controls.Add(btn_Salvar);
            Controls.Add(label1);
            Controls.Add(text_Tarefa);
            Controls.Add(ListBox);
            Controls.Add(btn_Carregar);
            Controls.Add(btn_Remover);
            Controls.Add(btn_Adicionar);
            Name = "Form1";
            Text = "To Do List";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Adicionar;
        private Button btn_Remover;
        private Button btn_Carregar;
        private CheckedListBox ListBox;
        private TextBox text_Tarefa;
        private Label label1;
        private Button btn_Salvar;
        private Button btn_Limpar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
