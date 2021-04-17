using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace Novo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {

            // definição das variaveis externas
            string nome = tb_nome.Text;
            int idade = Convert.ToInt32(tb_idade.Text);
            string tipo = cb_tipo.Text;
            int quantidade = Convert.ToInt32(tb_dias.Text);
            double consumo = Convert.ToDouble(tb_valor.Text);


            double totalgeral = 0;            
            double subtotal = 0;
            double taxaa = 150;
            double taxab = 100;
            double taxac = 75;
            double taxad = 50;
            double taxaservico = 0;

            //======================================

            double totaldiarias = 0;

            switch (tipo)
            {
                case "A":
                    {

                        if (idade >= 60)
                        {
                            SoundPlayer player = new SoundPlayer();
                            player.SoundLocation = "aud/a.wav";
                            player.Play();
                            taxaservico = 0;
                            totaldiarias = quantidade * taxaa;
                            subtotal = totaldiarias + consumo;
                            totalgeral = subtotal + taxaservico;
                            MessageBox.Show("\tBem Vindo Ao Sistema ERP\n\nNome:\t"+nome+"\nIdade:\t"+idade+"\n\t======================\n\nO Valor Total Das Diarias É:\t"+totaldiarias+"\nO Valor do Seu Consumo É:\t"+consumo+"\nO Valor do Subtotal É:\t"+subtotal+"\nO Valor da taxa de Serviço É:\t"+taxaservico+"\nO Valor do Total Geral É:\t"+totalgeral+"\n\n\tObrigado Por Utilizar Nosso Sitema :)");
                            
                        }
                        else
                        {
                            SoundPlayer player = new SoundPlayer();
                            player.SoundLocation = "aud/a.wav";
                            player.Play();
                            totaldiarias = quantidade * taxaa;
                            subtotal = totaldiarias + consumo;
                            taxaservico = subtotal * 10 / 100;
                            totalgeral = subtotal + taxaservico;
                            MessageBox.Show("\tBem Vindo Ao Sistema ERP\n\nNome:\t" + nome + "\nIdade:\t" + idade + "\n\t======================\n\nO Valor Total Das Diarias É:\t" + totaldiarias + "\nO Valor do Seu Consumo É:\t" + consumo + "\nO Valor do Subtotal É:\t" + subtotal + "\nO Valor da taxa de Serviço É:\t" + taxaservico + "\nO Valor do Total Geral É:\t" + totalgeral + "\n\n\tObrigado Por Utilizar Nosso Sitema :)");
                        
                        
                        }
                    }
                    break;

                case "B":
                    {
                        if (idade >= 60)
                        {
                            SoundPlayer player = new SoundPlayer();
                            player.SoundLocation = "aud/a.wav";
                            player.Play();
                            taxaservico = 0;
                            totaldiarias = quantidade * taxab;
                            subtotal = totaldiarias + consumo;
                            totalgeral = subtotal + taxaservico;
                            MessageBox.Show("\tBem Vindo Ao Sistema ERP\n\nNome:\t" + nome + "\nIdade:\t" + idade + "\n\t======================\n\nO Valor Total Das Diarias É:\t" + totaldiarias + "\nO Valor do Seu Consumo É:\t" + consumo + "\nO Valor do Subtotal É:\t" + subtotal + "\nO Valor da taxa de Serviço É:\t" + taxaservico + "\nO Valor do Total Geral É:\t" + totalgeral + "\n\n\tObrigado Por Utilizar Nosso Sitema :)");
                        
                        }
                        else
                        {
                            SoundPlayer player = new SoundPlayer();
                            player.SoundLocation = "aud/a.wav";
                            player.Play();
                            totaldiarias = quantidade * taxab;
                            subtotal = totaldiarias + consumo;
                            taxaservico = subtotal * 11 / 100;
                            totalgeral = subtotal + taxaservico;
                            MessageBox.Show("\tBem Vindo Ao Sistema ERP\n\nNome:\t" + nome + "\nIdade:\t" + idade + "\n\t======================\n\nO Valor Total Das Diarias É:\t" + totaldiarias + "\nO Valor do Seu Consumo É:\t" + consumo + "\nO Valor do Subtotal É:\t" + subtotal + "\nO Valor da taxa de Serviço É:\t" + taxaservico + "\nO Valor do Total Geral É:\t" + totalgeral + "\n\n\tObrigado Por Utilizar Nosso Sitema :)");
                        
                        }
                    }
                    break;
                case "C":
                    {
                        if (idade >= 60)
                        {
                            SoundPlayer player = new SoundPlayer();
                            player.SoundLocation = "aud/a.wav";
                            player.Play();
                            taxaservico = 0;
                            totaldiarias = quantidade * taxac;
                            subtotal = totaldiarias + consumo;
                            totalgeral = subtotal + taxaservico;
                            MessageBox.Show("\tBem Vindo Ao Sistema ERP\n\nNome:\t" + nome + "\nIdade:\t" + idade + "\n\t======================\n\nO Valor Total Das Diarias É:\t" + totaldiarias + "\nO Valor do Seu Consumo É:\t" + consumo + "\nO Valor do Subtotal É:\t" + subtotal + "\nO Valor da taxa de Serviço É:\t" + taxaservico + "\nO Valor do Total Geral É:\t" + totalgeral + "\n\n\tObrigado Por Utilizar Nosso Sitema :)");
                        }
                        else
                        {
                            SoundPlayer player = new SoundPlayer();
                            player.SoundLocation = "aud/a.wav";
                            player.Play();
                            totaldiarias = quantidade * taxac;
                            subtotal = totaldiarias + consumo;
                            taxaservico = subtotal * 12 / 100;
                            totalgeral = subtotal + taxaservico;
                            MessageBox.Show("\tBem Vindo Ao Sistema ERP\n\nNome:\t" + nome + "\nIdade:\t" + idade + "\n\t======================\n\nO Valor Total Das Diarias É:\t" + totaldiarias + "\nO Valor do Seu Consumo É:\t" + consumo + "\nO Valor do Subtotal É:\t" + subtotal + "\nO Valor da taxa de Serviço É:\t" + taxaservico + "\nO Valor do Total Geral É:\t" + totalgeral + "\n\n\tObrigado Por Utilizar Nosso Sitema :)");

                        }
                    }
                    break;
                case "D":
                    {
                        if (idade >= 60)
                        {
                            SoundPlayer player = new SoundPlayer();
                            player.SoundLocation = "aud/a.wav";
                            player.Play();
                            taxaservico = 0;
                            totaldiarias = quantidade * taxad;
                            subtotal = totaldiarias + consumo;
                            totalgeral = subtotal + taxaservico;
                            MessageBox.Show("\tBem Vindo Ao Sistema ERP\n\nNome:\t" + nome + "\nIdade:\t" + idade + "\n\t======================\n\nO Valor Total Das Diarias É:\t" + totaldiarias + "\nO Valor do Seu Consumo É:\t" + consumo + "\nO Valor do Subtotal É:\t" + subtotal + "\nO Valor da taxa de Serviço É:\t" + taxaservico + "\nO Valor do Total Geral É:\t" + totalgeral + "\n\n\tObrigado Por Utilizar Nosso Sitema :)");
                        }
                        else
                        {
                            SoundPlayer player = new SoundPlayer();
                            player.SoundLocation = "aud/a.wav";
                            player.Play();
                            totaldiarias = quantidade * taxad;
                            subtotal = totaldiarias + consumo;
                            taxaservico = subtotal * 13 / 100;
                            totalgeral = subtotal + taxaservico;
                            MessageBox.Show("\tBem Vindo Ao Sistema ERP\n\nNome:\t" + nome + "\nIdade:\t" + idade + "\n\t======================\n\nO Valor Total Das Diarias É:\t" + totaldiarias + "\nO Valor do Seu Consumo É:\t" + consumo + "\nO Valor do Subtotal É:\t" + subtotal + "\nO Valor da taxa de Serviço É:\t" + taxaservico + "\nO Valor do Total Geral É:\t" + totalgeral + "\n\n\tObrigado Por Utilizar Nosso Sitema :)");

                        }
                    }
                    break;









            }
          
            


           



        }

        private void l_quant_Click(object sender, EventArgs e)
        {

        }
    }
}
