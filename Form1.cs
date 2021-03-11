using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        string key;
        public Form1()
        {
            InitializeComponent();
            VKey.Hide();
            
            VigenereEncrypt.Hide();
          
            VegenereDecrypt.Hide();
            Vigenere_Cipher_heading.Hide();
            Play_fair_cipher_heading.Hide();
            RemoveAlpha.Hide();
            Alphabet_remove.Hide();
            substitutionCipherHeading.Hide();
            button1.Show();
            button2.Show();
            playfair_decrypt.Hide();
            Playfair_Encrypt.Hide();
            VegenereDecrypt.Hide();
            Substitution_Encrypt_button.Hide();
            Substitution_Decrypt_Button.Hide();
            VigenereEncrypt.Hide();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CT_Encrypt_text.Clear();
            
            string PT_Encrypt, CT_Encrypt;
            
            PT_Encrypt = PT_Encrypt_text.Text.ToUpper();
            key = Key.Text;
            PT_Encrypt = PT_Encrypt.Replace(" ", "");
            int len = PT_Encrypt.Length;
            char[] CTchars = new char[len];
            for (int i = 0; i < len; i++)
            {
                //char PTE = PT_Encrypt[i];
                int PTE;
                int CTE;
                PTE = ((int)PT_Encrypt[i] - 65) + Int32.Parse(key);
                CTE = (PTE % 26) + 65;
                CTchars[i] = (char)CTE;

            }
            CT_Encrypt = new string(CTchars);
            CT_Encrypt_text.Text += CT_Encrypt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PT_Decrypt_text.Clear();
            string PT_Decrypt, CT_Decrypt;
            CT_Decrypt = CT_Decrypt_text.Text.ToUpper();
            key = Key.Text;
            CT_Decrypt = CT_Decrypt.Replace(" ", "");
            int len = CT_Decrypt.Length;
            char[] CTchars = new char[len];
            for (int i = 0; i < len; i++)
            {
                //char PTE = PT_Encrypt[i];
                int PTD;
                int CTD;
                CTD = ((int)CT_Decrypt[i] - 65) - Int32.Parse(key);
                PTD = (CTD % 26);
                if (PTD < 0)
                {
                    PTD = 26 - (-PTD);
                }
                PTD = PTD + 65;
                CTchars[i] = (char)PTD;
            }
            PT_Decrypt = new string(CTchars);
            PT_Decrypt_text.Text += PT_Decrypt;
        }

        private void Key_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Key_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar);
        }

        private void CT_Shift_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || !(char.IsLetter(e.KeyChar));
        }

        private void PT_Decrypt_shift_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || !(char.IsLetter(e.KeyChar));
        }

        private void CT_Shift_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Key.Show();
            label5.Show();
            Key.Clear();
            PT_Encrypt_text.Clear();
            CT_Encrypt_text.Clear();
            CT_Decrypt_text.Clear();
            PT_Decrypt_text.Clear();
            playfair_decrypt.Hide();
            Playfair_Encrypt.Hide();
            RemoveAlpha.Hide();
            Alphabet_remove.Hide();
            PT_Encrypt_text.Show();
            CT_Encrypt_text.Show();
            button1.Show();
            CT_Decrypt_text.Show();
            PT_Decrypt_text.Show();
            button2.Show();
            VKey.Hide();
            button1.Show();
            VegenereDecrypt.Hide();
            VigenereEncrypt.Hide();
            button2.Show();
            
            Vigenere_Cipher_heading.Hide();
            Shift_Cipher_heading.Show();
            substitutionCipherHeading.Hide();
            Substitution_Encrypt_button.Hide();
            Substitution_Decrypt_Button.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Key.Hide();
            label5.Show();
            VKey.Clear();
            PT_Encrypt_text.Clear();
            CT_Encrypt_text.Clear();
            CT_Decrypt_text.Clear();
            PT_Decrypt_text.Clear();
            button2.Hide();
            button1.Hide();
            Playfair_Encrypt.Hide();
            playfair_decrypt.Hide();
            RemoveAlpha.Hide();
            Alphabet_remove.Hide();
            button1.Hide();
           
            button2.Hide();
            VKey.Show();
            
            VigenereEncrypt.Show();
           
            VegenereDecrypt.Show();
            Shift_Cipher_heading.Hide();
            Vigenere_Cipher_heading.Show();
            Play_fair_cipher_heading.Hide();
            substitutionCipherHeading.Hide();
        }

        private void VKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void VKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar);
        }

        private void VigenereEncrypt_Click(object sender, EventArgs e)
        {
            CT_Encrypt_text.Clear();

            string PT_Encrypt, CT_Encrypt;

            PT_Encrypt = PT_Encrypt_text.Text.ToUpper();
            key = VKey.Text.ToUpper();
            key = key.Replace(" ", "");
            PT_Encrypt = PT_Encrypt.Replace(" ", "");
            int len = PT_Encrypt.Length;
            char[] CTchars = new char[len];
            for (int i = 0; i < len; i++)
            {
                //char PTE = PT_Encrypt[i];
                int PTE;
                int K;
                int CTE;
                K = ((int)key[i] - 65);
                PTE = ((int)PT_Encrypt[i] - 65) + K;
                CTE = (PTE % 26) + 65;
                CTchars[i] = (char)CTE;

            }
            CT_Encrypt = new string(CTchars);
            CT_Encrypt_text.Text += CT_Encrypt;
        }

        private void VegenereDecrypt_Click(object sender, EventArgs e)
        {
            PT_Decrypt_text.Clear();
            string PT_Decrypt, CT_Decrypt;
            CT_Decrypt = CT_Decrypt_text.Text.ToUpper();
            key = VKey.Text.ToUpper();
            key = key.Replace(" ", "");
            CT_Decrypt = CT_Decrypt.Replace(" ", "");
            int len = CT_Decrypt.Length;
            char[] CTchars = new char[len];
            for (int i = 0; i < len; i++)
            {
                //char PTE = PT_Encrypt[i];
                int PTD;
                int K;
                int CTD;
                K = ((int)key[i] - 65);
                CTD = ((int)CT_Decrypt[i] - 65) - K;
                PTD = (CTD % 26);
                if (PTD < 0)
                {
                    PTD = 26 - (-PTD);
                }
                PTD = PTD + 65;
                CTchars[i] = (char)PTD;
            }
            PT_Decrypt = new string(CTchars);
            PT_Decrypt_text.Text += PT_Decrypt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void VCTDecrypt_TextChanged(object sender, EventArgs e)
        {

        }

        private void VPTDecrypt_TextChanged(object sender, EventArgs e)
        {

        }

        private void VCTEncrypt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PT_Decrypt_shift_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CT_Decrypt_shift_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VPTEncrypt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Key.Hide();
            label5.Show();
            VKey.Clear();
            PT_Encrypt_text.Clear();
            CT_Encrypt_text.Clear();
            CT_Decrypt_text.Clear();
            PT_Decrypt_text.Clear();
            Playfair_Encrypt.Show();
            playfair_decrypt.Show();
            VKey.Show();
            button2.Hide();
            VigenereEncrypt.Hide();
            VegenereDecrypt.Hide();
            Play_fair_cipher_heading.Show();
            button1.Hide();
            RemoveAlpha.Show();
            Alphabet_remove.Show();
            Shift_Cipher_heading.Hide();
            Vigenere_Cipher_heading.Hide();
            substitutionCipherHeading.Hide();
        }

        private void Playfair_Encrypt_Click(object sender, EventArgs e)
        {
            CT_Encrypt_text.Clear();
            string[] pairs = new string[50];
            key = VKey.Text.ToUpper();
            char removed_alpha = Convert.ToChar(Alphabet_remove.Text.ToUpper());
            
            string PT = PT_Encrypt_text.Text;
            PT = PT.ToUpper();
            key = key.Replace(" ", "");
            PT = PT.Replace(" ", "");
           // PT = PT.Replace(removed_alpha, 'I');
            //add X betweem same alphabets
            for (int i = 0; i < PT.Length; i++)
            {
                if (i + 1 < PT.Length && PT[i] == PT[i + 1])
                {
                    PT = PT.Insert(i + 1, "X");
                }
            }
            Console.WriteLine(PT);
            int l = 0;
            string alphas;
            //Adding X in the end of alphabet and pair each alphabet
            for (int i = 0; i < PT.Length; i++)
            {
                if (i + 1 > PT.Length - 1)
                {
                    alphas = Convert.ToString(PT[i]) + "X";
                    pairs[l] = alphas;
                    break;
                }
                else
                {
                    alphas = Convert.ToString(PT[i]) + Convert.ToString(PT[i + 1]);
                    pairs[l] = alphas;
                    i++;
                    l++;
                }
            }
            //making table
            int m = 0, p = 0;
            char[,] T = new char[5, 5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 5; j++)
                {
                    if (m < key.Length)
                    {
                        T[i, j] = key[m];

                        //check
                        for (int k = 0; k <= i; k++)
                        {
                            for (int o = 0; o < 5; o++)
                            {
                                if (m + 1 < key.Length && key[m + 1] == T[k, o])
                                {
                                    key = key.Remove(m + 1, 1);
                                    k = 0;
                                    o = 0;
                                }
                            }
                        }
                        m++;
                    }
                    else
                    {
                        char alpha = Convert.ToChar(65 + p);
                        int z = 0;
                        while (z <= key.Length / 4)
                        {
                            for (int k = 0; k < 5; k++)
                            {
                                if (T[z, k] == alpha || alpha == removed_alpha)
                                {
                                    p++;
                                    alpha = Convert.ToChar(65 + p);
                                    k = -1;
                                    z = 0;
                                }
                            }
                            z++;
                        }
                        T[i, j] = Convert.ToChar(65 + p);
                        p++;
                    }
                    Console.Write(T[i, j]);
                }
            }

            string[] CT = new string[PT.Length + 1];
            int x = 0;

            //convert into CT

            for (int i = 0; i < PT.Length; i++)
            {
                string PT_pair = pairs[i];
                if (PT_pair == null)
                {
                    break;
                }
                char ptAlpha = PT_pair[0];
                for (int q = 0; q < 5; q++)
                {
                    for (int w = 0; w < 5; w++)
                    {
                        if (T[q, w] == ptAlpha)
                        {
                            ptAlpha = PT_pair[1];
                            for (int t = 0; t < 5; t++)
                            {
                                for (int y = 0; y < 5; y++)
                                {
                                    if (T[t, y] == ptAlpha && q != t && w != y)
                                    {
                                        CT[x] = Convert.ToString(T[q, y]);
                                        x++;
                                        CT[x] = Convert.ToString(T[t, w]);
                                        x++;
                                        goto Break;
                                    }
                                    else if (T[t, y] == ptAlpha && q == t)
                                    {
                                       
                                        if (w + 1 > 4)
                                        {
                                            CT[x] = Convert.ToString(T[q, 0]);
                                            x++;
                                        }
                                        else
                                        {
                                            CT[x] = Convert.ToString(T[q, w + 1]);
                                            x++;
                                        }
                                        if (y + 1 > 4)
                                        {
                                            CT[x] = Convert.ToString(T[t, 0]);
                                            x++;
                                        }
                                        else
                                        {
                                            CT[x] = Convert.ToString(T[t, y + 1]);
                                            x++;
                                        }
                                        goto Break;
                                    }
                                    else if (T[t, y] == ptAlpha && w == y)
                                    {
                                        if (q + 1 > 4)
                                        {
                                            CT[x] = Convert.ToString(T[0, w]);
                                            x++;
                                        }
                                        else
                                        {
                                            CT[x] = Convert.ToString(T[q + 1, w]);
                                            x++;
                                        }
                                        if (t + 1 > 4)
                                        {
                                            CT[x] = Convert.ToString(T[0, y]);
                                            x++;
                                        }
                                        else
                                        {
                                            CT[x] = Convert.ToString(T[t + 1, y]);
                                            x++;
                                        }
                                        goto Break;
                                    }
                                }
                            }
                        }
                    }
                }
            Break:
                Console.Read();
            }
            //string CT_Encrypt_playfair;
            for (int i = 0; i < CT.Length; i++)
            {
                CT_Encrypt_text.Text += Convert.ToString(CT[i]);
            }
                 
        }

        private void Alphabet_remove_TextChanged(object sender, EventArgs e)
        {

        }

        private void Alphabet_remove_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void playfair_decrypt_Click(object sender, EventArgs e)
        {
            PT_Decrypt_text.Clear();
            string[] pairs = new string[50];
            key = VKey.Text.ToUpper();
            char removed_alpha = Convert.ToChar(Alphabet_remove.Text.ToUpper());

            string CT =CT_Decrypt_text.Text;
            CT = CT.ToUpper();
            key = key.Replace(" ", "");
            CT = CT.Replace(" ", "");
            CT = CT.Replace(removed_alpha, 'I');
            //add X betweem same alphabets
            for (int i = 0; i < CT.Length; i++)
            {
                if (i + 1 < CT.Length && CT[i] == CT[i + 1])
                {
                    CT = CT.Insert(i + 1, "X");
                }
            }
            Console.WriteLine(CT);
            int l = 0;
            string alphas;
            //Adding X in the end of alphabet and pair each alphabet
            for (int i = 0; i < CT.Length; i++)
            {
                if (i + 1 > CT.Length - 1)
                {
                    alphas = Convert.ToString(CT[i]) + "X";
                    pairs[l] = alphas;
                    break;
                }
                else
                {
                    alphas = Convert.ToString(CT[i]) + Convert.ToString(CT[i + 1]);
                    pairs[l] = alphas;
                    i++;
                    l++;
                }
            }
            //making table
            int m = 0, p = 0;
            char[,] T = new char[5, 5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 5; j++)
                {
                    if (m < key.Length)
                    {
                        T[i, j] = key[m];

                        //check
                        for (int k = 0; k <= i; k++)
                        {
                            for (int o = 0; o < 5; o++)
                            {
                                if (m + 1 < key.Length && key[m + 1] == T[k, o])
                                {
                                    key = key.Remove(m + 1, 1);
                                    k = 0;
                                    o = 0;
                                }
                            }
                        }
                        m++;
                    }
                    else
                    {
                        char alpha = Convert.ToChar(65 + p);
                        int z = 0;
                        while (z <= key.Length / 4)
                        {
                            for (int k = 0; k < 5; k++)
                            {
                                if (T[z, k] == alpha || alpha == removed_alpha)
                                {
                                    p++;
                                    alpha = Convert.ToChar(65 + p);
                                    k = -1;
                                    z = 0;
                                }
                            }
                            z++;
                        }
                        T[i, j] = Convert.ToChar(65 + p);
                        p++;
                    }
                    
                }
            }

            string[] PTT = new string[CT.Length + 1];
            int x = 0;

            //convert into CT

            for (int i = 0; i < CT.Length; i++)
            {
                string PT_pair = pairs[i];
                if (PT_pair == null)
                {
                    break;
                }
                char ptAlpha = PT_pair[0];
                for (int q = 0; q < 5; q++)
                {
                    for (int w = 0; w < 5; w++)
                    {
                        if (T[q, w] == ptAlpha)
                        {
                            ptAlpha = PT_pair[1];
                            for (int t = 0; t < 5; t++)
                            {
                                for (int y = 0; y < 5; y++)
                                {
                                    
                                    if (T[t, y] == ptAlpha && q != t && w != y)
                                    {
                                        PTT[x] = Convert.ToString(T[q, y]);
                                        x++;
                                        PTT[x] = Convert.ToString(T[t, w]);
                                        x++;
                                        goto Break;
                                    }
                                    else if (T[t, y] == ptAlpha && q == t)
                                    {

                                        if (w - 1 < 0)
                                        {
                                            PTT[x] = Convert.ToString(T[q, 4]);
                                            x++;
                                        }
                                        else
                                        {
                                            PTT[x] = Convert.ToString(T[q, w - 1]);
                                            x++;
                                        }
                                        if (y - 1 < 0)
                                        {
                                            PTT[x] = Convert.ToString(T[t, 4]);
                                            x++;
                                        }
                                        else
                                        {
                                            PTT[x] = Convert.ToString(T[t, y - 1]);
                                            x++;
                                        }
                                        goto Break;
                                    }
                                    else if (T[t, y] == ptAlpha && w == y)
                                    {
                                        if (q - 1 < 0)
                                        {
                                            PTT[x] = Convert.ToString(T[4, w]);
                                            x++;
                                        }
                                        else
                                        {
                                            PTT[x] = Convert.ToString(T[q - 1, w]);
                                            x++;
                                        }
                                        if (t - 1 < 0)
                                        {
                                            PTT[x] = Convert.ToString(T[4, y]);
                                            x++;
                                        }
                                        else
                                        {
                                            PTT[x] = Convert.ToString(T[t - 1, y]);
                                            x++;

                                            char AA = T[t - 1, y]; 
                                        }
                                        goto Break;
                                    }
                                }
                            }
                        }
                    }
                }
            Break:
                Console.Read();
            }
            //string CT_Encrypt_playfair;
            for (int i = 0; i < PTT.Length; i++)
            {
                //string aaa = PTT[i];
                //if (PTT[i] == "I")
                //{
                //    PTT[i] = PTT[i].Replace('I', removed_alpha);
                //}
                PT_Decrypt_text.Text += Convert.ToString(PTT[i]);
            }
                 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VKey.Hide();
            Key.Hide();
            label5.Hide();
            Substitution_Encrypt_button.Show();
            Substitution_Decrypt_Button.Show();
            
            Alphabet_remove.Hide();
            RemoveAlpha.Hide();
            PT_Encrypt_text.Clear();
            CT_Encrypt_text.Clear();
            CT_Decrypt_text.Clear();
            PT_Decrypt_text.Clear();
            substitutionCipherHeading.Show();
            button1.Hide();
            button2.Hide();
            VigenereEncrypt.Hide();
            VegenereDecrypt.Hide();
            Playfair_Encrypt.Hide();
            playfair_decrypt.Hide();
            Alphabet_remove.Hide();
            Shift_Cipher_heading.Hide();
            Vigenere_Cipher_heading.Hide();
            Play_fair_cipher_heading.Hide();
            RemoveAlpha.Hide();
        }

        private void Playfair_Encrypt_MouseHover(object sender, EventArgs e)
        {
            this.Playfair_Encrypt.ForeColor = System.Drawing.Color.DarkRed;
            this.Playfair_Encrypt.BackColor = System.Drawing.Color.White;
        }

        private void Playfair_Encrypt_MouseLeave(object sender, EventArgs e)
        {
            this.Playfair_Encrypt.ForeColor = System.Drawing.Color.White;
            this.Playfair_Encrypt.BackColor = System.Drawing.Color.DarkRed;
        }

        private void playfair_decrypt_MouseHover(object sender, EventArgs e)
        {
            this.playfair_decrypt.ForeColor = System.Drawing.Color.DarkRed;
            this.playfair_decrypt.BackColor = System.Drawing.Color.White;
        }

        private void playfair_decrypt_MouseLeave(object sender, EventArgs e)
        {
            this.playfair_decrypt.ForeColor = System.Drawing.Color.White;
            this.playfair_decrypt.BackColor = System.Drawing.Color.DarkRed;
        }

        private void Substitution_Encrypt_button_Click(object sender, EventArgs e)
        {
            CT_Encrypt_text.Clear();
            string PT = PT_Encrypt_text.Text.ToUpper();
            char[] CT = new char[PT.Length];
            for (int i = 0; i < PT.Length; i++)
            {
                if (PT[i] == 'A')
                    CT[i] = 'X';
                else if (PT[i] == 'B')
                    CT[i] = 'D';
                else if (PT[i] == 'C')
                    CT[i] = 'G';
                else if (PT[i] == 'D')
                    CT[i] = 'S';
                else if (PT[i] == 'E')
                    CT[i] = 'Z';
                else if (PT[i] == 'F')
                    CT[i] = 'A';
                else if (PT[i] == 'G')
                    CT[i] = 'N';
                else if (PT[i] == 'H')
                    CT[i] = 'Y';
                else if (PT[i] == 'I')
                    CT[i] = 'O';
                else if (PT[i] == 'J')
                    CT[i] = 'B';
                else if (PT[i] == 'K')
                    CT[i] = 'T';
                else if (PT[i] == 'L')
                    CT[i] = 'M';
                else if (PT[i] == 'M')
                    CT[i] = 'J';
                else if (PT[i] == 'N')
                    CT[i] = 'C';
                else if (PT[i] == 'O')
                    CT[i] = 'E';
                else if (PT[i] == 'P')
                    CT[i] = 'V';
                else if (PT[i] == 'Q')
                    CT[i] = 'F';
                else if (PT[i] == 'R')
                    CT[i] = 'H';
                else if (PT[i] == 'S')
                    CT[i] = 'K';
                else if (PT[i] == 'T')
                    CT[i] = 'W';
                else if (PT[i] == 'U')
                    CT[i] = 'P';
                else if (PT[i] == 'V')
                    CT[i] = 'L';
                else if (PT[i] == 'W')
                    CT[i] = 'Q';
                else if (PT[i] == 'X')
                    CT[i] = 'U';
                else if (PT[i] == 'Y')
                    CT[i] = 'R';
                else if (PT[i] == 'Z')
                    CT[i] = 'I';
            }
            for (int i = 0; i < CT.Length; i++)
            {
                CT_Encrypt_text.Text += Convert.ToString(CT[i]);
            }
            
            }

        private void Substitution_Decrypt_Button_Click(object sender, EventArgs e)
        {
            PT_Decrypt_text.Clear();
            string PT = CT_Decrypt_text.Text.ToUpper();
            char[] CT = new char[PT.Length];
            for (int i = 0; i < PT.Length; i++)
            {
                if (PT[i] == 'X')
                    CT[i] = 'A';
                else if (PT[i] == 'D')
                    CT[i] = 'B';
                else if (PT[i] == 'G')
                    CT[i] = 'C';
                else if (PT[i] == 'S')
                    CT[i] = 'D';
                else if (PT[i] == 'Z')
                    CT[i] = 'E';
                else if (PT[i] == 'A')
                    CT[i] = 'F';
                else if (PT[i] == 'N')
                    CT[i] = 'G';
                else if (PT[i] == 'Y')
                    CT[i] = 'H';
                else if (PT[i] == 'O')
                    CT[i] = 'I';
                else if (PT[i] == 'B')
                    CT[i] = 'J';
                else if (PT[i] == 'T')
                    CT[i] = 'K';
                else if (PT[i] == 'M')
                    CT[i] = 'L';
                else if (PT[i] == 'J')
                    CT[i] = 'M';
                else if (PT[i] == 'C')
                    CT[i] = 'N';
                else if (PT[i] == 'E')
                    CT[i] = 'O';
                else if (PT[i] == 'V')
                    CT[i] = 'P';
                else if (PT[i] == 'F')
                    CT[i] = 'Q';
                else if (PT[i] == 'H')
                    CT[i] = 'R';
                else if (PT[i] == 'K')
                    CT[i] = 'S';
                else if (PT[i] == 'W')
                    CT[i] = 'T';
                else if (PT[i] == 'P')
                    CT[i] = 'U';
                else if (PT[i] == 'L')
                    CT[i] = 'V';
                else if (PT[i] == 'Q')
                    CT[i] = 'W';
                else if (PT[i] == 'U')
                    CT[i] = 'X';
                else if (PT[i] == 'R')
                    CT[i] = 'Y';
                else if (PT[i] == 'I')
                    CT[i] = 'Z';
            }
            for (int i = 0; i < CT.Length; i++)
            {
                PT_Decrypt_text.Text += Convert.ToString(CT[i]);
            }
        }
    }
}
