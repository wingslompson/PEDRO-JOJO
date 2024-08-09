﻿using System;
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
                checkBox2.Text = "The World";
                checkBox3.Text = "Hierophant Green";
                checkBox4.Text = "Magicans Red";
                checkBox5.Text = "Silver Chariot";
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

            if (comboBox1.SelectedIndex == 3)
            {
                pictureBox5.Image = Properties.Resources.p4_josuke;

                label1.Text = "Josuke Higashikata (東方 仗助, Higashikata Jōsuke; o Suke — 助 — em seu nome também pode ser pronunciado como \"Jo\") \r\né o protagonista de Diamond is Unbreakable e o quarto JoJo da série série JoJo's Bizarre Adventure.\r\nJosuke é um aluno do primeiro ano do ensino médio que mora na cidade de Morioh. Ele logo conhece Jotaro Kujo, \r\nque o informa que ele é filho ilegítimo de Joseph Joestar. Depois que seu avô morre, \r\nJosuke assume a responsabilidade de proteger sua amada cidade dos malévolos usuários do Stand.\r\nJosuke empunha Crazy Diamond, um poderoso Stand com o poder de consertar quase tudo.";
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

                label1.Text = "Dio Brando (ディオ・ブランドーDio Burandō), conhecido como DIO da Parte 3 em diante, é o principal antagonista no universo original de JoJo's Bizarre Adventure, apresentado principalmente como o principal antagonista em Phantom Blood e Stardust Crusaders, e um antagonista chave póstumo em Stone Ocean.\r\n\r\nDepois de se tornar um Vampiro e mais tarde um usuário de Stand, Dio reuniu ao seu redor muitos lacaios e é responsável por muitos eventos importantes da série, desde a morte de Jonathan Joestar até a aquisição repentina do poder Stand pela Família Joestar, e seu legado persiste. ao longo da série.";
                if (radioButton2.Checked == false)
                {
                    label1.Text = null;
                    pictureBox5.Image = null;

                }

            }

            if (comboBox1.SelectedIndex == 3)
            {
                pictureBox5.Image = Properties.Resources.p4_koichi;

                label1.Text = "Koichi Hirose (広瀬 康一 Hirose Kōichi) é o deuteragonista de Diamond is Unbreakable e aparece brevemente como um personagem \r\nsecundário em Vento Aureo.\r\nKoichi é um tímido aluno do primeiro ano do ensino médio que faz amizade com Josuke Higashikata e \r\ndepois se envolve no mundo dos usuários do Stand.\r\nKoichi também se torna um usuário de Stand e usa Echoes.";
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

            if (comboBox1.SelectedIndex == 2)
            {
                pictureBox5.Image = Properties.Resources.p3_kakioin;

                label1.Text = "Noriaki Kakyoin (花京院典明 Kakyōin Noriaki) é um aliado central em Stardust Crusaders e um estudante japonês que sofreu uma lavagem cerebral por DIO durante uma viagem anterior ao Egito e é enviado para matar Jotaro Kujo. Depois de se libertar da influência de DIO, ele decide se juntar a Jotaro em sua jornada ao Egito para salvar a mãe de Jotaro e encontrar a redenção.\r\n\r\nKakyoin é um Usuário de Stand e empunha o Hierophant Green de longo alcance.";
                 if (radioButton3.Checked == false)
                {
                    label1.Text = null;
                    pictureBox5.Image = null;

                }
            }

            if (comboBox1.SelectedIndex == 3)
            {
                pictureBox5.Image = Properties.Resources.p4_okuyasu;

                label1.Text = "Okuyasu Nijimura (虹村 億泰 Nijimura Okuyasu) é um aliado central apresentado em Diamond is Unbreakable.\r\nApresentado como um antagonista, Okuyasu logo se torna o melhor amigo de Josuke Higashikata.\r\n Eles permanecem amigos íntimos durante a Parte 4 e enfrentam usuários malévolos do Stand juntos.\r\nEle também é o irmão mais novo de Keicho Nijimura e também um usuário de Stand empunhando o temível \" The Hand \"."; 
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

            if (comboBox1.SelectedIndex == 2)
            {
                pictureBox5.Image = Properties.Resources.p3_ponareff;

                label1.Text = "Jean Pierre Polnareff (ジャン・ピエール・ポルナレフ Jan Piēru Porunarefu) é um aliado central e usuário de stand em Stardust Crusaders. Ele reaparece em Vento Aureo como um personagem secundário e aliado.\r\n\r\nEm Stardust Crusaders, o francês Polnareff inicialmente como um lacaio de DIO após ter um esporo de carne, ele viaja com o Grupo Joestar para vingar sua irmã Sherry, que foi assassinada por um homem com duas mãos direitas.";
                if (radioButton4.Checked == false)
                {
                    label1.Text = null;
                    pictureBox5.Image = null;

                }
            }

            if (comboBox1.SelectedIndex == 3)
            {
                pictureBox5.Image = Properties.Resources.p4_rohan;

                label1.Text = "Rohan Kishibe (岸辺 露伴 Kishibe Rohan) é um importante aliado apresentado em Diamond is Unbreakable. Apresentado pela\r\n primeira vez como um antagonista, ele coopera na busca por Yoshikage Kira.\r\nUm mangaká profissional de sucesso, Rohan é frequentemente envolvido em eventos paranormais enquanto realiza pesquisas para \r\nseu último mangá. Ele é um usuário de Stand que usa seu Stand, Heaven's Door, para transformar outras\r\npessoas em livros e lê-los em busca de inspiração."; 
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

            if (comboBox1.SelectedIndex == 2)
            {
                pictureBox5.Image = Properties.Resources.p3_avdol;

                label1.Text = "Muhammad Avdol (モハメド・アヴドゥル Mohamedo Avuduru) é um aliado central em Stardust Crusaders.\r\n\r\nApresentado como um amigo egípcio de Joseph Joestar, ele se junta ao grupo em sua jornada para derrotar DIO, fornecendo conhecimento e orientação sobre usuários de Stand inimigos e culturas locais ao longo do caminho.\r\n\r\nAvdol é um usuário de Stand e empunha o Stand de manipulação de fogo, Magician's Red."; 
                if (radioButton5.Checked == false)
                {
                    label1.Text = null;
                    pictureBox5.Image = null;

                }
            }

            if (comboBox1.SelectedIndex == 3)
            {
                pictureBox5.Image = Properties.Resources.p4_jotaro;

                label1.Text = "Jotaro Kujo (空条 承太郎 Kūjō Jōtarō) é o protagonista da Parte 3 e também aparece nas Partes 4-6 Jotaro é o terceiro e o JoJo \r\nmais recorrente na série JoJo's Bizarre Adventure.\r\nJotaro é um delinquente que vive uma vida normal até que o velho inimigo da Família Joestar, DIO, retorna. Jotaro viaja para \r\no Egito para salvar sua mãe e parar o Vampiro de uma vez por todas.\r\nEmpunhando o incrivelmente poderoso Star Platinum, Jotaro é o primeiro JoJo apresentado com um Stand e está entre os \r\npersonagens mais conhecidos da série.\r\n"; 
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

            if (comboBox1.SelectedIndex == 2)
            {
                pictureBox5.Image = Properties.Resources.p3_iggy;

                label1.Text = "Iggy (イギー Igī) é um aliado central que aparece na segunda metade de Stardust Crusaders.\r\n\r\nUm vira-lata urbano das ruas de Nova York, Iggy relutantemente ajuda os protagonistas em sua última expedição ao Cairo, Egito, para derrotar DIO.\r\n\r\nIggy é um usuário do Stand que empunha o The Fool.";
                if (radioButton6.Checked == false)
                {
                    label1.Text = null;
                    pictureBox5.Image = null;

                }
            }

            if (comboBox1.SelectedIndex == 3)
            {
                pictureBox5.Image = Properties.Resources.p4_kira;

                label1.Text = "Yoshikage Kira (吉良 吉影 Kira Yoshikage) é o principal antagonista de Diamond is Unbreakable.\r\nDespercebido em Morioh por anos e imperturbável durante toda a sua vida, Yoshikage Kira é um serial killer anormal e \r\nparafílico cuja rotina é abalada quando o fantasma de sua primeira vítima, Reimi Sugimoto , implora ao Grupo Joestar para \r\nprocurá-lo e ele atrai atenção indesejada ao matar Shigekiyo Yangu. Kira é um usuário de Stand e empunha a poderosa Killer Queen,\r\n que tem a habilidade de criar bombas mortais"; 
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
                    label2.Text = "A terceira parte Stardust Crusaders é ambientada em 1989, quando o neto de Joseph, Jotaro Kujo, viaja com Joseph, Muhammad Avdol, Noriaki Kakyoin, Jean Pierre Polnareff e Iggy de Tóquio até o Cairo para lutar contra DIO, que voltou das profundezas do mar, para salvar sua mãe da influência sobrenatural de DIO. A partir de agora, aliados e vilões principalmente usam Stands, uma representação geralmente humanoide do espírito da pessoa, que se tornou uma das características mais proeminentes da série.";
                    pictureBox6.Image = Properties.Resources.gif_p3;
                }

                if (listBox1.SelectedIndex == 1)
                {
                    label2.Text = "Stardust Crusaders contém os personagens e episódios mais conhecidos da série; apresentando o fenômeno Stand distinto de JoJo e o emblemático protagonista Jotaro Kujo.\r\nMuitos personagens não foram nomeados até o lançamento de materiais adicionais, como os livros de arte.\r\nAraki descreve a base da Parte 3 como um jogo de tabuleiro, viajando entre uma série de paradas; e mais inspiração no filme A Volta ao Mundo em 80 Dias.\r\nEnquanto ele começava a planejar este papel, Araki primeiro o apresentou como uma versão moderna de Drácula. Só havia uma pessoa na sala que achou que era uma boa ideia; o resto ficou totalmente confuso. Seus editores disseram a ele para ter pelo menos um personagem/arco de história japonês antes desta parte, pois sentiram que a história tinha muitos personagens e cenários estrangeiros para o público-alvo dos quadrinhos.\r\nA Parte 3 é a última a apresentar qualquer vampiro ou a habilidade Hamon.";
                    pictureBox6.Image = Properties.Resources.gif_p3_2;
                }


            }

            if (comboBox1.SelectedIndex == 3)
            {
                if (listBox1.SelectedIndex == 0)
                {
                    label2.Text = "A historia passa-se em 1999, a temporada segue as aventuras de Josuke Higashikata, o filho ilegítimo de Joseph Joestar, enquanto ele e seus novos\r\n amigos buscam um arco e flecha mágico que concedeu às pessoas poderes perigosos de Stand, arrancando a vida antes tranquila \r\nde Josuke em sua casa cidade de Morioh.";
                    pictureBox6.Image = Properties.Resources.gif_p4;
                }

                if (listBox1.SelectedIndex == 1)
                {
                    label2.Text = "Esta parte se destaca por se passar em um cenário fictício, sem viajar para nenhum local real.\r\nDeixando o Tarô e a mitologia egípcia na Parte 3, a Parte 4 faz referência principalmente à música popular (rock) em seus nomes.\r\nAraki afirma que é possível que JoJo's Bizarre Adventure pudesse ter terminado na Parte 3, já que a ressurreição de DIO foi o último elemento da trama do precedente.\r\nO título deste arco foi traduzido anteriormente como Diamond Is Not Crash.\r\nEsta parte é notável por ter uma das mudanças mais drásticas no estilo artístico à medida que progredia. No seu início,\r\n ele assumiu o visual musculoso inspirado no Fist of the North Star que esteve presente nas três partes anteriores. ";
                    pictureBox6.Image = Properties.Resources.gif_p4_2;
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

            if (comboBox1.SelectedIndex == 2)
            {
                pictureBox7.Image = Properties.Resources.standp3_star;
                if (checkBox1.Checked == false)
                {

                    pictureBox7.Image = null;

                }
            }

            if (comboBox1.SelectedIndex == 3)
            {
                pictureBox7.Image = Properties.Resources.standp4_crazy;
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


            if (comboBox1.SelectedIndex == 2)
            {
                pictureBox8.Image = Properties.Resources.standp3_wolrd;
                if (checkBox2.Checked == false)
                {

                    pictureBox8.Image = null;

                }
            }

            if (comboBox1.SelectedIndex == 3)
            {
                pictureBox8.Image = Properties.Resources.standp4_echoes;
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


            if (comboBox1.SelectedIndex == 2)
            {
                pictureBox9.Image = Properties.Resources.standp3_greeb;
                if (checkBox3.Checked == false)
                {

                    pictureBox9.Image = null;

                }
            }

            if (comboBox1.SelectedIndex == 3)
            {
                pictureBox9.Image = Properties.Resources.standp4_hand;
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


            if (comboBox1.SelectedIndex == 2)
            {
                pictureBox10.Image = Properties.Resources.standp3_silver;
                if (checkBox5.Checked == false)
                {

                    pictureBox10.Image = null;

                }
            }

            if (comboBox1.SelectedIndex == 3)
            {
                pictureBox10.Image = Properties.Resources.standp4_door;
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


            if (comboBox1.SelectedIndex == 2)
            {
                pictureBox11.Image = Properties.Resources.standp3_red;
                if (checkBox4.Checked == false)
                {

                    pictureBox11.Image = null;

                }
            }

            if (comboBox1.SelectedIndex == 3)
            {
                pictureBox11.Image = Properties.Resources.standp4_star;
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

            if (comboBox1.SelectedIndex == 2)
            {
                pictureBox12.Image = Properties.Resources.standp3_fool;
                if (checkBox6.Checked == false)
                {

                    pictureBox12.Image = null;

                }
            }

            if (comboBox1.SelectedIndex == 3)
            {
                pictureBox12.Image = Properties.Resources.standp4_queen;
                if (checkBox6.Checked == false)
                {

                    pictureBox12.Image = null;

                }
            }


        }
    }
}
