namespace SistemaDeReservaDeEquipamentos
{
    partial class TelaEquipamentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        internal void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxNome = new TextBox();
            maskedTextBoxCpf = new MaskedTextBox();
            buttonRegistrarColaborador = new Button();
            label4 = new Label();
            checkBoxCxDeSom = new CheckBox();
            checkBoxCanetaLaser = new CheckBox();
            checkBoxExtensaoEletrica = new CheckBox();
            checkBoxMicrofone = new CheckBox();
            checkBoxMicSemFio = new CheckBox();
            checkBoxMiniTeclado = new CheckBox();
            checkBoxMouse = new CheckBox();
            checkBoxNotebook = new CheckBox();
            checkBoxPedestal = new CheckBox();
            checkBoxPedestalMicrofone = new CheckBox();
            checkBoxProjetor = new CheckBox();
            checkBoxSmartTv = new CheckBox();
            checkBoxTablet = new CheckBox();
            checkBoxTeclado = new CheckBox();
            checkBoxTelaProjecao = new CheckBox();
            numericUpDownCanetaLaser = new NumericUpDown();
            numericUpDownSmartTv = new NumericUpDown();
            numericUpDownProjetor = new NumericUpDown();
            numericUpDownPedestalTablet = new NumericUpDown();
            numericUpDownPedestalMic = new NumericUpDown();
            numericUpDownTelaProjecao = new NumericUpDown();
            numericUpDownTeclado = new NumericUpDown();
            numericUpDownCxDeSom = new NumericUpDown();
            numericUpDownExtensaoEletrica = new NumericUpDown();
            numericUpDownMicrofone = new NumericUpDown();
            numericUpDownMicSemFio = new NumericUpDown();
            numericUpDownMiniTeclado = new NumericUpDown();
            numericUpDownMouse = new NumericUpDown();
            numericUpDownNotebook = new NumericUpDown();
            numericUpDownTablet = new NumericUpDown();
            checkBoxMouseSemFio = new CheckBox();
            numericUpDownMouseFio = new NumericUpDown();
            label5 = new Label();
            dateTimePickerHoraInicial = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            dateTimePickerHoraFinal = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            maskedTextBoxHoraInicial = new MaskedTextBox();
            maskedTextBoxHoraFinal = new MaskedTextBox();
            buttonRealizarReserva = new Button();
            toolTip1 = new ToolTip(components);
            labelCancelarReserva = new Label();
            labelDigiteReserva = new Label();
            buttonCancelarReserva = new Button();
            maskedTextBoxCpfCancela = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCanetaLaser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSmartTv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProjetor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPedestalTablet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPedestalMic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTelaProjecao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTeclado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCxDeSom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownExtensaoEletrica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMicrofone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMicSemFio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMiniTeclado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMouse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNotebook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTablet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMouseFio).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 29);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(11, 36);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 1;
            label2.Text = "Nome : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(414, 36);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 2;
            label3.Text = "CPF  :";
            // 
            // textBoxNome
            // 
            textBoxNome.Cursor = Cursors.IBeam;
            textBoxNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNome.Location = new Point(77, 33);
            textBoxNome.MaxLength = 80;
            textBoxNome.Name = "textBoxNome";
            textBoxNome.PlaceholderText = "Digite seu nome completo";
            textBoxNome.Size = new Size(331, 29);
            textBoxNome.TabIndex = 3;
            // 
            // maskedTextBoxCpf
            // 
            maskedTextBoxCpf.Cursor = Cursors.IBeam;
            maskedTextBoxCpf.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxCpf.Location = new Point(470, 33);
            maskedTextBoxCpf.Mask = "000,000,000-00";
            maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            maskedTextBoxCpf.Size = new Size(127, 27);
            maskedTextBoxCpf.TabIndex = 4;
            // 
            // buttonRegistrarColaborador
            // 
            buttonRegistrarColaborador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegistrarColaborador.Location = new Point(613, 31);
            buttonRegistrarColaborador.Name = "buttonRegistrarColaborador";
            buttonRegistrarColaborador.Size = new Size(131, 29);
            buttonRegistrarColaborador.TabIndex = 3;
            buttonRegistrarColaborador.Text = "REGISTRAR";
            buttonRegistrarColaborador.UseVisualStyleBackColor = true;
            buttonRegistrarColaborador.Click += buttonRegistrarColaborador_Click_1;
            buttonRegistrarColaborador.MouseHover += buttonRegistrarColaborador_MouseHover;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(11, 80);
            label4.Name = "label4";
            label4.Size = new Size(294, 21);
            label4.TabIndex = 0;
            label4.Text = "Escolha o equipamento e quantidade";
            // 
            // checkBoxCxDeSom
            // 
            checkBoxCxDeSom.AutoSize = true;
            checkBoxCxDeSom.Enabled = false;
            checkBoxCxDeSom.Location = new Point(12, 129);
            checkBoxCxDeSom.Name = "checkBoxCxDeSom";
            checkBoxCxDeSom.Size = new Size(98, 19);
            checkBoxCxDeSom.TabIndex = 4;
            checkBoxCxDeSom.Text = "Caixa de Som";
            checkBoxCxDeSom.UseVisualStyleBackColor = true;
            checkBoxCxDeSom.CheckedChanged += checkBoxCxDeSom_CheckedChanged;
            checkBoxCxDeSom.MouseHover += checkBoxCxDeSom_MouseHover;
            // 
            // checkBoxCanetaLaser
            // 
            checkBoxCanetaLaser.AutoSize = true;
            checkBoxCanetaLaser.Enabled = false;
            checkBoxCanetaLaser.Location = new Point(11, 167);
            checkBoxCanetaLaser.Name = "checkBoxCanetaLaser";
            checkBoxCanetaLaser.Size = new Size(93, 19);
            checkBoxCanetaLaser.TabIndex = 6;
            checkBoxCanetaLaser.Text = "Caneta Laser";
            checkBoxCanetaLaser.UseVisualStyleBackColor = true;
            checkBoxCanetaLaser.CheckedChanged += checkBoxCanetaLaser_CheckedChanged_1;
            checkBoxCanetaLaser.MouseHover += checkBoxCanetaLaser_MouseHover;
            // 
            // checkBoxExtensaoEletrica
            // 
            checkBoxExtensaoEletrica.AutoSize = true;
            checkBoxExtensaoEletrica.Enabled = false;
            checkBoxExtensaoEletrica.Location = new Point(11, 204);
            checkBoxExtensaoEletrica.Name = "checkBoxExtensaoEletrica";
            checkBoxExtensaoEletrica.Size = new Size(114, 19);
            checkBoxExtensaoEletrica.TabIndex = 8;
            checkBoxExtensaoEletrica.Text = "Extensão elétrica";
            checkBoxExtensaoEletrica.UseVisualStyleBackColor = true;
            checkBoxExtensaoEletrica.CheckedChanged += checkBoxExtensaoEletrica_CheckedChanged;
            checkBoxExtensaoEletrica.MouseHover += checkBoxExtensaoEletrica_MouseHover;
            // 
            // checkBoxMicrofone
            // 
            checkBoxMicrofone.AutoSize = true;
            checkBoxMicrofone.Enabled = false;
            checkBoxMicrofone.Location = new Point(12, 240);
            checkBoxMicrofone.Name = "checkBoxMicrofone";
            checkBoxMicrofone.Size = new Size(81, 19);
            checkBoxMicrofone.TabIndex = 10;
            checkBoxMicrofone.Text = "Microfone";
            checkBoxMicrofone.UseVisualStyleBackColor = true;
            checkBoxMicrofone.CheckedChanged += checkBoxMicrofone_CheckedChanged;
            checkBoxMicrofone.MouseHover += checkBoxMicrofone_MouseHover;
            // 
            // checkBoxMicSemFio
            // 
            checkBoxMicSemFio.AutoSize = true;
            checkBoxMicSemFio.Enabled = false;
            checkBoxMicSemFio.Location = new Point(381, 129);
            checkBoxMicSemFio.Name = "checkBoxMicSemFio";
            checkBoxMicSemFio.Size = new Size(123, 19);
            checkBoxMicSemFio.TabIndex = 12;
            checkBoxMicSemFio.Text = "Microfone sem fio";
            checkBoxMicSemFio.UseVisualStyleBackColor = true;
            checkBoxMicSemFio.CheckedChanged += checkBoxMicSemFio_CheckedChanged;
            checkBoxMicSemFio.MouseHover += checkBoxMicSemFio_MouseHover;
            // 
            // checkBoxMiniTeclado
            // 
            checkBoxMiniTeclado.AutoSize = true;
            checkBoxMiniTeclado.Enabled = false;
            checkBoxMiniTeclado.Location = new Point(382, 170);
            checkBoxMiniTeclado.Name = "checkBoxMiniTeclado";
            checkBoxMiniTeclado.Size = new Size(92, 19);
            checkBoxMiniTeclado.TabIndex = 14;
            checkBoxMiniTeclado.Text = "Mini teclado";
            checkBoxMiniTeclado.UseVisualStyleBackColor = true;
            checkBoxMiniTeclado.CheckedChanged += checkBoxMiniTeclado_CheckedChanged;
            checkBoxMiniTeclado.MouseHover += checkBoxMiniTeclado_MouseHover;
            // 
            // checkBoxMouse
            // 
            checkBoxMouse.AutoSize = true;
            checkBoxMouse.Enabled = false;
            checkBoxMouse.Location = new Point(382, 203);
            checkBoxMouse.Name = "checkBoxMouse";
            checkBoxMouse.Size = new Size(62, 19);
            checkBoxMouse.TabIndex = 16;
            checkBoxMouse.Text = "Mouse";
            checkBoxMouse.UseVisualStyleBackColor = true;
            checkBoxMouse.CheckedChanged += checkBoxMouse_CheckedChanged;
            checkBoxMouse.MouseHover += checkBoxMouse_MouseHover;
            // 
            // checkBoxNotebook
            // 
            checkBoxNotebook.AutoSize = true;
            checkBoxNotebook.Enabled = false;
            checkBoxNotebook.Location = new Point(382, 239);
            checkBoxNotebook.Name = "checkBoxNotebook";
            checkBoxNotebook.Size = new Size(79, 19);
            checkBoxNotebook.TabIndex = 18;
            checkBoxNotebook.Text = "Notebook";
            checkBoxNotebook.UseVisualStyleBackColor = true;
            checkBoxNotebook.CheckedChanged += checkBoxNotebook_CheckedChanged;
            checkBoxNotebook.MouseHover += checkBoxNotebook_MouseHover;
            // 
            // checkBoxPedestal
            // 
            checkBoxPedestal.AutoSize = true;
            checkBoxPedestal.Enabled = false;
            checkBoxPedestal.Location = new Point(217, 129);
            checkBoxPedestal.Name = "checkBoxPedestal";
            checkBoxPedestal.Size = new Size(70, 19);
            checkBoxPedestal.TabIndex = 20;
            checkBoxPedestal.Text = "Pedestal";
            checkBoxPedestal.UseVisualStyleBackColor = true;
            checkBoxPedestal.CheckedChanged += checkBoxPedestal_CheckedChanged;
            checkBoxPedestal.MouseHover += checkBoxPedestal_MouseHover;
            // 
            // checkBoxPedestalMicrofone
            // 
            checkBoxPedestalMicrofone.AutoSize = true;
            checkBoxPedestalMicrofone.Enabled = false;
            checkBoxPedestalMicrofone.Location = new Point(217, 167);
            checkBoxPedestalMicrofone.Name = "checkBoxPedestalMicrofone";
            checkBoxPedestalMicrofone.Size = new Size(70, 19);
            checkBoxPedestalMicrofone.TabIndex = 22;
            checkBoxPedestalMicrofone.Text = "Pedestal";
            checkBoxPedestalMicrofone.UseVisualStyleBackColor = true;
            checkBoxPedestalMicrofone.CheckedChanged += checkBoxPedestalMicrofone_CheckedChanged;
            checkBoxPedestalMicrofone.MouseHover += checkBoxPedestalMicrofone_MouseHover;
            // 
            // checkBoxProjetor
            // 
            checkBoxProjetor.AutoSize = true;
            checkBoxProjetor.Enabled = false;
            checkBoxProjetor.Location = new Point(217, 203);
            checkBoxProjetor.Name = "checkBoxProjetor";
            checkBoxProjetor.Size = new Size(68, 19);
            checkBoxProjetor.TabIndex = 24;
            checkBoxProjetor.Text = "Projetor";
            checkBoxProjetor.UseVisualStyleBackColor = true;
            checkBoxProjetor.CheckedChanged += checkBoxProjetor_CheckedChanged;
            checkBoxProjetor.MouseHover += checkBoxProjetor_MouseHover;
            // 
            // checkBoxSmartTv
            // 
            checkBoxSmartTv.AutoSize = true;
            checkBoxSmartTv.Enabled = false;
            checkBoxSmartTv.Location = new Point(217, 240);
            checkBoxSmartTv.Name = "checkBoxSmartTv";
            checkBoxSmartTv.Size = new Size(70, 19);
            checkBoxSmartTv.TabIndex = 26;
            checkBoxSmartTv.Text = "Smart tv";
            checkBoxSmartTv.UseVisualStyleBackColor = true;
            checkBoxSmartTv.CheckedChanged += checkBoxSmartTv_CheckedChanged;
            checkBoxSmartTv.MouseHover += checkBoxSmartTv_MouseHover;
            // 
            // checkBoxTablet
            // 
            checkBoxTablet.AutoSize = true;
            checkBoxTablet.Enabled = false;
            checkBoxTablet.Location = new Point(600, 126);
            checkBoxTablet.Name = "checkBoxTablet";
            checkBoxTablet.Size = new Size(57, 19);
            checkBoxTablet.TabIndex = 28;
            checkBoxTablet.Text = "Tablet";
            checkBoxTablet.UseVisualStyleBackColor = true;
            checkBoxTablet.CheckedChanged += checkBoxTablet_CheckedChanged;
            checkBoxTablet.MouseHover += checkBoxTablet_MouseHover;
            // 
            // checkBoxTeclado
            // 
            checkBoxTeclado.AutoSize = true;
            checkBoxTeclado.Enabled = false;
            checkBoxTeclado.Location = new Point(600, 163);
            checkBoxTeclado.Name = "checkBoxTeclado";
            checkBoxTeclado.Size = new Size(66, 19);
            checkBoxTeclado.TabIndex = 30;
            checkBoxTeclado.Text = "Teclado";
            checkBoxTeclado.UseVisualStyleBackColor = true;
            checkBoxTeclado.CheckedChanged += checkBoxTeclado_CheckedChanged;
            checkBoxTeclado.MouseHover += checkBoxTeclado_MouseHover;
            // 
            // checkBoxTelaProjecao
            // 
            checkBoxTelaProjecao.AutoSize = true;
            checkBoxTelaProjecao.Enabled = false;
            checkBoxTelaProjecao.Location = new Point(600, 200);
            checkBoxTelaProjecao.Name = "checkBoxTelaProjecao";
            checkBoxTelaProjecao.Size = new Size(111, 19);
            checkBoxTelaProjecao.TabIndex = 32;
            checkBoxTelaProjecao.Text = "Tela de projeção";
            checkBoxTelaProjecao.UseVisualStyleBackColor = true;
            checkBoxTelaProjecao.CheckedChanged += checkBoxTelaProjecao_CheckedChanged;
            checkBoxTelaProjecao.MouseHover += checkBoxTelaProjecao_MouseHover;
            // 
            // numericUpDownCanetaLaser
            // 
            numericUpDownCanetaLaser.Enabled = false;
            numericUpDownCanetaLaser.Location = new Point(131, 166);
            numericUpDownCanetaLaser.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDownCanetaLaser.Name = "numericUpDownCanetaLaser";
            numericUpDownCanetaLaser.Size = new Size(38, 23);
            numericUpDownCanetaLaser.TabIndex = 7;
            numericUpDownCanetaLaser.ValueChanged += numericUpDownCanetaLaser_ValueChanged;
            // 
            // numericUpDownSmartTv
            // 
            numericUpDownSmartTv.Enabled = false;
            numericUpDownSmartTv.Location = new Point(302, 240);
            numericUpDownSmartTv.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownSmartTv.Name = "numericUpDownSmartTv";
            numericUpDownSmartTv.Size = new Size(38, 23);
            numericUpDownSmartTv.TabIndex = 27;
            numericUpDownSmartTv.ValueChanged += numericUpDownSmartTv_ValueChanged;
            // 
            // numericUpDownProjetor
            // 
            numericUpDownProjetor.Enabled = false;
            numericUpDownProjetor.Location = new Point(302, 199);
            numericUpDownProjetor.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownProjetor.Name = "numericUpDownProjetor";
            numericUpDownProjetor.Size = new Size(38, 23);
            numericUpDownProjetor.TabIndex = 25;
            numericUpDownProjetor.ValueChanged += numericUpDownProjetor_ValueChanged;
            // 
            // numericUpDownPedestalTablet
            // 
            numericUpDownPedestalTablet.Enabled = false;
            numericUpDownPedestalTablet.Location = new Point(302, 128);
            numericUpDownPedestalTablet.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDownPedestalTablet.Name = "numericUpDownPedestalTablet";
            numericUpDownPedestalTablet.Size = new Size(38, 23);
            numericUpDownPedestalTablet.TabIndex = 21;
            numericUpDownPedestalTablet.ValueChanged += numericUpDownPedestalTablet_ValueChanged;
            // 
            // numericUpDownPedestalMic
            // 
            numericUpDownPedestalMic.Enabled = false;
            numericUpDownPedestalMic.Location = new Point(302, 166);
            numericUpDownPedestalMic.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDownPedestalMic.Name = "numericUpDownPedestalMic";
            numericUpDownPedestalMic.Size = new Size(38, 23);
            numericUpDownPedestalMic.TabIndex = 23;
            numericUpDownPedestalMic.ValueChanged += numericUpDownPedestalMic_ValueChanged;
            // 
            // numericUpDownTelaProjecao
            // 
            numericUpDownTelaProjecao.Enabled = false;
            numericUpDownTelaProjecao.Location = new Point(706, 196);
            numericUpDownTelaProjecao.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDownTelaProjecao.Name = "numericUpDownTelaProjecao";
            numericUpDownTelaProjecao.Size = new Size(38, 23);
            numericUpDownTelaProjecao.TabIndex = 33;
            numericUpDownTelaProjecao.ValueChanged += numericUpDownTelaProjecao_ValueChanged;
            // 
            // numericUpDownTeclado
            // 
            numericUpDownTeclado.Enabled = false;
            numericUpDownTeclado.Location = new Point(706, 157);
            numericUpDownTeclado.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDownTeclado.Name = "numericUpDownTeclado";
            numericUpDownTeclado.Size = new Size(38, 23);
            numericUpDownTeclado.TabIndex = 31;
            numericUpDownTeclado.ValueChanged += numericUpDownTeclado_ValueChanged;
            // 
            // numericUpDownCxDeSom
            // 
            numericUpDownCxDeSom.Enabled = false;
            numericUpDownCxDeSom.Location = new Point(131, 128);
            numericUpDownCxDeSom.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDownCxDeSom.Name = "numericUpDownCxDeSom";
            numericUpDownCxDeSom.Size = new Size(38, 23);
            numericUpDownCxDeSom.TabIndex = 5;
            numericUpDownCxDeSom.ValueChanged += numericUpDownCxDeSom_ValueChanged;
            // 
            // numericUpDownExtensaoEletrica
            // 
            numericUpDownExtensaoEletrica.Enabled = false;
            numericUpDownExtensaoEletrica.Location = new Point(131, 200);
            numericUpDownExtensaoEletrica.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDownExtensaoEletrica.Name = "numericUpDownExtensaoEletrica";
            numericUpDownExtensaoEletrica.Size = new Size(38, 23);
            numericUpDownExtensaoEletrica.TabIndex = 9;
            numericUpDownExtensaoEletrica.ValueChanged += numericUpDownExtensaoEletrica_ValueChanged;
            // 
            // numericUpDownMicrofone
            // 
            numericUpDownMicrofone.Enabled = false;
            numericUpDownMicrofone.Location = new Point(131, 239);
            numericUpDownMicrofone.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDownMicrofone.Name = "numericUpDownMicrofone";
            numericUpDownMicrofone.Size = new Size(38, 23);
            numericUpDownMicrofone.TabIndex = 11;
            numericUpDownMicrofone.ValueChanged += numericUpDownMicrofone_ValueChanged;
            // 
            // numericUpDownMicSemFio
            // 
            numericUpDownMicSemFio.Enabled = false;
            numericUpDownMicSemFio.Location = new Point(510, 125);
            numericUpDownMicSemFio.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDownMicSemFio.Name = "numericUpDownMicSemFio";
            numericUpDownMicSemFio.Size = new Size(38, 23);
            numericUpDownMicSemFio.TabIndex = 13;
            numericUpDownMicSemFio.ValueChanged += numericUpDownMicSemFio_ValueChanged;
            // 
            // numericUpDownMiniTeclado
            // 
            numericUpDownMiniTeclado.Enabled = false;
            numericUpDownMiniTeclado.Location = new Point(510, 163);
            numericUpDownMiniTeclado.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDownMiniTeclado.Name = "numericUpDownMiniTeclado";
            numericUpDownMiniTeclado.Size = new Size(38, 23);
            numericUpDownMiniTeclado.TabIndex = 15;
            numericUpDownMiniTeclado.ValueChanged += numericUpDownMiniTeclado_ValueChanged;
            // 
            // numericUpDownMouse
            // 
            numericUpDownMouse.Enabled = false;
            numericUpDownMouse.Location = new Point(510, 199);
            numericUpDownMouse.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDownMouse.Name = "numericUpDownMouse";
            numericUpDownMouse.Size = new Size(38, 23);
            numericUpDownMouse.TabIndex = 17;
            numericUpDownMouse.ValueChanged += numericUpDownMouse_ValueChanged;
            // 
            // numericUpDownNotebook
            // 
            numericUpDownNotebook.Enabled = false;
            numericUpDownNotebook.Location = new Point(510, 235);
            numericUpDownNotebook.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDownNotebook.Name = "numericUpDownNotebook";
            numericUpDownNotebook.Size = new Size(38, 23);
            numericUpDownNotebook.TabIndex = 19;
            numericUpDownNotebook.ValueChanged += numericUpDownNotebook_ValueChanged;
            // 
            // numericUpDownTablet
            // 
            numericUpDownTablet.Enabled = false;
            numericUpDownTablet.Location = new Point(706, 128);
            numericUpDownTablet.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDownTablet.Name = "numericUpDownTablet";
            numericUpDownTablet.Size = new Size(38, 23);
            numericUpDownTablet.TabIndex = 29;
            numericUpDownTablet.ValueChanged += numericUpDownTablet_ValueChanged;
            // 
            // checkBoxMouseSemFio
            // 
            checkBoxMouseSemFio.AutoSize = true;
            checkBoxMouseSemFio.Enabled = false;
            checkBoxMouseSemFio.Location = new Point(600, 235);
            checkBoxMouseSemFio.Name = "checkBoxMouseSemFio";
            checkBoxMouseSemFio.Size = new Size(62, 19);
            checkBoxMouseSemFio.TabIndex = 35;
            checkBoxMouseSemFio.Text = "Mouse";
            checkBoxMouseSemFio.UseVisualStyleBackColor = true;
            checkBoxMouseSemFio.CheckedChanged += checkBoxMouseSemFio_CheckedChanged;
            checkBoxMouseSemFio.MouseHover += checkBoxMouseSemFio_MouseHover;
            // 
            // numericUpDownMouseFio
            // 
            numericUpDownMouseFio.Enabled = false;
            numericUpDownMouseFio.Location = new Point(706, 231);
            numericUpDownMouseFio.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDownMouseFio.Name = "numericUpDownMouseFio";
            numericUpDownMouseFio.Size = new Size(38, 23);
            numericUpDownMouseFio.TabIndex = 36;
            numericUpDownMouseFio.ValueChanged += numericUpDownMouseFio_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 296);
            label5.Name = "label5";
            label5.Size = new Size(171, 21);
            label5.TabIndex = 37;
            label5.Text = "Escolha a data e hora";
            // 
            // dateTimePickerHoraInicial
            // 
            dateTimePickerHoraInicial.Enabled = false;
            dateTimePickerHoraInicial.Location = new Point(95, 348);
            dateTimePickerHoraInicial.MaxDate = new DateTime(2023, 12, 31, 0, 0, 0, 0);
            dateTimePickerHoraInicial.MinDate = new DateTime(2023, 3, 30, 11, 19, 3, 0);
            dateTimePickerHoraInicial.Name = "dateTimePickerHoraInicial";
            dateTimePickerHoraInicial.Size = new Size(234, 23);
            dateTimePickerHoraInicial.TabIndex = 38;
            dateTimePickerHoraInicial.Value = new DateTime(2023, 3, 30, 11, 19, 3, 0);
            dateTimePickerHoraInicial.ValueChanged += dateTimePickerHoraInicial_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(13, 354);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 39;
            label6.Text = "Data Inicial : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(13, 403);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 40;
            label7.Text = "Data Final : ";
            // 
            // dateTimePickerHoraFinal
            // 
            dateTimePickerHoraFinal.Enabled = false;
            dateTimePickerHoraFinal.Location = new Point(95, 395);
            dateTimePickerHoraFinal.MaxDate = new DateTime(2023, 12, 31, 0, 0, 0, 0);
            dateTimePickerHoraFinal.MinDate = new DateTime(2023, 3, 30, 11, 18, 46, 0);
            dateTimePickerHoraFinal.Name = "dateTimePickerHoraFinal";
            dateTimePickerHoraFinal.Size = new Size(234, 23);
            dateTimePickerHoraFinal.TabIndex = 39;
            dateTimePickerHoraFinal.Value = new DateTime(2023, 3, 30, 11, 18, 46, 0);
            dateTimePickerHoraFinal.ValueChanged += dateTimePickerHoraFinal_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(371, 354);
            label8.Name = "label8";
            label8.Size = new Size(90, 15);
            label8.TabIndex = 42;
            label8.Text = "Hora de inicio : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(371, 401);
            label9.Name = "label9";
            label9.Size = new Size(104, 15);
            label9.TabIndex = 43;
            label9.Text = "Hora do término : ";
            // 
            // maskedTextBoxHoraInicial
            // 
            maskedTextBoxHoraInicial.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxHoraInicial.Location = new Point(499, 346);
            maskedTextBoxHoraInicial.Mask = "00:00";
            maskedTextBoxHoraInicial.Name = "maskedTextBoxHoraInicial";
            maskedTextBoxHoraInicial.Size = new Size(48, 29);
            maskedTextBoxHoraInicial.TabIndex = 40;
            maskedTextBoxHoraInicial.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBoxHoraFinal
            // 
            maskedTextBoxHoraFinal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxHoraFinal.Location = new Point(499, 393);
            maskedTextBoxHoraFinal.Mask = "00:00";
            maskedTextBoxHoraFinal.Name = "maskedTextBoxHoraFinal";
            maskedTextBoxHoraFinal.Size = new Size(48, 29);
            maskedTextBoxHoraFinal.TabIndex = 41;
            maskedTextBoxHoraFinal.ValidatingType = typeof(DateTime);
            // 
            // buttonRealizarReserva
            // 
            buttonRealizarReserva.BackColor = SystemColors.Highlight;
            buttonRealizarReserva.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRealizarReserva.ForeColor = SystemColors.ControlLightLight;
            buttonRealizarReserva.Location = new Point(600, 348);
            buttonRealizarReserva.Name = "buttonRealizarReserva";
            buttonRealizarReserva.Size = new Size(144, 74);
            buttonRealizarReserva.TabIndex = 44;
            buttonRealizarReserva.Text = "OK";
            buttonRealizarReserva.UseVisualStyleBackColor = false;
            buttonRealizarReserva.Click += buttonRealizarReserva_Click;
            buttonRealizarReserva.MouseHover += buttonRealizarReserva_MouseHover_1;
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 150;
            toolTip1.ReshowDelay = 100;
            // 
            // labelCancelarReserva
            // 
            labelCancelarReserva.AutoSize = true;
            labelCancelarReserva.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCancelarReserva.Location = new Point(11, 457);
            labelCancelarReserva.Name = "labelCancelarReserva";
            labelCancelarReserva.Size = new Size(166, 21);
            labelCancelarReserva.TabIndex = 45;
            labelCancelarReserva.Text = "Cancelar sua reserva";
            // 
            // labelDigiteReserva
            // 
            labelDigiteReserva.AutoSize = true;
            labelDigiteReserva.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelDigiteReserva.Location = new Point(312, 463);
            labelDigiteReserva.Name = "labelDigiteReserva";
            labelDigiteReserva.Size = new Size(96, 15);
            labelDigiteReserva.TabIndex = 47;
            labelDigiteReserva.Text = "Digite o seu cpf :";
            // 
            // buttonCancelarReserva
            // 
            buttonCancelarReserva.BackColor = Color.Red;
            buttonCancelarReserva.ForeColor = SystemColors.ControlLightLight;
            buttonCancelarReserva.Location = new Point(600, 448);
            buttonCancelarReserva.Name = "buttonCancelarReserva";
            buttonCancelarReserva.Size = new Size(144, 43);
            buttonCancelarReserva.TabIndex = 48;
            buttonCancelarReserva.Text = "CANCELAR RESERVA";
            buttonCancelarReserva.UseVisualStyleBackColor = false;
            buttonCancelarReserva.Click += buttonCancelarReserva_Click;
            // 
            // maskedTextBoxCpfCancela
            // 
            maskedTextBoxCpfCancela.Cursor = Cursors.IBeam;
            maskedTextBoxCpfCancela.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxCpfCancela.Location = new Point(421, 455);
            maskedTextBoxCpfCancela.Mask = "000,000,000-00";
            maskedTextBoxCpfCancela.Name = "maskedTextBoxCpfCancela";
            maskedTextBoxCpfCancela.Size = new Size(127, 27);
            maskedTextBoxCpfCancela.TabIndex = 49;
            // 
            // TelaEquipamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(756, 507);
            Controls.Add(maskedTextBoxCpfCancela);
            Controls.Add(buttonCancelarReserva);
            Controls.Add(labelDigiteReserva);
            Controls.Add(labelCancelarReserva);
            Controls.Add(buttonRealizarReserva);
            Controls.Add(maskedTextBoxHoraFinal);
            Controls.Add(maskedTextBoxHoraInicial);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dateTimePickerHoraFinal);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dateTimePickerHoraInicial);
            Controls.Add(label5);
            Controls.Add(numericUpDownMouseFio);
            Controls.Add(checkBoxMouseSemFio);
            Controls.Add(numericUpDownTablet);
            Controls.Add(numericUpDownNotebook);
            Controls.Add(numericUpDownMouse);
            Controls.Add(numericUpDownMiniTeclado);
            Controls.Add(numericUpDownMicSemFio);
            Controls.Add(numericUpDownMicrofone);
            Controls.Add(numericUpDownExtensaoEletrica);
            Controls.Add(numericUpDownCxDeSom);
            Controls.Add(numericUpDownTeclado);
            Controls.Add(numericUpDownTelaProjecao);
            Controls.Add(numericUpDownPedestalMic);
            Controls.Add(numericUpDownPedestalTablet);
            Controls.Add(numericUpDownProjetor);
            Controls.Add(numericUpDownSmartTv);
            Controls.Add(numericUpDownCanetaLaser);
            Controls.Add(checkBoxTelaProjecao);
            Controls.Add(checkBoxTeclado);
            Controls.Add(checkBoxTablet);
            Controls.Add(checkBoxSmartTv);
            Controls.Add(checkBoxProjetor);
            Controls.Add(checkBoxPedestalMicrofone);
            Controls.Add(checkBoxPedestal);
            Controls.Add(checkBoxNotebook);
            Controls.Add(checkBoxMouse);
            Controls.Add(checkBoxMiniTeclado);
            Controls.Add(checkBoxMicSemFio);
            Controls.Add(checkBoxMicrofone);
            Controls.Add(checkBoxExtensaoEletrica);
            Controls.Add(checkBoxCanetaLaser);
            Controls.Add(checkBoxCxDeSom);
            Controls.Add(label4);
            Controls.Add(buttonRegistrarColaborador);
            Controls.Add(maskedTextBoxCpf);
            Controls.Add(textBoxNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            ImeMode = ImeMode.Off;
            MaximumSize = new Size(776, 550);
            MinimumSize = new Size(776, 550);
            Name = "TelaEquipamentos";
            RightToLeft = RightToLeft.No;
            Text = "Reserva de Equipamentos";
            ((System.ComponentModel.ISupportInitialize)numericUpDownCanetaLaser).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSmartTv).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProjetor).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPedestalTablet).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPedestalMic).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTelaProjecao).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTeclado).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCxDeSom).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownExtensaoEletrica).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMicrofone).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMicSemFio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMiniTeclado).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMouse).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNotebook).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTablet).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMouseFio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ToolTip toolTip1;
        internal CheckBox checkBoxCxDeSom;
        internal TextBox textBoxNome;
        internal MaskedTextBox maskedTextBoxCpf;
        internal Button buttonRegistrarColaborador;
        internal CheckBox checkBoxCanetaLaser;
        internal CheckBox checkBoxExtensaoEletrica;
        internal CheckBox checkBoxMicrofone;
        internal CheckBox checkBoxMicSemFio;
        internal CheckBox checkBoxMiniTeclado;
        internal CheckBox checkBoxMouse;
        internal CheckBox checkBoxNotebook;
        internal CheckBox checkBoxPedestal;
        internal CheckBox checkBoxPedestalMicrofone;
        internal CheckBox checkBoxProjetor;
        internal CheckBox checkBoxSmartTv;
        internal CheckBox checkBoxTablet;
        internal CheckBox checkBoxTeclado;
        internal CheckBox checkBoxTelaProjecao;
        internal NumericUpDown numericUpDownCanetaLaser;
        internal NumericUpDown numericUpDownSmartTv;
        internal NumericUpDown numericUpDownProjetor;
        internal NumericUpDown numericUpDownPedestalTablet;
        internal NumericUpDown numericUpDownPedestalMic;
        internal NumericUpDown numericUpDownTelaProjecao;
        internal NumericUpDown numericUpDownTeclado;
        internal NumericUpDown numericUpDownCxDeSom;
        internal NumericUpDown numericUpDownExtensaoEletrica;
        internal NumericUpDown numericUpDownMicrofone;
        internal NumericUpDown numericUpDownMiniTeclado;
        internal NumericUpDown numericUpDownMouse;
        internal NumericUpDown numericUpDownNotebook;
        internal NumericUpDown numericUpDownTablet;
        internal CheckBox checkBoxMouseSemFio;
        internal NumericUpDown numericUpDownMouseFio;
        internal DateTimePicker dateTimePickerHoraInicial;
        internal DateTimePicker dateTimePickerHoraFinal;
        internal MaskedTextBox maskedTextBoxHoraInicial;
        internal MaskedTextBox maskedTextBoxHoraFinal;
        internal Button buttonRealizarReserva;
        internal NumericUpDown numericUpDownMicSemFio;
        private Label labelCancelarReserva;
        private Label labelDigiteReserva;
        internal Button buttonCancelarReserva;
        internal MaskedTextBox maskedTextBoxCpfCancela;
    }
}