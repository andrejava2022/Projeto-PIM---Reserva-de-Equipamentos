
namespace SistemaDeReservaDeEquipamentos
{
    public partial class TelaEquipamentos : Form
    {
        public bool ValidaCpf = false;
        Colaborador colab = new Colaborador();
        Reserva rsv = new Reserva();
        int id = 0;
        public TelaEquipamentos()
        {
            InitializeComponent();


        }
        public void buttonRegistrarColaborador_Click_1(object sender, EventArgs e)
        {

            if (textBoxNome.Text != null)
            {

                if (maskedTextBoxCpf.Text.Length > 6)
                {
                    if (colab.verificarCadastro(textBoxNome.Text, maskedTextBoxCpf.Text))
                    {
                        checkBoxCxDeSom.Enabled = true;
                        checkBoxCanetaLaser.Enabled = true;
                        checkBoxExtensaoEletrica.Enabled = true;
                        checkBoxMicrofone.Enabled = true;
                        checkBoxMicSemFio.Enabled = true;
                        checkBoxMiniTeclado.Enabled = true;
                        checkBoxMouse.Enabled = true;
                        checkBoxNotebook.Enabled = true;
                        checkBoxPedestal.Enabled = true;
                        checkBoxPedestalMicrofone.Enabled = true;
                        checkBoxProjetor.Enabled = true;
                        checkBoxSmartTv.Enabled = true;
                        checkBoxTablet.Enabled = true;
                        checkBoxTeclado.Enabled = true;
                        checkBoxTelaProjecao.Enabled = true;
                        checkBoxMouseSemFio.Enabled = true;
                        dateTimePickerHoraInicial.Enabled = true;
                        dateTimePickerHoraFinal.Enabled = true;
                        maskedTextBoxHoraInicial.Enabled = true;
                        maskedTextBoxHoraFinal.Enabled = true;
                    }



                }
                else
                {
                    MessageBox.Show("Verifique seu CPF", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Preencha seu Nome Completo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void buttonRegistrarColaborador_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Pressione esse botão para registrar seus dados pessoais!\nVerifique se os campos nome e cpf estão preenchidos corretamente", buttonRegistrarColaborador);
        }

        public void checkBoxCxDeSom_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Caixa de Som Amplificada Mondial CM-150 com Bluetooth, USB, Rádio FM e Função TWS - 150W", checkBoxCxDeSom);
        }

        public void checkBoxCanetaLaser_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Caneta Laser verde para palestra", checkBoxCanetaLaser);
        }

        public void checkBoxExtensaoEletrica_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Extensão elétrica com 7 tomadas, 2 USB e cabo de 2m", checkBoxExtensaoEletrica);
        }

        public void checkBoxMicrofone_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Microfone com fio Dinamico profissional com cabo 4mts MUD 515", checkBoxMicrofone);
        }

        public void checkBoxPedestal_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Pedestal para tablet Help-80 Torelli", checkBoxPedestal);
        }

        public void checkBoxPedestalMicrofone_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Pedestal para microfone Reto Studio Hpm50 Torelli", checkBoxPedestalMicrofone);
        }

        public void checkBoxProjetor_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Projetor led Portátil 2500 Lúmens T5 - Hamy", checkBoxProjetor);
        }

        public void checkBoxSmartTv_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Smart tv 75' 4K Samsung 75AU7700 Wi-Fi - Bluetooth HDR Alexa Built in 3 HDMI 1 USB", checkBoxSmartTv);
        }

        public void checkBoxMicSemFio_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Microfone sem fio Duplo Uhf Jwl Profissional", checkBoxMicSemFio);
        }

        public void checkBoxMiniTeclado_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Mini teclado sem fio", checkBoxMiniTeclado);
        }

        public void checkBoxMouse_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Mouse Óptico Com Fio Multilaser 1200 Dpi Usb Preto Mo300", checkBoxMouse);
        }

        public void checkBoxNotebook_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Notebook Philco Core i3- 5005U 4GB 1TB Tela Full HD 15.6” Windows 10", checkBoxNotebook);
        }

        public void checkBoxTablet_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Tablet Samsung Galaxy A7 Lite WiFi, 64GB, 3GB RAM, Android 11", checkBoxTablet);
        }

        public void checkBoxTeclado_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Teclado sem fio Multilaser", checkBoxTeclado);
        }

        public void checkBoxTelaProjecao_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Tela de projeção para data show 92' com tripé", checkBoxTelaProjecao);
        }

        public void checkBoxMouseSemFio_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Mouse sem fio Multilaser", checkBoxMouseSemFio);
        }

        public void buttonRealizarReserva_MouseHover_1(object sender, EventArgs e)
        {
            toolTip1.Show("Pressione esse botão para registrar a solicitação de Reserva!\nVerifique se todos os campos estão preenchidos corretamente", buttonRealizarReserva);
        }

        internal void checkBoxCxDeSom_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownCxDeSom.Enabled = checkBoxCxDeSom.Checked;
            if (checkBoxCxDeSom.Checked == true)
            {
                numericUpDownCxDeSom.Value = 1;

            }
            else
            {
                numericUpDownCxDeSom.Value = 0;
            }

        }

        public void checkBoxCanetaLaser_CheckedChanged_1(object sender, EventArgs e)
        {
            numericUpDownCanetaLaser.Enabled = checkBoxCanetaLaser.Checked;
            if (checkBoxCanetaLaser.Checked == true)
            {
                numericUpDownCanetaLaser.Value = 1;
            }
            else
            {
                numericUpDownCanetaLaser.Value = 0;
            }
        }

        public void checkBoxExtensaoEletrica_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownExtensaoEletrica.Enabled = checkBoxExtensaoEletrica.Checked;
            if (checkBoxExtensaoEletrica.Checked == true)
            {
                numericUpDownExtensaoEletrica.Value = 1;
            }
            else
            {
                numericUpDownExtensaoEletrica.Value = 0;
            }
        }

        public void checkBoxMicrofone_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownMicrofone.Enabled = checkBoxMicrofone.Checked;
            if (checkBoxMicrofone.Checked == true)
            {
                numericUpDownMicrofone.Value = 1;
            }
            else
            {
                numericUpDownMicrofone.Value = 0;

            }
        }

        public void checkBoxPedestal_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownPedestalTablet.Enabled = checkBoxPedestal.Checked;
            if (checkBoxPedestal.Checked == true)
            {
                numericUpDownPedestalTablet.Value = 1;
            }
            else
            {
                numericUpDownPedestalTablet.Value = 0;
            }
        }

        public void checkBoxPedestalMicrofone_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownPedestalMic.Enabled = checkBoxPedestalMicrofone.Checked;
            if (checkBoxPedestalMicrofone.Checked == true)
            {
                numericUpDownPedestalMic.Value = 1;
            }
            else
            {
                numericUpDownPedestalMic.Value = 0;
            }
        }

        public void checkBoxProjetor_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownProjetor.Enabled = checkBoxProjetor.Checked;
            if (checkBoxProjetor.Checked == true)
            {
                numericUpDownProjetor.Value = 1;

            }
            else
            {
                numericUpDownProjetor.Value = 0;
            }
        }

        public void checkBoxSmartTv_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownSmartTv.Enabled = checkBoxSmartTv.Checked;
            if (checkBoxSmartTv.Checked == true)
            {
                numericUpDownSmartTv.Value = 1;
            }
            else
            {
                numericUpDownSmartTv.Value = 0;
            }
        }

        public void checkBoxMicSemFio_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownMicSemFio.Enabled = checkBoxMicSemFio.Checked;
            if (checkBoxMicSemFio.Checked == true)
            {
                numericUpDownMicSemFio.Value = 1;
            }
            else
            {
                numericUpDownMicSemFio.Value = 0;
            }
        }

        public void checkBoxMiniTeclado_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownMiniTeclado.Enabled = checkBoxMiniTeclado.Checked;
            if (checkBoxMiniTeclado.Checked == true)
            {
                numericUpDownMiniTeclado.Value = 1;
            }
            else
            {
                numericUpDownMiniTeclado.Value = 0;
            }
        }

        public void checkBoxMouse_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownMouse.Enabled = checkBoxMouse.Checked;
            if (checkBoxMouse.Checked == true)
            {
                numericUpDownMouse.Value = 1;
            }
            else
            {
                numericUpDownMouse.Value = 0;
            }
        }

        public void checkBoxNotebook_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownNotebook.Enabled = checkBoxNotebook.Checked;
            if (checkBoxNotebook.Checked == true)
            {
                numericUpDownNotebook.Value = 1;
            }
            else
            {
                numericUpDownNotebook.Value = 0;
            }
        }

        public void checkBoxTablet_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownTablet.Enabled = checkBoxTablet.Checked;
            if (checkBoxTablet.Checked == true)
            {
                numericUpDownTablet.Value = 1;
            }
            else
            {
                numericUpDownTablet.Enabled = false;

            }
        }

        public void checkBoxTeclado_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownTeclado.Enabled = checkBoxTeclado.Checked;
            if (checkBoxTeclado.Checked == true)
            {

                numericUpDownTeclado.Value = 1;

            }
            else
            {
                numericUpDownTeclado.Value = 0;

            }
        }

        public void checkBoxTelaProjecao_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownTelaProjecao.Enabled = checkBoxTelaProjecao.Checked;
            if (checkBoxTelaProjecao.Checked == true)
            {
                numericUpDownTelaProjecao.Value = 1;
            }
            else
            {
                numericUpDownTelaProjecao.Value = 0;
            }
        }

        public void checkBoxMouseSemFio_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownMouseFio.Enabled = checkBoxMouseSemFio.Checked;
            if (checkBoxMouseSemFio.Checked == true)
            {
                numericUpDownMouseFio.Value = 1;
            }
            else
            {
                numericUpDownMouseFio.Value = 0;
            }
        }

        public void numericUpDownCxDeSom_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownCxDeSom.Value == 0)
            {
                checkBoxCxDeSom.Checked = false;
            }

        }

        public void numericUpDownCanetaLaser_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownCanetaLaser.Value == 0)
            {
                checkBoxCanetaLaser.Checked = false;
            }
        }

        public void numericUpDownExtensaoEletrica_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownExtensaoEletrica.Value == 0)
            {
                checkBoxExtensaoEletrica.Checked = false;
            }
        }

        public void numericUpDownMicrofone_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownMicrofone.Value == 0)
            {
                checkBoxMicrofone.Checked = false;
            }
        }

        public void numericUpDownPedestalTablet_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownPedestalTablet.Value == 0)
            {
                checkBoxPedestal.Checked = false;
            }
        }

        public void numericUpDownPedestalMic_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownPedestalMic.Value == 0)
            {
                checkBoxPedestalMicrofone.Checked = false;
            }
        }

        public void numericUpDownProjetor_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownProjetor.Value == 0)
            {
                checkBoxProjetor.Checked = false;
            }
        }

        public void numericUpDownSmartTv_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownSmartTv.Value == 0)
            {
                checkBoxSmartTv.Checked = false;
            }
        }

        public void numericUpDownMicSemFio_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownMicSemFio.Value == 0)
            {
                checkBoxMicSemFio.Checked = false;
            }
        }

        public void numericUpDownMiniTeclado_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownMiniTeclado.Value == 0)
            {
                checkBoxMiniTeclado.Checked = false;
            }
        }

        public void numericUpDownMouse_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownMouse.Value == 0)
            {
                checkBoxMouse.Checked = false;
            }
        }

        public void numericUpDownNotebook_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownNotebook.Value == 0)
            {
                checkBoxNotebook.Checked = false;
            }
        }

        public void numericUpDownTablet_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownTablet.Value == 0)
            {
                checkBoxTablet.Checked = false;
            }
        }

        public void numericUpDownTeclado_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownTeclado.Value == 0)
            {
                checkBoxTeclado.Checked = false;
            }
        }

        public void numericUpDownTelaProjecao_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownTelaProjecao.Value == 0)
            {
                checkBoxTelaProjecao.Checked = false;
            }
        }

        public void numericUpDownMouseFio_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownMouseFio.Value == 0)
            {
                checkBoxMouseSemFio.Checked = false;
            }
        }

        public void buttonRealizarReserva_Click(object sender, EventArgs e)
        {
            if (checkBoxCanetaLaser.Checked || checkBoxCxDeSom.Checked || checkBoxExtensaoEletrica.Checked || checkBoxMicrofone.Checked || checkBoxMicSemFio.Checked || checkBoxMiniTeclado.Checked || checkBoxMouse.Checked || checkBoxMouseSemFio.Checked || checkBoxNotebook.Checked || checkBoxPedestal.Checked || checkBoxPedestalMicrofone.Checked || checkBoxProjetor.Checked || checkBoxSmartTv.Checked || checkBoxTablet.Checked || checkBoxTeclado.Checked || checkBoxTelaProjecao.Checked)
            {
                if (maskedTextBoxHoraInicial.Text[0] == '1' && maskedTextBoxHoraInicial.Text[1] <= '9' ||
                    maskedTextBoxHoraInicial.Text[0] == '2' && maskedTextBoxHoraInicial.Text[1] <= '1')
                {
                    if (maskedTextBoxHoraInicial.Text[3] == '0' || maskedTextBoxHoraInicial.Text[3] == '3' && maskedTextBoxHoraInicial.Text[4] == '0')
                    {
                        if (maskedTextBoxHoraFinal.Text[0] == '1' && maskedTextBoxHoraFinal.Text[1] <= '9' ||
                    maskedTextBoxHoraFinal.Text[0] == '2' && maskedTextBoxHoraFinal.Text[1] <= '1')
                        {
                            if (maskedTextBoxHoraFinal.Text[3] == '0' || maskedTextBoxHoraFinal.Text[3] == '3' &&
                        maskedTextBoxHoraFinal.Text[4] == '0')
                            {

                                Colaborador colaborador = new Colaborador(textBoxNome.Text, maskedTextBoxCpf.Text);
                                DateTime dateTimeAgora = DateTime.Now;
                                DateTime dataInicial = dateTimePickerHoraInicial.Value;
                                string DataInicial = dataInicial.ToString("dd/MM/yyyy");
                                string horaInicial = maskedTextBoxHoraInicial.Text;
                                DateTime dataFinal = dateTimePickerHoraFinal.Value;
                                string DataFinal = dataFinal.ToString("dd/MM/yyyy");
                                string horaFinal = maskedTextBoxHoraFinal.Text;
                                Reserva reserva = new Reserva(0, dateTimeAgora, DataInicial, horaInicial, DataFinal, horaFinal, colaborador);
                                MessageBox.Show(reserva.ToString(), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                reserva.ToString();
                            }
                            else
                            {
                                MessageBox.Show("Digite um horário válido! ex: 10:30 ou 10:00", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Verique a hora final!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else { MessageBox.Show("Digite um horário válido! ex: " + maskedTextBoxHoraInicial.Text[0] + maskedTextBoxHoraInicial.Text[1] + ":30 ou " + maskedTextBoxHoraInicial.Text[0] + maskedTextBoxHoraInicial.Text[1] + ":00", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                {
                    MessageBox.Show("Verique a hora inicial!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("É necessário escolher pelo menos um equipamento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void dateTimePickerHoraInicial_ValueChanged(object sender, EventArgs e)
        {
            DateTime dataInicial = dateTimePickerHoraInicial.Value;
        }

        public void dateTimePickerHoraFinal_ValueChanged(object sender, EventArgs e)
        {
            DateTime dataFinal = dateTimePickerHoraFinal.Value;
        }

        public void buttonCancelarReserva_Click(object sender, EventArgs e)
        {            
            rsv.cancelarReserva();
        }
    }

}
