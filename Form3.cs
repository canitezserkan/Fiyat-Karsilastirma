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
    public partial class Form3 : Form
    {

        private SoundPlayer _soundPlayerRepair;
        public Form1 form1;    //BU KISIM VALUE AKTARMAK İÇİN KULLANILDI

        public Form3(Form1 form_1)   //BU KISMIN İÇİ NORMALDE BOŞ AMA VALUE AKTARMAK İÇİN KULLANILDI
        {
            _soundPlayerRepair = new SoundPlayer(FiyatKarsilastir.Properties.Resources.ui_repair);

            InitializeComponent();

                            form1 = form_1;            //BU KISIM VALUE AKTARMAK İÇİN KULLANILDI. 
            //AYRICA FORM1'İN DESIGNER'INA GİRİLİP TEXTBOX8 PUBLİC HALE GETİRİLDİ
            //Kİ İÇİNE BAŞKA FORMLARDAN VERİ EKLENEBİLSİN.


            maxComboBox.Items.Add("Evet");
            maxComboBox.Items.Add("Hayır");
            maxComboBox.SelectedIndex = 0;

            arkaplanComboBox.Items.Add("Merchant");
            arkaplanComboBox.Items.Add("Deva Bird");
            arkaplanComboBox.Items.Add("Female Warrior");
            arkaplanComboBox.Items.Add("Knight Online");
            arkaplanComboBox.SelectedIndex = 0;


        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //AYARLAR BUTONUNA TIKLANDIĞINDA FORM1'DEN, FORM1'İN ARKAPLANI NE İSE, AYARLAR KISMINDAKİ
            //ARKAPLAN SEÇENEKLERİNDEN O AN KULLANILAN ARKAPLANI SEÇİLİ HALDE GÖSTERİYOR COMBOBOX.
            #region
            if (form1.arkaplanLabel.Text == "Merchant")
            {
                arkaplanComboBox.SelectedIndex = 0;
            }
            else
                if (form1.arkaplanLabel.Text == "Deva Bird")
                {
                    arkaplanComboBox.SelectedIndex = 1;
                }
                else
                    if (form1.arkaplanLabel.Text == "Female Warrior")
                    {
                        arkaplanComboBox.SelectedIndex = 2;
                    }
                    else
                        if (form1.arkaplanLabel.Text == "Knight Online")
                        {
                            arkaplanComboBox.SelectedIndex = 3;
                        }
            #endregion

            if (form1.maxKontrolLabel.Text == "Pasif")
            {
                maxComboBox.SelectedIndex = 1;
            }
            else 
            {
                maxComboBox.SelectedIndex = 0;
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if(maxComboBox.SelectedIndex == 1)
            {
                form1.maxKontrolLabel.Text = "Pasif";
            }

            if (maxComboBox.SelectedIndex == 0)
            {
                form1.maxKontrolLabel.Text = "Aktif";
            }
            
            
            //BU KISIMDA, ARKAPLAN SEÇİMİNİ SAĞLAYAN COMBOBOX'IN ÇALIŞMASINI DÜZENLİYORUZ. GEREKLİ RESİMLERİ EŞLEŞTİRİYOR.
            #region
            if (arkaplanComboBox.Text == "Knight Online")
            {
            form1.BackgroundImage = FiyatKarsilastir.Properties.Resources.background_knightOnline;
            form1.menuStrip1.BackgroundImage = FiyatKarsilastir.Properties.Resources.background_knightOnline_menu_strip;
            form1.arkaplanLabel.Text = "Knight Online";
            }
            if (arkaplanComboBox.Text == "Female Warrior")
            {
                form1.BackgroundImage = FiyatKarsilastir.Properties.Resources.background_femaleWarrior;
                form1.menuStrip1.BackgroundImage = FiyatKarsilastir.Properties.Resources.background_femaleWarrior_menu_strip;
                form1.arkaplanLabel.Text = "Female Warrior";
            }
            if (arkaplanComboBox.Text == "Deva Bird")
            {
                form1.BackgroundImage = FiyatKarsilastir.Properties.Resources.background_devaBird;
                form1.menuStrip1.BackgroundImage = FiyatKarsilastir.Properties.Resources.background_devaBird_menu_strip;
                form1.arkaplanLabel.Text = "Deva Bird";
            }
            if (arkaplanComboBox.Text == "Merchant")
            {
                form1.arkaplanLabel.Text = "Merchant";
                form1.BackgroundImage = FiyatKarsilastir.Properties.Resources.background_merchant;
                form1.menuStrip1.BackgroundImage = FiyatKarsilastir.Properties.Resources.background_merchant_menu_strip;
            }
            #endregion

            _soundPlayerRepair.Play();

            this.Close();
        }

        private void arkaplanComboBox_TextChanged(object sender, EventArgs e)
        {
            if (arkaplanComboBox.Text != "Merchant")
            {
                maxComboBox.SelectedIndex = 1;
                maxComboBox.Enabled = false;
            }
            else
            {
                maxComboBox.Enabled = true;
                maxComboBox.SelectedIndex = 0;
            }
        }

        private void maxComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(maxComboBox.SelectedIndex == 1)
            {
                form1.maxKontrolLabel.Text = "Pasif";
            }
        }

        
    }
}
