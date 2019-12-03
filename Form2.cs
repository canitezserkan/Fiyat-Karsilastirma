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
    public partial class Form2 : Form
    {
        private SoundPlayer _soundPlayerGet;

        public Form1 form1; //BU KISIM VALUE AKTARMAK İÇİN YARATILDI VE KULLANILDI

        public Form2(Form1 form_1) //BU KISMIN İÇİ NORMALDE BOŞ AMA VALUE AKTARMAK İÇİN KULLANILDI
        {
            InitializeComponent();
            goldBarPictureBox.Image = Properties.Resources.background_goldBar;
            _soundPlayerGet = new SoundPlayer(FiyatKarsilastir.Properties.Resources.ui_button2);

            form1 = form_1;            //BU KISIM VALUE AKTARMAK İÇİN KULLANILDI. 
            //AYRICA FORM1'İN DESIGNER'INA GİRİLİP TEXTBOX8 PUBLİC HALE GETİRİLDİ
            //Kİ İÇİNE BAŞKA FORMLARDAN VERİ EKLENEBİLSİN.
            
            #region
                       /* toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");

                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        toolTip1.SetToolTip = (this.Health500ScButton, "500 HEALTH SC");
                        **/
            #endregion

        }
        private void Form2_MouseLeave(object sender, EventArgs e)
        {

        }


        private void Form2_Load(object sender, EventArgs e)
        {

            esyaKontrolLabel.Visible = false;
            esyaKontrolLabel.Text = "0";
        }


        //TAMAMLA ve İPTAL Butonları Bunlardır. Tamamla Buton'u sadece Form'u Kapar.
        //Diğer İptal Buton'u ise Eşya Seçim TextBox'ının içini Temizleyip Form'u Kapar.
        private void button1_Click(object sender, EventArgs e)
        {
            if (esyaKontrolLabel.Text == "1" && form1.textBox8.Text != "")
            {
                _soundPlayerGet.Play();
            }
            this.Close();

        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            
            form1.textBox8.Text = "";
            this.Close();
        }


        //500 HEALTH SC
        private void Health500ScButton_MouseEnter(object sender, EventArgs e)
        {
            this.Health500ScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._500HealthSc_MEN));
        }
        private void Health500ScButton_MouseLeave(object sender, EventArgs e)
        {
            this.Health500ScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._500HealthSc));
            esyaKontrolLabel.Text = "1";
        }
        private void Health500ScButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.Health500ScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._500HealthSc_MDWN));
        }
        private void Health500ScButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.Health500ScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._500HealthSc_MEN));
        }
        private void Health500ScButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._500HealthSc));
            form1.textBox8.Text = "500 Health+Scroll(L)";
        }

        //1000 HEALTH SC
        private void Health1000ScButton_MouseEnter(object sender, EventArgs e)
        {
            this.Health1000ScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._1000HealthSc_MEN));
        }
        private void Health1000ScButton_MouseLeave(object sender, EventArgs e)
        {
            this.Health1000ScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._1000HealthSc));
            esyaKontrolLabel.Text = "1";
        }
        private void Health1000ScButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.Health1000ScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._1000HealthSc_MDWN));
        }        
        private void Health1000ScButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.Health1000ScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._1000HealthSc_MEN));

        }
        private void Health1000ScButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._1000HealthSc));
            form1.textBox8.Text = "1000 Health+Scroll(L)";
        }

        //1500 HEALTH SC
        private void Health1500ScButton_MouseEnter(object sender, EventArgs e)
        {
            this.Health1500ScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._1500HealthSc_MEN));
        }
        private void Health1500ScButton_MouseLeave(object sender, EventArgs e)
        {
            this.Health1500ScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._1500HealthSc));
            esyaKontrolLabel.Text = "1";
        }
        private void Health1500ScButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.Health1500ScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._1500HealthSc_MDWN));

        }
        private void Health1500ScButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.Health1500ScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._1500HealthSc_MEN));
        }
        private void Health1500ScButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._1500HealthSc));
            form1.textBox8.Text = "1500 Health+Scroll(L)";
        }

        //2000 HEALTH SC
        private void Health2000ScButton_MouseEnter(object sender, EventArgs e)
        {
            this.Health2000ScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._2000HealthSc_MEN));
        }
        private void Health2000ScButton_MouseLeave(object sender, EventArgs e)
        {
            this.Health2000ScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._2000HealthSc));
            esyaKontrolLabel.Text = "1";
        }
        private void Health2000ScButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.Health2000ScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._2000HealthSc_MDWN));
        }
        private void Health2000ScButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.Health2000ScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._2000HealthSc_MEN));
        }
        private void Health2000ScButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._2000HealthSc));
            form1.textBox8.Text = "2000 Health+ Scroll";
        }

        //UND SC
        private void UndSc_MouseEnter(object sender, EventArgs e)
        {
            this.UndSc.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.UndySc_MEN));
        }
        private void UndSc_MouseLeave(object sender, EventArgs e)
        {
            this.UndSc.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.UndySc));
            esyaKontrolLabel.Text = "1";
        }
        private void UndSc_MouseDown(object sender, MouseEventArgs e)
        {
            this.UndSc.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.UndySc_MDWN));
        }
        private void UndSc_MouseUp(object sender, MouseEventArgs e)
        {
            this.UndSc.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.UndySc_MEN));
        }
        private void UndSc_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.UndySc));
            form1.textBox8.Text = "HP Scroll 60%";
        }

        //150 DEFENSE SC
        private void Defense150Sc_MouseEnter(object sender, EventArgs e)
        {
            this.Defense150Sc.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._150AC_MEN));
        }
        private void Defense150Sc_MouseLeave(object sender, EventArgs e)
        {
            this.Defense150Sc.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._150AC));
            esyaKontrolLabel.Text = "1";
        }
        private void Defense150Sc_MouseDown(object sender, MouseEventArgs e)
        {
            this.Defense150Sc.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._150AC_MDWN));
        }
        private void Defense150Sc_MouseUp(object sender, MouseEventArgs e)
        {
            this.Defense150Sc.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._150AC_MEN));
        }
        private void Defense150Sc_Click(object sender, EventArgs e)
        {
               kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._150AC));
               form1.textBox8.Text = "150 Defense+Scroll(L)";
        }

        //300 DEFENSE SC
        private void Defense300Sc_MouseEnter(object sender, EventArgs e)
        {
            this.Defense300Sc.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._300AC_MEN));
        }
        private void Defense300Sc_MouseLeave(object sender, EventArgs e)
        {
            this.Defense300Sc.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._300AC));
            esyaKontrolLabel.Text = "1";
        }
        private void Defense300Sc_MouseDown(object sender, MouseEventArgs e)
        {
            this.Defense300Sc.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._300AC_MDWN));
        }
        private void Defense300Sc_MouseUp(object sender, MouseEventArgs e)
        {
            this.Defense300Sc.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._300AC_MEN));
        }
        private void Defense300Sc_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._300AC));
            form1.textBox8.Text = "300 Defense+Scroll(L)";
        }

        //350 DEFENSE SC
        private void Defense350Sc_MouseEnter(object sender, EventArgs e)
        {
            this.Defense350Sc.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._300AC_MEN));
        }
        private void Defense350Sc_MouseLeave(object sender, EventArgs e)
        {
            this.Defense350Sc.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._300AC));
            esyaKontrolLabel.Text = "1";
        }
        private void Defense350Sc_MouseDown(object sender, MouseEventArgs e)
        {
            this.Defense350Sc.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._300AC_MDWN));
        }
        private void Defense350Sc_MouseUp(object sender, MouseEventArgs e)
        {
            this.Defense350Sc.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._300AC_MEN));
        }
        private void Defense350Sc_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._350AC));
            form1.textBox8.Text = "Scroll of Armor 350";
        }

        //SPEED POT
        private void SpeedPot_MouseEnter(object sender, EventArgs e)
        {
            this.SpeedPot.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.SWPotion_MEN));
        }
        private void SpeedPot_MouseLeave(object sender, EventArgs e)
        {
            this.SpeedPot.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.SWPotion));
            esyaKontrolLabel.Text = "1";
        }
        private void SpeedPot_MouseDown(object sender, MouseEventArgs e)
        {
            this.SpeedPot.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.SWPotion_MDWN));
        }
        private void SpeedPot_MouseUp(object sender, MouseEventArgs e)
        {
            this.SpeedPot.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.SWPotion_MEN));
        }
        private void SpeedPot_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.SWPotion));
            form1.textBox8.Text = "Speed+Potion";
        }

        //ATTACK DAMAGE
        private void AttackDamage_MouseEnter(object sender, EventArgs e)
        {
            this.AttackDamage.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.AttackDamage_MEN));
        }
        private void AttackDamage_MouseLeave(object sender, EventArgs e)
        {
            this.AttackDamage.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.AttackDamage));
            esyaKontrolLabel.Text = "1";
        }
        private void AttackDamage_MouseDown(object sender, MouseEventArgs e)
        {
            this.AttackDamage.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.AttackDamage_MDWN));
        }
        private void AttackDamage_MouseUp(object sender, MouseEventArgs e)
        {
            this.AttackDamage.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.AttackDamage_MEN));
        }
        private void AttackDamage_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.AttackDamage));
            form1.textBox8.Text = "Attack Damage+";
        }

        //POWER OF LION
        private void PowerofLion_MouseEnter(object sender, EventArgs e)
        {
            this.PowerofLion.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PowerofLion_MEN));
        }
        private void PowerofLion_MouseLeave(object sender, EventArgs e)
        {
            this.PowerofLion.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PowerofLion));
            esyaKontrolLabel.Text = "1";
        }
        private void PowerofLion_MouseDown(object sender, MouseEventArgs e)
        {
            this.PowerofLion.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PowerofLion_MDWN));
        }
        private void PowerofLion_MouseUp(object sender, MouseEventArgs e)
        {
            this.PowerofLion.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PowerofLion_MEN));
        }
        private void PowerofLion_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PowerofLion));
            form1.textBox8.Text = "Power of Lion Scroll(Stat)(L)";
        }

        //STR SC
        private void STRScButton_MouseEnter(object sender, EventArgs e)
        {
            this.STRScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.STRSc_MEN));
        }
        private void STRScButton_MouseLeave(object sender, EventArgs e)
        {
            this.STRScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.STRSc));
            esyaKontrolLabel.Text = "1";
        }
        private void STRScButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.STRScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.STRSc_MDWN));
        }
        private void STRScButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.STRScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.STRSc_MEN));
        }
        private void STRScButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.STRSc));
            form1.textBox8.Text = "STR+ Scroll(Stat)(L)";
            
        }

        //HP SC
        private void HPScButton_MouseEnter(object sender, EventArgs e)
        {
            this.HPScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HPSc_MEN));
        }
        private void HPScButton_MouseLeave(object sender, EventArgs e)
        {
            this.HPScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HPSc));
            esyaKontrolLabel.Text = "1";
        }
        private void HPScButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.HPScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HPSc_MDWN));
        }
        private void HPScButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.HPScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HPSc_MEN));
        }
        private void HPScButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HPSc));
            form1.textBox8.Text = "HP+ Scroll(Stat)(L)";
        }

        //DEX SC
        private void DEXScButton_MouseEnter(object sender, EventArgs e)
        {
            this.DEXScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.DEXSc_MEN));
        }
        private void DEXScButton_MouseLeave(object sender, EventArgs e)
        {
            this.DEXScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.DEXSc));
            esyaKontrolLabel.Text = "1";
        }
        private void DEXScButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.DEXScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.DEXSc_MDWN));
        }
        private void DEXScButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.DEXScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.DEXSc_MEN));
        }
        private void DEXScButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.DEXSc));
            form1.textBox8.Text = "DEX+ Scroll(Stat)(L)";
        }

        //INT SC
        private void INTScButton_MouseEnter(object sender, EventArgs e)
        {
            this.INTScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.INTSc_MEN));
        }
        private void INTScButton_MouseLeave(object sender, EventArgs e)
        {
            this.INTScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.INTSc));
            esyaKontrolLabel.Text = "1";
        }
        private void INTScButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.INTScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.INTSc_MDWN));
        }
        private void INTScButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.INTScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.INTSc_MEN));
        }
        private void INTScButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.INTSc));
            form1.textBox8.Text = "INT+ Scroll(Stat)(L)";
        }

        //MP SC
        private void MPScButton_MouseEnter(object sender, EventArgs e)
        {
            this.MPScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MPSc_MEN));
        }
        private void MPScButton_MouseLeave(object sender, EventArgs e)
        {
            this.MPScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MPSc));
            esyaKontrolLabel.Text = "1";
        }
        private void MPScButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.MPScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MPSc_MDWN));
        }
        private void MPScButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.MPScButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MPSc_MEN));
        }
        private void MPScButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MPSc));
            form1.textBox8.Text = "MP+ Scroll(Stat)(L)";
        }

        //LESSON OF MASTER
        private void LessonOfMasterButton_MouseEnter(object sender, EventArgs e)
        {
            this.LessonOfMasterButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.LessonofMaster_MEN ));
        }
        private void LessonOfMasterButton_MouseLeave(object sender, EventArgs e)
        {
            this.LessonOfMasterButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.LessonofMaster));
            esyaKontrolLabel.Text = "1";
        }
        private void LessonOfMasterButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.LessonOfMasterButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.LessonofMaster_MDWN));
        }
        private void LessonOfMasterButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.LessonOfMasterButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.LessonofMaster_MEN));
        }
        private void LessonOfMasterButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.LessonofMaster));
            form1.textBox8.Text = "Lesson of Master";
        }

        //DURATION ITEM
        private void button14_MouseEnter(object sender, EventArgs e)
        {
            this.button14.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.DurationItem_MEN));
        }
        private void button14_MouseLeave(object sender, EventArgs e)
        {
            this.button14.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.DurationItem));
            esyaKontrolLabel.Text = "1";
        }
        private void button14_MouseDown(object sender, MouseEventArgs e)
        {
            this.button14.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.DurationItem_MDWN));
        }
        private void button14_MouseUp(object sender, MouseEventArgs e)
        {
            this.button14.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.DurationItem_MEN));
        }
        private void button14_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.DurationItem));
            form1.textBox8.Text = "Duration Item";
        }

        //HYPER NOAH
        private void HyperNoahButton_MouseEnter(object sender, EventArgs e)
        {
            this.HyperNoahButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HyperNoah_MEN));
        }
        private void HyperNoahButton_MouseLeave(object sender, EventArgs e)
        {
            this.HyperNoahButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HyperNoah));
            esyaKontrolLabel.Text = "1";
        }
        private void HyperNoahButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.HyperNoahButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HyperNoah_MDWN));
        }
        private void HyperNoahButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.HyperNoahButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HyperNoah_MEN));
        }
        private void HyperNoahButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HyperNoah));
            form1.textBox8.Text = "Hyper Noah Scroll";
        }

        //WARRIOR SYMBOL
        private void WarriorSymbolButton_MouseEnter(object sender, EventArgs e)
        {
            this.WarriorSymbolButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.WarriorSymbol_MEN));
        }
        private void WarriorSymbolButton_MouseLeave(object sender, EventArgs e)
        {
            this.WarriorSymbolButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.WarriorSymbol));
            esyaKontrolLabel.Text = "1";
        }
        private void WarriorSymbolButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.WarriorSymbolButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.WarriorSymbol_MDWN));
        }
        private void WarriorSymbolButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.WarriorSymbolButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.WarriorSymbol_MEN));
        }
        private void WarriorSymbolButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.WarriorSymbol));
            form1.textBox8.Text = "Symbol of Warrior[10ea]";
        }

        //GLADIATOR SYMBOL
        private void GladiatorSymbolButton_MouseEnter(object sender, EventArgs e)
        {
            this.GladiatorSymbolButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GladiatorSymbol_MEN));
        }
        private void GladiatorSymbolButton_MouseLeave(object sender, EventArgs e)
        {
            this.GladiatorSymbolButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GladiatorSymbol));
            esyaKontrolLabel.Text = "1";
        }
        private void GladiatorSymbolButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.GladiatorSymbolButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GladiatorSymbol_MDWN));
        }
        private void GladiatorSymbolButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.GladiatorSymbolButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GladiatorSymbol_MEN));
        }
        private void GladiatorSymbolButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GladiatorSymbol));
            form1.textBox8.Text = "Symbol of Gladiator[10 ea]";
        }

        //GROWTH SYMBOL
        private void GrowthSymbolButton_MouseEnter(object sender, EventArgs e)
        {
            this.GrowthSymbolButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GrowthSymbol_MEN));
        }
        private void GrowthSymbolButton_MouseLeave(object sender, EventArgs e)
        {
            this.GrowthSymbolButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GrowthSymbol));
            esyaKontrolLabel.Text = "1";
        }
        private void GrowthSymbolButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.GrowthSymbolButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GrowthSymbol_MDWN));
        }
        private void GrowthSymbolButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.GrowthSymbolButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GrowthSymbol_MEN));
        }
        private void GrowthSymbolButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GrowthSymbol));
            form1.textBox8.Text = "Symbol of Growth";
        }

        //NP INCREASE
        private void NPIncreaseButton_MouseEnter(object sender, EventArgs e)
        {
            this.NPIncreaseButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.NPIncrease_MEN));
        }
        private void NPIncreaseButton_MouseLeave(object sender, EventArgs e)
        {
            this.NPIncreaseButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.NPIncrease));
            esyaKontrolLabel.Text = "1";
        }
        private void NPIncreaseButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.NPIncreaseButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.NPIncrease_MDWN));
        }
        private void NPIncreaseButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.NPIncreaseButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.NPIncrease_MEN));
        }
        private void NPIncreaseButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.NPIncrease));
            form1.textBox8.Text = "NP Increase Item";
        }

        //PRE HP POT
        private void PrePotHPButton_MouseEnter(object sender, EventArgs e)
        {
            this.PrePotHPButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PreHpPot_MEN));
        }
        private void PrePotHPButton_MouseLeave(object sender, EventArgs e)
        {
            this.PrePotHPButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PreHpPot));
            esyaKontrolLabel.Text = "1";
        }
        private void PrePotHPButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.PrePotHPButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PreHpPot_MDWN));
        }
        private void PrePotHPButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.PrePotHPButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PreHpPot_MEN));
        }
        private void PrePotHPButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PreHpPot));
            form1.textBox8.Text = "Premium Potion HP";
        }

        //PRE MP POT
        private void PrePotMPButton_MouseEnter(object sender, EventArgs e)
        {
            this.PrePotMPButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PreMpPot_MEN));
        }
        private void PrePotMPButton_MouseLeave(object sender, EventArgs e)
        {
            this.PrePotMPButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PreMpPot));
            esyaKontrolLabel.Text = "1";
        }
        private void PrePotMPButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.PrePotMPButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PreMpPot_MDWN));
        }
        private void PrePotMPButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.PrePotMPButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PreMpPot_MEN));
        }
        private void PrePotMPButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PreMpPot));
            form1.textBox8.Text = "Premium Potion MP";
        }

        //HP MAESTRO
        private void HPMaestroButton_MouseEnter(object sender, EventArgs e)
        {
            this.HPMaestroButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HPMaestro_MEN));
        }
        private void HPMaestroButton_MouseLeave(object sender, EventArgs e)
        {
            this.HPMaestroButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HPMaestro));
            esyaKontrolLabel.Text = "1";
        }
        private void HPMaestroButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.HPMaestroButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HPMaestro_MDWN));
        }
        private void HPMaestroButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.HPMaestroButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HPMaestro_MEN));
        }
        private void HPMaestroButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HPMaestro));
            form1.textBox8.Text = "HP Maestro Voucher";
        }

        //MP MAESTRO
        private void MPMaestroButton_MouseEnter(object sender, EventArgs e)
        {
            this.MPMaestroButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MPMaestro_MEN));
        }
        private void MPMaestroButton_MouseLeave(object sender, EventArgs e)
        {
            this.MPMaestroButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MPMaestro));
            esyaKontrolLabel.Text = "1";
        }
        private void MPMaestroButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.MPMaestroButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MPMaestro_MDWN));
        }
        private void MPMaestroButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.MPMaestroButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MPMaestro_MEN));
        }
        private void MPMaestroButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MPMaestro));
            form1.textBox8.Text = "MP Maestro Voucher";
        }

        //SPIRIT OF GENIE
        private void SpiritofGenieButton_MouseEnter(object sender, EventArgs e)
        {
            this.SpiritofGenieButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.SpiritofGenie_MEN));
        }
        private void SpiritofGenieButton_MouseLeave(object sender, EventArgs e)
        {
            this.SpiritofGenieButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.SpiritofGenie));
            esyaKontrolLabel.Text = "1";
        }
        private void SpiritofGenieButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.SpiritofGenieButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.SpiritofGenie_MDWN));
        }
        private void SpiritofGenieButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.SpiritofGenieButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.SpiritofGenie_MEN));
        }
        private void SpiritofGenieButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.SpiritofGenie));
            form1.textBox8.Text = "Spirit of Genie (10ea)";
        }

        //GENIE HAMMER
        private void GenieHammerButton_MouseEnter(object sender, EventArgs e)
        {
            this.GenieHammerButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GenieHammer_MEN));
        }
        private void GenieHammerButton_MouseLeave(object sender, EventArgs e)
        {
            this.GenieHammerButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GenieHammer));
            esyaKontrolLabel.Text = "1";
        }
        private void GenieHammerButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.GenieHammerButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GenieHammer_MDWN));
        }
        private void GenieHammerButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.GenieHammerButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GenieHammer_MEN));
        }
        private void GenieHammerButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GenieHammer));
            form1.textBox8.Text = "Genie Hammer";
        }

        //MAGIC BAG
        private void MagicBagButton_MouseEnter(object sender, EventArgs e)
        {
            this.MagicBagButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MagicBag_MEN));
        }
        private void MagicBagButton_MouseLeave(object sender, EventArgs e)
        {
            this.MagicBagButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MagicBag));
            esyaKontrolLabel.Text = "1";
        }
        private void MagicBagButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.MagicBagButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MagicBag_MDWN));
        }
        private void MagicBagButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.MagicBagButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MagicBag_MEN));
        }
        private void MagicBagButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MagicBag));
            form1.textBox8.Text = "Voucher for Magic Bag";
        }

        //AUTO LOOT
        private void AutoLootButton_MouseEnter(object sender, EventArgs e)
        {
            this.AutoLootButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.AutomaticPet_MEN));
        }
        private void AutoLootButton_MouseLeave(object sender, EventArgs e)
        {
            this.AutoLootButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.AutomaticPet));
            esyaKontrolLabel.Text = "1";
        }
        private void AutoLootButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.AutoLootButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.AutomaticPet_MDWN));
        }
        private void AutoLootButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.AutoLootButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.AutomaticPet_MEN));
        }
        private void AutoLootButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.AutomaticPet));
            form1.textBox8.Text = "Voucher for Automatic Pet";
        }

        //PATHOS GLOVE
        private void PathosGloveButton_MouseEnter(object sender, EventArgs e)
        {
            this.PathosGloveButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PathosGlove_MEN));
        }
        private void PathosGloveButton_MouseLeave(object sender, EventArgs e)
        {
            this.PathosGloveButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PathosGlove));
            esyaKontrolLabel.Text = "1";
        }
        private void PathosGloveButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.PathosGloveButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PathosGlove_MDWN));
        }
        private void PathosGloveButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.PathosGloveButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PathosGlove_MEN));
        }
        private void PathosGloveButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PathosGlove));
            form1.textBox8.Text = "Voucher for a Pathos Glove";
        }

        //PATHOS PACKAGE
        private void PathosPackageButton_MouseEnter(object sender, EventArgs e)
        {
            this.PathosPackageButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PathosPackage_MEN));
        }
        private void PathosPackageButton_MouseLeave(object sender, EventArgs e)
        {
            this.PathosPackageButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PathosPackage));
            esyaKontrolLabel.Text = "1";
        }
        private void PathosPackageButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.PathosPackageButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PathosPackage_MDWN));
        }
        private void PathosPackageButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.PathosPackageButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PathosPackage_MEN));
        }
        private void PathosPackageButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PathosPackage));
            form1.textBox8.Text = "Pathos Package";
        }

        //PET NAME CHANGE
        private void PetNameChangeButton_MouseEnter(object sender, EventArgs e)
        {
            this.PetNameChangeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.FamiliarNameChange_MEN));
        }
        private void PetNameChangeButton_MouseLeave(object sender, EventArgs e)
        {
            this.PetNameChangeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.FamiliarNameChange));
            esyaKontrolLabel.Text = "1";
        }
        private void PetNameChangeButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.PetNameChangeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.FamiliarNameChange_MDWN));
        }
        private void PetNameChangeButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.PetNameChangeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.FamiliarNameChange_MEN));
        }
        private void PetNameChangeButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.FamiliarNameChange));
            form1.textBox8.Text = "Familiar Name Change";
        }

        //CUFF BINDER
        private void CuffBinderButton_MouseEnter(object sender, EventArgs e)
        {
            this.CuffBinderButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.CuffBinder_MEN));
        }
        private void CuffBinderButton_MouseLeave(object sender, EventArgs e)
        {
            this.CuffBinderButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.CuffBinder));
            esyaKontrolLabel.Text = "1";
        }
        private void CuffBinderButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.CuffBinderButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.CuffBinder_MDWN));
        }
        private void CuffBinderButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.CuffBinderButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.CuffBinder_MEN));
        }
        private void CuffBinderButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.CuffBinder));
            form1.textBox8.Text = "Cuff Binder Pet";
        }

        //GIGA HAMMER
        private void GigaPetButton_MouseEnter(object sender, EventArgs e)
        {
            this.GigaPetButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GigaHammerPet_MEN));
        }
        private void GigaPetButton_MouseLeave(object sender, EventArgs e)
        {
            this.GigaPetButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GigaHammerPet));
            esyaKontrolLabel.Text = "1";
        }
        private void GigaPetButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.GigaPetButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GigaHammerPet_MDWN));
        }
        private void GigaPetButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.GigaPetButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GigaHammerPet_MEN));
        }
        private void GigaPetButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GigaHammerPet));
            form1.textBox8.Text = "Giga Hammer Pet";
        }

        //KROWAZ PET
        private void KrowazPetButton_MouseEnter(object sender, EventArgs e)
        {
            this.KrowazPetButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.KrowazPet_MEN));
        }
        private void KrowazPetButton_MouseLeave(object sender, EventArgs e)
        {
            this.KrowazPetButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.KrowazPet));
            esyaKontrolLabel.Text = "1";
        }
        private void KrowazPetButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.KrowazPetButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.KrowazPet_MDWN));
        }
        private void KrowazPetButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.KrowazPetButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.KrowazPet_MEN));
        }
        private void KrowazPetButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.KrowazPet));
            form1.textBox8.Text = "Krowaz Pet";
        }

        //DRYAD
        private void DryadButton_MouseEnter(object sender, EventArgs e)
        {
            this.DryadButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Dryad_MEN));
        }
        private void DryadButton_MouseLeave(object sender, EventArgs e)
        {
            this.DryadButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Dryad));
            esyaKontrolLabel.Text = "1";
        }
        private void DryadButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.DryadButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Dryad_MDWN));
        }
        private void DryadButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.DryadButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Dryad_MEN));
        }
        private void DryadButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Dryad));
            form1.textBox8.Text = "Dryad Voucher (30 Days)";
        }

        //OREADS
        private void OreadsButton_MouseEnter(object sender, EventArgs e)
        {
            this.OreadsButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Oreads_MEN));
        }
        private void OreadsButton_MouseLeave(object sender, EventArgs e)
        {
            this.OreadsButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Oreads));
            esyaKontrolLabel.Text = "1";
        }
        private void OreadsButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.OreadsButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Oreads_MDWN));
        }
        private void OreadsButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.OreadsButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Oreads_MEN));
        }
        private void OreadsButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Oreads));
            form1.textBox8.Text = "Oreads Voucher (30 Days)";
        }

        //VIP KEY
        private void VIPKeyButton_MouseEnter(object sender, EventArgs e)
        {
            this.VIPKeyButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.VaultKey_MEN));
        }
        private void VIPKeyButton_MouseLeave(object sender, EventArgs e)
        {
            this.VIPKeyButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.VaultKey));
            esyaKontrolLabel.Text = "1";
        }
        private void VIPKeyButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.VIPKeyButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.VaultKey_MDWN));
        }
        private void VIPKeyButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.VIPKeyButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.VaultKey_MEN));
        }
        private void VIPKeyButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.VaultKey));
            form1.textBox8.Text = "VIP Vault Key [30 Days]";
        }

        //SEAL EXCHANGE
        private void SealExchButton_MouseEnter(object sender, EventArgs e)
        {
            this.SealExchButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.SealExchange_MEN));
        }
        private void SealExchButton_MouseLeave(object sender, EventArgs e)
        {
            this.SealExchButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.SealExchange));
            esyaKontrolLabel.Text = "1";
        }
        private void SealExchButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.SealExchButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.SealExchange_MDWN));
        }
        private void SealExchButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.SealExchButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.SealExchange_MEN));
        }
        private void SealExchButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.SealExchange));
            form1.textBox8.Text = "Seal Exchange Voucher";
        }

        //MEDIUM SEAL EXCHANGE
        private void MediumSealExchButton_MouseEnter(object sender, EventArgs e)
        {
            this.MediumSealExchButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MediumSealExchange_MEN));
        }
        private void MediumSealExchButton_MouseLeave(object sender, EventArgs e)
        {
            this.MediumSealExchButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MediumSealExchange));
            esyaKontrolLabel.Text = "1";
        }
        private void MediumSealExchButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.MediumSealExchButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MediumSealExchange_MDWN));
        }
        private void MediumSealExchButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.MediumSealExchButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MediumSealExchange_MEN));
        }
        private void MediumSealExchButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MediumSealExchange));
            form1.textBox8.Text = "Medium Level Seal Exchange";
        }

        //DRAGONS WING
        private void DragonsWingButton_MouseEnter(object sender, EventArgs e)
        {
            this.DragonsWingButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.DragonsWing_MEN));
        }
        private void DragonsWingButton_MouseLeave(object sender, EventArgs e)
        {
            this.DragonsWingButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.DragonsWing));
            esyaKontrolLabel.Text = "1";
        }
        private void DragonsWingButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.DragonsWingButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.DragonsWing_MDWN));
        }
        private void DragonsWingButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.DragonsWingButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.DragonsWing_MEN));
        }
        private void DragonsWingButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.DragonsWing));
            form1.textBox8.Text = "Dragons Wing";
        }

        //STICK AND WING
        private void WingStickButton_MouseEnter(object sender, EventArgs e)
        {
            this.WingStickButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.WingAndStick_MEN));
        }
        private void WingStickButton_MouseLeave(object sender, EventArgs e)
        {
            this.WingStickButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.WingAndStick));
            esyaKontrolLabel.Text = "1";
        }
        private void WingStickButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.WingStickButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.WingAndStick_MDWN));
        }
        private void WingStickButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.WingStickButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.WingAndStick_MEN));
        }
        private void WingStickButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.WingAndStick));
            form1.textBox8.Text = "Punishment Stick + Wing";
        }

        //MENISSIAH KARUS
        private void MenissiahKarusButton_MouseEnter(object sender, EventArgs e)
        {
            this.MenissiahKarusButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MenissiahTransKarus_MEN));
        }
        private void MenissiahKarusButton_MouseLeave(object sender, EventArgs e)
        {
            this.MenissiahKarusButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MenissiahTransKarus));
            esyaKontrolLabel.Text = "1";
        }
        private void MenissiahKarusButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.MenissiahKarusButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MenissiahTransKarus_MDWN));
        }
        private void MenissiahKarusButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.MenissiahKarusButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MenissiahTransKarus_MEN));
        }
        private void MenissiahKarusButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MenissiahTransKarus));
            form1.textBox8.Text = "Menissiah Transform (Karus)";
        }

        //MENISSIAH MORAD
        private void MenissiahMoradButton_MouseEnter(object sender, EventArgs e)
        {
            this.MenissiahMoradButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MenissiahTransElmorad_MEN));
        }
        private void MenissiahMoradButton_MouseLeave(object sender, EventArgs e)
        {
            this.MenissiahMoradButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MenissiahTransElmorad));
            esyaKontrolLabel.Text = "1";
        }
        private void MenissiahMoradButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.MenissiahMoradButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MenissiahTransElmorad_MDWN));
        }
        private void MenissiahMoradButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.MenissiahMoradButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MenissiahTransElmorad_MEN));
        }
        private void MenissiahMoradButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MenissiahTransElmorad));
            form1.textBox8.Text = "Menissiah Transform (Elmorad)";
        }

        //PATRICK KARUS
        private void PatrickKarusButton_MouseEnter(object sender, EventArgs e)
        {
            this.PatrickKarusButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PatrickTransKarus_MEN));
        }
        private void PatrickKarusButton_MouseLeave(object sender, EventArgs e)
        {
            this.PatrickKarusButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PatrickTransKarus));
            esyaKontrolLabel.Text = "1";
        }
        private void PatrickKarusButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.PatrickKarusButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PatrickTransKarus_MDWN));
        }
        private void PatrickKarusButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.PatrickKarusButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PatrickTransKarus_MEN));
        }
        private void PatrickKarusButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PatrickTransKarus));
            form1.textBox8.Text = "Patrick Transform (Karus)";
        }

        //PATRICK MORAD
        private void PatrickMoradButton_MouseEnter(object sender, EventArgs e)
        {
            this.PatrickMoradButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PatrickTransElmorad_MEN));
        }
        private void PatrickMoradButton_MouseLeave(object sender, EventArgs e)
        {
            this.PatrickMoradButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PatrickTransElmorad));
            esyaKontrolLabel.Text = "1";
        }
        private void PatrickMoradButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.PatrickMoradButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PatrickTransElmorad_MDWN));
        }
        private void PatrickMoradButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.PatrickMoradButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PatrickTransElmorad_MEN));
        }
        private void PatrickMoradButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.PatrickTransElmorad));
            form1.textBox8.Text = "Patrick Transform (Elmorad)";
        }

        //MAGPIE KARUS
        private void MagpieKarusButton_MouseEnter(object sender, EventArgs e)
        {
            this.MagpieKarusButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MagpieKarus_MEN));
        }
        private void MagpieKarusButton_MouseLeave(object sender, EventArgs e)
        {
            this.MagpieKarusButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MagpieKarus));
            esyaKontrolLabel.Text = "1";
        }
        private void MagpieKarusButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.MagpieKarusButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MagpieKarus_MDWN));
        }
        private void MagpieKarusButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.MagpieKarusButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MagpieKarus_MEN));
        }
        private void MagpieKarusButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MagpieKarus));
            form1.textBox8.Text = "Magpie (Karus)";
        }

        //MAGPIE MORAD
        private void MagpieMoradButton_MouseEnter(object sender, EventArgs e)
        {
            this.MagpieMoradButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MagpieElmorad_MEN));
        }
        private void MagpieMoradButton_MouseLeave(object sender, EventArgs e)
        {
            this.MagpieMoradButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MagpieElmorad));
            esyaKontrolLabel.Text = "1";
        }
        private void MagpieMoradButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.MagpieMoradButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MagpieElmorad_MDWN));
        }
        private void MagpieMoradButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.MagpieMoradButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MagpieElmorad_MEN));
        }
        private void MagpieMoradButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MagpieElmorad));
            form1.textBox8.Text = "Magpie (Elmorad)";
        }

        //APPEAR CHANGE
        private void AppearChangeButton_MouseEnter(object sender, EventArgs e)
        {
            this.AppearChangeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.AppearanceChange_MEN));
        }
        private void AppearChangeButton_MouseLeave(object sender, EventArgs e)
        {
            this.AppearChangeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.AppearanceChange));
            esyaKontrolLabel.Text = "1";
        }
        private void AppearChangeButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.AppearChangeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.AppearanceChange_MDWN));
        }
        private void AppearChangeButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.AppearChangeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.AppearanceChange_MEN));
        }
        private void AppearChangeButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.AppearanceChange));
            form1.textBox8.Text = "Appearance Change";
        }

        //YENICERI HELMET
        private void YeniceriHelmetButton_MouseEnter(object sender, EventArgs e)
        {
            this.YeniceriHelmetButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.YeniceriHelmet_MEN));
        }
        private void YeniceriHelmetButton_MouseLeave(object sender, EventArgs e)
        {
            this.YeniceriHelmetButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.YeniceriHelmet));
            esyaKontrolLabel.Text = "1";
        }
        private void YeniceriHelmetButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.YeniceriHelmetButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.YeniceriHelmet_MDWN));
        }
        private void YeniceriHelmetButton_MouseMove(object sender, MouseEventArgs e)
        {

        }
        private void YeniceriHelmetButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.YeniceriHelmetButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.YeniceriHelmet_MEN));
        }
        private void YeniceriHelmetButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.YeniceriHelmet));
            form1.textBox8.Text = "Yeniceri Helmet";
        }

        //GRYPHON HELMET
        private void GryphonHelmetButton_MouseEnter(object sender, EventArgs e)
        {
            this.GryphonHelmetButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GryphonHelmet_MEN));
        }
        private void GryphonHelmetButton_MouseLeave(object sender, EventArgs e)
        {
            this.GryphonHelmetButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GryphonHelmet));
            esyaKontrolLabel.Text = "1";
        }
        private void GryphonHelmetButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.GryphonHelmetButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GryphonHelmet_MDWN));
        }
        private void GryphonHelmetButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.GryphonHelmetButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GryphonHelmet_MEN));
        }
        private void GryphonHelmetButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GryphonHelmet));
            form1.textBox8.Text = "Gryphon Helmet";
        }

        //BAHAMUT HELMET
        private void BahamutHelmetButton_MouseEnter(object sender, EventArgs e)
        {
            this.BahamutHelmetButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BahamutHelmet_MEN));
        }
        private void BahamutHelmetButton_MouseLeave(object sender, EventArgs e)
        {
            this.BahamutHelmetButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BahamutHelmet));
            esyaKontrolLabel.Text = "1";
        }
        private void BahamutHelmetButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.BahamutHelmetButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BahamutHelmet_MDWN));
        }
        private void BahamutHelmetButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.BahamutHelmetButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BahamutHelmet_MEN));
        }
        private void BahamutHelmetButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BahamutHelmet));
            form1.textBox8.Text = "Bahamut Helmet";
        }

        //VALKYRIE HELMET
        private void ValkyrieHelmetButton_MouseEnter(object sender, EventArgs e)
        {
            this.ValkyrieHelmetButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ValkyrieHelmet_MEN));
        }
        private void ValkyrieHelmetButton_MouseLeave(object sender, EventArgs e)
        {
            this.ValkyrieHelmetButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ValkyrieHelmet));
            esyaKontrolLabel.Text = "1";
        }
        private void ValkyrieHelmetButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.ValkyrieHelmetButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ValkyrieHelmet_MDWN));
        }
        private void ValkyrieHelmetButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.ValkyrieHelmetButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ValkyrieHelmet_MEN));
        }
        private void ValkyrieHelmetButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ValkyrieHelmet));
            form1.textBox8.Text = "Valkyrie Helmet";
        }

        //HERA KARUS
        private void HeraKarusButton_MouseEnter(object sender, EventArgs e)
        {
            this.HeraKarusButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HeraTransKarus_MEN));
        }
        private void HeraKarusButton_MouseLeave(object sender, EventArgs e)
        {
            this.HeraKarusButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HeraTransKarus));
            esyaKontrolLabel.Text = "1";
        }
        private void HeraKarusButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.HeraKarusButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HeraTransKarus_MDWN));
        }
        private void HeraKarusButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.HeraKarusButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HeraTransKarus_MEN));
        }
        private void HeraKarusButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HeraTransKarus));
            form1.textBox8.Text = "Hera Transform (Karus)";
        }

        //HERA MORAD
        private void HeraMoradButton_MouseEnter(object sender, EventArgs e)
        {
            this.HeraMoradButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HeraTransElmorad_MEN));
        }
        private void HeraMoradButton_MouseLeave(object sender, EventArgs e)
        {
            this.HeraMoradButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HeraTransElmorad));
            esyaKontrolLabel.Text = "1";
        }
        private void HeraMoradButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.HeraMoradButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HeraTransElmorad_MDWN));
        }
        private void HeraMoradButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.HeraMoradButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HeraTransElmorad_MEN));
        }
        private void HeraMoradButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HeraTransElmorad));
            form1.textBox8.Text = "Hera Transform (Elmorad)";
        }

        //COUGAR KARUS
        private void CougarKarusButton_MouseEnter(object sender, EventArgs e)
        {
            this.CougarKarusButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.CougarTransKarus_MEN));
        }
        private void CougarKarusButton_MouseLeave(object sender, EventArgs e)
        {
            this.CougarKarusButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.CougarTransKarus));
            esyaKontrolLabel.Text = "1";
        }
        private void CougarKarusButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.CougarKarusButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.CougarTransKarus_MDWN));
        }
        private void CougarKarusButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.CougarKarusButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.CougarTransKarus_MEN));
        }
        private void CougarKarusButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.CougarTransKarus));
            form1.textBox8.Text = "Cougar Transform (Karus)";
        }

        //COUGAR MORAD
        private void CougarMoradButton_MouseEnter(object sender, EventArgs e)
        {
            this.CougarMoradButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.CougarTransElmorad_MEN));
        }
        private void CougarMoradButton_MouseLeave(object sender, EventArgs e)
        {
            this.CougarMoradButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.CougarTransElmorad));
            esyaKontrolLabel.Text = "1";
        }
        private void CougarMoradButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.CougarMoradButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.CougarTransElmorad_MDWN));
        }
        private void CougarMoradButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.CougarMoradButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.CougarTransElmorad_MEN));
        }
        private void CougarMoradButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.CougarTransElmorad));
            form1.textBox8.Text = "Cougar Transform (Elmorad)";
        }

        //CRISIS
        private void CrisisButton_MouseEnter(object sender, EventArgs e)
        {
            this.CrisisButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Crisis_MEN));
        }
        private void CrisisButton_MouseLeave(object sender, EventArgs e)
        {
            this.CrisisButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Crisis));
            esyaKontrolLabel.Text = "1";
        }
        private void CrisisButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.CrisisButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Crisis_MDWN));
        }
        private void CrisisButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.CrisisButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Crisis_MEN));
        }
        private void CrisisButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Crisis));
            form1.textBox8.Text = "Crisis(Elmorad)";
        }

        //IBEX
        private void IbexButton_MouseEnter(object sender, EventArgs e)
        {
            this.IbexButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Ibex_MEN));
        }
        private void IbexButton_MouseLeave(object sender, EventArgs e)
        {
            this.IbexButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Ibex));
            esyaKontrolLabel.Text = "1";
        }
        private void IbexButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.IbexButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Ibex_MDWN));
        }
        private void IbexButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.IbexButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Ibex_MEN));
        }
        private void IbexButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Ibex));
            form1.textBox8.Text = "Ibex(Karus)";
        }

        //MINERVA PACKAGE
        private void MinervaPackageButton_MouseEnter(object sender, EventArgs e)
        {
            this.MinervaPackageButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MinervaPack_MEN));
        }
        private void MinervaPackageButton_MouseLeave(object sender, EventArgs e)
        {
            this.MinervaPackageButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MinervaPack));
            esyaKontrolLabel.Text = "1";
        }
        private void MinervaPackageButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.MinervaPackageButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MinervaPack_MDWN));
        }
        private void MinervaPackageButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.MinervaPackageButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MinervaPack_MEN));
        }
        private void MinervaPackageButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MinervaPack));
            form1.textBox8.Text = "Minerva Package";
        }

        //YENICERI ARMOR
        private void YeniceriAmorButton_MouseEnter(object sender, EventArgs e)
        {
            this.YeniceriAmorButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.YeniceriArmor_MEN));
        }
        private void YeniceriAmorButton_MouseLeave(object sender, EventArgs e)
        {
            this.YeniceriAmorButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.YeniceriArmor));
            esyaKontrolLabel.Text = "1";
        }
        private void YeniceriAmorButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.YeniceriAmorButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.YeniceriArmor_MDWN));
        }
        private void YeniceriAmorButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.YeniceriAmorButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.YeniceriArmor_MEN));
        }
        private void YeniceriAmorButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.YeniceriArmor));
            form1.textBox8.Text = "Yeniceri Armor";
        }

        //GRYPHON ARMOR
        private void GryphonArmorButton_MouseEnter(object sender, EventArgs e)
        {
            this.GryphonArmorButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GryphonArmor_MEN));
        }
        private void GryphonArmorButton_MouseLeave(object sender, EventArgs e)
        {
            this.GryphonArmorButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GryphonArmor));
            esyaKontrolLabel.Text = "1";
        }
        private void GryphonArmorButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.GryphonArmorButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GryphonArmor_MDWN));
        }
        private void GryphonArmorButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.GryphonArmorButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GryphonArmor_MEN));
        }
        private void GryphonArmorButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GryphonArmor));
            form1.textBox8.Text = "Gryphon Armor Certificate";
        }

        //BAHAMUT ARMOR
        private void BahamutArmorButton_MouseEnter(object sender, EventArgs e)
        {
            this.BahamutArmorButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BahamutArmor_MEN));
        }
        private void BahamutArmorButton_MouseLeave(object sender, EventArgs e)
        {
            this.BahamutArmorButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BahamutArmor));
            esyaKontrolLabel.Text = "1";
        }
        private void BahamutArmorButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.BahamutArmorButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BahamutArmor_MDWN));
        }
        private void BahamutArmorButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.BahamutArmorButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BahamutArmor_MEN));
        }
        private void BahamutArmorButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BahamutArmor));
            form1.textBox8.Text = "Bahamut Armor";
        }

        //VALKYRIE ARMOR
        private void ValkyrieArmorButton_MouseEnter(object sender, EventArgs e)
        {
            this.ValkyrieArmorButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ValkyrieArmor_MEN));
        }
        private void ValkyrieArmorButton_MouseLeave(object sender, EventArgs e)
        {
            this.ValkyrieArmorButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ValkyrieArmor));
            esyaKontrolLabel.Text = "1";
        }
        private void ValkyrieArmorButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.ValkyrieArmorButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ValkyrieArmor_MDWN));
        }
        private void ValkyrieArmorButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.ValkyrieArmorButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ValkyrieArmor_MEN));
        }
        private void ValkyrieArmorButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ValkyrieArmor));
            form1.textBox8.Text = "Valkyrie Armor Certificate";
        }

        //SWITCH PRE
        private void SwitchPreButton_MouseEnter(object sender, EventArgs e)
        {
            this.SwitchPreButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.SWITCHPre_MEN));
        }
        private void SwitchPreButton_MouseLeave(object sender, EventArgs e)
        {
            this.SwitchPreButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.SWITCHPre));
            esyaKontrolLabel.Text = "1";
        }
        private void SwitchPreButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.SwitchPreButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.SWITCHPre_MDWN));
        }
        private void SwitchPreButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.SwitchPreButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.SWITCHPre_MEN));
        }
        private void SwitchPreButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.SWITCHPre));
            form1.textBox8.Text = "SWITCH Premium";
        }

        //EXP PRE
        private void EXPPreButton_MouseEnter(object sender, EventArgs e)
        {
            this.EXPPreButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.EXPpre_MEN));
        }
        private void EXPPreButton_MouseLeave(object sender, EventArgs e)
        {
            this.EXPPreButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.EXPpre));
            esyaKontrolLabel.Text = "1";
        }
        private void EXPPreButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.EXPPreButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.EXPpre_MDWN));
        }
        private void EXPPreButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.EXPPreButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.EXPpre_MEN));
        }
        private void EXPPreButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.EXPpre));
            form1.textBox8.Text = "EXP Premium";
        }

        //DC PRE
        private void DISCPreButton_MouseEnter(object sender, EventArgs e)
        {
            this.DISCPreButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.DCPre_MEN));
        }
        private void DISCPreButton_MouseLeave(object sender, EventArgs e)
        {
            this.DISCPreButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.DCPre));
            esyaKontrolLabel.Text = "1";
        }
        private void DISCPreButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.DISCPreButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.DCPre_MDWN));
        }
        private void DISCPreButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.DISCPreButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.DCPre_MEN));
        }
        private void DISCPreButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.DCPre));
            form1.textBox8.Text = "DISC Premium";
        }

        //WAR PRE
        private void WARPreButton_MouseEnter(object sender, EventArgs e)
        {
            this.WARPreButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.WARPre_MEN));
        }
        private void WARPreButton_MouseLeave(object sender, EventArgs e)
        {
            this.WARPreButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.WARPre));
            esyaKontrolLabel.Text = "1";
        }
        private void WARPreButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.WARPreButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.WARPre_MDWN));
        }
        private void WARPreButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.WARPreButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.WARPre_MEN));
        }
        private void WARPreButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.WARPre));
            form1.textBox8.Text = "WAR Premium";
        }

        //TRINA
        private void TrinaButton_MouseEnter(object sender, EventArgs e)
        {
            this.TrinaButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Trina_MEN));
        }
        private void TrinaButton_MouseLeave(object sender, EventArgs e)
        {
            this.TrinaButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Trina));
            esyaKontrolLabel.Text = "1";
        }
        private void TrinaButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.TrinaButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Trina_MDWN));
        }
        private void TrinaButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.TrinaButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Trina_MEN));
        }
        private void TrinaButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Trina));
            form1.textBox8.Text = "Trinas Piece";
        }

        //SHADOW
        private void ShadowButton_MouseEnter(object sender, EventArgs e)
        {
            this.ShadowButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Shadow_MEN));
        }
        private void ShadowButton_MouseLeave(object sender, EventArgs e)
        {
            this.ShadowButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Shadow));
            esyaKontrolLabel.Text = "1";
        }
        private void ShadowButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.ShadowButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Shadow_MDWN));
        }
        private void ShadowButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.ShadowButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Shadow_MEN));
        }
        private void ShadowButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Shadow));
            form1.textBox8.Text = "Shadow Piece";
        }

        //KARIVDIS
        private void KarivdisButton_MouseEnter(object sender, EventArgs e)
        {
            this.KarivdisButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.TearsofKarivdis_MEN));
        }
        private void KarivdisButton_MouseLeave(object sender, EventArgs e)
        {
            this.KarivdisButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.TearsofKarivdis));
            esyaKontrolLabel.Text = "1";
        }
        private void KarivdisButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.KarivdisButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.TearsofKarivdis_MDWN));
        }
        private void KarivdisButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.KarivdisButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.TearsofKarivdis_MEN));
        }
        private void KarivdisButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.TearsofKarivdis));
            form1.textBox8.Text = "Tears of Karivdis";
        }

        //DRAGON SCALE
        private void DragonScaleButton_MouseEnter(object sender, EventArgs e)
        {
            this.DragonScaleButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.DragonsScale_MEN));
        }
        private void DragonScaleButton_MouseLeave(object sender, EventArgs e)
        {
            this.DragonScaleButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.DragonsScale));
            esyaKontrolLabel.Text = "1";
        }
        private void DragonScaleButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.DragonScaleButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.DragonsScale_MDWN));
        }
        private void DragonScaleButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.DragonScaleButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.DragonsScale_MEN));
        }
        private void DragonScaleButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.DragonsScale));
            form1.textBox8.Text = "Dragons Scale";
        }

        //MONSTER SUMMON
        private void MonsterSummonButton_MouseEnter(object sender, EventArgs e)
        {
            this.MonsterSummonButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MonsterSummonStaff_MEN));
        }
        private void MonsterSummonButton_MouseLeave(object sender, EventArgs e)
        {
            this.MonsterSummonButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MonsterSummonStaff));
            esyaKontrolLabel.Text = "1";
        }
        private void MonsterSummonButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.MonsterSummonButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MonsterSummonStaff_MDWN));
        }
        private void MonsterSummonButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.MonsterSummonButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MonsterSummonStaff_MEN));
        }
        private void MonsterSummonButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MonsterSummonStaff));
            form1.textBox8.Text = "Monster Summon Staff";
        }

        //MERCHANT CONCENTRATION
        private void MerchantConcentrationButton_MouseEnter(object sender, EventArgs e)
        {
            this.MerchantConcentrationButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MerchantConcentration_MEN));
        }
        private void MerchantConcentrationButton_MouseLeave(object sender, EventArgs e)
        {
            this.MerchantConcentrationButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MerchantConcentration));
            esyaKontrolLabel.Text = "1";
        }
        private void MerchantConcentrationButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.MerchantConcentrationButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MerchantConcentration_MDWN));
        }
        private void MerchantConcentrationButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.MerchantConcentrationButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MerchantConcentration_MEN));
        }
        private void MerchantConcentrationButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MerchantConcentration));
            form1.textBox8.Text = "Merchant Concentration";
        }

        //MENICIAS LIST
        private void MeniciasListButton_MouseEnter(object sender, EventArgs e)
        {
            this.MeniciasListButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MeniciasList_MEN));
        }
        private void MeniciasListButton_MouseLeave(object sender, EventArgs e)
        {
            this.MeniciasListButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MeniciasList));
            esyaKontrolLabel.Text = "1";
        }
        private void MeniciasListButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.MeniciasListButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MeniciasList_MDWN));
        }
        private void MeniciasListButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.MeniciasListButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MeniciasList_MEN));
        }
        private void MeniciasListButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MeniciasList));
            form1.textBox8.Text = "Menicias Official List";
        }

        //NAME CHANGE BUTTON
        private void NameChangeButton_MouseEnter(object sender, EventArgs e)
        {
            this.NameChangeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.NameChange_MEN));
        }
        private void NameChangeButton_MouseLeave(object sender, EventArgs e)
        {
            this.NameChangeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.NameChange));
            esyaKontrolLabel.Text = "1";
        }
        private void NameChangeButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.NameChangeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.NameChange_MDWN));
        }
        private void NameChangeButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.NameChangeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.NameChange_MEN));
        }
        private void NameChangeButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.NameChange));
            form1.textBox8.Text = "Name Change Scroll";
        }

        //CLAN NAME CHANGE
        private void ClanNameChangeButton_MouseEnter(object sender, EventArgs e)
        {
            this.ClanNameChangeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ClanNameChangeSc_MEN));
        }
        private void ClanNameChangeButton_MouseLeave(object sender, EventArgs e)
        {
            this.ClanNameChangeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ClanNameChangeSc));
            esyaKontrolLabel.Text = "1";
        }
        private void ClanNameChangeButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.ClanNameChangeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ClanNameChangeSc_MDWN));
        }
        private void ClanNameChangeButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.ClanNameChangeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ClanNameChangeSc_MEN));
        }
        private void ClanNameChangeButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ClanNameChangeSc));
            form1.textBox8.Text = "Clan Name Change Scroll";
        }

        //GENDER CHANGE
        private void GenderChangeButton_MouseEnter(object sender, EventArgs e)
        {
            this.GenderChangeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GenderChange_MEN));
        }
        private void GenderChangeButton_MouseLeave(object sender, EventArgs e)
        {
            this.GenderChangeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GenderChange));
            esyaKontrolLabel.Text = "1";
        }
        private void GenderChangeButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.GenderChangeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GenderChange_MDWN));
        }
        private void GenderChangeButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.GenderChangeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GenderChange_MEN));
        }
        private void GenderChangeButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.GenderChange));
            form1.textBox8.Text = "Gender Change";
        }

        //NATION TRANSFER
        private void NationTransferButton_MouseEnter(object sender, EventArgs e)
        {
            this.NationTransferButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.NationTransfer_MEN));
        }
        private void NationTransferButton_MouseLeave(object sender, EventArgs e)
        {
            this.NationTransferButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.NationTransfer));
            esyaKontrolLabel.Text = "1";
        }
        private void NationTransferButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.NationTransferButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.NationTransfer_MDWN));
        }
        private void NationTransferButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.NationTransferButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.NationTransfer_MEN));
        }
        private void NationTransferButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.NationTransfer));
            form1.textBox8.Text = "Nation Transfer";
        }

        //CLAN CONTRIBUTION
        private void ClanContributionButton_MouseEnter(object sender, EventArgs e)
        {
            this.ClanContributionButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ClanContribution_MEN));
        }
        private void ClanContributionButton_MouseLeave(object sender, EventArgs e)
        {
            this.ClanContributionButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ClanContribution));
            esyaKontrolLabel.Text = "1";
        }
        private void ClanContributionButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.ClanContributionButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ClanContribution_MDWN));
        }
        private void ClanContributionButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.ClanContributionButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ClanContribution_MEN));
        }
        private void ClanContributionButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ClanContribution));
            form1.textBox8.Text = "Clan Contribution";
        }

        //CHARACTER SEAL
        private void CharacterSealButton_MouseEnter(object sender, EventArgs e)
        {
            this.CharacterSealButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.CharacterSealSc_MEN));
        }
        private void CharacterSealButton_MouseLeave(object sender, EventArgs e)
        {
            this.CharacterSealButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.CharacterSealSc));
            esyaKontrolLabel.Text = "1";
        }
        private void CharacterSealButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.CharacterSealButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.CharacterSealSc_MDWN));
        }
        private void CharacterSealButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.CharacterSealButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.CharacterSealSc_MEN));
        }
        private void CharacterSealButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.CharacterSealSc));
            form1.textBox8.Text = "Character Seal Scroll";
        }

        //REDISTRIBUTION
        private void RedistributionButton_MouseEnter(object sender, EventArgs e)
        {
            this.RedistributionButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.RedistributionItem_MEN));
        }
        private void RedistributionButton_MouseLeave(object sender, EventArgs e)
        {
            this.RedistributionButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.RedistributionItem));
            esyaKontrolLabel.Text = "1";
        }
        private void RedistributionButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.RedistributionButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.RedistributionItem_MDWN));
        }
        private void RedistributionButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.RedistributionButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.RedistributionItem_MEN));
        }
        private void RedistributionButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.RedistributionItem));
            form1.textBox8.Text = "Redistribution Item";
        }

        //ANCIENT TEXT
        private void AncientTextButton_MouseEnter(object sender, EventArgs e)
        {
            this.AncientTextButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.AncientText_MEN));
        }
        private void AncientTextButton_MouseLeave(object sender, EventArgs e)
        {
            this.AncientTextButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.AncientText));
            esyaKontrolLabel.Text = "1";
        }
        private void AncientTextButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.AncientTextButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.AncientText_MDWN));
        }
        private void AncientTextButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.AncientTextButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.AncientText_MEN));
        }
        private void AncientTextButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.AncientText));
            form1.textBox8.Text = "Ancient Text";
        }

        //CHAOS COUPON
        private void ChaosCouponButton_MouseEnter(object sender, EventArgs e)
        {
            this.ChaosCouponButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ChaosCoupon_MEN));
        }
        private void ChaosCouponButton_MouseLeave(object sender, EventArgs e)
        {
            this.ChaosCouponButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ChaosCoupon));
            esyaKontrolLabel.Text = "1";
        }
        private void ChaosCouponButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.ChaosCouponButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ChaosCoupon_MDWN));
        }
        private void ChaosCouponButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.ChaosCouponButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ChaosCoupon_MEN));
        }
        private void ChaosCouponButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ChaosCoupon));
            form1.textBox8.Text = "Chaos Map Coupon";
        }

        //TELEPORTATION SC
        private void TeleportationButton_MouseEnter(object sender, EventArgs e)
        {
            this.TeleportationButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.TeleportationItem_MEN));
        }
        private void TeleportationButton_MouseLeave(object sender, EventArgs e)
        {
            this.TeleportationButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.TeleportationItem));

        }
        private void TeleportationButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.TeleportationButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.TeleportationItem_MDWN));
        }
        private void TeleportationButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.TeleportationButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.TeleportationItem_MEN));
        }
        private void TeleportationButton_Click(object sender, EventArgs e)
        {
            kararButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.TeleportationItem));
            form1.textBox8.Text = "Teleportation Item";
        }
        




    }
}
