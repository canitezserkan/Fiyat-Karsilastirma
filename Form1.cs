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

namespace FiyatKarsilastir
{
    public partial class Form1 : Form
    {
        private SoundPlayer _soundPlayerNoah;
        private SoundPlayer _soundPlayerMenu;
        private SoundPlayer _soundPlayerOptionRepair;
        private SoundPlayer _soundPlayerCloseForm;
        
        public Form1()
        {
            InitializeComponent();

            menuStrip1.Renderer = new MyRenderer();

            this.Opacity = 0.99;  //FORM KAPANIRKEN OPACITY'SI DÜŞEREK KAPANMASI İÇİN

            _soundPlayerNoah = new SoundPlayer(FiyatKarsilastir.Properties.Resources.ui_money);
            _soundPlayerMenu = new SoundPlayer(FiyatKarsilastir.Properties.Resources.ui_button4);
            _soundPlayerOptionRepair = new SoundPlayer(FiyatKarsilastir.Properties.Resources.ui_money);
            _soundPlayerCloseForm = new SoundPlayer(FiyatKarsilastir.Properties.Resources.fire_cast);



            //TEXTBOX'LARIN BÜYÜKLÜKLERİNİ AYARLA
            #region
            this.textBox1.AutoSize = false;
            this.textBox1.Size = new System.Drawing.Size(49, 23);

            this.textBox2.AutoSize = false;
            this.textBox2.Size = new System.Drawing.Size(49, 23);

            this.textBox3.AutoSize = false;
            this.textBox3.Size = new System.Drawing.Size(49, 23);

            this.textBox4.AutoSize = false;
            this.textBox4.Size = new System.Drawing.Size(49, 23);

            this.textBox5.AutoSize = false;
            this.textBox5.Size = new System.Drawing.Size(73, 23);

            this.textBox6.AutoSize = false;
            this.textBox6.Size = new System.Drawing.Size(49, 23);

            this.textBox7.AutoSize = false;
            this.textBox7.Size = new System.Drawing.Size(49, 23);

            this.textBox8.AutoSize = false;
            this.textBox8.Size = new System.Drawing.Size(214, 24);
            #endregion

        }


        //MENU STRIP KISMINDA "DOSYA" SEÇENEĞİNE GELİNDİĞİNDE HOVER RENGİ DĞEİŞSİN DİYE VE İÇİNDEKİ İTEMLERİN ÜSTÜNE GELİNDİĞİNDE
        //DE FARKLI RENKLER ÇIKSIN DİYE WINDOWS'UN DEFAULT AYARLARIYLA OYNAMA YAPILDI.
        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

            private class MyColors : ProfessionalColorTable {
        public override Color MenuItemSelected {
            get { return Color.Black; }
        }
        public override Color MenuItemSelectedGradientBegin {
            get { return Color.Orange; }
        }
        public override Color MenuItemSelectedGradientEnd {
            get { return Color.Black; }

        }
        public override Color MenuItemBorder
        {
            get { return Color.Black; }
        }
    }



        //FORM KAPANIRKEN OPACITY'SI DÜŞEREK KAPANMASI İÇİN
        #region
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (!e.Cancel)
            {
                _soundPlayerCloseForm.Play();
                for (int op = 99; op >= 0; op -= 2)
                {
                    this.Opacity = op / 100f;
                    System.Threading.Thread.Sleep(15);
                }
            }
        }
        #endregion

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
            //EĞER HESPALAMA SONRASI AŞAĞIDA GÖZÜKEN BİR SONUÇ VAR İSE, VE RADIOBUTTON'LARA TEKRARDAN TIKLANIRSA BU AŞAĞIDAKİ SONUÇ SİLİNECEKTİR.
            #region
            label7.Visible = false;
            label14.Visible = false;
            label9.Visible = false;
            label13.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            #endregion
        }
        private void Form1_Load(object sender, EventArgs e)
        {    
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
        }



        private void button2_Click(object sender, EventArgs e)
        {

            //TEMİZLEME İŞİNİ YAPAN TUŞTUR. BÜTÜN  TEXTBOX'LARI TEMİZLER VE SONUCU VEREN LABEL'LARI DA EKRANDA INVISIBLE HALE SOKAR.
            #region
            label13.Text = "ERROR";
            label14.Text = "ERROR";
            label7.Visible = false;
            label14.Visible = false;
            label9.Visible = false;
            label13.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox1.Focus();

            if(radioButton1.Checked==true || radioButton2.Checked == true)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }

            label6.Visible = false;
            label8.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            textBox8.Text = "";
            textBox5.Text = "";

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            #endregion
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //EĞER HESAPLAMA SONRASI AŞAĞIDA GÖZÜKEN BİR SONUÇ VAR İSE, VE RADIOBUTTON'LARA TEKRARDAN TIKLANIRSA BU AŞAĞIDAKİ SONUÇ SİLİNECEKTİR.
            #region
            label7.Visible = false;
            label14.Visible = false;
            label9.Visible = false;
            label13.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            #endregion
        }
        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

            //SATIN ALINACAK EŞYA, PUSTA ÇOKLU HALDE SATILIYOR İSE BU KOD KISMI DEVREYE GİRECEK VE ALINACAK İTEMİN PARÇALI OLUP OLMADIĞINI VE PARÇALIYSA KAÇ ADET OLDUĞU SORAN KISIMLARI VISIBLE YAPACAK
            //SATIN ALINACAK EŞYANIN, ORJİNAL HALDEKİ PUS SATIŞ MİKTARINI DA GERÇEK ZAMANLI HESAPLAYIP LABEL'DA GÖSTERECEK
            #region
            if (textBox8.Text == "Premium Potion MP" || textBox8.Text == "Premium Potion HP" || textBox8.Text == "Lesson of Master" || textBox8.Text == "Duration Item"
                || textBox8.Text == "Medium Level Seal Exchange" || textBox8.Text == "Teleportation Item" || textBox8.Text == "HP Scroll 60%" || textBox8.Text == "Scroll of Armor 350"
                || textBox8.Text == "2000 Health+ Scroll" || textBox8.Text == "MP+ Scroll(Stat)(L)" || textBox8.Text == "INT+ Scroll(Stat)(L)" || textBox8.Text == "DEX+ Scroll(Stat)(L)"
                || textBox8.Text == "HP+ Scroll(Stat)(L)" || textBox8.Text == "STR+ Scroll(Stat)(L)" || textBox8.Text == "Attack Damage+" || textBox8.Text == "Speed+Potion"
                || textBox8.Text == "150 Defense+Scroll(L)" || textBox8.Text == "300 Defense+Scroll(L)" || textBox8.Text == "500 Health+Scroll(L)" || textBox8.Text == "1000 Health+Scroll(L)"
                || textBox8.Text == "1500 Health+Scroll(L)" || textBox8.Text == "Genie Hammer" || textBox8.Text == "Magpie (Karus)" || textBox8.Text == "Magpie (Elmorad)"
                || textBox8.Text == "Ibex(Karus)" || textBox8.Text == "Crisis(Elmorad)" || textBox8.Text == "Cougar Transform (Elmorad)" || textBox8.Text == "Cougar Transform (Karus)"
                || textBox8.Text == "Patrick Transform (Elmorad)" || textBox8.Text == "Patrick Transform (Karus)" || textBox8.Text == "Hera Transform (Elmorad)" || textBox8.Text == "Hera Transform (Karus)"
                || textBox8.Text == "Menissiah Transform (Elmorad)" || textBox8.Text == "Menissiah Transform (Karus)" || textBox8.Text == "Power of Lion Scroll(Stat)(L)" || textBox8.Text == "Spirit of Genie (10ea)"
                || textBox8.Text == "Seal Exchange Voucher" || textBox8.Text == "Hyper Noah Scroll" || textBox8.Text == "Merchant Concentration" || textBox8.Text == "NP Increase Item" || textBox8.Text == "Symbol of Gladiator[10 ea]"
                || textBox8.Text == "Symbol of Warrior[10ea]" || textBox8.Text == "Symbol of Growth")
            {
                label21.Visible = true;
                label22.Visible = true;
                label8.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
            }
            else
            {
                label8.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }

            if(textBox8.Text == "Premium Potion MP" || textBox8.Text == "Premium Potion HP")

            {
                label21.Text = "Orjinal PUS Adedi : ";
                label22.Text = "5000";
            }
            else if (textBox8.Text == "Duration Item" || textBox8.Text == "Lesson of Master")
            {
                label21.Text = "Orjinal PUS Adedi : ";
                label22.Text = "100";
            }
            else if (textBox8.Text == "Teleportation Item" || textBox8.Text == "Medium Level Seal Exchange")
            {
                label21.Text = "Orjinal PUS Adedi : ";
                label22.Text = "50";
            }
            else if (textBox8.Text == "Genie Hammer" || textBox8.Text == "HP Scroll 60%" || textBox8.Text == "Scroll of Armor 350"
                || textBox8.Text == "1500 Health+Scroll(L)" || textBox8.Text == "2000 Health+ Scroll" || textBox8.Text == "1000 Health+Scroll(L)"
                || textBox8.Text == "500 Health+Scroll(L)" || textBox8.Text == "MP+ Scroll(Stat)(L)" || textBox8.Text == "300 Defense+Scroll(L)"
                || textBox8.Text == "INT+ Scroll(Stat)(L)" || textBox8.Text == "150 Defense+Scroll(L)" || textBox8.Text == "DEX+ Scroll(Stat)(L)"
                || textBox8.Text == "HP+ Scroll(Stat)(L)" || textBox8.Text == "Speed+Potion" || textBox8.Text == "STR+ Scroll(Stat)(L)"
                || textBox8.Text == "Attack Damage+")
            {
                label21.Text = "Orjinal PUS Adedi : ";
                label22.Text = "30";
            }
            else if (textBox8.Text == "Power of Lion Scroll(Stat)(L)" || textBox8.Text == "Magpie (Karus)" || textBox8.Text == "Menissiah Transform (Karus)"
                || textBox8.Text == "Magpie (Elmorad)" || textBox8.Text == "Menissiah Transform (Elmorad)" || textBox8.Text == "Ibex(Karus)"
                || textBox8.Text == "Hera Transform (Karus)" || textBox8.Text == "Crisis(Elmorad)" || textBox8.Text == "Hera Transform (Elmorad)"
                || textBox8.Text == "Cougar Transform (Elmorad)" || textBox8.Text == "Patrick Transform (Karus)" || textBox8.Text == "Patrick Transform (Elmorad)"
                || textBox8.Text == "Cougar Transform (Karus)")
            {
                label21.Text = "Orjinal PUS Adedi : ";
                label22.Text = "20";
            }
            else if (textBox8.Text == "Symbol of Gladiator[10 ea]" || textBox8.Text == "Spirit of Genie (10ea)" || textBox8.Text == "Symbol of Warrior[10ea]"
                || textBox8.Text == "Seal Exchange Voucher" || textBox8.Text == "NP Increase Item" || textBox8.Text == "Hyper Noah Scroll"
                || textBox8.Text == "Merchant Concentration")
            {
                label21.Text = "Orjinal PUS Adedi : ";
                label22.Text = "10";
            }
            else if (textBox8.Text == "Symbol of Growth")
            {
                label21.Text = "Orjinal PUS Adedi : ";
                label22.Text = "5";
            }
            else
            { 
                label22.Text = "";
                label21.Text = "";
            }
            #endregion

            //
            label7.Visible = false;
            label14.Visible = false;
            label9.Visible = false;
            label13.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
        }

        //AŞAĞIDAKİ BLOK'UN HEPSİ, TEXTBOX'LARA HARF GİRİLMESİNE ENGEL OLMA İŞİNİ YAPIYOR - SATIN ALINACAK EŞYANIN ISMININ SORULDUĞU TEXTBOX HARİÇ

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //EĞER HESPALAMA SONRASI AŞAĞIDA GÖZÜKEN BİR SONUÇ VAR İSE, VE RADIOBUTTON'LARA TEKRARDAN TIKLANIRSA BU AŞAĞIDAKİ SONUÇ SİLİNECEKTİR.
            #region
            label7.Visible = false;
            label14.Visible = false;
            label9.Visible = false;
            label13.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            #endregion
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }



        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //EĞER ÜRÜNÜN PARÇALI MİKTARDA SATILDIĞINI BELİRTMİŞSE KULLANICI, SAĞ TARAFTAKİ MİKTAR SORAN KISIM VISIBLE OLACAKTIR. 
            //AKSİ HALDE, MİKTARI GİRDİĞİMİZ TEXTBOX'IN İÇİ TEMİZLENECEKTİR VE O KISIM KOMPLE GÖRÜNMEZ OLACAKTIR.
            #region
            if (radioButton2.Checked == true)
            {
                label6.Visible = true;
                textBox5.Visible = true;
            }
            else
            {
                label6.Visible = false;
                textBox5.Text = "";
                textBox5.Visible = false;
            }
            #endregion

            //EĞER HESAPLAMA YAPILDIKTAN SONRA ALT KISIMDA SONUÇ GÖZÜKMÜŞ İSE, VE TEKRARDAN RADIO BUTTON'LARA TIKLANIR İSE AŞAĞIDAKİ SONUÇLAR EŞ ZAMANLI GÖRÜNMEZ OLACAKTIR.
            #region
            label7.Visible = false;
            label14.Visible = false;
            label9.Visible = false;
            label13.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            #endregion

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                //SONUCU GÖSTEREN LABEL'LARIN HEPSİNİ GÖRÜNMEZ YAPTIM ÇÜNKÜ BUTON'A TIKLANDIKTAN SONRA YENİ BİR SONUÇ YA DA HATA İŞLEMİ EKRANA GELECEK VE O YÜZDEN EKRAN TEMİZ KALMALI
                #region
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                label9.Visible = false;
                label13.Visible = false;
                label7.Visible = false;
                label14.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label13.Text = "ERROR";
                label14.Text = "ERROR";
                #endregion

                //EĞER TEXTBOXT'LAR BOŞ HALDE İKEN HESAPLAMA BUTON'UNA TIKLANIRSA PROGRAM HATA VERECEKTİR. EKSTRA OLARAK, OYUN İÇİ PARASININ KURUŞ KISMI 3 HANELİ SAYI DEĞİLSE, SON TEXTBOX'UN HATASINDAN ÖNCE BU HATAYI VERMESİ SAĞLANDI
                #region
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
                {
                    MessageBox.Show("Lütfen Bilgilerinizi Eksiksiz Giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Double KurusGuncelOyuniciHataBelirle = 0;      //OYUNICI FİYATI DEĞİŞKEN YARAT
                KurusGuncelOyuniciHataBelirle = Double.Parse(textBox4.Text);          //OYUNİÇİ FİYATI
                if (KurusGuncelOyuniciHataBelirle < 100)     //KURUŞ KISMI 100'ÜN ALTINDA İSE BUNUN 0.004'MÜ YOKSA 4'MÜ OLDUĞUNU SORGULA
                {
                    if (textBox4.Text == "000" || textBox4.Text == "001" || textBox4.Text == "002"
                        || textBox4.Text == "003" || textBox4.Text == "004" || textBox4.Text == "005"
                        || textBox4.Text == "006" || textBox4.Text == "007" || textBox4.Text == "008"
                        || textBox4.Text == "009" || textBox4.Text == "010" || textBox4.Text == "011"
                        || textBox4.Text == "012" || textBox4.Text == "013" || textBox4.Text == "014"
                        || textBox4.Text == "015" || textBox4.Text == "016" || textBox4.Text == "017"
                        || textBox4.Text == "018" || textBox4.Text == "019" || textBox4.Text == "020"
                        || textBox4.Text == "021" || textBox4.Text == "022" || textBox4.Text == "023"
                        || textBox4.Text == "024" || textBox4.Text == "025" || textBox4.Text == "026"
                        || textBox4.Text == "027" || textBox4.Text == "028" || textBox4.Text == "029"
                        || textBox4.Text == "030" || textBox4.Text == "031" || textBox4.Text == "032"
                        || textBox4.Text == "033" || textBox4.Text == "034" || textBox4.Text == "035"
                        || textBox4.Text == "036" || textBox4.Text == "037" || textBox4.Text == "038"
                        || textBox4.Text == "039" || textBox4.Text == "040" || textBox4.Text == "041"
                        || textBox4.Text == "042" || textBox4.Text == "043" || textBox4.Text == "044"
                        || textBox4.Text == "045" || textBox4.Text == "046" || textBox4.Text == "047"
                        || textBox4.Text == "048" || textBox4.Text == "049" || textBox4.Text == "050"
                        || textBox4.Text == "051" || textBox4.Text == "052" || textBox4.Text == "053"
                        || textBox4.Text == "054" || textBox4.Text == "055" || textBox4.Text == "056"
                        || textBox4.Text == "057" || textBox4.Text == "058" || textBox4.Text == "059"
                        || textBox4.Text == "060" || textBox4.Text == "061" || textBox4.Text == "062"
                        || textBox4.Text == "063" || textBox4.Text == "064" || textBox4.Text == "065"
                        || textBox4.Text == "066" || textBox4.Text == "067" || textBox4.Text == "068"
                        || textBox4.Text == "069" || textBox4.Text == "070" || textBox4.Text == "071"
                        || textBox4.Text == "072" || textBox4.Text == "073" || textBox4.Text == "074"
                        || textBox4.Text == "075" || textBox4.Text == "076" || textBox4.Text == "077"
                        || textBox4.Text == "078" || textBox4.Text == "079" || textBox4.Text == "080"
                        || textBox4.Text == "081" || textBox4.Text == "082" || textBox4.Text == "083"
                        || textBox4.Text == "084" || textBox4.Text == "085" || textBox4.Text == "086"
                        || textBox4.Text == "087" || textBox4.Text == "088" || textBox4.Text == "089"
                        || textBox4.Text == "090" || textBox4.Text == "091" || textBox4.Text == "092"
                        || textBox4.Text == "093" || textBox4.Text == "094" || textBox4.Text == "095"
                        || textBox4.Text == "096" || textBox4.Text == "097" || textBox4.Text == "098"
                        || textBox4.Text == "099")
                    {
                    }

                    else
                    {
                        MessageBox.Show("Lütfen Oyun İçi Para Miktarını Üç Haneli Olacak Şekilde Belirtiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                #endregion

                //EĞER BUTON'A TIKLANDIKTAN SONRA EŞYA'NIN PARÇALI MI SATILDIĞINI SORAN KISIM GÖRÜNMEZ HALDE İSE, ONUN SAHİP OLDUĞU RADİO BUTON'LARINI UNCHECKED HALE GETİRİR
                #region
                if (label8.Visible == false || radioButton1.Visible == false || radioButton2.Visible == false) //alta gidebilir belirli itemler yazılınca çünkü görünmezler ortaya çıkacak ve işlem bitince butona tekrar tıklanırsa o kutular görünmez olmalı yada yeni visible oluşturulup en altta false yapılmalı
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;

                }
                #endregion

                //BU KISIMDA, EŞYA'NIN PARÇALI MI OLUP OLMADIĞINI SORAN KISMIN GÖRÜNÜZ OLDUĞUNU BİLİYORUZ VE EĞER RADIO BUTON'LARIN İKİSİ DE İŞARETLENMEMİŞ İSE, EKRANA HATA YANSITACAĞIZ
                #region
                else if (radioButton1.Checked == false && radioButton2.Checked == false)
                {
                    MessageBox.Show("Lütfen Bir Şık Seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                #endregion

                //EĞER EN SONDAKİ TEXTBOX, YANİ PARÇALI EŞYANIN SAYISINI SORAN TEXTBOX BOŞ İSE PROGRAM HATA VERECEKTİR. YA DA BU KISMIN İÇİNDEKİ SAYI, EŞYANIN ORJİNAL PUS MİKTARINDAN FAZLA İSE.
                //YA DA SIFIRA EŞİTSE.
                #region
                if (textBox5.Visible == true && textBox5.Text == "")
                {
                    MessageBox.Show("Lütfen Seçilen Eşya'nın Parça Adedini Kontrol Ediniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                #endregion
                #region
                if (textBox5.Visible == true && Convert.ToInt32(textBox5.Text) == 0)
                {
                    MessageBox.Show("Satılan Eşya'nın Parça Miktarı, SIFIR'a Eşit Olamaz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                #endregion
                #region
                if (textBox5.Visible == true && Convert.ToInt32(textBox5.Text) >= Convert.ToInt32(label22.Text))
                {
                    MessageBox.Show("Satılan Eşya'nın Parça Adedi, Orjinal Adedinden Az Olmalı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                #endregion

                if (textBox8.Text != "Premium Potion MP" && textBox8.Text != "Premium Potion HP" && textBox8.Text != "Lesson of Master" && textBox8.Text != "Duration Item"
                && textBox8.Text != "Medium Level Seal Exchange" && textBox8.Text != "Teleportation Item" && textBox8.Text != "HP Scroll 60%" && textBox8.Text != "Scroll of Armor 350"
                && textBox8.Text != "2000 Health+ Scroll" && textBox8.Text != "MP+ Scroll(Stat)(L)" && textBox8.Text != "INT+ Scroll(Stat)(L)" && textBox8.Text != "DEX+ Scroll(Stat)(L)"
                && textBox8.Text != "HP+ Scroll(Stat)(L)" && textBox8.Text != "STR+ Scroll(Stat)(L)" && textBox8.Text != "Attack Damage+" && textBox8.Text != "Speed+Potion"
                && textBox8.Text != "150 Defense+Scroll(L)" && textBox8.Text != "300 Defense+Scroll(L)" && textBox8.Text != "500 Health+Scroll(L)" && textBox8.Text != "1000 Health+Scroll(L)"
                && textBox8.Text != "1500 Health+Scroll(L)" && textBox8.Text != "Genie Hammer" && textBox8.Text != "Magpie (Karus)" && textBox8.Text != "Magpie (Elmorad)"
                && textBox8.Text != "Ibex(Karus)" && textBox8.Text != "Crisis(Elmorad)" && textBox8.Text != "Cougar Transform (Elmorad)" && textBox8.Text != "Cougar Transform (Karus)"
                && textBox8.Text != "Patrick Transform (Elmorad)" && textBox8.Text != "Patrick Transform (Karus)" && textBox8.Text != "Hera Transform (Elmorad)" && textBox8.Text != "Hera Transform (Karus)"
                && textBox8.Text != "Menissiah Transform (Elmorad)" && textBox8.Text != "Menissiah Transform (Karus)" && textBox8.Text != "Power of Lion Scroll(Stat)(L)" && textBox8.Text != "Spirit of Genie (10ea)"
                && textBox8.Text != "Seal Exchange Voucher" && textBox8.Text != "Hyper Noah Scroll" && textBox8.Text != "Merchant Concentration" && textBox8.Text != "NP Increase Item" && textBox8.Text != "Symbol of Gladiator[10 ea]"
                && textBox8.Text != "Symbol of Warrior[10ea]" && textBox8.Text != "Symbol of Growth" && textBox8.Text != "SWITCH Premium" && textBox8.Text != "EXP Premium" && textBox8.Text != "DISC Premium"
                && textBox8.Text != "WAR Premium" && textBox8.Text != "Trinas Piece" && textBox8.Text != "Shadow Piece" && textBox8.Text != "Dragons Wing" && textBox8.Text != "Clan Name Change Scroll"
                && textBox8.Text != "Monster Summon Staff" && textBox8.Text != "Gender Change" && textBox8.Text != "Name Change Scroll" && textBox8.Text != "Tears of Karivdis" && textBox8.Text != "Redistribution Item"
                && textBox8.Text != "Voucher for Magic Bag" && textBox8.Text != "Character Seal Scroll" && textBox8.Text != "Chaos Map Coupon" && textBox8.Text != "Ancient Text" && textBox8.Text != "Voucher for a Pathos Glove"
                && textBox8.Text != "Voucher for Automatic Pet" && textBox8.Text != "Nation Transfer" && textBox8.Text != "Cuff Binder Pet" && textBox8.Text != "Familiar Name Change" && textBox8.Text != "Pathos Package"
                && textBox8.Text != "Giga Hammer Pet" && textBox8.Text != "Krowaz Pet" && textBox8.Text != "HP Maestro Voucher" && textBox8.Text != "MP Maestro Voucher" && textBox8.Text != "Dryad Voucher (30 Days)"
                && textBox8.Text != "Oreads Voucher (30 Days)" && textBox8.Text != "VIP Vault Key [30 Days]" && textBox8.Text != "Appearance Change" && textBox8.Text != "Yeniceri Armor" && textBox8.Text != "Valkyrie Helmet"
                && textBox8.Text != "Valkyrie Armor Certificate" && textBox8.Text != "Gryphon Helmet" && textBox8.Text != "Gryphon Armor Certificate" && textBox8.Text != "Yeniceri Helmet" && textBox8.Text != "Bahamut Armor"
                && textBox8.Text != "Bahamut Helmet" && textBox8.Text != "Minerva Package" && textBox8.Text != "Dragons Scale" && textBox8.Text != "Menicias Official List" && textBox8.Text != "Clan Contribution"
                && textBox8.Text != "Punishment Stick + Wing")
                {
                    MessageBox.Show("Lütfen Seçtiğiniz Eşya Adını Kontrol Ediniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    _soundPlayerNoah.Play();

                    //DEĞİŞKENLERİ ATA VE BU DEĞİŞKENLERİN DEĞERİNİ TEXTBOX'LARDAN ALIP HESAPLAMADAN ÖNCEKİ AYARLAMALARI YAP
                    #region
                    Double tlGuncelGB = 0;              //GB FİYATI DEĞİŞKEN YARAT
                    Double KurusGuncelGB = 0;           //GB FİYATI DEĞİŞKEN YARAT
                    Double GB = 0;                      //GB FİYATININ TUTULACAĞI DEĞİŞKEN

                    Double tlGuncelCash = 0;            //CASH FİYATI DEĞİŞKEN YARAT
                    Double KurusGuncelCash = 0;         //CASH FİYATI DEĞİŞKEN YARAT
                    Double Cash = 0;                    //CASH FİYATININ TUTULACAĞI DEĞİŞKEN

                    Double milyonGuncelOyunici = 0;     //OYUNICI FİYATI DEĞİŞKEN YARAT
                    Double KurusGuncelOyunici = 0;      //OYUNICI FİYATI DEĞİŞKEN YARAT
                    Double Milyon = 0;                  //OYUNICI FİYATININ TUTULACAĞI DEĞİŞKEN

                    tlGuncelGB = Double.Parse(textBox1.Text);             //GB FİYATI
                    KurusGuncelGB = Double.Parse(textBox2.Text);          //GB FİYATI

                    tlGuncelCash = Double.Parse(textBox6.Text);           //CASH FİYATI
                    KurusGuncelCash = Double.Parse(textBox7.Text);        //CASH FİYATI

                    milyonGuncelOyunici = Double.Parse(textBox3.Text);    //OYUNİÇİ FİYATI
                    KurusGuncelOyunici = Double.Parse(textBox4.Text);          //OYUNİÇİ FİYATI
                    #endregion
                    //CASH HESAPLAMA
                    #region
                    if (KurusGuncelCash < 10)
                    {
                        if (textBox7.Text == "01" || textBox7.Text == "02" || textBox7.Text == "03" || textBox7.Text == "04"
                            || textBox7.Text == "05" || textBox7.Text == "06" || textBox7.Text == "07" || textBox7.Text == "08"
                            || textBox7.Text == "09" || textBox7.Text == "00")
                        {
                            Cash = ((KurusGuncelCash / 100) + tlGuncelCash);     //ÇOK ÖNEMLİ!!     CASH
                        }
                        else
                        {
                            KurusGuncelCash = KurusGuncelCash * 10;
                            Cash = ((KurusGuncelCash / 100) + tlGuncelCash);     //ÇOK ÖNEMLİ!!     CASH
                        }
                    }
                    else
                    {
                        Cash = ((KurusGuncelCash / 100) + tlGuncelCash);//ÇOK ÖNEMLİ!!     CASH
                    }
                    #endregion
                    //GB HESAPLAMA
                    #region
                    if (KurusGuncelGB < 10)     //KURUŞ KISMI 10'UN ALTINDA İSE BUNUN 0.04'MÜ YOKSA 0.4'MÜ OLDUĞUNU SORGULA
                    {
                        if (textBox2.Text == "01" || textBox2.Text == "02" || textBox2.Text == "03" || textBox2.Text == "04"
                            || textBox2.Text == "05" || textBox2.Text == "06" || textBox2.Text == "07" || textBox2.Text == "08"
                            || textBox2.Text == "09" || textBox2.Text == "00")
                        {

                            GB = ((KurusGuncelGB / 100) + tlGuncelGB);          //ÇOK ÖNEMLİ!!  GB      //EĞER KURUŞ KISMI 0.06 GİBİ BİR RAKAMSA BU SAYI 100'LE ÇARPILMAYI HAKEDİYOR.
                        }
                        else
                        {
                            KurusGuncelGB = KurusGuncelGB * 10;                       //EĞER KURUŞ KISMI 0.6 GİBİ BİR RAKAMSA BU SAYI 10 İLE ÇARPILIP, SONRA 100'E BÖLÜNMELİDİR.
                            GB = ((KurusGuncelGB / 100) + tlGuncelGB);          //ÇOK ÖNEMLİ!!  GB
                        }
                    }
                    else                                                    //EĞER KURUŞ KISMI 0.99'DAN BÜYÜK İSE BU SAYI DİREKT 100'E BÖLÜNMELİDİR VE GB FİYATI BULUNMALIDIR.
                    {
                        GB = ((KurusGuncelGB / 100) + tlGuncelGB);              //ÇOK ÖNEMLİ!!  GB
                    }
                    #endregion
                    //Milyon HESAPLAMA
                    #region

                    if (KurusGuncelOyunici < 100)     //KURUŞ KISMI 100'ÜN ALTINDA İSE BUNUN 0.004'MÜ YOKSA 4'MÜ OLDUĞUNU SORGULA
                    {
                        if (textBox4.Text == "000" || textBox4.Text == "001" || textBox4.Text == "002"
                            || textBox4.Text == "003" || textBox4.Text == "004" || textBox4.Text == "005"
                            || textBox4.Text == "006" || textBox4.Text == "007" || textBox4.Text == "008"
                            || textBox4.Text == "009" || textBox4.Text == "010" || textBox4.Text == "011"
                            || textBox4.Text == "012" || textBox4.Text == "013" || textBox4.Text == "014"
                            || textBox4.Text == "015" || textBox4.Text == "016" || textBox4.Text == "017"
                            || textBox4.Text == "018" || textBox4.Text == "019" || textBox4.Text == "020"
                            || textBox4.Text == "021" || textBox4.Text == "022" || textBox4.Text == "023"
                            || textBox4.Text == "024" || textBox4.Text == "025" || textBox4.Text == "026"
                            || textBox4.Text == "027" || textBox4.Text == "028" || textBox4.Text == "029"
                            || textBox4.Text == "030" || textBox4.Text == "031" || textBox4.Text == "032"
                            || textBox4.Text == "033" || textBox4.Text == "034" || textBox4.Text == "035"
                            || textBox4.Text == "036" || textBox4.Text == "037" || textBox4.Text == "038"
                            || textBox4.Text == "039" || textBox4.Text == "040" || textBox4.Text == "041"
                            || textBox4.Text == "042" || textBox4.Text == "043" || textBox4.Text == "044"
                            || textBox4.Text == "045" || textBox4.Text == "046" || textBox4.Text == "047"
                            || textBox4.Text == "048" || textBox4.Text == "049" || textBox4.Text == "050"
                            || textBox4.Text == "051" || textBox4.Text == "052" || textBox4.Text == "053"
                            || textBox4.Text == "054" || textBox4.Text == "055" || textBox4.Text == "056"
                            || textBox4.Text == "057" || textBox4.Text == "058" || textBox4.Text == "059"
                            || textBox4.Text == "060" || textBox4.Text == "061" || textBox4.Text == "062"
                            || textBox4.Text == "063" || textBox4.Text == "064" || textBox4.Text == "065"
                            || textBox4.Text == "066" || textBox4.Text == "067" || textBox4.Text == "068"
                            || textBox4.Text == "069" || textBox4.Text == "070" || textBox4.Text == "071"
                            || textBox4.Text == "072" || textBox4.Text == "073" || textBox4.Text == "074"
                            || textBox4.Text == "075" || textBox4.Text == "076" || textBox4.Text == "077"
                            || textBox4.Text == "078" || textBox4.Text == "079" || textBox4.Text == "080"
                            || textBox4.Text == "081" || textBox4.Text == "082" || textBox4.Text == "083"
                            || textBox4.Text == "084" || textBox4.Text == "085" || textBox4.Text == "086"
                            || textBox4.Text == "087" || textBox4.Text == "088" || textBox4.Text == "089"
                            || textBox4.Text == "090" || textBox4.Text == "091" || textBox4.Text == "092"
                            || textBox4.Text == "093" || textBox4.Text == "094" || textBox4.Text == "095"
                            || textBox4.Text == "096" || textBox4.Text == "097" || textBox4.Text == "098"
                            || textBox4.Text == "099")
                        {
                            Milyon = (((milyonGuncelOyunici) + (KurusGuncelOyunici / 1000)) * 1000000);     //BUNU KULLAN MİLYON
                            //EĞER KURUŞ KISMI 0.006 GİBİ BİR RAKAMSA BU SAYI 100'LE ÇARPILMAYI HAKEDİYOR.



                        }

                        else
                        {
                            MessageBox.Show("Lütfen Oyun İçi Para Miktarını Doğru Şekilde Belirtiniz");
                            return;
                        }

                    }


                    if (Convert.ToInt32(textBox4.Text) >= 100)
                    {

                        Milyon = (((milyonGuncelOyunici) + (KurusGuncelOyunici / 1000)) * 1000000); //BUNU KULLAN MİLYON
                    }
                    #endregion


                    //İNDİRİMSİZ TEKLİ EŞYA HESABI
                    #region

                    if (checkBox1.Checked == false) //EĞER PUS'TA İNDİRİM YOK İSE, ÜRÜNLER İÇİN AŞAĞIDAKİ HESAPLAMALAR GERÇEKLEŞİR 
                    {
                        //SWITCH PRE BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "SWITCH Premium") //SWITCH PRE BAŞLANGIÇ İNDİRİMSİZ
                        {
                            Double SWITCHPre = (((3596 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (SWITCHPre > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                label9.Visible = true;
                                label13.Visible = true;
                                islem = Convert.ToInt64(SWITCHPre - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (SWITCHPre == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (SWITCHPre < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - SWITCHPre);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //SWITCH PRE BİTİŞ İNDİRİMSİZ
                            }
                        }
                        #endregion

                        //EXP PRE BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "EXP Premium") //EXP PRE BAŞLANGIÇ İNDİRİMSİZ
                        {
                            Double EXPpre = (((2796 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (EXPpre > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                label9.Visible = true;
                                label13.Visible = true;
                                islem = Convert.ToInt64(EXPpre - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (EXPpre == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (EXPpre < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - EXPpre);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //EXP PRE BİTİŞ İNDİRİMSİZ
                            }
                        }
                        #endregion

                        //DISC PRE BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "DISC Premium")
                        {
                            Double DISCpre = (((2159 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (DISCpre > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(DISCpre - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (DISCpre == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (DISCpre < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - DISCpre);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //DISC PRE BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //WAR PRE BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "WAR Premium")
                        {
                            Double WARpre = (((2599 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (WARpre > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(WARpre - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (WARpre == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (WARpre < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - WARpre);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //DISC PRE BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion//WAR PRE BAŞLANGIÇ İNDİRİMSİZ //WAR PRE BAŞLANGIÇ İNDİRİMSİZ

                        //TRINA BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Trinas Piece")
                        {
                            Double Trina = (((800 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (Trina > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Trina - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (Trina == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (Trina < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - Trina);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //TRINA BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //SHADOW BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Shadow Piece")
                        {
                            Double Shadow = (((959 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (Shadow > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Shadow - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (Shadow == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (Shadow < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - Shadow);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //SHADOW BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //DRAGON WING BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Dragons Wing")
                        {
                            Double DragonsWing = (((899 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (DragonsWing > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(DragonsWing - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (DragonsWing == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (DragonsWing < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - DragonsWing);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //DRAGON WING BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //CLAN NAME CHANGE SC BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Clan Name Change Scroll")
                        {
                            Double ClanNameChangeSc = (((399 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (ClanNameChangeSc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(ClanNameChangeSc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (ClanNameChangeSc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (ClanNameChangeSc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - ClanNameChangeSc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //CLAN NAME CHANGE SC BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //MONSTER SUMMON STAFF BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Monster Summon Staff")
                        {
                            Double MonsterSummon = (((249 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (MonsterSummon > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MonsterSummon - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MonsterSummon == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MonsterSummon < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MonsterSummon);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //MONSTER SUMMON STAFF BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //GENDER CHANGE BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Gender Change")
                        {
                            Double GenderChange = (((749 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (GenderChange > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(GenderChange - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (GenderChange == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (GenderChange < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - GenderChange);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //GENDER CHANGE BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //NAME CHANGE SC BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Name Change Scroll")
                        {
                            Double NameChangeScroll = (((2000 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (NameChangeScroll > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(NameChangeScroll - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (NameChangeScroll == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (NameChangeScroll < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - NameChangeScroll);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //NAME CHANGE SC BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //TEARS OF KARIVDIS BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Tears of Karivdis")
                        {
                            Double TearsofKarivdis = (((400 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (TearsofKarivdis > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(TearsofKarivdis - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (TearsofKarivdis == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (TearsofKarivdis < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - TearsofKarivdis);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //TEARS OF KARIVDIS BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //REDISTRIBUTION ITEM BAŞLANFIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Redistribution Item")
                        {
                            Double RedistributionItem = (((799 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (RedistributionItem > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(RedistributionItem - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (RedistributionItem == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (RedistributionItem < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - RedistributionItem);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //REDISTRIBUTION ITEM BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //VOUCHER FOR MAGIC BAG BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Voucher for Magic Bag")
                        {
                            Double VoucherforMagicBag = (((89 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (VoucherforMagicBag > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(VoucherforMagicBag - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (VoucherforMagicBag == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (VoucherforMagicBag < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - VoucherforMagicBag);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //VOUCHER FOR MAGIC BAG BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //CHARACTER SEAL SC BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Character Seal Scroll")
                        {
                            Double CharacterSealSc = (((2800 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (CharacterSealSc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(CharacterSealSc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (CharacterSealSc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (CharacterSealSc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - CharacterSealSc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //CHARACTER SEAL SC BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //CHAOS MAP COUPON BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Chaos Map Coupon")
                        {
                            Double ChaosMapCoupon = (((35 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (ChaosMapCoupon > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(ChaosMapCoupon - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (ChaosMapCoupon == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (ChaosMapCoupon < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - ChaosMapCoupon);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //CHAOS MAP COUPON BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //ANCIENT TEXT BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Ancient Text")
                        {
                            Double AncientText = (((25 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (AncientText > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(AncientText - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (AncientText == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (AncientText < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - AncientText);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //ANCIENT TEXT BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //VOUCHER FOR A PATHOS GLOVE BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Voucher for a Pathos Glove")
                        {
                            Double VoucherforaPathosGlove = (((249 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (VoucherforaPathosGlove > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(VoucherforaPathosGlove - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (VoucherforaPathosGlove == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (VoucherforaPathosGlove < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - VoucherforaPathosGlove);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //VOUCHER FOR A PATHOS GLOVE BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //VOUCHER FOR AUTO PET BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Voucher for Automatic Pet")
                        {
                            Double VoucherforAutoPet = (((248 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (VoucherforAutoPet > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(VoucherforAutoPet - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (VoucherforAutoPet == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (VoucherforAutoPet < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - VoucherforAutoPet);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //VOUCHER FOR AUTO PET BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //NATION TRANSFER BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Nation Transfer")
                        {
                            Double NationTransfer = (((1599 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (NationTransfer > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(NationTransfer - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (NationTransfer == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (NationTransfer < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - NationTransfer);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //NATION TRANSFER BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //CUFF BINDER PET BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Cuff Binder Pet")
                        {
                            Double CuffBinderPet = (((299 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (CuffBinderPet > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(CuffBinderPet - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (CuffBinderPet == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (CuffBinderPet < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - CuffBinderPet);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //CUFF BINDER PET BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //FAMILIAR NAME CHANGE BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Familiar Name Change")
                        {
                            Double FamiliarNameChange = (((349 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (FamiliarNameChange > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(FamiliarNameChange - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (FamiliarNameChange == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (FamiliarNameChange < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - FamiliarNameChange);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //FAMILIAR NAME CHANGE BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //PATHOS PACKAGE BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Pathos Package")
                        {
                            Double PathosPackage = (((479 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (PathosPackage > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(PathosPackage - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (PathosPackage == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (PathosPackage < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - PathosPackage);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //PATHOS PACKAGE BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //GIGA HAMMER PET BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Giga Hammer Pet")
                        {
                            Double GigaHammerPet = (((349 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (GigaHammerPet > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(GigaHammerPet - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (GigaHammerPet == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (GigaHammerPet < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - GigaHammerPet);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //GIGA HAMMER PET BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //KROWAZ PET BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Krowaz Pet")
                        {
                            Double KrowazPet = (((499 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (KrowazPet > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(KrowazPet - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (KrowazPet == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (KrowazPet < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - KrowazPet);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //KROWAZ PET BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //HP MAESTRO VOUCHER BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "HP Maestro Voucher")
                        {
                            Double HPMaestroVoucher = (((200 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (HPMaestroVoucher > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(HPMaestroVoucher - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (HPMaestroVoucher == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (HPMaestroVoucher < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - HPMaestroVoucher);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //HP MAESTRO VOUCHER BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //MP MAESTRO VOUCHER BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "MP Maestro Voucher")
                        {
                            Double MPMaestroVoucher = (((200 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (MPMaestroVoucher > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MPMaestroVoucher - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MPMaestroVoucher == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MPMaestroVoucher < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MPMaestroVoucher);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //MP MAESTRO VOUCHER BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //DRYAD VOUCHER BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Dryad Voucher (30 Days)")
                        {
                            Double DryadVoucher = (((699 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (DryadVoucher > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(DryadVoucher - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (DryadVoucher == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (DryadVoucher < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - DryadVoucher);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //DRYAD VOUCHER BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //OREADS VOUCHER BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Oreads Voucher (30 Days)")
                        {
                            Double OreadsVoucher = (((699 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (OreadsVoucher > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(OreadsVoucher - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (OreadsVoucher == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (OreadsVoucher < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - OreadsVoucher);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //OREADS VOUCHER BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //VIP VAULT KEY BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "VIP Vault Key [30 Days]")
                        {
                            Double VIPVaultKey = (((349 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (VIPVaultKey > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(VIPVaultKey - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (VIPVaultKey == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (VIPVaultKey < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - VIPVaultKey);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //VIP VAULT KEY BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //APPEARANCE CHANGE BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Appearance Change")
                        {
                            Double AppearanceChange = (((125 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (AppearanceChange > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(AppearanceChange - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (AppearanceChange == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (AppearanceChange < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - AppearanceChange);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //APPEARANCE CHANGE BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //YENICERI ARMOR BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Yeniceri Armor")
                        {
                            Double YeniceriArmor = (((429 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (YeniceriArmor > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(YeniceriArmor - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (YeniceriArmor == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (YeniceriArmor < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - YeniceriArmor);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //YENICERI ARMOR BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //VALKYRIE HELMET BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Valkyrie Helmet")
                        {
                            Double ValkyrieHelmet = (((349 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (ValkyrieHelmet > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(ValkyrieHelmet - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (ValkyrieHelmet == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (ValkyrieHelmet < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - ValkyrieHelmet);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //VALKYRIE HELMET BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //VALKYRIE ARMOR CERTIFICATE BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Valkyrie Armor Certificate")
                        {
                            Double ValkyrieArmorCertificate = (((429 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (ValkyrieArmorCertificate > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(ValkyrieArmorCertificate - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (ValkyrieArmorCertificate == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (ValkyrieArmorCertificate < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - ValkyrieArmorCertificate);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //VALKYRIE ARMOR CERTIFICATE BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //GRYPHON HELMET BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Gryphon Helmet")
                        {
                            Double GryphonHelmet = (((349 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (GryphonHelmet > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(GryphonHelmet - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (GryphonHelmet == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (GryphonHelmet < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - GryphonHelmet);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //GRYPHON HELMET BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //GRYPHON ARMOR CERTIFICATE BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Gryphon Armor Certificate")
                        {
                            Double GryphonArmorCertificate = (((429 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (GryphonArmorCertificate > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(GryphonArmorCertificate - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (GryphonArmorCertificate == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (GryphonArmorCertificate < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - GryphonArmorCertificate);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //GRYPHON ARMOR CERTIFICATE BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //YENICERI HELMET BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Yeniceri Helmet")
                        {
                            Double YeniceriHelmet = (((349 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (YeniceriHelmet > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(YeniceriHelmet - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (YeniceriHelmet == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (YeniceriHelmet < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - YeniceriHelmet);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //YENICERI HELMET BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //BAHAMUT ARMOR BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Bahamut Armor")
                        {
                            Double BahamutArmor = (((429 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (BahamutArmor > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(BahamutArmor - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (BahamutArmor == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (BahamutArmor < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - BahamutArmor);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //BAHAMUT ARMOR BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //BAHAMUT HELMET BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Bahamut Helmet")
                        {
                            Double BahamutHelmet = (((349 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (BahamutHelmet > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(BahamutHelmet - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (BahamutHelmet == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (BahamutHelmet < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - BahamutHelmet);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //BAHAMUT HELMET BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //MINERVA PACKAGE BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Minerva Package")
                        {
                            Double MinervaPackage = (((729 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (MinervaPackage > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MinervaPackage - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MinervaPackage == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MinervaPackage < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MinervaPackage);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //MINERVA PACKAGE BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //DRAGON SCALE BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Dragons Scale")
                        {
                            Double DragonsScale = (((400 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (DragonsScale > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(DragonsScale - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (DragonsScale == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (DragonsScale < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - DragonsScale);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //DRAGON SCALE BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //MENICIAS OFFICIAL LIST BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Menicias Official List")
                        {
                            Double MeniciasOfficialList = (((360 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (MeniciasOfficialList > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MeniciasOfficialList - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MeniciasOfficialList == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MeniciasOfficialList < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MeniciasOfficialList);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //MENICIAS OFFICIAL LIST BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //CLAN CONTRIBUTION BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Clan Contribution")
                        {
                            Double ClanContribution = (((1040 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (ClanContribution > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(ClanContribution - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (ClanContribution == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (ClanContribution < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - ClanContribution);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //CLAN CONTRIBUTION BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion

                        //PUNISHMENT STICK AND WING BAŞLANGIÇ İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Punishment Stick + Wing")
                        {
                            Double PunishmentStickAndWing = (((999 * (Cash / 400) / (GB))) * 100000000);    //İNDİRİMSİZ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (PunishmentStickAndWing > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(PunishmentStickAndWing - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (PunishmentStickAndWing == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (PunishmentStickAndWing < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - PunishmentStickAndWing);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //PUNISHMENT STICK AND WING BİTİŞ İNDİRİMSİZ


                            }
                        }
                        #endregion


                        //TEKLİ SATILAN ÜRÜNLERİN, PROGRAMDA KULLANILAN DEĞİŞKEN İSİMLERİ BURADA İNDİRİMSİZ
                        #region
                        //Double SWITCHPre = (3596 * (Cash / 400) / (GB));
                        //Double EXPpre = (2796 * (Cash / 400) / (GB));
                        //Double DISCpre = (2159 * (Cash / 400));
                        //Double WARPre = (2599 * (Cash / 400));
                        //Double Trina = (800 * (Cash / 400));
                        //Double Shadow = (959 * (Cash / 400));
                        //Double DragonsWing = (899 * (Cash / 400));
                        //Double ClanNameChangeSc = (399 * (Cash / 400));
                        //Double MonsterSummon = (249 * (Cash / 400));
                        //Double GenderChange = (749 * (Cash / 400));
                        //Double NameChangeScroll = (2000 * (Cash / 400));
                        //Double TearsofKarivdis = (400 * (Cash / 400));
                        //Double RedistributionItem = (799 * (Cash / 400));
                        //Double VoucherforMagicBag = (89 * (Cash / 400));
                        //Double CharacterSealSc = (2800 * (Cash / 400));
                        //Double ChaosMapCoupon = (35 * (Cash / 400));
                        //Double AncientText = (25 * (Cash / 400));
                        //Double VoucherforaPathosGlove = (249 * (Cash / 400));
                        //Double VoucherforAutoPet = (248 * (Cash / 400));
                        //Double NationTransfer = (1599 * (Cash / 400));
                        //Double CuffBinderPet = (299 * (Cash / 400));
                        //Double FamiliarNameChange = (349 * (Cash / 400));
                        //Double PathosPackage = (479 * (Cash / 400));
                        //Double GigaHammerPet = (349 * (Cash / 400));
                        //Double KrowazPet = (499 * (Cash / 400));
                        //Double HPMaestroVoucher = (200 * (Cash / 400));
                        //Double MPMaestroVoucher = (200 * (Cash / 400));
                        //Double DryadVoucher = (699 * (Cash / 400));
                        //Double OreadsVoucher = (699 * (Cash / 400));
                        //Double VIPVaultKey = (349 * (Cash / 400));
                        //Double PunishmentStickAndWing = (999 * (Cash / 400));
                        //Double AppearanceChange = (125 * (Cash / 400));
                        //Double YeniceriArmor = (429 * (Cash / 400));
                        //Double ValkyrieHelmet = (349 * (Cash / 400));
                        //Double ValkyrieArmorCertificate = (429 * (Cash / 400));
                        //Double GryphonHelmet = (349 * (Cash / 400));
                        //Double GryphonArmorCertificate = (429 * (Cash / 400));
                        //Double YeniceriHelmet = (349 * (Cash / 400));
                        //Double BahamutArmor = (429 * (Cash / 400));
                        //Double BahamutHelmet = (349 * (Cash / 400));
                        //Double MinervaPackage = (729 * (Cash / 400));
                        //Double DragonsScale = (400 * (Cash / 400));
                        //Double MeniciasOfficialList = (360 * (Cash / 400));
                        //Double ClanContribution = (1040 * (Cash / 400));
                        #endregion

                    #endregion
                        //İNDİRİMSİZ ÇOKLU EŞYA HESABI
                        #region

                        //PRE POT HP İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Premium Potion HP" && radioButton1.Checked == true)
                        {
                            Double PrePotHP = (((192 * (Cash / 400) / (GB))) * 100000000);    //PRE POT HP ORJİNAL SAYIDAYSA BAŞLANGIÇ İNDİRİSİZ


                            if (PrePotHP > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(PrePotHP - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (PrePotHP == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (PrePotHP < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - PrePotHP);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //PRE POT HP ORJİNAL SAYIDAYSA BİTİŞ BİTİŞ İNDİRİMSİZ


                            }
                        }
                        else if (textBox8.Text == "Premium Potion HP" && radioButton2.Checked == true) //PRE POT HP PARÇALI SAYIDAYSA BAŞLANGIÇ İNDİRİMSİZ
                        {
                            Double PrePotHP = (((((192 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (PrePotHP > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(PrePotHP - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (PrePotHP == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (PrePotHP < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - PrePotHP);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //PRE POT HP PARÇALI SAYIDAYSA BİTİŞ İNDİRİMSİZ


                            }
                        }

                        #endregion

                        //PREMIUM POT MP İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Premium Potion MP" && radioButton1.Checked == true)
                        {
                            Double PrePotMP = (((192 * (Cash / 400) / (GB))) * 100000000);    //PRE POT MP ORJİNAL SAYIDAYSA BAŞLANGIÇ İNDİRİMSİZ


                            if (PrePotMP > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(PrePotMP - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (PrePotMP == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (PrePotMP < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - PrePotMP);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //PRE POT MP ORJİNAL SAYIDAYSA BİTİŞ


                            }
                        }
                        else if (textBox8.Text == "Premium Potion MP" && radioButton2.Checked == true)  //PRE POT MP PARÇALI SAYIDAYSA BAŞLANGIÇ İNDİRİMSİZ
                        {
                            Double PrePotMP = (((((192 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (PrePotMP > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(PrePotMP - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (PrePotMP == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (PrePotMP < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - PrePotMP);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //PRE POT MP PARÇALI SAYIDAYSA BİTİŞ İNDİRİMSİZ


                            }
                        }

                        #endregion

                        //GENIE HAMMER İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Genie Hammer" && radioButton1.Checked == true)
                        {
                            Double GenieHammer = (((99 * (Cash / 400) / (GB))) * 100000000);    //GENIE HAMMER ORJİNAL SAYIDAYSA BAŞLANGIÇ İNDİRİMSİZ


                            if (GenieHammer > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(GenieHammer - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (GenieHammer == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (GenieHammer < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - GenieHammer);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //GENIE HAMMER ORJİNAL SAYIDAYSA BİTİŞ


                            }
                        }
                        else if (textBox8.Text == "Genie Hammer" && radioButton2.Checked == true)  //GENIE HAMMER PARÇALI SAYIDAYSA BAŞLANGIÇ İNDİRİMSİZ
                        {
                            Double GenieHammer = (((((99 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (GenieHammer > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(GenieHammer - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (GenieHammer == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (GenieHammer < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - GenieHammer);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //GENIE HAMMER PARÇALI SAYIDAYSA BİTİŞ İNDİRİMSİZ


                            }
                        }

                        #endregion

                        //HEALTH 1500 SC İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "1500 Health+Scroll(L)" && radioButton1.Checked == true)
                        {
                            Double Health1500Sc = (((149 * (Cash / 400) / (GB))) * 100000000);


                            if (Health1500Sc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Health1500Sc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (Health1500Sc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (Health1500Sc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - Health1500Sc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "1500 Health+Scroll(L)" && radioButton2.Checked == true)
                        {
                            Double Health1500Sc = (((((149 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (Health1500Sc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Health1500Sc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (Health1500Sc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (Health1500Sc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - Health1500Sc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //HEALTH 1000 SC İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "1000 Health+Scroll(L)" && radioButton1.Checked == true)
                        {
                            Double Health1000Sc = (((99 * (Cash / 400) / (GB))) * 100000000);


                            if (Health1000Sc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Health1000Sc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (Health1000Sc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (Health1000Sc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - Health1000Sc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "1000 Health+Scroll(L)" && radioButton2.Checked == true)
                        {
                            Double Health1000Sc = (((((99 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (Health1000Sc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Health1000Sc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (Health1000Sc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (Health1000Sc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - Health1000Sc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //HEALTH 500 SC İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "500 Health+Scroll(L)" && radioButton1.Checked == true)
                        {
                            Double Health500Sc = (((49 * (Cash / 400) / (GB))) * 100000000);


                            if (Health500Sc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Health500Sc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (Health500Sc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (Health500Sc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - Health500Sc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "500 Health+Scroll(L)" && radioButton2.Checked == true)
                        {
                            Double Health500Sc = (((((49 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (Health500Sc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Health500Sc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (Health500Sc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (Health500Sc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - Health500Sc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //DEFENSE 300 SC İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "300 Defense+Scroll(L)" && radioButton1.Checked == true)
                        {
                            Double Defense300Sc = (((149 * (Cash / 400) / (GB))) * 100000000);


                            if (Defense300Sc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Defense300Sc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (Defense300Sc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (Defense300Sc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - Defense300Sc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "300 Defense+Scroll(L)" && radioButton2.Checked == true)
                        {
                            Double Defense300Sc = (((((149 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (Defense300Sc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Defense300Sc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (Defense300Sc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (Defense300Sc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - Defense300Sc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //DEFENSE 150 SC İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "150 Defense+Scroll(L)" && radioButton1.Checked == true)
                        {
                            Double Defense150Sc = (((79 * (Cash / 400) / (GB))) * 100000000);


                            if (Defense150Sc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Defense150Sc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (Defense150Sc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (Defense150Sc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - Defense150Sc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "150 Defense+Scroll(L)" && radioButton2.Checked == true)
                        {
                            Double Defense150Sc = (((((79 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (Defense150Sc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Defense150Sc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (Defense150Sc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (Defense150Sc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - Defense150Sc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //SPEED POTION İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Speed+Potion" && radioButton1.Checked == true)
                        {
                            Double SpeedPotion = (((79 * (Cash / 400) / (GB))) * 100000000);


                            if (SpeedPotion > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(SpeedPotion - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (SpeedPotion == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (SpeedPotion < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - SpeedPotion);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Speed+Potion" && radioButton2.Checked == true)
                        {
                            Double SpeedPotion = (((((79 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (SpeedPotion > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(SpeedPotion - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (SpeedPotion == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (SpeedPotion < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - SpeedPotion);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //ATTACK DAMAGE İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Attack Damage+" && radioButton1.Checked == true)
                        {
                            Double AttackDamage = (((159 * (Cash / 400) / (GB))) * 100000000);


                            if (AttackDamage > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(AttackDamage - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (AttackDamage == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (AttackDamage < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - AttackDamage);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Attack Damage+" && radioButton2.Checked == true)
                        {
                            Double AttackDamage = (((((159 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (AttackDamage > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(AttackDamage - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (AttackDamage == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (AttackDamage < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - AttackDamage);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //POWER OF LION SC İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Power of Lion Scroll(Stat)(L)" && radioButton1.Checked == true)
                        {
                            Double PowerofLionSc = (((229 * (Cash / 400) / (GB))) * 100000000);


                            if (PowerofLionSc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(PowerofLionSc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (PowerofLionSc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (PowerofLionSc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - PowerofLionSc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Power of Lion Scroll(Stat)(L)" && radioButton2.Checked == true)
                        {
                            Double PowerofLionSc = (((((229 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (PowerofLionSc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(PowerofLionSc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (PowerofLionSc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (PowerofLionSc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - PowerofLionSc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //STR SC İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "STR+ Scroll(Stat)(L)" && radioButton1.Checked == true)
                        {
                            Double STRSc = (((169 * (Cash / 400) / (GB))) * 100000000);


                            if (STRSc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(STRSc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (STRSc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (STRSc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - STRSc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "STR+ Scroll(Stat)(L)" && radioButton2.Checked == true)
                        {
                            Double STRSc = (((((169 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (STRSc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(STRSc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (STRSc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (STRSc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - STRSc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //HP SC İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "HP+ Scroll(Stat)(L)" && radioButton1.Checked == true)
                        {
                            Double HPSc = (((159 * (Cash / 400) / (GB))) * 100000000);


                            if (HPSc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(HPSc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (HPSc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (HPSc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - HPSc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "HP+ Scroll(Stat)(L)" && radioButton2.Checked == true)
                        {
                            Double HPSc = (((((159 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (HPSc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(HPSc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (HPSc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (HPSc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - HPSc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //DEX SC İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "DEX+ Scroll(Stat)(L)" && radioButton1.Checked == true)
                        {
                            Double DEXSc = (((169 * (Cash / 400) / (GB))) * 100000000);


                            if (DEXSc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(DEXSc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (DEXSc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (DEXSc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - DEXSc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "DEX+ Scroll(Stat)(L)" && radioButton2.Checked == true)
                        {
                            Double DEXSc = (((((169 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (DEXSc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(DEXSc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (DEXSc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (DEXSc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - DEXSc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //INT SC İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "INT+ Scroll(Stat)(L)" && radioButton1.Checked == true)
                        {
                            Double INTSc = (((69 * (Cash / 400) / (GB))) * 100000000);


                            if (INTSc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(INTSc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (INTSc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (INTSc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - INTSc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "INT+ Scroll(Stat)(L)" && radioButton2.Checked == true)
                        {
                            Double INTSc = (((((69 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (INTSc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(INTSc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (INTSc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (INTSc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - INTSc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //MP SC İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "MP+ Scroll(Stat)(L)" && radioButton1.Checked == true)
                        {
                            Double MPSc = (((69 * (Cash / 400) / (GB))) * 100000000);


                            if (MPSc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MPSc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MPSc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MPSc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MPSc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "MP+ Scroll(Stat)(L)" && radioButton2.Checked == true)
                        {
                            Double MPSc = (((((69 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (MPSc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MPSc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MPSc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MPSc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MPSc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //TELEPORTATION ITEM İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Teleportation Item" && radioButton1.Checked == true)
                        {
                            Double TeleportationItem = (((99 * (Cash / 400) / (GB))) * 100000000);


                            if (TeleportationItem > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(TeleportationItem - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (TeleportationItem == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (TeleportationItem < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - TeleportationItem);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Teleportation Item" && radioButton2.Checked == true)
                        {
                            Double TeleportationItem = (((((99 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (TeleportationItem > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(TeleportationItem - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (TeleportationItem == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (TeleportationItem < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - TeleportationItem);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //DURATION ITEM İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Duration Item" && radioButton1.Checked == true)
                        {
                            Double DurationItem = (((59 * (Cash / 400) / (GB))) * 100000000);


                            if (DurationItem > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(DurationItem - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (DurationItem == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (DurationItem < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - DurationItem);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Duration Item" && radioButton2.Checked == true)
                        {
                            Double DurationItem = (((((59 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (DurationItem > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(DurationItem - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (DurationItem == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (DurationItem < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - DurationItem);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //SYMBOL OF GLADIATOR 10 İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Symbol of Gladiator[10 ea]" && radioButton1.Checked == true)
                        {
                            Double SymbolofGladiator10 = (((769 * (Cash / 400) / (GB))) * 100000000);


                            if (SymbolofGladiator10 > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(SymbolofGladiator10 - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (SymbolofGladiator10 == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (SymbolofGladiator10 < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - SymbolofGladiator10);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Symbol of Gladiator[10 ea]" && radioButton2.Checked == true)
                        {
                            Double SymbolofGladiator10 = (((((769 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (SymbolofGladiator10 > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(SymbolofGladiator10 - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (SymbolofGladiator10 == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (SymbolofGladiator10 < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - SymbolofGladiator10);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //SYMBOL OF WARRIOR 10 İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Symbol of Warrior[10ea]" && radioButton1.Checked == true)
                        {
                            Double SymbolofWarrior10 = (((769 * (Cash / 400) / (GB))) * 100000000);


                            if (SymbolofWarrior10 > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(SymbolofWarrior10 - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (SymbolofWarrior10 == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (SymbolofWarrior10 < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - SymbolofWarrior10);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Symbol of Warrior[10ea]" && radioButton2.Checked == true)
                        {
                            Double SymbolofWarrior10 = (((((769 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (SymbolofWarrior10 > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(SymbolofWarrior10 - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (SymbolofWarrior10 == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (SymbolofWarrior10 < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - SymbolofWarrior10);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //HEALTH 2000 SC İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "2000 Health+ Scroll" && radioButton1.Checked == true)
                        {
                            Double Health2000Sc = (((249 * (Cash / 400) / (GB))) * 100000000);


                            if (Health2000Sc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Health2000Sc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (Health2000Sc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (Health2000Sc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - Health2000Sc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "2000 Health+ Scroll" && radioButton2.Checked == true)
                        {
                            Double Health2000Sc = (((((249 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (Health2000Sc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Health2000Sc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (Health2000Sc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (Health2000Sc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - Health2000Sc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //SCROLL OF ARMOR 350 SC İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Scroll of Armor 350" && radioButton1.Checked == true)
                        {
                            Double ScrollofArmor350 = (((249 * (Cash / 400) / (GB))) * 100000000);


                            if (ScrollofArmor350 > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(ScrollofArmor350 - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (ScrollofArmor350 == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (ScrollofArmor350 < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - ScrollofArmor350);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Scroll of Armor 350" && radioButton2.Checked == true)
                        {
                            Double ScrollofArmor350 = (((((249 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (ScrollofArmor350 > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(ScrollofArmor350 - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (ScrollofArmor350 == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (ScrollofArmor350 < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - ScrollofArmor350);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //NP INCREASE ITEM İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "NP Increase Item" && radioButton1.Checked == true)
                        {
                            Double NPIncreaseItem = (((799 * (Cash / 400) / (GB))) * 100000000);


                            if (NPIncreaseItem > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(NPIncreaseItem - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (NPIncreaseItem == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (NPIncreaseItem < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - NPIncreaseItem);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "NP Increase Item" && radioButton2.Checked == true)
                        {
                            Double NPIncreaseItem = (((((799 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (NPIncreaseItem > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(NPIncreaseItem - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (NPIncreaseItem == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (NPIncreaseItem < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - NPIncreaseItem);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //MERCHANT CONCENTRATION İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Merchant Concentration" && radioButton1.Checked == true)
                        {
                            Double MerchantConcentration = (((159 * (Cash / 400) / (GB))) * 100000000);


                            if (MerchantConcentration > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MerchantConcentration - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MerchantConcentration == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MerchantConcentration < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MerchantConcentration);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Merchant Concentration" && radioButton2.Checked == true)
                        {
                            Double MerchantConcentration = (((((159 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (MerchantConcentration > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MerchantConcentration - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MerchantConcentration == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MerchantConcentration < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MerchantConcentration);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //SYMBOL OF GROWTH İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Symbol of Growth" && radioButton1.Checked == true)
                        {
                            Double SymbolofGrowth = (((249 * (Cash / 400) / (GB))) * 100000000);


                            if (SymbolofGrowth > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(SymbolofGrowth - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (SymbolofGrowth == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (SymbolofGrowth < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - SymbolofGrowth);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Symbol of Growth" && radioButton2.Checked == true)
                        {
                            Double SymbolofGrowth = (((((249 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (SymbolofGrowth > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(SymbolofGrowth - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (SymbolofGrowth == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (SymbolofGrowth < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - SymbolofGrowth);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //HP 60 PERCENT SC İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "HP Scroll 60%" && radioButton1.Checked == true)
                        {
                            Double HPScroll60percent = (((299 * (Cash / 400) / (GB))) * 100000000);


                            if (HPScroll60percent > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(HPScroll60percent - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (HPScroll60percent == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (HPScroll60percent < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - HPScroll60percent);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "HP Scroll 60%" && radioButton2.Checked == true)
                        {
                            Double HPScroll60percent = (((((299 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (HPScroll60percent > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(HPScroll60percent - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (HPScroll60percent == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (HPScroll60percent < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - HPScroll60percent);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //HYPER NOAH SC İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Hyper Noah Scroll" && radioButton1.Checked == true)
                        {
                            Double HyperNoahSc = (((149 * (Cash / 400) / (GB))) * 100000000);


                            if (HyperNoahSc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(HyperNoahSc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (HyperNoahSc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (HyperNoahSc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - HyperNoahSc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Hyper Noah Scroll" && radioButton2.Checked == true)
                        {
                            Double HyperNoahSc = (((((149 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (HyperNoahSc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(HyperNoahSc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (HyperNoahSc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (HyperNoahSc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - HyperNoahSc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //LESSON OF MASTER İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Lesson of Master" && radioButton1.Checked == true)
                        {
                            Double LessonofMaster = (((859 * (Cash / 400) / (GB))) * 100000000);


                            if (LessonofMaster > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(LessonofMaster - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (LessonofMaster == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (LessonofMaster < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - LessonofMaster);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Lesson of Master" && radioButton2.Checked == true)
                        {
                            Double LessonofMaster = (((((859 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (LessonofMaster > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(LessonofMaster - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (LessonofMaster == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (LessonofMaster < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - LessonofMaster);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //SEAL EXCHANGE VOUCHER İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Seal Exchange Voucher" && radioButton1.Checked == true)
                        {
                            Double SealExchangeVoucher = (((79 * (Cash / 400) / (GB))) * 100000000);


                            if (SealExchangeVoucher > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(SealExchangeVoucher - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (SealExchangeVoucher == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (SealExchangeVoucher < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - SealExchangeVoucher);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Seal Exchange Voucher" && radioButton2.Checked == true)
                        {
                            Double SealExchangeVoucher = (((((79 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (SealExchangeVoucher > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(SealExchangeVoucher - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (SealExchangeVoucher == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (SealExchangeVoucher < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - SealExchangeVoucher);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //MEDIUM SEAL EXCHANGE SC İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Medium Level Seal Exchange" && radioButton1.Checked == true)
                        {
                            Double MediumSealExchange = (((379 * (Cash / 400) / (GB))) * 100000000);


                            if (MediumSealExchange > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MediumSealExchange - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MediumSealExchange == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MediumSealExchange < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MediumSealExchange);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Medium Level Seal Exchange" && radioButton2.Checked == true)
                        {
                            Double MediumSealExchange = (((((379 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (MediumSealExchange > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MediumSealExchange - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MediumSealExchange == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MediumSealExchange < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MediumSealExchange);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //SPIRIT OF GENIE İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Spirit of Genie (10ea)" && radioButton1.Checked == true)
                        {
                            Double SpiritofGenie = (((149 * (Cash / 400) / (GB))) * 100000000);


                            if (SpiritofGenie > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(SpiritofGenie - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (SpiritofGenie == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (SpiritofGenie < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - SpiritofGenie);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Spirit of Genie (10ea)" && radioButton2.Checked == true)
                        {
                            Double SpiritofGenie = (((((149 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (SpiritofGenie > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(SpiritofGenie - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (SpiritofGenie == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (SpiritofGenie < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - SpiritofGenie);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //MENISSIAH TRANSFORM KARUS İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Menissiah Transform (Karus)" && radioButton1.Checked == true)
                        {
                            Double MenissiahTransformKarus = (((249 * (Cash / 400) / (GB))) * 100000000);


                            if (MenissiahTransformKarus > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MenissiahTransformKarus - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MenissiahTransformKarus == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MenissiahTransformKarus < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MenissiahTransformKarus);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Menissiah Transform (Karus)" && radioButton2.Checked == true)
                        {
                            Double MenissiahTransformKarus = (((((249 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (MenissiahTransformKarus > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MenissiahTransformKarus - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MenissiahTransformKarus == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MenissiahTransformKarus < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MenissiahTransformKarus);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //MENISSIAH TRANSFORM ELMORAD İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Menissiah Transform (Elmorad)" && radioButton1.Checked == true)
                        {
                            Double MenissiahTransformElmorad = (((249 * (Cash / 400) / (GB))) * 100000000);


                            if (MenissiahTransformElmorad > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MenissiahTransformElmorad - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MenissiahTransformElmorad == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MenissiahTransformElmorad < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MenissiahTransformElmorad);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Menissiah Transform (Elmorad)" && radioButton2.Checked == true)
                        {
                            Double MenissiahTransformElmorad = (((((249 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (MenissiahTransformElmorad > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MenissiahTransformElmorad - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MenissiahTransformElmorad == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MenissiahTransformElmorad < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MenissiahTransformElmorad);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //HERA TRANSFORM KARUS İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Hera Transform (Karus)" && radioButton1.Checked == true)
                        {
                            Double HeraTransformKarus = (((249 * (Cash / 400) / (GB))) * 100000000);


                            if (HeraTransformKarus > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(HeraTransformKarus - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (HeraTransformKarus == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (HeraTransformKarus < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - HeraTransformKarus);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Hera Transform (Karus)" && radioButton2.Checked == true)
                        {
                            Double HeraTransformKarus = (((((249 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (HeraTransformKarus > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(HeraTransformKarus - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (HeraTransformKarus == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (HeraTransformKarus < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - HeraTransformKarus);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //HERA TRANSFORM KARUS İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Hera Transform (Elmorad)" && radioButton1.Checked == true)
                        {
                            Double HeraTransformElmorad = (((249 * (Cash / 400) / (GB))) * 100000000);


                            if (HeraTransformElmorad > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(HeraTransformElmorad - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (HeraTransformElmorad == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (HeraTransformElmorad < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - HeraTransformElmorad);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Hera Transform (Elmorad)" && radioButton2.Checked == true)
                        {
                            Double HeraTransformElmorad = (((((249 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (HeraTransformElmorad > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(HeraTransformElmorad - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (HeraTransformElmorad == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (HeraTransformElmorad < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - HeraTransformElmorad);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //PATRICK TRANSFORM KARUS İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Patrick Transform (Karus)" && radioButton1.Checked == true)
                        {
                            Double PatrickTransformKarus = (((149 * (Cash / 400) / (GB))) * 100000000);


                            if (PatrickTransformKarus > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(PatrickTransformKarus - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (PatrickTransformKarus == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (PatrickTransformKarus < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - PatrickTransformKarus);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Patrick Transform (Karus)" && radioButton2.Checked == true)
                        {
                            Double PatrickTransformKarus = (((((149 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (PatrickTransformKarus > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(PatrickTransformKarus - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (PatrickTransformKarus == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (PatrickTransformKarus < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - PatrickTransformKarus);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //PATRICK TRANSFORM ELMORAD İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Patrick Transform (Elmorad)" && radioButton1.Checked == true)
                        {
                            Double PatrickTransformElmorad = (((149 * (Cash / 400) / (GB))) * 100000000);


                            if (PatrickTransformElmorad > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(PatrickTransformElmorad - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (PatrickTransformElmorad == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (PatrickTransformElmorad < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - PatrickTransformElmorad);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Patrick Transform (Elmorad)" && radioButton2.Checked == true)
                        {
                            Double PatrickTransformElmorad = (((((149 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (PatrickTransformElmorad > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(PatrickTransformElmorad - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (PatrickTransformElmorad == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (PatrickTransformElmorad < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - PatrickTransformElmorad);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //COUGAR TRANSFORM KARUS İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Cougar Transform (Karus)" && radioButton1.Checked == true)
                        {
                            Double CougarTransformKarus = (((149 * (Cash / 400) / (GB))) * 100000000);


                            if (CougarTransformKarus > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(CougarTransformKarus - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (CougarTransformKarus == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (CougarTransformKarus < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - CougarTransformKarus);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Cougar Transform (Karus)" && radioButton2.Checked == true)
                        {
                            Double CougarTransformKarus = (((((149 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (CougarTransformKarus > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(CougarTransformKarus - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (CougarTransformKarus == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (CougarTransformKarus < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - CougarTransformKarus);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //COUGAR TRANSFORM ELMORAD İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Cougar Transform (Elmorad)" && radioButton1.Checked == true)
                        {
                            Double CougarTransformElmorad = (((149 * (Cash / 400) / (GB))) * 100000000);


                            if (CougarTransformElmorad > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(CougarTransformElmorad - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (CougarTransformElmorad == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (CougarTransformElmorad < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - CougarTransformElmorad);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Cougar Transform (Elmorad)" && radioButton2.Checked == true)
                        {
                            Double CougarTransformElmorad = (((((149 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (CougarTransformElmorad > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(CougarTransformElmorad - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (CougarTransformElmorad == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (CougarTransformElmorad < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - CougarTransformElmorad);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //CRISIS ELMORAD İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Crisis(Elmorad)" && radioButton1.Checked == true)
                        {
                            Double CrisisElmorad = (((289 * (Cash / 400) / (GB))) * 100000000);


                            if (CrisisElmorad > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(CrisisElmorad - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (CrisisElmorad == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (CrisisElmorad < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - CrisisElmorad);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Crisis(Elmorad)" && radioButton2.Checked == true)
                        {
                            Double CrisisElmorad = (((((289 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (CrisisElmorad > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(CrisisElmorad - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (CrisisElmorad == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (CrisisElmorad < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - CrisisElmorad);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //IBEX KARUS İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Ibex(Karus)" && radioButton1.Checked == true)
                        {
                            Double IbexKarus = (((289 * (Cash / 400) / (GB))) * 100000000);


                            if (IbexKarus > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(IbexKarus - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (IbexKarus == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (IbexKarus < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - IbexKarus);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Ibex(Karus)" && radioButton2.Checked == true)
                        {
                            Double IbexKarus = (((((289 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (IbexKarus > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(IbexKarus - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (IbexKarus == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (IbexKarus < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - IbexKarus);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //MAGPIE ELMORAD İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Magpie (Elmorad)" && radioButton1.Checked == true)
                        {
                            Double MagpieElmorad = (((289 * (Cash / 400) / (GB))) * 100000000);


                            if (MagpieElmorad > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MagpieElmorad - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MagpieElmorad == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MagpieElmorad < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MagpieElmorad);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Magpie (Elmorad)" && radioButton2.Checked == true)
                        {
                            Double MagpieElmorad = (((((289 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (MagpieElmorad > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MagpieElmorad - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MagpieElmorad == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MagpieElmorad < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MagpieElmorad);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //MAGPIE KARUS İNDİRİMSİZ
                        #region
                        if (textBox8.Text == "Magpie (Karus)" && radioButton1.Checked == true)
                        {
                            Double MagpieKarus = (((289 * (Cash / 400) / (GB))) * 100000000);


                            if (MagpieKarus > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MagpieKarus - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MagpieKarus == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MagpieKarus < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MagpieKarus);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Magpie (Karus)" && radioButton2.Checked == true)
                        {
                            Double MagpieKarus = (((((289 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (MagpieKarus > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MagpieKarus - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MagpieKarus == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MagpieKarus < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MagpieKarus);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //TEKLİ SATILAN ÜRÜNLERİN, PROGRAMDA KULLANILAN DEĞİŞKEN İSİMLERİ BURADA İNDİRİMSİZ
                        #region
                        //Double PrePotHP = (192 * (Cash / 400));
                        //Double PrePotMP = (192 * (Cash / 400));
                        //Double GenieHammer = (99 * (Cash / 400));
                        //Double Health1500Sc = (149 * (Cash / 400));
                        //Double Health1000Sc = (99 * (Cash / 400));
                        //Double Health500Sc = (49 * (Cash / 400));
                        //Double Defense300Sc = (149 * (Cash / 400));
                        //Double Defense150Sc = (79 * (Cash / 400));
                        //Double SpeedPotion = (79 * (Cash / 400));
                        //Double AttackDamage = (159 * (Cash / 400));
                        //Double PowerofLionSc = (229 * (Cash / 400));
                        //Double STRSc = (169 * (Cash / 400));
                        //Double HPSc = (159 * (Cash / 400));
                        //Double DEXSc = (169 * (Cash / 400));
                        //Double INTSc = (69 * (Cash / 400));
                        //Double MPSc = (69 * (Cash / 400));
                        //Double TeleportationItem = (99 * (Cash / 400));
                        //Double DurationItem = (59 * (Cash / 400));
                        //Double SymbolofGladiator10 = (769 * (Cash / 400));
                        //Double SymbolofWarrior10 = (769 * (Cash / 400));
                        //Double Health2000Sc = (249 * (Cash / 400));
                        //Double ScrollofArmor350 = (249 * (Cash / 400));
                        //Double NPIncreaseItem = (799 * (Cash / 400));
                        //Double MerchantConcentration = (159 * (Cash / 400));
                        //Double SymbolofGrowth = (249 * (Cash / 400));
                        //Double SealExchangeVoucher = (79 * (Cash / 400));
                        //Double MediumSealExchange = (379 * (Cash / 400));
                        //Double SpiritofGenie = (149 * (Cash / 400));
                        //Double MenissiahTransformKarus = (249 * (Cash / 400));
                        //Double MenissiahTransformElmorad = (249 * (Cash / 400));
                        //Double HeraTransformKarus = (249 * (Cash / 400));
                        //Double HeraTransformElmorad = (249 * (Cash / 400));
                        //Double PatrickTransformKarus = (149 * (Cash / 400));
                        //Double PatrickTransformElmorad = (149 * (Cash / 400));
                        //Double CougarTransformKarus = (149 * (Cash / 400));
                        //Double CougarTransformElmorad = (149 * (Cash / 400));
                        //Double HPScroll60percent = (299 * (Cash / 400));
                        //Double HyperNoahSc = (149 * (Cash / 400));
                        //Double LessonofMaster = (859 * (Cash / 400));
                        //Double CrisisElmorad = (289 * (Cash / 400));
                        //Double IbexKarus = (289 * (Cash / 400));
                        //Double MagpieElmorad = (289 * (Cash / 400));
                        //Double MagpieKarus = (289 * (Cash / 400));

                    }
                        #endregion

                        #endregion

                    //Program Bazen Hesap Sonrası, Sonucu Yansıttığında, Para farkı Sıfır Olan Eşyalara, Eşittir Demek Yerine, 0 Coins Daha Pahalıdır Diyor
                    //Bunun Önüne Geçmek İçin Aşağıdaki Kodlar Yazıldı.
                    //PAHALIDIR KISMI İÇİN OLAN
                    #region
                    if (label14.Visible == true && label14.Text == (0 + "   Coins Daha Pahalıdır."))
                    {
                        label14.Visible = false;
                        label7.Visible = false;

                        label26.Visible = true;
                        label27.Visible = true;
                        label27.Text = "Eşittir";
                    }
                    #endregion
                    //UCUZDUR KISMI İÇİN OLAN
                    #region

                    if (label13.Visible == true && label13.Text == (0 + "   Coins Daha Ucuzdur."))
                    {
                        label13.Visible = false;
                        label9.Visible = false;

                        label26.Visible = true;
                        label27.Visible = true;
                        label27.Text = "Eşittir";
                    }
                    #endregion


                    //İNDİRİMLİ TEKLİ EŞYA HESABI
                    #region
                    else if (checkBox1.Checked == true)
                    {

                        //SWITCH PRE BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "SWITCH Premium") //SWITCH PRE BAŞLANGIÇ İNDİRİMLİ
                        {
                            Double SWITCHPre = ((2697 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (SWITCHPre > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                label9.Visible = true;
                                label13.Visible = true;
                                islem = Convert.ToInt64(SWITCHPre - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (SWITCHPre == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (SWITCHPre < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - SWITCHPre);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //SWITCH PRE BİTİŞ İNDİRİMLİ
                            }
                        }
                        #endregion

                        //EXP PRE BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "EXP Premium") //EXP PRE BAŞLANGIÇ İNDİRİMLİ
                        {
                            Double EXPpre = ((2097 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (EXPpre > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                label9.Visible = true;
                                label13.Visible = true;
                                islem = Convert.ToInt64(EXPpre - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (EXPpre == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (EXPpre < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - EXPpre);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //EXP PRE BİTİŞ İNDİRİMLİ
                            }
                        }
                        #endregion

                        //DISC PRE BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "DISC Premium")
                        {
                            Double DISCpre = ((1619 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (DISCpre > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(DISCpre - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (DISCpre == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (DISCpre < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - DISCpre);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //DISC PRE BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //WAR PRE BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "WAR Premium")
                        {
                            Double WARpre = ((1949 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (WARpre > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(WARpre - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (WARpre == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (WARpre < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - WARpre);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //DISC PRE BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion//WAR PRE BAŞLANGIÇ İNDİRİMSİZ //WAR PRE BAŞLANGIÇ İNDİRİMSİZ

                        //TRINA BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Trinas Piece")
                        {
                            Double Trina = ((600 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (Trina > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Trina - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (Trina == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (Trina < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - Trina);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //TRINA BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //SHADOW BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Shadow Piece")
                        {
                            Double Shadow = ((719 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (Shadow > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Shadow - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (Shadow == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (Shadow < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - Shadow);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //SHADOW BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //DRAGON WING BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Dragons Wing")
                        {
                            Double DragonsWing = ((674 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (DragonsWing > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(DragonsWing - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (DragonsWing == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (DragonsWing < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - DragonsWing);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //DRAGON WING BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //CLAN NAME CHANGE SC BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Clan Name Change Scroll")
                        {
                            Double ClanNameChangeSc = ((299 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (ClanNameChangeSc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(ClanNameChangeSc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (ClanNameChangeSc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (ClanNameChangeSc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - ClanNameChangeSc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //CLAN NAME CHANGE SC BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //MONSTER SUMMON STAFF BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Monster Summon Staff")
                        {
                            Double MonsterSummon = ((187 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (MonsterSummon > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MonsterSummon - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MonsterSummon == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MonsterSummon < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MonsterSummon);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //MONSTER SUMMON STAFF BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //GENDER CHANGE BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Gender Change")
                        {
                            Double GenderChange = ((562 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (GenderChange > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(GenderChange - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (GenderChange == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (GenderChange < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - GenderChange);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //GENDER CHANGE BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //NAME CHANGE SC BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Name Change Scroll")
                        {
                            Double NameChangeScroll = ((1500 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (NameChangeScroll > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(NameChangeScroll - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (NameChangeScroll == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (NameChangeScroll < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - NameChangeScroll);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //NAME CHANGE SC BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //TEARS OF KARIVDIS BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Tears of Karivdis")
                        {
                            Double TearsofKarivdis = ((300 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (TearsofKarivdis > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(TearsofKarivdis - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (TearsofKarivdis == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (TearsofKarivdis < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - TearsofKarivdis);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //TEARS OF KARIVDIS BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //REDISTRIBUTION ITEM BAŞLANFIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Redistribution Item")
                        {
                            Double RedistributionItem = ((399 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (RedistributionItem > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(RedistributionItem - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (RedistributionItem == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (RedistributionItem < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - RedistributionItem);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //REDISTRIBUTION ITEM BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //VOUCHER FOR MAGIC BAG BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Voucher for Magic Bag")
                        {
                            Double VoucherforMagicBag = ((67 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (VoucherforMagicBag > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(VoucherforMagicBag - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (VoucherforMagicBag == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (VoucherforMagicBag < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - VoucherforMagicBag);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //VOUCHER FOR MAGIC BAG BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //CHARACTER SEAL SC BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Character Seal Scroll")
                        {
                            Double CharacterSealSc = ((2100 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (CharacterSealSc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(CharacterSealSc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (CharacterSealSc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (CharacterSealSc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - CharacterSealSc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //CHARACTER SEAL SC BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //CHAOS MAP COUPON BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Chaos Map Coupon")
                        {
                            Double ChaosMapCoupon = ((26 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (ChaosMapCoupon > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(ChaosMapCoupon - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (ChaosMapCoupon == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (ChaosMapCoupon < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - ChaosMapCoupon);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //CHAOS MAP COUPON BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //ANCIENT TEXT BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Ancient Text")
                        {
                            Double AncientText = ((19 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (AncientText > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(AncientText - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (AncientText == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (AncientText < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - AncientText);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //ANCIENT TEXT BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //VOUCHER FOR A PATHOS GLOVE BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Voucher for a Pathos Glove")
                        {
                            Double VoucherforaPathosGlove = ((187 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (VoucherforaPathosGlove > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(VoucherforaPathosGlove - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (VoucherforaPathosGlove == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (VoucherforaPathosGlove < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - VoucherforaPathosGlove);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //VOUCHER FOR A PATHOS GLOVE BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //VOUCHER FOR AUTO PET BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Voucher for Automatic Pet")
                        {
                            Double VoucherforAutoPet = ((186 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (VoucherforAutoPet > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(VoucherforAutoPet - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (VoucherforAutoPet == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (VoucherforAutoPet < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - VoucherforAutoPet);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //VOUCHER FOR AUTO PET BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //NATION TRANSFER BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Nation Transfer")
                        {
                            Double NationTransfer = ((1199 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (NationTransfer > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(NationTransfer - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (NationTransfer == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (NationTransfer < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - NationTransfer);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //NATION TRANSFER BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //CUFF BINDER PET BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Cuff Binder Pet")
                        {
                            Double CuffBinderPet = ((224 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (CuffBinderPet > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(CuffBinderPet - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (CuffBinderPet == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (CuffBinderPet < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - CuffBinderPet);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //CUFF BINDER PET BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //FAMILIAR NAME CHANGE BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Familiar Name Change")
                        {
                            Double FamiliarNameChange = ((262 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (FamiliarNameChange > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(FamiliarNameChange - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (FamiliarNameChange == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (FamiliarNameChange < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - FamiliarNameChange);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //FAMILIAR NAME CHANGE BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //PATHOS PACKAGE BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Pathos Package")
                        {
                            Double PathosPackage = ((359 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (PathosPackage > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(PathosPackage - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (PathosPackage == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (PathosPackage < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - PathosPackage);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //PATHOS PACKAGE BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //GIGA HAMMER PET BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Giga Hammer Pet")
                        {
                            Double GigaHammerPet = ((262 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (GigaHammerPet > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(GigaHammerPet - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (GigaHammerPet == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (GigaHammerPet < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - GigaHammerPet);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //GIGA HAMMER PET BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //KROWAZ PET BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Krowaz Pet")
                        {
                            Double KrowazPet = ((374 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (KrowazPet > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(KrowazPet - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (KrowazPet == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (KrowazPet < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - KrowazPet);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //KROWAZ PET BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //HP MAESTRO VOUCHER BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "HP Maestro Voucher")
                        {
                            Double HPMaestroVoucher = ((150 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (HPMaestroVoucher > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(HPMaestroVoucher - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (HPMaestroVoucher == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (HPMaestroVoucher < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - HPMaestroVoucher);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //HP MAESTRO VOUCHER BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //MP MAESTRO VOUCHER BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "MP Maestro Voucher")
                        {
                            Double MPMaestroVoucher = ((150 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (MPMaestroVoucher > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MPMaestroVoucher - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MPMaestroVoucher == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MPMaestroVoucher < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MPMaestroVoucher);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //MP MAESTRO VOUCHER BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //DRYAD VOUCHER BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Dryad Voucher (30 Days)")
                        {
                            Double DryadVoucher = ((524 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (DryadVoucher > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(DryadVoucher - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (DryadVoucher == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (DryadVoucher < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - DryadVoucher);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //DRYAD VOUCHER BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //OREADS VOUCHER BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Oreads Voucher (30 Days)")
                        {
                            Double OreadsVoucher = ((524 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (OreadsVoucher > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(OreadsVoucher - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (OreadsVoucher == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (OreadsVoucher < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - OreadsVoucher);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //OREADS VOUCHER BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //VIP VAULT KEY BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "VIP Vault Key [30 Days]")
                        {
                            Double VIPVaultKey = ((262 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (VIPVaultKey > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(VIPVaultKey - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (VIPVaultKey == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (VIPVaultKey < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - VIPVaultKey);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //VIP VAULT KEY BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //APPEARANCE CHANGE BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Appearance Change")
                        {
                            Double AppearanceChange = ((94 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (AppearanceChange > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(AppearanceChange - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (AppearanceChange == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (AppearanceChange < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - AppearanceChange);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //APPEARANCE CHANGE BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //YENICERI ARMOR BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Yeniceri Armor")
                        {
                            Double YeniceriArmor = ((322 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (YeniceriArmor > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(YeniceriArmor - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (YeniceriArmor == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (YeniceriArmor < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - YeniceriArmor);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //YENICERI ARMOR BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //VALKYRIE HELMET BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Valkyrie Helmet")
                        {
                            Double ValkyrieHelmet = ((262 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (ValkyrieHelmet > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(ValkyrieHelmet - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (ValkyrieHelmet == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (ValkyrieHelmet < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - ValkyrieHelmet);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //VALKYRIE HELMET BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //VALKYRIE ARMOR CERTIFICATE BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Valkyrie Armor Certificate")
                        {
                            Double ValkyrieArmorCertificate = ((322 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (ValkyrieArmorCertificate > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(ValkyrieArmorCertificate - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (ValkyrieArmorCertificate == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (ValkyrieArmorCertificate < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - ValkyrieArmorCertificate);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //VALKYRIE ARMOR CERTIFICATE BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //GRYPHON HELMET BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Gryphon Helmet")
                        {
                            Double GryphonHelmet = ((262 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (GryphonHelmet > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(GryphonHelmet - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (GryphonHelmet == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (GryphonHelmet < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - GryphonHelmet);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //GRYPHON HELMET BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //GRYPHON ARMOR CERTIFICATE BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Gryphon Armor Certificate")
                        {
                            Double GryphonArmorCertificate = ((322 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (GryphonArmorCertificate > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(GryphonArmorCertificate - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (GryphonArmorCertificate == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (GryphonArmorCertificate < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - GryphonArmorCertificate);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //GRYPHON ARMOR CERTIFICATE BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //YENICERI HELMET BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Yeniceri Helmet")
                        {
                            Double YeniceriHelmet = ((262 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (YeniceriHelmet > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(YeniceriHelmet - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (YeniceriHelmet == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (YeniceriHelmet < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - YeniceriHelmet);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //YENICERI HELMET BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //BAHAMUT ARMOR BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Bahamut Armor")
                        {
                            Double BahamutArmor = ((322 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (BahamutArmor > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(BahamutArmor - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (BahamutArmor == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (BahamutArmor < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - BahamutArmor);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //BAHAMUT ARMOR BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //BAHAMUT HELMET BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Bahamut Helmet")
                        {
                            Double BahamutHelmet = ((262 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (BahamutHelmet > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(BahamutHelmet - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (BahamutHelmet == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (BahamutHelmet < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - BahamutHelmet);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //BAHAMUT HELMET BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //MINERVA PACKAGE BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Minerva Package")
                        {
                            Double MinervaPackage = ((547 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (MinervaPackage > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MinervaPackage - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MinervaPackage == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MinervaPackage < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MinervaPackage);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //MINERVA PACKAGE BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //DRAGON SCALE BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Dragons Scale")
                        {
                            Double DragonsScale = ((300 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (DragonsScale > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(DragonsScale - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (DragonsScale == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (DragonsScale < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - DragonsScale);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //DRAGON SCALE BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //MENICIAS OFFICIAL LIST BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Menicias Official List")
                        {
                            Double MeniciasOfficialList = ((270 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (MeniciasOfficialList > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MeniciasOfficialList - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MeniciasOfficialList == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MeniciasOfficialList < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MeniciasOfficialList);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //MENICIAS OFFICIAL LIST BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //CLAN CONTRIBUTION BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Clan Contribution")
                        {
                            Double ClanContribution = ((780 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (ClanContribution > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(ClanContribution - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (ClanContribution == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (ClanContribution < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - ClanContribution);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //CLAN CONTRIBUTION BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //PUNISHMENT STICK AND WING BAŞLANGIÇ İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Punishment Stick + Wing")
                        {
                            Double PunishmentStickAndWing = ((749 * (Cash / 400) / (GB)) * 100000000);    //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİNİ BULDUK VE SONRA OYUN İÇİ PARASINA EŞDEĞERİNİ BULDUK


                            if (PunishmentStickAndWing > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(PunishmentStickAndWing - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (PunishmentStickAndWing == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (PunishmentStickAndWing < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - PunishmentStickAndWing);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //PUNISHMENT STICK AND WING BİTİŞ İNDİRİMLİ


                            }
                        }
                        #endregion

                        //TEKLİ SATILAN ÜRÜNLERİN, PROGRAMDA KULLANILAN DEĞİŞKEN İSİMLERİ BURADA İNDİRİMLİ
                        #region
                        //Double SWITCHPre = (2697 * (Cash / 400));   //İNDİRİMLİ PUS FİYATINA GÖRE TL DEĞERİ
                        //Double EXPpre = (2097 * (Cash / 400));          
                        //Double DISCpre = (1619 * (Cash / 400));
                        //Double WARPre = (1949 * (Cash / 400));
                        //Double Trina = (600 * (Cash / 400));
                        //Double Shadow = (719 * (Cash / 400));
                        //Double DragonsWing = (674 * (Cash / 400));
                        //Double ClanNameChangeSc = (299 * (Cash / 400));
                        //Double MonsterSummon = (187 * (Cash / 400));
                        //Double GenderChange = (562 * (Cash / 400));
                        //Double NameChangeScroll = (1500 * (Cash / 400));
                        //Double TearsofKarivdis = (300 * (Cash / 400));
                        //Double RedistributionItem = (399 * (Cash / 400));
                        //Double VoucherforMagicBag = (67 * (Cash / 400));
                        //Double CharacterSealSc = (2100 * (Cash / 400));
                        //Double ChaosMapCoupon = (26 * (Cash / 400));
                        //Double AncientText = (19 * (Cash / 400));
                        //Double VoucherforaPathosGlove = (187 * (Cash / 400));
                        //Double VoucherforAutoPet = (186 * (Cash / 400));
                        //Double NationTransfer = (1199 * (Cash / 400));
                        //Double CuffBinderPet = (224 * (Cash / 400));
                        //Double FamiliarNameChange = (262 * (Cash / 400));
                        //Double PathosPackage = (359 * (Cash / 400));
                        //Double GigaHammerPet = (262 * (Cash / 400));
                        //Double KrowazPet = (374 * (Cash / 400));
                        //Double HPMaestroVoucher = (150 * (Cash / 400));
                        //Double MPMaestroVoucher = (150 * (Cash / 400));
                        //Double DryadVoucher = (524 * (Cash / 400));
                        //Double OreadsVoucher = (524 * (Cash / 400));
                        //Double VIPVaultKey = (262 * (Cash / 400));
                        //Double PunishmentStickAndWing = (749 * (Cash / 400));
                        //Double AppearanceChange = (94 * (Cash / 400));
                        //Double YeniceriArmor = (322 * (Cash / 400));
                        //Double ValkyrieHelmet = (262 * (Cash / 400));
                        //Double ValkyrieArmorCertificate = (322 * (Cash / 400));
                        //Double GryphonHelmet = (262 * (Cash / 400));
                        //Double GryphonArmorCertificate = (322 * (Cash / 400));
                        //Double YeniceriHelmet = (262 * (Cash / 400));
                        //Double BahamutArmor = (322 * (Cash / 400));
                        //Double BahamutHelmet = (262 * (Cash / 400));
                        //Double MinervaPackage = (547 * (Cash / 400));
                        //Double DragonsScale = (300 * (Cash / 400));
                        //Double MeniciasOfficialList = (270 * (Cash / 400));
                        //Double ClanContribution = (780 * (Cash / 400));
                        #endregion

                    #endregion
                        //İNDİRİMLİ ÇOKLU EŞYA HESABI
                        #region

                        //PREMIUM POT HP İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Premium Potion HP" && radioButton1.Checked == true)
                        {
                            Double PrePotHP = (((144 * (Cash / 400) / (GB))) * 100000000);    //PRE POT HP ORJİNAL SAYIDAYSA BAŞLANGIÇ İNDİRİMLİ


                            if (PrePotHP > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(PrePotHP - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (PrePotHP == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (PrePotHP < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - PrePotHP);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //PRE POT HP ORJİNAL SAYIDAYSA BİTİŞ BİTİŞ İNDİRİMLİ


                            }
                        }
                        else if (textBox8.Text == "Premium Potion HP" && radioButton2.Checked == true) //PRE POT HP PARÇALI SAYIDAYSA BAŞLANGIÇ İNDİRİMLİ
                        {
                            Double PrePotHP = (((((144 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (PrePotHP > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(PrePotHP - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (PrePotHP == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (PrePotHP < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - PrePotHP);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //PRE POT HP PARÇALI SAYIDAYSA BİTİŞ İNDİRİMLİ


                            }
                        }

                        #endregion

                        //PREMIUM POT MP İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Premium Potion MP" && radioButton1.Checked == true)
                        {
                            Double PrePotMP = (((144 * (Cash / 400) / (GB))) * 100000000);    //PRE POT MP ORJİNAL SAYIDAYSA BAŞLANGIÇ İNDİRİMLİ


                            if (PrePotMP > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(PrePotMP - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (PrePotMP == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (PrePotMP < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - PrePotMP);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //PRE POT MP ORJİNAL SAYIDAYSA BİTİŞ


                            }
                        }
                        else if (textBox8.Text == "Premium Potion MP" && radioButton2.Checked == true)  //PRE POT MP PARÇALI SAYIDAYSA BAŞLANGIÇ İNDİRİMLİ
                        {
                            Double PrePotMP = (((((144 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (PrePotMP > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(PrePotMP - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (PrePotMP == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (PrePotMP < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - PrePotMP);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //PRE POT MP PARÇALI SAYIDAYSA BİTİŞ İNDİRİMLİ


                            }
                        }

                        #endregion

                        //GENIE HAMMER İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Genie Hammer" && radioButton1.Checked == true)
                        {
                            Double GenieHammer = (((74 * (Cash / 400) / (GB))) * 100000000);    //GENIE HAMMER ORJİNAL SAYIDAYSA BAŞLANGIÇ İNDİRİMLİ


                            if (GenieHammer > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(GenieHammer - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (GenieHammer == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (GenieHammer < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - GenieHammer);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //GENIE HAMMER ORJİNAL SAYIDAYSA BİTİŞ


                            }
                        }
                        else if (textBox8.Text == "Genie Hammer" && radioButton2.Checked == true)  //GENIE HAMMER PARÇALI SAYIDAYSA BAŞLANGIÇ İNDİRİMLİ
                        {
                            Double GenieHammer = (((((74 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (GenieHammer > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(GenieHammer - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (GenieHammer == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (GenieHammer < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - GenieHammer);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır."); //GENIE HAMMER PARÇALI SAYIDAYSA BİTİŞ İNDİRİMLİ


                            }
                        }

                        #endregion

                        //HEALTH 1500 SC İNDİRİMLİ
                        #region
                        if (textBox8.Text == "1500 Health+Scroll(L)" && radioButton1.Checked == true)
                        {
                            Double Health1500Sc = (((112 * (Cash / 400) / (GB))) * 100000000);


                            if (Health1500Sc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Health1500Sc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (Health1500Sc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (Health1500Sc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - Health1500Sc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "1500 Health+Scroll(L)" && radioButton2.Checked == true)
                        {
                            Double Health1500Sc = (((((112 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (Health1500Sc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Health1500Sc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (Health1500Sc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (Health1500Sc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - Health1500Sc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //HEALTH 1000 SC İNDİRİMLİ
                        #region
                        if (textBox8.Text == "1000 Health+Scroll(L)" && radioButton1.Checked == true)
                        {
                            Double Health1000Sc = (((74 * (Cash / 400) / (GB))) * 100000000);


                            if (Health1000Sc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Health1000Sc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (Health1000Sc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (Health1000Sc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - Health1000Sc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "1000 Health+Scroll(L)" && radioButton2.Checked == true)
                        {
                            Double Health1000Sc = (((((74 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (Health1000Sc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Health1000Sc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (Health1000Sc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (Health1000Sc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - Health1000Sc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //HEALTH 500 SC İNDİRİMLİ
                        #region
                        if (textBox8.Text == "500 Health+Scroll(L)" && radioButton1.Checked == true)
                        {
                            Double Health500Sc = (((37 * (Cash / 400) / (GB))) * 100000000);


                            if (Health500Sc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Health500Sc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (Health500Sc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (Health500Sc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - Health500Sc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "500 Health+Scroll(L)" && radioButton2.Checked == true)
                        {
                            Double Health500Sc = (((((37 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (Health500Sc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Health500Sc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (Health500Sc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (Health500Sc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - Health500Sc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //DEFENSE 300 SC İNDİRİMLİ
                        #region
                        if (textBox8.Text == "300 Defense+Scroll(L)" && radioButton1.Checked == true)
                        {
                            Double Defense300Sc = (((112 * (Cash / 400) / (GB))) * 100000000);


                            if (Defense300Sc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Defense300Sc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (Defense300Sc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (Defense300Sc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - Defense300Sc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "300 Defense+Scroll(L)" && radioButton2.Checked == true)
                        {
                            Double Defense300Sc = (((((112 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (Defense300Sc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Defense300Sc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (Defense300Sc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (Defense300Sc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - Defense300Sc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //DEFENSE 150 SC İNDİRİMLİ
                        #region
                        if (textBox8.Text == "150 Defense+Scroll(L)" && radioButton1.Checked == true)
                        {
                            Double Defense150Sc = (((59 * (Cash / 400) / (GB))) * 100000000);


                            if (Defense150Sc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Defense150Sc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (Defense150Sc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (Defense150Sc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - Defense150Sc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "150 Defense+Scroll(L)" && radioButton2.Checked == true)
                        {
                            Double Defense150Sc = (((((59 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (Defense150Sc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Defense150Sc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (Defense150Sc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (Defense150Sc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - Defense150Sc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //SPEED POTION İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Speed+Potion" && radioButton1.Checked == true)
                        {
                            Double SpeedPotion = (((59 * (Cash / 400) / (GB))) * 100000000);


                            if (SpeedPotion > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(SpeedPotion - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (SpeedPotion == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (SpeedPotion < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - SpeedPotion);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Speed+Potion" && radioButton2.Checked == true)
                        {
                            Double SpeedPotion = (((((59 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (SpeedPotion > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(SpeedPotion - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (SpeedPotion == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (SpeedPotion < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - SpeedPotion);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //ATTACK DAMAGE İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Attack Damage+" && radioButton1.Checked == true)
                        {
                            Double AttackDamage = (((119 * (Cash / 400) / (GB))) * 100000000);


                            if (AttackDamage > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(AttackDamage - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (AttackDamage == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (AttackDamage < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - AttackDamage);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Attack Damage+" && radioButton2.Checked == true)
                        {
                            Double AttackDamage = (((((119 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (AttackDamage > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(AttackDamage - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (AttackDamage == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (AttackDamage < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - AttackDamage);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //POWER OF LION SC İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Power of Lion Scroll(Stat)(L)" && radioButton1.Checked == true)
                        {
                            Double PowerofLionSc = (((172 * (Cash / 400) / (GB))) * 100000000);


                            if (PowerofLionSc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(PowerofLionSc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (PowerofLionSc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (PowerofLionSc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - PowerofLionSc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Power of Lion Scroll(Stat)(L)" && radioButton2.Checked == true)
                        {
                            Double PowerofLionSc = (((((172 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (PowerofLionSc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(PowerofLionSc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (PowerofLionSc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (PowerofLionSc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - PowerofLionSc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //STR SC İNDİRİMLİ
                        #region
                        if (textBox8.Text == "STR+ Scroll(Stat)(L)" && radioButton1.Checked == true)
                        {
                            Double STRSc = (((127 * (Cash / 400) / (GB))) * 100000000);


                            if (STRSc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(STRSc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (STRSc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (STRSc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - STRSc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "STR+ Scroll(Stat)(L)" && radioButton2.Checked == true)
                        {
                            Double STRSc = (((((127 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (STRSc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(STRSc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (STRSc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (STRSc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - STRSc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //HP SC İNDİRİMLİ
                        #region
                        if (textBox8.Text == "HP+ Scroll(Stat)(L)" && radioButton1.Checked == true)
                        {
                            Double HPSc = (((119 * (Cash / 400) / (GB))) * 100000000);


                            if (HPSc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(HPSc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (HPSc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (HPSc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - HPSc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "HP+ Scroll(Stat)(L)" && radioButton2.Checked == true)
                        {
                            Double HPSc = (((((119 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (HPSc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(HPSc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (HPSc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (HPSc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - HPSc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //DEX SC İNDİRİMLİ
                        #region
                        if (textBox8.Text == "DEX+ Scroll(Stat)(L)" && radioButton1.Checked == true)
                        {
                            Double DEXSc = (((127 * (Cash / 400) / (GB))) * 100000000);


                            if (DEXSc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(DEXSc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (DEXSc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (DEXSc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - DEXSc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "DEX+ Scroll(Stat)(L)" && radioButton2.Checked == true)
                        {
                            Double DEXSc = (((((127 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (DEXSc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(DEXSc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (DEXSc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (DEXSc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - DEXSc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //INT SC İNDİRİMLİ
                        #region
                        if (textBox8.Text == "INT+ Scroll(Stat)(L)" && radioButton1.Checked == true)
                        {
                            Double INTSc = (((52 * (Cash / 400) / (GB))) * 100000000);


                            if (INTSc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(INTSc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (INTSc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (INTSc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - INTSc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "INT+ Scroll(Stat)(L)" && radioButton2.Checked == true)
                        {
                            Double INTSc = (((((52 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (INTSc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(INTSc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (INTSc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (INTSc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - INTSc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //MP SC İNDİRİMLİ
                        #region
                        if (textBox8.Text == "MP+ Scroll(Stat)(L)" && radioButton1.Checked == true)
                        {
                            Double MPSc = (((52 * (Cash / 400) / (GB))) * 100000000);


                            if (MPSc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MPSc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MPSc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MPSc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MPSc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "MP+ Scroll(Stat)(L)" && radioButton2.Checked == true)
                        {
                            Double MPSc = (((((52 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (MPSc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MPSc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MPSc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MPSc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MPSc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //TELEPORTATION ITEM İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Teleportation Item" && radioButton1.Checked == true)
                        {
                            Double TeleportationItem = (((74 * (Cash / 400) / (GB))) * 100000000);


                            if (TeleportationItem > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(TeleportationItem - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (TeleportationItem == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (TeleportationItem < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - TeleportationItem);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Teleportation Item" && radioButton2.Checked == true)
                        {
                            Double TeleportationItem = (((((74 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (TeleportationItem > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(TeleportationItem - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (TeleportationItem == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (TeleportationItem < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - TeleportationItem);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //DURATION ITEM İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Duration Item" && radioButton1.Checked == true)
                        {
                            Double DurationItem = (((44 * (Cash / 400) / (GB))) * 100000000);


                            if (DurationItem > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(DurationItem - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (DurationItem == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (DurationItem < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - DurationItem);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Duration Item" && radioButton2.Checked == true)
                        {
                            Double DurationItem = (((((44 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (DurationItem > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(DurationItem - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (DurationItem == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (DurationItem < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - DurationItem);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //SYMBOL OF GLADIATOR 10 İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Symbol of Gladiator[10 ea]" && radioButton1.Checked == true)
                        {
                            Double SymbolofGladiator10 = (((577 * (Cash / 400) / (GB))) * 100000000);


                            if (SymbolofGladiator10 > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(SymbolofGladiator10 - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (SymbolofGladiator10 == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (SymbolofGladiator10 < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - SymbolofGladiator10);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Symbol of Gladiator[10 ea]" && radioButton2.Checked == true)
                        {
                            Double SymbolofGladiator10 = (((((577 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (SymbolofGladiator10 > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(SymbolofGladiator10 - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (SymbolofGladiator10 == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (SymbolofGladiator10 < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - SymbolofGladiator10);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //SYMBOL OF WARRIOR 10 İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Symbol of Warrior[10ea]" && radioButton1.Checked == true)
                        {
                            Double SymbolofWarrior10 = (((577 * (Cash / 400) / (GB))) * 100000000);


                            if (SymbolofWarrior10 > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(SymbolofWarrior10 - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (SymbolofWarrior10 == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (SymbolofWarrior10 < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - SymbolofWarrior10);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Symbol of Warrior[10ea]" && radioButton2.Checked == true)
                        {
                            Double SymbolofWarrior10 = (((((577 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (SymbolofWarrior10 > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(SymbolofWarrior10 - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (SymbolofWarrior10 == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (SymbolofWarrior10 < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - SymbolofWarrior10);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //HEALTH 2000 SC İNDİRİMLİ
                        #region
                        if (textBox8.Text == "2000 Health+ Scroll" && radioButton1.Checked == true)
                        {
                            Double Health2000Sc = (((187 * (Cash / 400) / (GB))) * 100000000);


                            if (Health2000Sc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Health2000Sc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (Health2000Sc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (Health2000Sc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - Health2000Sc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "2000 Health+ Scroll" && radioButton2.Checked == true)
                        {
                            Double Health2000Sc = (((((187 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (Health2000Sc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Health2000Sc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (Health2000Sc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (Health2000Sc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - Health2000Sc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //SCROLL OF ARMOR 350 SC İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Scroll of Armor 350" && radioButton1.Checked == true)
                        {
                            Double ScrollofArmor350 = (((187 * (Cash / 400) / (GB))) * 100000000);


                            if (ScrollofArmor350 > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(ScrollofArmor350 - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (ScrollofArmor350 == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (ScrollofArmor350 < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - ScrollofArmor350);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Scroll of Armor 350" && radioButton2.Checked == true)
                        {
                            Double ScrollofArmor350 = (((((187 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (ScrollofArmor350 > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(ScrollofArmor350 - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (ScrollofArmor350 == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (ScrollofArmor350 < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - ScrollofArmor350);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //NP INCREASE ITEM İNDİRİMLİ
                        #region
                        if (textBox8.Text == "NP Increase Item" && radioButton1.Checked == true)
                        {
                            Double NPIncreaseItem = (((599 * (Cash / 400) / (GB))) * 100000000);


                            if (NPIncreaseItem > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(NPIncreaseItem - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (NPIncreaseItem == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (NPIncreaseItem < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - NPIncreaseItem);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "NP Increase Item" && radioButton2.Checked == true)
                        {
                            Double NPIncreaseItem = (((((599 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (NPIncreaseItem > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(NPIncreaseItem - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (NPIncreaseItem == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (NPIncreaseItem < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - NPIncreaseItem);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //MERCHANT CONCENTRATION İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Merchant Concentration" && radioButton1.Checked == true)
                        {
                            Double MerchantConcentration = (((119 * (Cash / 400) / (GB))) * 100000000);


                            if (MerchantConcentration > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MerchantConcentration - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MerchantConcentration == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MerchantConcentration < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MerchantConcentration);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Merchant Concentration" && radioButton2.Checked == true)
                        {
                            Double MerchantConcentration = (((((119 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (MerchantConcentration > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MerchantConcentration - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MerchantConcentration == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MerchantConcentration < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MerchantConcentration);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //SYMBOL OF GROWTH İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Symbol of Growth" && radioButton1.Checked == true)
                        {
                            Double SymbolofGrowth = (((187 * (Cash / 400) / (GB))) * 100000000);


                            if (SymbolofGrowth > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(SymbolofGrowth - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (SymbolofGrowth == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (SymbolofGrowth < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - SymbolofGrowth);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Symbol of Growth" && radioButton2.Checked == true)
                        {
                            Double SymbolofGrowth = (((((187 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (SymbolofGrowth > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(SymbolofGrowth - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (SymbolofGrowth == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (SymbolofGrowth < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - SymbolofGrowth);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //HP 60 PERCENT SC İNDİRİMLİ
                        #region
                        if (textBox8.Text == "HP Scroll 60%" && radioButton1.Checked == true)
                        {
                            Double HPScroll60percent = (((224 * (Cash / 400) / (GB))) * 100000000);


                            if (HPScroll60percent > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(HPScroll60percent - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (HPScroll60percent == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (HPScroll60percent < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - HPScroll60percent);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "HP Scroll 60%" && radioButton2.Checked == true)
                        {
                            Double HPScroll60percent = (((((224 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (HPScroll60percent > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(HPScroll60percent - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (HPScroll60percent == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (HPScroll60percent < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - HPScroll60percent);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //HYPER NOAH SC İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Hyper Noah Scroll" && radioButton1.Checked == true)
                        {
                            Double HyperNoahSc = (((97 * (Cash / 400) / (GB))) * 100000000);


                            if (HyperNoahSc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(HyperNoahSc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (HyperNoahSc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (HyperNoahSc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - HyperNoahSc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Hyper Noah Scroll" && radioButton2.Checked == true)
                        {
                            Double HyperNoahSc = (((((97 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (HyperNoahSc > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(HyperNoahSc - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (HyperNoahSc == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (HyperNoahSc < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - HyperNoahSc);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //LESSON OF MASTER İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Lesson of Master" && radioButton1.Checked == true)
                        {
                            Double LessonofMaster = (((429 * (Cash / 400) / (GB))) * 100000000);


                            if (LessonofMaster > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(LessonofMaster - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (LessonofMaster == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (LessonofMaster < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - LessonofMaster);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Lesson of Master" && radioButton2.Checked == true)
                        {
                            Double LessonofMaster = (((((429 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (LessonofMaster > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(LessonofMaster - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (LessonofMaster == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (LessonofMaster < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - LessonofMaster);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //SEAL EXCHANGE VOUCHER İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Seal Exchange Voucher" && radioButton1.Checked == true)
                        {
                            Double SealExchangeVoucher = (((59 * (Cash / 400) / (GB))) * 100000000);


                            if (SealExchangeVoucher > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(SealExchangeVoucher - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (SealExchangeVoucher == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (SealExchangeVoucher < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - SealExchangeVoucher);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Seal Exchange Voucher" && radioButton2.Checked == true)
                        {
                            Double SealExchangeVoucher = (((((59 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (SealExchangeVoucher > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(SealExchangeVoucher - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (SealExchangeVoucher == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (SealExchangeVoucher < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - SealExchangeVoucher);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //MEDIUM SEAL EXCHANGE SC İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Medium Level Seal Exchange" && radioButton1.Checked == true)
                        {
                            Double MediumSealExchange = (((284 * (Cash / 400) / (GB))) * 100000000);


                            if (MediumSealExchange > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MediumSealExchange - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MediumSealExchange == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MediumSealExchange < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MediumSealExchange);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Medium Level Seal Exchange" && radioButton2.Checked == true)
                        {
                            Double MediumSealExchange = (((((284 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (MediumSealExchange > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MediumSealExchange - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MediumSealExchange == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MediumSealExchange < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MediumSealExchange);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //SPIRIT OF GENIE İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Spirit of Genie (10ea)" && radioButton1.Checked == true)
                        {
                            Double SpiritofGenie = (((112 * (Cash / 400) / (GB))) * 100000000);


                            if (SpiritofGenie > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(SpiritofGenie - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (SpiritofGenie == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (SpiritofGenie < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - SpiritofGenie);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Spirit of Genie (10ea)" && radioButton2.Checked == true)
                        {
                            Double SpiritofGenie = (((((112 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (SpiritofGenie > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(SpiritofGenie - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (SpiritofGenie == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (SpiritofGenie < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - SpiritofGenie);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //MENISSIAH TRANSFORM KARUS İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Menissiah Transform (Karus)" && radioButton1.Checked == true)
                        {
                            Double MenissiahTransformKarus = (((187 * (Cash / 400) / (GB))) * 100000000);


                            if (MenissiahTransformKarus > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MenissiahTransformKarus - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MenissiahTransformKarus == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MenissiahTransformKarus < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MenissiahTransformKarus);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Menissiah Transform (Karus)" && radioButton2.Checked == true)
                        {
                            Double MenissiahTransformKarus = (((((187 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (MenissiahTransformKarus > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MenissiahTransformKarus - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MenissiahTransformKarus == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MenissiahTransformKarus < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MenissiahTransformKarus);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //MENISSIAH TRANSFORM ELMORAD İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Menissiah Transform (Elmorad)" && radioButton1.Checked == true)
                        {
                            Double MenissiahTransformElmorad = (((187 * (Cash / 400) / (GB))) * 100000000);


                            if (MenissiahTransformElmorad > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MenissiahTransformElmorad - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MenissiahTransformElmorad == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MenissiahTransformElmorad < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MenissiahTransformElmorad);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Menissiah Transform (Elmorad)" && radioButton2.Checked == true)
                        {
                            Double MenissiahTransformElmorad = (((((187 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (MenissiahTransformElmorad > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MenissiahTransformElmorad - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MenissiahTransformElmorad == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MenissiahTransformElmorad < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MenissiahTransformElmorad);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //HERA TRANSFORM KARUS İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Hera Transform (Karus)" && radioButton1.Checked == true)
                        {
                            Double HeraTransformKarus = (((187 * (Cash / 400) / (GB))) * 100000000);


                            if (HeraTransformKarus > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(HeraTransformKarus - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (HeraTransformKarus == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (HeraTransformKarus < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - HeraTransformKarus);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Hera Transform (Karus)" && radioButton2.Checked == true)
                        {
                            Double HeraTransformKarus = (((((187 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (HeraTransformKarus > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(HeraTransformKarus - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (HeraTransformKarus == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (HeraTransformKarus < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - HeraTransformKarus);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //HERA TRANSFORM KARUS İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Hera Transform (Elmorad)" && radioButton1.Checked == true)
                        {
                            Double HeraTransformElmorad = (((187 * (Cash / 400) / (GB))) * 100000000);


                            if (HeraTransformElmorad > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(HeraTransformElmorad - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (HeraTransformElmorad == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (HeraTransformElmorad < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - HeraTransformElmorad);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Hera Transform (Elmorad)" && radioButton2.Checked == true)
                        {
                            Double HeraTransformElmorad = (((((187 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (HeraTransformElmorad > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(HeraTransformElmorad - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (HeraTransformElmorad == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (HeraTransformElmorad < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - HeraTransformElmorad);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //PATRICK TRANSFORM KARUS İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Patrick Transform (Karus)" && radioButton1.Checked == true)
                        {
                            Double PatrickTransformKarus = (((112 * (Cash / 400) / (GB))) * 100000000);


                            if (PatrickTransformKarus > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(PatrickTransformKarus - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (PatrickTransformKarus == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (PatrickTransformKarus < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - PatrickTransformKarus);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Patrick Transform (Karus)" && radioButton2.Checked == true)
                        {
                            Double PatrickTransformKarus = (((((112 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (PatrickTransformKarus > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(PatrickTransformKarus - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (PatrickTransformKarus == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (PatrickTransformKarus < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - PatrickTransformKarus);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //PATRICK TRANSFORM ELMORAD İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Patrick Transform (Elmorad)" && radioButton1.Checked == true)
                        {
                            Double PatrickTransformElmorad = (((112 * (Cash / 400) / (GB))) * 100000000);


                            if (PatrickTransformElmorad > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(PatrickTransformElmorad - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (PatrickTransformElmorad == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (PatrickTransformElmorad < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - PatrickTransformElmorad);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Patrick Transform (Elmorad)" && radioButton2.Checked == true)
                        {
                            Double PatrickTransformElmorad = (((((112 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (PatrickTransformElmorad > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(PatrickTransformElmorad - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (PatrickTransformElmorad == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (PatrickTransformElmorad < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - PatrickTransformElmorad);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //COUGAR TRANSFORM KARUS İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Cougar Transform (Karus)" && radioButton1.Checked == true)
                        {
                            Double CougarTransformKarus = (((112 * (Cash / 400) / (GB))) * 100000000);


                            if (CougarTransformKarus > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(CougarTransformKarus - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (CougarTransformKarus == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (CougarTransformKarus < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - CougarTransformKarus);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Cougar Transform (Karus)" && radioButton2.Checked == true)
                        {
                            Double CougarTransformKarus = (((((112 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (CougarTransformKarus > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(CougarTransformKarus - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (CougarTransformKarus == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (CougarTransformKarus < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - CougarTransformKarus);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //COUGAR TRANSFORM ELMORAD İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Cougar Transform (Elmorad)" && radioButton1.Checked == true)
                        {
                            Double CougarTransformElmorad = (((112 * (Cash / 400) / (GB))) * 100000000);


                            if (CougarTransformElmorad > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(CougarTransformElmorad - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (CougarTransformElmorad == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (CougarTransformElmorad < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - CougarTransformElmorad);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Cougar Transform (Elmorad)" && radioButton2.Checked == true)
                        {
                            Double CougarTransformElmorad = (((((112 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (CougarTransformElmorad > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(CougarTransformElmorad - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (CougarTransformElmorad == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (CougarTransformElmorad < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - CougarTransformElmorad);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //CRISIS ELMORAD İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Crisis(Elmorad)" && radioButton1.Checked == true)
                        {
                            Double CrisisElmorad = (((217 * (Cash / 400) / (GB))) * 100000000);


                            if (CrisisElmorad > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(CrisisElmorad - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (CrisisElmorad == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (CrisisElmorad < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - CrisisElmorad);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Crisis(Elmorad)" && radioButton2.Checked == true)
                        {
                            Double CrisisElmorad = (((((217 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (CrisisElmorad > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(CrisisElmorad - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (CrisisElmorad == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (CrisisElmorad < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - CrisisElmorad);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //IBEX KARUS İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Ibex(Karus)" && radioButton1.Checked == true)
                        {
                            Double IbexKarus = (((217 * (Cash / 400) / (GB))) * 100000000);


                            if (IbexKarus > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(IbexKarus - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (IbexKarus == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (IbexKarus < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - IbexKarus);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Ibex(Karus)" && radioButton2.Checked == true)
                        {
                            Double IbexKarus = (((((217 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (IbexKarus > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(IbexKarus - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (IbexKarus == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (IbexKarus < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - IbexKarus);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //MAGPIE ELMORAD İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Magpie (Elmorad)" && radioButton1.Checked == true)
                        {
                            Double MagpieElmorad = (((217 * (Cash / 400) / (GB))) * 100000000);


                            if (MagpieElmorad > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MagpieElmorad - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MagpieElmorad == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MagpieElmorad < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MagpieElmorad);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Magpie (Elmorad)" && radioButton2.Checked == true)
                        {
                            Double MagpieElmorad = (((((217 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (MagpieElmorad > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MagpieElmorad - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MagpieElmorad == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MagpieElmorad < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MagpieElmorad);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //MAGPIE KARUS İNDİRİMLİ
                        #region
                        if (textBox8.Text == "Magpie (Karus)" && radioButton1.Checked == true)
                        {
                            Double MagpieKarus = (((217 * (Cash / 400) / (GB))) * 100000000);


                            if (MagpieKarus > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MagpieKarus - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MagpieKarus == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MagpieKarus < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MagpieKarus);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }
                        else if (textBox8.Text == "Magpie (Karus)" && radioButton2.Checked == true)
                        {
                            Double MagpieKarus = (((((217 * (Cash / 400)) / Convert.ToInt32(label22.Text)) * Convert.ToInt32(textBox5.Text)) / (GB)) * 100000000);

                            if (MagpieKarus > Milyon)
                            {
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = false;
                                label27.Visible = false;
                                label9.Visible = true;
                                label13.Visible = true;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(MagpieKarus - Milyon);
                                String s = String.Format("{0:#,###0}", islem);
                                label13.Text = (s + "   Coins Daha Ucuzdur.");

                            }
                            else if (MagpieKarus == Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = false;
                                label14.Visible = false;
                                label26.Visible = true;
                                label27.Visible = true;
                                label27.Text = ("Eşittir");
                            }
                            else if (MagpieKarus < Milyon)
                            {
                                label9.Visible = false;
                                label13.Visible = false;
                                label7.Visible = true;
                                label14.Visible = true;
                                label26.Visible = false;
                                label27.Visible = false;
                                Int64 islem = 0;
                                islem = Convert.ToInt64(Milyon - MagpieKarus);
                                String s = String.Format("{0:#,###0}", islem);
                                label14.Text = (s + "   Coins Daha Pahalıdır.");


                            }
                        }

                        #endregion

                        //ÇOKLU SATILAN ÜRÜNLERİN, PROGRAMDA KULLANILAN DEĞİŞKEN İSİMLERİ BURADA İNDİRİMLİ
                        #region
                        //Double PrePotHP = (144 * (Cash / 400));
                        //Double PrePotMP = (144 * (Cash / 400));
                        //Double GenieHammer = (74 * (Cash / 400));
                        //Double Health1500Sc = (112 * (Cash / 400));
                        //Double Health1000Sc = (74 * (Cash / 400));
                        //Double Health500Sc = (37 * (Cash / 400));
                        //Double Defense300Sc = (112 * (Cash / 400));
                        //Double Defense150Sc = (59 * (Cash / 400));
                        //Double SpeedPotion = (59 * (Cash / 400));
                        //Double AttackDamage = (119 * (Cash / 400));
                        //Double PowerofLionSc = (172 * (Cash / 400));
                        //Double STRSc = (127 * (Cash / 400));
                        //Double HPSc = (119 * (Cash / 400));
                        //Double DEXSc = (127 * (Cash / 400));
                        //Double INTSc = (52 * (Cash / 400));
                        //Double MPSc = (52 * (Cash / 400));
                        //Double TeleportationItem = (74 * (Cash / 400));
                        //Double DurationItem = (44 * (Cash / 400));
                        //Double SymbolofGladiator10 = (577 * (Cash / 400));
                        //Double SymbolofWarrior10 = (577 * (Cash / 400));
                        //Double Health2000Sc = (187 * (Cash / 400));
                        //Double ScrollofArmor350 = (187 * (Cash / 400));
                        //Double NPIncreaseItem = (599 * (Cash / 400));
                        //Double MerchantConcentration = (119 * (Cash / 400));
                        //Double SymbolofGrowth = (187 * (Cash / 400));
                        //Double HPScroll60percent = (224 * (Cash / 400));
                        //Double HyperNoahSc = (97 * (Cash / 400));
                        //Double LessonofMaster = (429 * (Cash / 400));
                        //Double SealExchangeVoucher = (59 * (Cash / 400));
                        //Double MediumSealExchange = (284 * (Cash / 400));
                        //Double SpiritofGenie = (112 * (Cash / 400));
                        //Double MenissiahTransformKarus = (187 * (Cash / 400));
                        //Double MenissiahTransformElmorad = (187 * (Cash / 400));
                        //Double HeraTransformKarus = (187 * (Cash / 400));
                        //Double HeraTransformElmorad = (187 * (Cash / 400));
                        //Double PatrickTransformKarus = (112 * (Cash / 400));
                        //Double PatrickTransformElmorad = (112 * (Cash / 400));
                        //Double CougarTransformKarus = (112 * (Cash / 400));
                        //Double CougarTransformElmorad = (112 * (Cash / 400));
                        //Double CrisisElmorad = (217 * (Cash / 400));
                        //Double IbexKarus = (217 * (Cash / 400));
                        //Double MagpieElmorad = (217 * (Cash / 400));
                        //Double MagpieKarus = (217 * (Cash / 400));
                        #endregion
                    }


                        #endregion

                    //Program Bazen Hesap Sonrası, Sonucu Yansıttığında, Para farkı Sıfır Olan Eşyalara, Eşittir Demek Yerine, 0 Coins Daha Pahalıdır Diyor
                    //Bunun Önüne Geçmek İçin Aşağıdaki Kodlar Yazıldı.
                    //PAHALIDIR KISMI İÇİN OLAN
                    #region
                    if (label14.Visible == true && label14.Text == (0 + "   Coins Daha Pahalıdır."))
                    {
                        label14.Visible = false;
                        label7.Visible = false;

                        label26.Visible = true;
                        label27.Visible = true;
                        label27.Text = "Eşittir";
                    }
                    #endregion
                    //UCUZDUR KISMI İÇİN OLAN
                    #region

                    if (label13.Visible == true && label13.Text == (0 + "   Coins Daha Ucuzdur."))
                    {
                        label13.Visible = false;
                        label9.Visible = false;

                        label26.Visible = true;
                        label27.Visible = true;
                        label27.Text = "Eşittir";
                    }
                    #endregion


                    Image Sevin1 = FiyatKarsilastir.Properties.Resources.MaxNotify1;
                    pictureBox1.Image = Sevin1;
                    Image Sevin2 = FiyatKarsilastir.Properties.Resources.MaxNotify2;
                    pictureBox2.Image = Sevin2;
                    Image Uzul1 = FiyatKarsilastir.Properties.Resources.MaxNotify3;
                    pictureBox3.Image = Uzul1;
                    Image Uzul2 = FiyatKarsilastir.Properties.Resources.MaxNotify4;
                    pictureBox4.Image = Uzul2;

                    if (arkaplanLabel.Text != "Merchant")
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        timer3.Enabled = false;
                        timer4.Enabled = false;
                        timer5.Enabled = false;
                    }
                    else
                    {
                        timer1.Enabled = true;
                        timer2.Enabled = false;
                        timer3.Enabled = false;
                        timer4.Enabled = false;
                        timer5.Enabled = false;
                    }
                    if (maxKontrolLabel.Text == "Pasif")
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        timer3.Enabled = false;
                        timer4.Enabled = false;
                        timer5.Enabled = false;
                    }
                    else
                        if (maxKontrolLabel.Text == "Aktif")
                        {
                            timer1.Enabled = true;
                            timer2.Enabled = false;
                            timer3.Enabled = false;
                            timer4.Enabled = false;
                            timer5.Enabled = false;
                        }

                }

            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString(),"HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        private void Form1_BackgroundImageChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

        }


        //AŞAĞIDAKİ KOD BLOK'U, TEXTBOX'LARA MOUSE İLE TEK TIKLAYIŞTA İÇİNDEKİLERİN BÜTÜN YAZILANLARI SEÇİLİ HALE GETİRMEKTE.
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.SelectAll();
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.SelectAll();
        }

        private void textBox6_MouseClick(object sender, MouseEventArgs e)
        {
            textBox6.SelectAll();
        }

        private void textBox7_MouseClick(object sender, MouseEventArgs e)
        {
            textBox7.SelectAll();
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.SelectAll();
        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            textBox4.SelectAll();
        }

        private void textBox5_MouseClick(object sender, MouseEventArgs e)
        {
            textBox5.SelectAll();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            //EĞER HESAPLAMA SONRASI AŞAĞIDA GÖZÜKEN BİR SONUÇ VAR İSE, VE RADIOBUTTON'LARA TEKRARDAN TIKLANIRSA BU AŞAĞIDAKİ SONUÇ SİLİNECEKTİR.
            #region
            label7.Visible = false;
            label14.Visible = false;
            label9.Visible = false;
            label13.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            #endregion
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //EĞER HESAPLAMA SONRASI AŞAĞIDA GÖZÜKEN BİR SONUÇ VAR İSE, VE RADIOBUTTON'LARA TEKRARDAN TIKLANIRSA BU AŞAĞIDAKİ SONUÇ SİLİNECEKTİR.
            #region
            label7.Visible = false;
            label14.Visible = false;
            label9.Visible = false;
            label13.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            #endregion
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //EĞER HESAPLAMA SONRASI AŞAĞIDA GÖZÜKEN BİR SONUÇ VAR İSE, VE RADIOBUTTON'LARA TEKRARDAN TIKLANIRSA BU AŞAĞIDAKİ SONUÇ SİLİNECEKTİR.
            #region
            label7.Visible = false;
            label14.Visible = false;
            label9.Visible = false;
            label13.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            #endregion
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //EĞER HESAPLAMA SONRASI AŞAĞIDA GÖZÜKEN BİR SONUÇ VAR İSE, VE RADIOBUTTON'LARA TEKRARDAN TIKLANIRSA BU AŞAĞIDAKİ SONUÇ SİLİNECEKTİR.
            #region
            label7.Visible = false;
            label14.Visible = false;
            label9.Visible = false;
            label13.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            #endregion
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //EĞER HESAPLAMA SONRASI AŞAĞIDA GÖZÜKEN BİR SONUÇ VAR İSE, VE RADIOBUTTON'LARA TEKRARDAN TIKLANIRSA BU AŞAĞIDAKİ SONUÇ SİLİNECEKTİR.
            #region
            label7.Visible = false;
            label14.Visible = false;
            label9.Visible = false;
            label13.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            #endregion
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            //EĞER HESAPLAMA SONRASI AŞAĞIDA GÖZÜKEN BİR SONUÇ VAR İSE, VE RADIOBUTTON'LARA TEKRARDAN TIKLANIRSA BU AŞAĞIDAKİ SONUÇ SİLİNECEKTİR.
            #region
            label7.Visible = false;
            label14.Visible = false;
            label9.Visible = false;
            label13.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            #endregion
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Form2 f2 = new Form2(this);
            f2.ShowDialog();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }


        
        //MAX HAKKINDA HERŞEY BAŞLANGIÇ


        //MAX'E TIKLANDIĞINDA RESİM KAYBOLUR VE SIRADAKİ VAR İSE O GÖRÜNÜR HALDE OLUR.
        //YOK İSE RESİMLER BİTER HEPSİ INVISIBLE OLUR.
        private void pictureBox1_Click(object sender, EventArgs e)
        {

                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
           
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

                pictureBox2.Visible = false;
            
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

                pictureBox4.Visible = false;
            
        }

        //TIMER 1
        private void timer1_Tick(object sender, EventArgs e)
        {

                //Timer2 Burasının İçinde Başlatılıyor ve Bu Kısım Max'in İlk Resmini Ekrana Veriyor
                #region
                //MAX ARTIK ÇIKMAYA BAŞLAYACAĞI İÇİN BU SIRADA, ÖBÜR RESİM DE BU TİMER İLE BERABER 
                //GÖRÜNÜR OLACAĞINDAN ŞİMDİ BAŞLATILMALI.
                timer2.Enabled = true;

                if (label14.Text != "ERROR")
                {
                    pictureBox3.Visible = true;
                    timer1.Enabled = false;
                }
                else
                    if (label13.Text != "ERROR")
                    {
                        pictureBox1.Visible = true;
                        timer1.Enabled = false;
                    }
                    else
                    { timer1.Enabled = false; }
                #endregion
            
        }      
        //TIMER 2
        private void timer2_Tick(object sender, EventArgs e)
        {

                // BUTTON'UN EN ALTINDA TIMER1 BAŞLATILDI.
                #region
                timer3.Enabled = true;
                if (label14.Text != "ERROR")
                {
                    if (pictureBox3.Visible == true)
                    {
                        pictureBox3.Visible = false;
                        pictureBox4.Visible = true;
                    }
                    timer2.Enabled = false;
                }
                else
                    if (label13.Text != "ERROR")
                    {
                        if (pictureBox1.Visible == true)
                        {
                            pictureBox1.Visible = false;
                            pictureBox2.Visible = true;
                        }
                        timer2.Enabled = false;
                    }
                #endregion
            
        }
        //TIMER 3
        private void timer3_Tick(object sender, EventArgs e)
        {

                timer4.Enabled = true;

                if (pictureBox2.Visible == true)
                {
                    Image maxFade2 = Properties.Resources.MaxNotify2_Fade1;
                    pictureBox2.Image = maxFade2;
                    timer3.Enabled = false;
                }
                if (pictureBox4.Visible == true)
                {
                    Image maxFade2 = Properties.Resources.MaxNotify4_Fade1;
                    pictureBox4.Image = maxFade2;
                    timer3.Enabled = false;
                }
            
        }
        //TIMER 4
        private void timer4_Tick(object sender, EventArgs e)
        {
                timer5.Enabled = true;
                if (pictureBox2.Visible == true)
                {
                    Image maxFade3 = Properties.Resources.MaxNotify2_Fade2;
                    pictureBox2.Image = maxFade3;
                    timer4.Enabled = false;
                }
                if (pictureBox4.Visible == true)
                {
                    Image maxFade3 = Properties.Resources.MaxNotify4_Fade2;
                    pictureBox4.Image = maxFade3;
                    timer4.Enabled = false;
                }
            
        }
        //TIMER 5
        private void timer5_Tick(object sender, EventArgs e)
        {

                if (pictureBox2.Visible == true)
                {
                    pictureBox2.Visible = false;
                }
                if (pictureBox4.Visible == true)
                {
                    pictureBox4.Visible = false;
                }
            
        }


        //MAX HAKKINDA HERŞEY BİTİŞ


        //MENÜ HAKKINDA HERŞEY
        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(this);
            frm3.ShowDialog();
        }      

        
        //YUKARI MENU'DEN DOSYA TUŞUNA BASINCA BU SES GELİYOR OLMASI SAĞLANDI
        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _soundPlayerMenu.Play();
        }


        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ayarlarToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
        }
        private void anasayfaToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
        }

        private void anasayfaToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void hakkındaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.ShowDialog();
        }

        

        




    }
}
