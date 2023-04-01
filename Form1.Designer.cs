namespace SistemaDeReservaDeEquipamentos
{
    partial class TelaLogin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelTextoStatus = new Label();
            textBoxUsuario = new TextBox();
            label5 = new Label();
            buttonLogin = new Button();
            textBoxSenha = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Lucida Console", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(309, 21);
            label1.TabIndex = 0;
            label1.Text = "Reserva de Equipamentos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Location = new Point(54, 133);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Usuário : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Location = new Point(55, 163);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Senha :";
            // 
            // labelTextoStatus
            // 
            labelTextoStatus.AutoSize = true;
            labelTextoStatus.BackColor = SystemColors.Control;
            labelTextoStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTextoStatus.Location = new Point(54, 67);
            labelTextoStatus.Name = "labelTextoStatus";
            labelTextoStatus.Size = new Size(232, 21);
            labelTextoStatus.TabIndex = 3;
            labelTextoStatus.Text = "Entre com seus dados de acesso";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BackColor = SystemColors.Control;
            textBoxUsuario.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsuario.Location = new Point(118, 130);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(143, 23);
            textBoxUsuario.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(205, 281);
            label5.MaximumSize = new Size(132, 15);
            label5.MinimumSize = new Size(132, 15);
            label5.Name = "label5";
            label5.Size = new Size(132, 15);
            label5.TabIndex = 6;
            label5.Text = "Colégio Vencer Sempre";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.Highlight;
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogin.ForeColor = SystemColors.ControlLightLight;
            buttonLogin.Location = new Point(117, 201);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(143, 32);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            buttonLogin.MouseEnter += buttonLogin_MouseEnter;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(117, 167);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(143, 23);
            textBoxSenha.TabIndex = 2;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.import_professoretecnologia;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(337, 296);
            Controls.Add(textBoxSenha);
            Controls.Add(buttonLogin);
            Controls.Add(label5);
            Controls.Add(textBoxUsuario);
            Controls.Add(labelTextoStatus);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MaximumSize = new Size(357, 339);
            MinimizeBox = false;
            MinimumSize = new Size(357, 339);
            Name = "TelaLogin";
            Text = "Tela de Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelTextoStatus;
        private TextBox textBoxUsuario;
        private Label label5;
        private Button buttonLogin;
        private TextBox textBoxSenha;
    }
}