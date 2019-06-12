using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES_Encryption
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_encription_Click(object sender, EventArgs e)
        {
            // encription button click
            string plaintext = txt_plaintext.Text;
            string key = txt_key.Text;
            var radioButtons = groupBox1.Controls.OfType<RadioButton>();
            if (plaintext != "")
            {
                if (key.Length == 16)
                {
                    foreach (RadioButton rdb in radioButtons)
                    {
                        if (rdb.Checked == true)
                        {
                            // Switch the radio buttons of AES Types
                            switch (rdb.Name)
                            {
                                case "radioBtn_ECB":
                                    txt_plaintext.Text = AES.ECB_Encryption(plaintext, key);
                                    break;
                                case "radioBtn_CBC":
                                    txt_plaintext.Text = AES.CBC_Encryption(plaintext, key);
                                    break;
                                case "radioBtn_CFB":
                                    txt_plaintext.Text = AES.CFB_Encryption(plaintext, key);
                                    break;
                            }
                        }
                    }

                }
                else MessageBox.Show("Please Add Your Correct Encription Key");
            }
            else MessageBox.Show("Please Add Your Text");
        }

        private void btn_decryption_Click(object sender, EventArgs e)
        {
            // decryption button click
            string plaintext = txt_plaintext.Text;
            string key = txt_key.Text;
            var radioButtons = groupBox1.Controls.OfType<RadioButton>();
            if (plaintext != "")
            {
                if (key != "" && key.Length == 16)
                {
                    foreach (RadioButton rdb in radioButtons)
                    {
                        if (rdb.Checked == true)
                        {
                            // Switch the radio buttons of AES Types
                            switch (rdb.Name)
                            {
                                case "radioBtn_ECB":
                                    txt_plaintext.Text = AES.ECB_Decryption(plaintext, key);
                                    break;
                                case "radioBtn_CBC":
                                    txt_plaintext.Text = AES.CBC_Decryption(plaintext, key);
                                    break;
                                case "radioBtn_CFB":
                                    txt_plaintext.Text = AES.CFB_Decryption(plaintext, key);
                                    break;
                            }
                        }
                    }

                }
                else MessageBox.Show("Please Add Your Correct Encription Key");
            }
            else MessageBox.Show("Please Add Your Text");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            // clear all input text boxs
            txt_key.Clear();
            txt_plaintext.Clear();
        }
    }
}
