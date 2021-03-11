namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PT_Encrypt_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CT_Encrypt_text = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PT_Decrypt_text = new System.Windows.Forms.TextBox();
            this.CT_Decrypt_text = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Key = new System.Windows.Forms.TextBox();
            this.VKey = new System.Windows.Forms.TextBox();
            this.VigenereEncrypt = new System.Windows.Forms.Button();
            this.VegenereDecrypt = new System.Windows.Forms.Button();
            this.Shift_Cipher_heading = new System.Windows.Forms.Label();
            this.Vigenere_Cipher_heading = new System.Windows.Forms.Label();
            this.Play_fair_cipher_heading = new System.Windows.Forms.Label();
            this.Playfair_Encrypt = new System.Windows.Forms.Button();
            this.playfair_decrypt = new System.Windows.Forms.Button();
            this.RemoveAlpha = new System.Windows.Forms.Label();
            this.Alphabet_remove = new System.Windows.Forms.TextBox();
            this.substitutionCipherHeading = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Substitution_Encrypt_button = new System.Windows.Forms.Button();
            this.Substitution_Decrypt_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PT_Encrypt_text
            // 
            this.PT_Encrypt_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PT_Encrypt_text.Location = new System.Drawing.Point(217, 287);
            this.PT_Encrypt_text.Margin = new System.Windows.Forms.Padding(4);
            this.PT_Encrypt_text.Multiline = true;
            this.PT_Encrypt_text.Name = "PT_Encrypt_text";
            this.PT_Encrypt_text.Size = new System.Drawing.Size(751, 49);
            this.PT_Encrypt_text.TabIndex = 0;
            this.PT_Encrypt_text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plain Text:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CT_Encrypt_text
            // 
            this.CT_Encrypt_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CT_Encrypt_text.Location = new System.Drawing.Point(217, 343);
            this.CT_Encrypt_text.Multiline = true;
            this.CT_Encrypt_text.Name = "CT_Encrypt_text";
            this.CT_Encrypt_text.Size = new System.Drawing.Size(751, 49);
            this.CT_Encrypt_text.TabIndex = 2;
            this.CT_Encrypt_text.TextChanged += new System.EventHandler(this.CT_Shift_TextChanged);
            this.CT_Encrypt_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CT_Shift_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(773, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "ENCRYPT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(773, 634);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 54);
            this.button2.TabIndex = 9;
            this.button2.Text = "DECRYPT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PT_Decrypt_text
            // 
            this.PT_Decrypt_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PT_Decrypt_text.Location = new System.Drawing.Point(217, 574);
            this.PT_Decrypt_text.Multiline = true;
            this.PT_Decrypt_text.Name = "PT_Decrypt_text";
            this.PT_Decrypt_text.Size = new System.Drawing.Size(751, 49);
            this.PT_Decrypt_text.TabIndex = 7;
            this.PT_Decrypt_text.TextChanged += new System.EventHandler(this.PT_Decrypt_shift_TextChanged);
            this.PT_Decrypt_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PT_Decrypt_shift_KeyPress);
            // 
            // CT_Decrypt_text
            // 
            this.CT_Decrypt_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CT_Decrypt_text.Location = new System.Drawing.Point(217, 506);
            this.CT_Decrypt_text.Multiline = true;
            this.CT_Decrypt_text.Name = "CT_Decrypt_text";
            this.CT_Decrypt_text.Size = new System.Drawing.Size(751, 49);
            this.CT_Decrypt_text.TabIndex = 5;
            this.CT_Decrypt_text.TextChanged += new System.EventHandler(this.CT_Decrypt_shift_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(35, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(228, 58);
            this.button3.TabIndex = 11;
            this.button3.Text = "Shift Cipher";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkRed;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(281, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(239, 58);
            this.button4.TabIndex = 12;
            this.button4.Text = "Vigenere Cipher";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkRed;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(526, 24);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(248, 58);
            this.button5.TabIndex = 13;
            this.button5.Text = "Play Fair Cipher";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkRed;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(780, 24);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(251, 57);
            this.button6.TabIndex = 14;
            this.button6.Text = "Substitution Cipher";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(154, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 42);
            this.label5.TabIndex = 15;
            this.label5.Text = "Key:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Key
            // 
            this.Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Key.Location = new System.Drawing.Point(269, 214);
            this.Key.Multiline = true;
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(609, 49);
            this.Key.TabIndex = 16;
            this.Key.TextChanged += new System.EventHandler(this.Key_TextChanged);
            this.Key.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_KeyPress);
            // 
            // VKey
            // 
            this.VKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VKey.Location = new System.Drawing.Point(269, 214);
            this.VKey.Multiline = true;
            this.VKey.Name = "VKey";
            this.VKey.Size = new System.Drawing.Size(609, 49);
            this.VKey.TabIndex = 17;
            this.VKey.TextChanged += new System.EventHandler(this.VKey_TextChanged);
            this.VKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VKey_KeyPress);
            // 
            // VigenereEncrypt
            // 
            this.VigenereEncrypt.BackColor = System.Drawing.Color.DarkRed;
            this.VigenereEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VigenereEncrypt.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VigenereEncrypt.ForeColor = System.Drawing.Color.White;
            this.VigenereEncrypt.Location = new System.Drawing.Point(773, 404);
            this.VigenereEncrypt.Name = "VigenereEncrypt";
            this.VigenereEncrypt.Size = new System.Drawing.Size(195, 54);
            this.VigenereEncrypt.TabIndex = 20;
            this.VigenereEncrypt.Text = "ENCRYPT";
            this.VigenereEncrypt.UseVisualStyleBackColor = false;
            this.VigenereEncrypt.Click += new System.EventHandler(this.VigenereEncrypt_Click);
            // 
            // VegenereDecrypt
            // 
            this.VegenereDecrypt.BackColor = System.Drawing.Color.DarkRed;
            this.VegenereDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VegenereDecrypt.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VegenereDecrypt.ForeColor = System.Drawing.Color.White;
            this.VegenereDecrypt.Location = new System.Drawing.Point(773, 634);
            this.VegenereDecrypt.Name = "VegenereDecrypt";
            this.VegenereDecrypt.Size = new System.Drawing.Size(195, 54);
            this.VegenereDecrypt.TabIndex = 23;
            this.VegenereDecrypt.Text = "DECRYPT";
            this.VegenereDecrypt.UseVisualStyleBackColor = false;
            this.VegenereDecrypt.Click += new System.EventHandler(this.VegenereDecrypt_Click);
            // 
            // Shift_Cipher_heading
            // 
            this.Shift_Cipher_heading.BackColor = System.Drawing.Color.DarkRed;
            this.Shift_Cipher_heading.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shift_Cipher_heading.ForeColor = System.Drawing.Color.White;
            this.Shift_Cipher_heading.Location = new System.Drawing.Point(0, 110);
            this.Shift_Cipher_heading.Name = "Shift_Cipher_heading";
            this.Shift_Cipher_heading.Size = new System.Drawing.Size(1078, 76);
            this.Shift_Cipher_heading.TabIndex = 24;
            this.Shift_Cipher_heading.Text = "Shift Cipher";
            this.Shift_Cipher_heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Vigenere_Cipher_heading
            // 
            this.Vigenere_Cipher_heading.BackColor = System.Drawing.Color.DarkRed;
            this.Vigenere_Cipher_heading.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vigenere_Cipher_heading.ForeColor = System.Drawing.Color.White;
            this.Vigenere_Cipher_heading.Location = new System.Drawing.Point(0, 110);
            this.Vigenere_Cipher_heading.Name = "Vigenere_Cipher_heading";
            this.Vigenere_Cipher_heading.Size = new System.Drawing.Size(1078, 76);
            this.Vigenere_Cipher_heading.TabIndex = 25;
            this.Vigenere_Cipher_heading.Text = "Vigenere Cipher";
            this.Vigenere_Cipher_heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Play_fair_cipher_heading
            // 
            this.Play_fair_cipher_heading.BackColor = System.Drawing.Color.DarkRed;
            this.Play_fair_cipher_heading.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play_fair_cipher_heading.ForeColor = System.Drawing.Color.White;
            this.Play_fair_cipher_heading.Location = new System.Drawing.Point(0, 110);
            this.Play_fair_cipher_heading.Name = "Play_fair_cipher_heading";
            this.Play_fair_cipher_heading.Size = new System.Drawing.Size(1078, 74);
            this.Play_fair_cipher_heading.TabIndex = 26;
            this.Play_fair_cipher_heading.Text = "Playfair Cipher";
            this.Play_fair_cipher_heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Playfair_Encrypt
            // 
            this.Playfair_Encrypt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Playfair_Encrypt.BackColor = System.Drawing.Color.DarkRed;
            this.Playfair_Encrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Playfair_Encrypt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Playfair_Encrypt.FlatAppearance.BorderSize = 0;
            this.Playfair_Encrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Playfair_Encrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Playfair_Encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Playfair_Encrypt.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playfair_Encrypt.ForeColor = System.Drawing.Color.White;
            this.Playfair_Encrypt.Location = new System.Drawing.Point(773, 404);
            this.Playfair_Encrypt.Name = "Playfair_Encrypt";
            this.Playfair_Encrypt.Size = new System.Drawing.Size(195, 54);
            this.Playfair_Encrypt.TabIndex = 27;
            this.Playfair_Encrypt.Text = "ENCRYPT";
            this.Playfair_Encrypt.UseVisualStyleBackColor = false;
            this.Playfair_Encrypt.Click += new System.EventHandler(this.Playfair_Encrypt_Click);
            this.Playfair_Encrypt.MouseLeave += new System.EventHandler(this.Playfair_Encrypt_MouseLeave);
            this.Playfair_Encrypt.MouseHover += new System.EventHandler(this.Playfair_Encrypt_MouseHover);
            // 
            // playfair_decrypt
            // 
            this.playfair_decrypt.BackColor = System.Drawing.Color.Maroon;
            this.playfair_decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playfair_decrypt.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playfair_decrypt.ForeColor = System.Drawing.Color.White;
            this.playfair_decrypt.Location = new System.Drawing.Point(773, 634);
            this.playfair_decrypt.Name = "playfair_decrypt";
            this.playfair_decrypt.Size = new System.Drawing.Size(195, 54);
            this.playfair_decrypt.TabIndex = 28;
            this.playfair_decrypt.Text = "DECRYPT";
            this.playfair_decrypt.UseVisualStyleBackColor = false;
            this.playfair_decrypt.Click += new System.EventHandler(this.playfair_decrypt_Click);
            this.playfair_decrypt.MouseLeave += new System.EventHandler(this.playfair_decrypt_MouseLeave);
            this.playfair_decrypt.MouseHover += new System.EventHandler(this.playfair_decrypt_MouseHover);
            // 
            // RemoveAlpha
            // 
            this.RemoveAlpha.BackColor = System.Drawing.Color.Transparent;
            this.RemoveAlpha.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveAlpha.ForeColor = System.Drawing.Color.White;
            this.RemoveAlpha.Location = new System.Drawing.Point(213, 404);
            this.RemoveAlpha.Name = "RemoveAlpha";
            this.RemoveAlpha.Size = new System.Drawing.Size(242, 35);
            this.RemoveAlpha.TabIndex = 29;
            this.RemoveAlpha.Text = "Remove an Alphabet";
            // 
            // Alphabet_remove
            // 
            this.Alphabet_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alphabet_remove.Location = new System.Drawing.Point(461, 399);
            this.Alphabet_remove.Multiline = true;
            this.Alphabet_remove.Name = "Alphabet_remove";
            this.Alphabet_remove.Size = new System.Drawing.Size(123, 40);
            this.Alphabet_remove.TabIndex = 30;
            this.Alphabet_remove.TextChanged += new System.EventHandler(this.Alphabet_remove_TextChanged);
            this.Alphabet_remove.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Alphabet_remove_KeyPress);
            // 
            // substitutionCipherHeading
            // 
            this.substitutionCipherHeading.BackColor = System.Drawing.Color.DarkRed;
            this.substitutionCipherHeading.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.substitutionCipherHeading.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.substitutionCipherHeading.ForeColor = System.Drawing.Color.White;
            this.substitutionCipherHeading.Location = new System.Drawing.Point(0, 110);
            this.substitutionCipherHeading.Name = "substitutionCipherHeading";
            this.substitutionCipherHeading.Size = new System.Drawing.Size(1078, 73);
            this.substitutionCipherHeading.TabIndex = 31;
            this.substitutionCipherHeading.Text = "Substitution Cipher";
            this.substitutionCipherHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 40);
            this.label2.TabIndex = 32;
            this.label2.Text = "Cipher Text:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 514);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 40);
            this.label3.TabIndex = 33;
            this.label3.Text = "Cipher Text:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 583);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 40);
            this.label4.TabIndex = 34;
            this.label4.Text = "Plain Text:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(-5, -2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1083, 112);
            this.label6.TabIndex = 35;
            this.label6.Text = "label6";
            // 
            // Substitution_Encrypt_button
            // 
            this.Substitution_Encrypt_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Substitution_Encrypt_button.BackColor = System.Drawing.Color.DarkRed;
            this.Substitution_Encrypt_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Substitution_Encrypt_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Substitution_Encrypt_button.FlatAppearance.BorderSize = 0;
            this.Substitution_Encrypt_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Substitution_Encrypt_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Substitution_Encrypt_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Substitution_Encrypt_button.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Substitution_Encrypt_button.ForeColor = System.Drawing.Color.White;
            this.Substitution_Encrypt_button.Location = new System.Drawing.Point(773, 404);
            this.Substitution_Encrypt_button.Name = "Substitution_Encrypt_button";
            this.Substitution_Encrypt_button.Size = new System.Drawing.Size(195, 54);
            this.Substitution_Encrypt_button.TabIndex = 36;
            this.Substitution_Encrypt_button.Text = "ENCRYPT";
            this.Substitution_Encrypt_button.UseVisualStyleBackColor = false;
            this.Substitution_Encrypt_button.Click += new System.EventHandler(this.Substitution_Encrypt_button_Click);
            // 
            // Substitution_Decrypt_Button
            // 
            this.Substitution_Decrypt_Button.BackColor = System.Drawing.Color.Maroon;
            this.Substitution_Decrypt_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Substitution_Decrypt_Button.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Substitution_Decrypt_Button.ForeColor = System.Drawing.Color.White;
            this.Substitution_Decrypt_Button.Location = new System.Drawing.Point(773, 634);
            this.Substitution_Decrypt_Button.Name = "Substitution_Decrypt_Button";
            this.Substitution_Decrypt_Button.Size = new System.Drawing.Size(195, 54);
            this.Substitution_Decrypt_Button.TabIndex = 37;
            this.Substitution_Decrypt_Button.Text = "DECRYPT";
            this.Substitution_Decrypt_Button.UseVisualStyleBackColor = false;
            this.Substitution_Decrypt_Button.Click += new System.EventHandler(this.Substitution_Decrypt_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1078, 718);
            this.Controls.Add(this.Substitution_Decrypt_Button);
            this.Controls.Add(this.Substitution_Encrypt_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.substitutionCipherHeading);
            this.Controls.Add(this.Alphabet_remove);
            this.Controls.Add(this.RemoveAlpha);
            this.Controls.Add(this.playfair_decrypt);
            this.Controls.Add(this.Playfair_Encrypt);
            this.Controls.Add(this.Play_fair_cipher_heading);
            this.Controls.Add(this.Vigenere_Cipher_heading);
            this.Controls.Add(this.Shift_Cipher_heading);
            this.Controls.Add(this.VegenereDecrypt);
            this.Controls.Add(this.VigenereEncrypt);
            this.Controls.Add(this.VKey);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PT_Decrypt_text);
            this.Controls.Add(this.CT_Decrypt_text);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CT_Encrypt_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PT_Encrypt_text);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cipers Algorithm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PT_Encrypt_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CT_Encrypt_text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox PT_Decrypt_text;
        private System.Windows.Forms.TextBox CT_Decrypt_text;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Key;
        private System.Windows.Forms.TextBox VKey;
        private System.Windows.Forms.Button VigenereEncrypt;
        private System.Windows.Forms.Button VegenereDecrypt;
        private System.Windows.Forms.Label Shift_Cipher_heading;
        private System.Windows.Forms.Label Vigenere_Cipher_heading;
        private System.Windows.Forms.Label Play_fair_cipher_heading;
        private System.Windows.Forms.Button Playfair_Encrypt;
        private System.Windows.Forms.Button playfair_decrypt;
        private System.Windows.Forms.Label RemoveAlpha;
        private System.Windows.Forms.TextBox Alphabet_remove;
        private System.Windows.Forms.Label substitutionCipherHeading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Substitution_Encrypt_button;
        private System.Windows.Forms.Button Substitution_Decrypt_Button;
    }
}

