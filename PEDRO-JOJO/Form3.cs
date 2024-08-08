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
            //adiciona intens a combo box e list box

            comboBox1.Items.Add("Parte 1");
            comboBox1.Items.Add("Parte 2");
            comboBox1.Items.Add("Parte 3");
            comboBox1.Items.Add("Parte 4");
            comboBox1.Items.Add("Parte 5");
            comboBox1.Items.Add("Parte 6");

            listBox1.Items.Add("História");
            listBox1.Items.Add("Curiosidades");


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) 
            {
                //limpa todas as labels e pictures e check box
                pictureBox5.Image = null;
                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                pictureBox10.Image = null;
                pictureBox11.Image = null;
                pictureBox12.Image = null;
                
                label1.Text = "";
                label2.Text = "";

                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;


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

                //checkbox

                checkBox1.Text = "Máscara";
                checkBox2.Text = "Pluck";
                checkBox3.Text = "Hamon";
                checkBox4.Text = "Congelar";
                checkBox5.Text = "Overdrive";
                checkBox6.Text = "Planar";

                






            }
            else if (comboBox1.SelectedIndex == 1) 
            {
                pictureBox3.Image = Properties.Resources.poster_p2;

                pictureBox5.Image = null;
                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                pictureBox10.Image = null;
                pictureBox11.Image = null;
                pictureBox12.Image = null;
                label1.Text = "";
                label2.Text = "";
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;


                //torna as group box visiveis
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;

                //radio button

                radioButton1.Text = "Joseph";
                radioButton2.Text = "Ceasar";
                radioButton3.Text = "Lisa Lisa";
                radioButton4.Text = "Kars";
                radioButton5.Text = "Stroheim";
                radioButton6.Text = "Esidisi";

                //checkbox

                checkBox1.Text = "Hamon";
                checkBox2.Text = "Bolhas";
                checkBox3.Text = "Bat Beg";
                checkBox4.Text = "Red Stone";
                checkBox5.Text = "Tempestade";
                checkBox6.Text = "Pilar Men";
            }
            else if (comboBox1.SelectedIndex == 2 ) 
            {
                pictureBox3.Image = Properties.Resources.poster_p3;

                pictureBox5.Image = null;
                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                pictureBox10.Image = null;
                pictureBox11.Image = null;
                pictureBox12.Image = null;
                label1.Text = "";
                label2.Text = "";
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;



                //torna as group box visiveis
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;

                //radio button

                radioButton1.Text = "Jotaro";
                radioButton2.Text = "Dio";
                radioButton3.Text = "Kakyoin";
                radioButton4.Text = "Polnareff";
                radioButton5.Text = "Avdol";
                radioButton6.Text = "Iggy";

                //checkbox

                checkBox1.Text = "Star Platinum";
                checkBox2.Text = "Hierophant";
                checkBox3.Text = "Silver Chariot";
                checkBox4.Text = "The World";
                checkBox5.Text = "Magicans Red";
                checkBox6.Text = "The Fool";
            }
            else if (comboBox1.SelectedIndex == 3) 
            {
                pictureBox3.Image = Properties.Resources.p4_poster;

                pictureBox5.Image = null;
                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                pictureBox10.Image = null;
                pictureBox11.Image = null;
                pictureBox12.Image = null;
                label1.Text = "";
                label2.Text = "";
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;



                //torna as group box visiveis
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;

                //radio button

                radioButton1.Text = "Josuke";
                radioButton2.Text = "Koichi";
                radioButton3.Text = "Okuyasu";
                radioButton4.Text = "Rohan";
                radioButton5.Text = "Jotaro";
                radioButton6.Text = "Kira";

                //checkbox

                checkBox1.Text = "Crazy Diamond";
                checkBox2.Text = "Echoes";
                checkBox3.Text = "The Hand";
                checkBox4.Text = "Heavens Door";
                checkBox5.Text = "Star Platinum";
                checkBox6.Text = "Killer Queen";

            }
            else if (comboBox1.SelectedIndex == 4) 
            {
                pictureBox3.Image = Properties.Resources.poster_p5;

                pictureBox5.Image = null;
                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                pictureBox10.Image = null;
                pictureBox11.Image = null;
                pictureBox12.Image = null;
                label1.Text = "";
                label2.Text = "";
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;



                //torna as group box visiveis
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;

                //radio button

                radioButton1.Text = "Giorno";
                radioButton2.Text = "Bucciarati";
                radioButton3.Text = "Mista";
                radioButton4.Text = "Narancia";
                radioButton5.Text = "Abbacchio";
                radioButton6.Text = "Diavolo";

                //checkbox

                checkBox1.Text = "Golden Experience";
                checkBox2.Text = "Sticky Fingers";
                checkBox3.Text = "Sex Pistols";
                checkBox4.Text = "Aerosmith";
                checkBox5.Text = "Moody Blues";
                checkBox6.Text = "King Crimison";


            }
            else if (comboBox1.SelectedIndex == 5) 
            {
                pictureBox3.Image = Properties.Resources.poster_p6;

                pictureBox5.Image = null;
                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                pictureBox10.Image = null;
                pictureBox11.Image = null;
                pictureBox12.Image = null;
                label1.Text = "";
                label2.Text = "";
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;



                //torna as group box visiveis
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;


                radioButton1.Text = "Jolyne";
                radioButton2.Text = "Hermes";
                radioButton3.Text = "Foo Fighters";
                radioButton4.Text = "Anasui";
                radioButton5.Text = "Weathear";
                radioButton6.Text = "Pucci";

                //checkbox

                checkBox1.Text = "Stone Free";
                checkBox2.Text = "Kiss";
                checkBox3.Text = "Foo Fighters";
                checkBox4.Text = "Aerosmith";
                checkBox5.Text = "Diver Down";
                checkBox6.Text = "Made Heaven";

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
                
                //quando o radio button nao estiver marcado vai limpar a label e picture box
                if (radioButton1.Checked == false) {
                    label1.Text = null;
                    pictureBox5.Image = null;

                }
            }

            if(comboBox1.SelectedIndex == 1)
            {
                pictureBox5.Image = Properties.Resources.p2_joseph;

                label1.Text = "Joseph Joestar (ジョセフ・ジョースター, Josefu Jōsutā) é o protagonista da segunda parte de JoJo's Bizarre Adventure, Battle Tendency, e o segundo JoJo da série. Ele também aparece como um aliado primário em Stardust Crusaders, e como um aliado secundário em Diamond is Unbreakable.\r\n\r\nComo o neto de Jonathan Joestar, Joseph é um usuário natural de Hamon e um eventual usuário de Stand, tendo Hermit Purple como seu Stand. Um encrenqueiro exuberante com um talento excepcional para trapaças, Joseph encontra várias ameaças fantásticas aproximando-se dele durante sua vida com iniciativa e uma ingenuidade impressionante.";
                if (radioButton1.Checked == false)
                {
                    label1.Text = null;
                    pictureBox5.Image = null;

                }

            }

            if (comboBox1.SelectedIndex == 2)
            {
                pictureBox5.Image = Properties.Resources.p3_jotaro;

                label1.Text = "Jotaro Kujo (空条 承太郎 Kūjō Jōtarō) é o protagonista da Parte 3 e também aparece nas Partes 4-6 Jotaro é o terceiro e o JoJo mais recorrente na série JoJo's Bizarre Adventure.\r\n\r\nJotaro é um delinquente que vive uma vida normal até que o velho inimigo da Família Joestar, DIO, retorna. Jotaro viaja para o Egito para salvar sua mãe e parar o Vampiro de uma vez por todas.\r\n\r\nEmpunhando o incrivelmente poderoso Star Platinum, Jotaro é o primeiro JoJo apresentado com um Stand e está entre os personagens mais conhecidos da série.";
                if (radioButton1.Checked == false)
                {
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

                label1.Text = "Dio Brando (ディオ・ブランドー, Dio Burandō), mais tarde conhecido simplesmente como DIO (DIOディオ), é o principal antagonista da primeira e terceira partes da série JoJo's Bizarre Adventure, Phantom Blood e Stardust Crusaders, bem como o primeiro personagem principal. antagonista da série em geral.Originalmente um homem de origem humilde, mas com ambição incomparável, Dio é um vilão astuto, de pouca consciência e com uma fome insaciável de poder. Depois de se tornar um vampiro, Dio parte para conquistar o mundo com um exército de zumbis sob seu comando, trazendo à tona uma rivalidade de longa data entre ele e seu irmão adotivo, Jonathan Joestar.";

                if (radioButton2.Checked == false)
                {
                    label1.Text = null;
                    pictureBox5.Image = null;

                }
            }

            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox5.Image = Properties.Resources.p2_ceasar;

                label1.Text = "Caesar Anthonio Zeppeli (シーザー・アントニオ・ツェペリ, Shīzā Antonio Tseperi) é um aliado primário na segunda parte de JoJo's Bizarre Adventure, Battle Tendency.\r\n\r\nCaesar é um usuário italiano do Hamon e um discipulo da mestra do Hamon, Lisa Lisa. Ele é o neto de Will Anthonio Zeppeli e batalha os Homens do Pilar junto de Joseph Joestar para honrar sua herança como um Zeppeli.";

                if (radioButton2.Checked == false)
                {
                    label1.Text = null;
                    pictureBox5.Image = null;

                }
            }

            if (comboBox1.SelectedIndex == 2)
            {
                pictureBox5.Image = Properties.Resources.p3_dio;

                label1.Text = "";
                if (radioButton1.Checked == false)
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

            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox5.Image = Properties.Resources.p2_Lisa_Lisa;

                label1.Text = "Lisa Lisa (リサリサ Risa Risa), cujo nome verdadeiro é Elizabeth Joestar (エリザベス・ジョースター Erizabesu Jōsutā), é uma aliada central em Battle Tendency.Lisa Lisa é a esposa de George Joestar II e mãe de Joseph Joestar . Uma poderosa mestra Hamon, que atua como mentor de Joseph e Caesar Zeppeli. Residindo em Venezia, com um passado inicialmente desconhecido, ela lidera os esforços dos Usuários Hamon na luta contra os Homens do Pilar, revelando posteriormente sua conexão com Joseph durante o final da Battle Tendency.";
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

            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox5.Image = Properties.Resources.p2_kars;

                label1.Text = "Kars (カーズ Kāzu) é o principal antagonista de Battle Tendency.Kars é o líder dos Homens do Pilar e o criador da Máscara de Pedra . Seu objetivo é evoluir ainda mais para se tornar imune aos raios do sol e, assim, ele busca a Pedra Vermelha de Aja para fortalecer suas Máscaras, lutando contra os usuários do Hamon por sua posse. Ele está classificado em 1º lugar entre todos os Homens do Pilar.Como o criador das Máscaras de Pedra e Vampiros, Kars é um dos personagens mais influentes da série; sua invenção teve repercussões de longo alcance para vários personagens importantes, como Dio Brando , a Família Joestar e a Família Zeppeli.";
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

            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox5.Image = Properties.Resources.p2_stroiheim;

                label1.Text = "Rudol von Stroheim (ルドル・フォン・シュトロハイム Rudoru fon Shutorohaimu) é um aliado central em Battle Tendency.\r\n\r\nStroheim é apresentado como um oficial nazista pesquisando e experimentando o Homem do Pilar Santana. Eventualmente, ele e sua unidade cooperam com os usuários do Hamon para impedir a ameaça dos Homens do Pilar.";
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

            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox5.Image = Properties.Resources.p2_esidisi;

                label1.Text = "Esidisi (エシディシ Eshidishi) é um antagonista apresentado em Battle Tendency.\r\n\r\nEle é o segundo Homem do Pilar mais bem classificado depois de Kars e luta contra os usuários do Hamon pela posse da Pedra Vermelha de Aja.";
                if (radioButton6.Checked == false)
                {
                    label1.Text = null;
                    pictureBox5.Image = null;

                }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                if(listBox1.SelectedIndex  == 0)
                {
                    label2.Text = "Jonathan é o herdeiro único de uma notória família da aristocracia britânica, os Joestar. Tudo o que o jovem queria era ser um cavalheiro e viver de forma tranquila e despreocupada. Porém, seus pacatos dias estão para acabar, pois a chegada do “invasor” Dio Brando fará tudo virar de cabeça para baixo. Além de sofrer diariamente nas mãos de Dio, ainda há a presença sombria de uma misteriosa Máscara de Pedra...";
                    pictureBox6.Image = Properties.Resources.gif_p1;
                }

                if (listBox1.SelectedIndex == 1)
                {
                    label2.Text = "Araki afirmou que suas inspirações para Phantom Blood foram o mangá Fist of the North Star e o romance Bram Stoker's Dracula.";
                    pictureBox6.Image = Properties.Resources.wryyyyyy;
                }


            }

            if (comboBox1.SelectedIndex == 1)
            {
                if (listBox1.SelectedIndex == 0)
                {
                    label2.Text = "A segunda parte Battle Tendency mostra o neto de Jonathan, Joseph Joestar, cruzando o mundo nos dias que antecederam a Segunda Guerra Mundial em 1938 para combater os Homens do Pilar, uma antiga raça de seres hostis responsáveis ​​pela criação da Máscara de Pedra. Como seu avô, Joseph passa por um árduo treinamento em Hamon ao lado de César Anthonio Zeppeli, neto de Will, pela secreta Lisa Lisa e tenta proteger a Pedra Vermelha de Aja, uma joia procurada pelos Homens do Pilar para completar a Máscara de Pedra e conceder imunidade ao Sol.";
                     pictureBox6.Image = Properties.Resources.aberturaaa;
                }

                if (listBox1.SelectedIndex == 1)
                {
                    label2.Text = "Como inglês, ele é famoso por dizer várias frases em inglês. Seus bordões incluem \"OH! NÃO!\" (Usado na Parte 2 e na Parte 3 ) e \"Oh! Meu! Deus!\" (usado na Parte 3 e Parte 4 ) como alguns exemplos.\r\nNa parte 3, Joseph é erroneamente chamado de americano por alguns personagens, apesar de ser britânico. Isso se deve ao fato de que Joseph estava viajando por países da Ásia, e é comum que a maioria das pessoas que não falam inglês não saibam as diferenças de sotaque dos diferentes dialetos da língua inglesa.";
                    pictureBox6.Image = Properties.Resources.nigerandaioooo;
                }


            }

            if (comboBox1.SelectedIndex == 2)
            {
                if (listBox1.SelectedIndex == 0)
                {
                    label2.Text = "";
                    pictureBox6.Image = Properties.Resources.aberturaaa;
                }

                if (listBox1.SelectedIndex == 1)
                {
                    label2.Text = "";
                    pictureBox6.Image = Properties.Resources.nigerandaioooo;
                }


            }

            if (comboBox1.SelectedIndex == 3)
            {
                if (listBox1.SelectedIndex == 0)
                {
                    label2.Text = "";
                    pictureBox6.Image = Properties.Resources.aberturaaa;
                }

                if (listBox1.SelectedIndex == 1)
                {
                    label2.Text = "";
                    pictureBox6.Image = Properties.Resources.nigerandaioooo;
                }


            }

            if (comboBox1.SelectedIndex == 4)
            {
                if (listBox1.SelectedIndex == 0)
                {
                    label2.Text = "";
                    pictureBox6.Image = Properties.Resources.aberturaaa;
                }

                if (listBox1.SelectedIndex == 1)
                {
                    label2.Text = "";
                    pictureBox6.Image = Properties.Resources.nigerandaioooo;
                }


            }

            if (comboBox1.SelectedIndex == 5)
            {
                if (listBox1.SelectedIndex == 0)
                {
                    label2.Text = "";
                    pictureBox6.Image = Properties.Resources.aberturaaa;
                }

                if (listBox1.SelectedIndex == 1)
                {
                    label2.Text = "";
                    pictureBox6.Image = Properties.Resources.nigerandaioooo;
                }


            }

            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                pictureBox7.Image = Properties.Resources.mascara;
                if (checkBox1.Checked == false)
                {
                 
                    pictureBox7.Image = null;

                }
            }

            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox7.Image = Properties.Resources.p2_hamon;
                if (checkBox1.Checked == false)
                {

                    pictureBox7.Image = null;

                }
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox8.Image = Properties.Resources.Luck_Pluck1;
                if (checkBox2.Checked == false)
                {

                    pictureBox8.Image = null;

                }
            }

            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox8.Image = Properties.Resources.p2_bolhas;
                if (checkBox2.Checked == false)
                {

                    pictureBox8.Image = null;

                }
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox9.Image = Properties.Resources.hamon;
                if (checkBox3.Checked == false)
                {

                    pictureBox9.Image = null;

                }
            }

            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox9.Image = Properties.Resources.p2_batbeg1;
                if (checkBox3.Checked == false)
                {

                    pictureBox9.Image = null;

                }
            }

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox10.Image = Properties.Resources.overdrive1;
                if (checkBox5.Checked == false)
                {

                    pictureBox10.Image = null;

                }
            }

            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox10.Image = Properties.Resources.p2_tempestade;
                if (checkBox5.Checked == false)
                {

                    pictureBox10.Image = null;

                }
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox11.Image = Properties.Resources.congelamento1;
                if (checkBox4.Checked == false)
                {

                    pictureBox11.Image = null;

                }
            }

            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox11.Image = Properties.Resources.p2_redatone;
                if (checkBox4.Checked == false)
                {

                    pictureBox11.Image = null;

                }
            }

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox12.Image = Properties.Resources.planar;
                if (checkBox6.Checked == false)
                {

                    pictureBox12.Image = null;

                }
            }

            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox12.Image = Properties.Resources.p2_pilarman;
                if (checkBox6.Checked == false)
                {

                    pictureBox12.Image = null;

                }
            }

        }
    }
}
