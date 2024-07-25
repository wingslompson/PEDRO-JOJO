using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEDRO_JOJO
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //adiciona intens a combo box

            comboBox1.Items.Add("Parte 1");
            comboBox1.Items.Add("Parte 2");
            comboBox1.Items.Add("Parte 3");
            comboBox1.Items.Add("Parte 4");
            comboBox1.Items.Add("Parte 5");
            comboBox1.Items.Add("Parte 6");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) 
            {
                //adiciona a imagem a pixture box
                pictureBox3.Image = Properties.Resources.poster_p1;

                //torna as group box visiveis
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;

                //radio button

                radioButton1.Text = "Jonathan";
                radioButton2.Text = "Dio";
                radioButton3.Text = "Zeppeli";
                radioButton4.Text = "Speedwagon";
                radioButton5.Text = "Erina";
                radioButton6.Text = "George";




            }
            else if (comboBox1.SelectedIndex == 1) 
            {
                pictureBox3.Image = Properties.Resources.poster_p2;

                //torna as group box visiveis
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
            }
            else if (comboBox1.SelectedIndex == 2 ) 
            {
                pictureBox3.Image = Properties.Resources.poster_p3;

                //torna as group box visiveis
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
            }
            else if (comboBox1.SelectedIndex == 3) 
            {
                pictureBox3.Image = Properties.Resources.p4_poster;

                //torna as group box visiveis
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
            }
            else if (comboBox1.SelectedIndex == 4) 
            {
                pictureBox3.Image = Properties.Resources.poster_p5;

                //torna as group box visiveis
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
            }
            else if (comboBox1.SelectedIndex == 5) 
            {
                pictureBox3.Image = Properties.Resources.poster_p6;

                //torna as group box visiveis
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;

            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0 )
            {
               pictureBox5.Image = Properties.Resources.p1_jonathan;

                   label1.Text = "Jonathan Joestar (ジョナサン・ジョースター Jonasan Jōsutā) é o protagonista de Phantom Blood e o primeiro JoJo da série JoJo's Bizarre Adventure.\r\n\r\nFilho de George Joestar I, Jonathan é um homem honesto, gentil e positivo, cuja vida está repleta de tragédias após conhecer seu irmão mais velho adotivo, Dio Brando. Em sua batalha contra Dio, Jonathan se torna um usuário do Hamon sob a tutela de Will Anthonio Zeppeli.";
                
                if (radioButton1.Checked == false) {
                    label1.Text = null;
                    pictureBox5.Image = null;

                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox5.Image = Properties.Resources.p1_dio;

                label1.Text = "Dio Brando (ディオ・ブランドー, Dio Burandō), mais tarde conhecido simplesmente como DIO (DIOディオ), é o principal antagonista da primeira e terceira partes da série JoJo's Bizarre Adventure, Phantom Blood e Stardust Crusaders, bem como o primeiro personagem principal. antagonista da série em geral.Originalmente um homem de origem humilde, mas com ambição incomparável, Dio é um vilão astuto, de pouca consciência e com uma fome insaciável de poder. Depois de se tornar um vampiro, Dio parte para conquistar o mundo com um exército de zumbis sob seu comando, trazendo à tona uma rivalidade de longa data entre ele e seu irmão adotivo, Jonathan Joestar. Seu legado e influência persistem ao longo das primeiras seis partes de JoJo, com muitos personagens relacionados a ele ou inspirados por seu carisma e malícia.";

                if (radioButton2.Checked == false)
                {
                    label1.Text = null;
                    pictureBox5.Image = null;

                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox5.Image = Properties.Resources.p1_zepeli;

                label1.Text = "Will Anthonio Zeppeli (ウィル・ Ａ・ツェペリ (ウィル・アントニオ ・ツェペリ) Wiru Antonio Tseperi), também conhecido como Baron Zeppeli (ツェペリ男爵 Tseperi Danshaku), é o deuteragonista apresentado em Phantom Blood.Zeppeli é um mestre Hamon vindo da Itália que procura a Máscara de Pedra para destruí-la.\r\n\r\n Ouvindo sobre Dio Brando, ele se torna o mentor de Jonathan e o ensina na arte do Hamon, bem como luta ao lado dele.";
                if (radioButton3.Checked == false)
                {
                    label1.Text = null;
                    pictureBox5.Image = null;

                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox5.Image = Properties.Resources.p1_speedwagon;

                label1.Text = "Robert E. O. Speedwagon (ロバート・E・O・スピードワゴン Robāto Ī Ō Supīdowagon) é um aliado central apresentado em Phantom Blood e um aliado menor em Battle Tendency.\r\n\r\nInicialmente apresentado como um inimigo que reside na Rua Ogre, acaba sendo derrotado por Jonathan Joestar, a quem ele se torna leal e passa a acompanhar durante sua jornada. Mesmo após a morte de Jonathan, ele continua servindo a família Joestar.";
                if (radioButton4.Checked == false)
                {
                    label1.Text = null;
                    pictureBox5.Image = null;

                }
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox5.Image = Properties.Resources.p1_erina;

                label1.Text = "Erina Pendleton (エリナ・ペンドルトン Erina Pendoruton) é uma personagem secundária e aliada que aparece em Phantom Blood e Battle Tendency.\r\n\r\nErina é uma jovem da cidade natal de Jonathan Joestar, que se torna seu interesse amoroso e ela eventualmente se torna sua esposa (o que agora a torna Erina Joestar ), a mãe de George Joestar II e a avó/tutora de Joseph Joestar.";
                if (radioButton5.Checked == false)
                {
                    label1.Text = null;
                    pictureBox5.Image = null;

                }
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox5.Image = Properties.Resources.p1_george;

                label1.Text = "George Joestar (ジョージ・ジョースター Jōji Jōsutā) é um personagem secundário apresentado em Phantom Blood.\r\n\r\nGeorge é o pai de Jonathan Joestar. e após um trágico mal-entendido, adota Dio Brando em sua família, dando início aos acontecimentos da série.";
                if (radioButton6.Checked == false)
                {
                    label1.Text = null;
                    pictureBox5.Image = null;

                }
            }
        }
    }
}
