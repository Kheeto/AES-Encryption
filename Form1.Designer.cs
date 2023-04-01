namespace Encrypter_App
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.encryptionPlainText = new System.Windows.Forms.RichTextBox();
            this.encryptionKey = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.decryptionKey = new System.Windows.Forms.TextBox();
            this.decryptionEncryptedText = new System.Windows.Forms.RichTextBox();
            this.encryptTextButton = new System.Windows.Forms.Button();
            this.decryptTextButton = new System.Windows.Forms.Button();
            this.encryptFileButton = new System.Windows.Forms.Button();
            this.encryptionResult = new System.Windows.Forms.RichTextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.decryptionResult = new System.Windows.Forms.RichTextBox();
            this.decryptFileButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.randomKeyText = new System.Windows.Forms.TextBox();
            this.generateRandomKey = new System.Windows.Forms.Button();
            this.saveEncryptedText = new System.Windows.Forms.Button();
            this.saveDecryptedText = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.navEncryption = new System.Windows.Forms.Button();
            this.navDecryption = new System.Windows.Forms.Button();
            this.navKeyGen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // encryptionPlainText
            // 
            this.encryptionPlainText.Location = new System.Drawing.Point(191, 35);
            this.encryptionPlainText.Name = "encryptionPlainText";
            this.encryptionPlainText.Size = new System.Drawing.Size(362, 96);
            this.encryptionPlainText.TabIndex = 0;
            this.encryptionPlainText.Text = "";
            // 
            // encryptionKey
            // 
            this.encryptionKey.Location = new System.Drawing.Point(190, 156);
            this.encryptionKey.Name = "encryptionKey";
            this.encryptionKey.Size = new System.Drawing.Size(275, 20);
            this.encryptionKey.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(190, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(161, 13);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Encryption Key (16 chars)";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(191, 15);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 13);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Plain Text";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(191, 16);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(122, 13);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "Encrypted Text";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(191, 137);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(194, 13);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "Decryption Key (16 chars)";
            // 
            // decryptionKey
            // 
            this.decryptionKey.Location = new System.Drawing.Point(191, 156);
            this.decryptionKey.Name = "decryptionKey";
            this.decryptionKey.Size = new System.Drawing.Size(275, 20);
            this.decryptionKey.TabIndex = 5;
            // 
            // decryptionEncryptedText
            // 
            this.decryptionEncryptedText.Location = new System.Drawing.Point(190, 35);
            this.decryptionEncryptedText.Name = "decryptionEncryptedText";
            this.decryptionEncryptedText.Size = new System.Drawing.Size(363, 96);
            this.decryptionEncryptedText.TabIndex = 4;
            this.decryptionEncryptedText.Text = "";
            // 
            // encryptTextButton
            // 
            this.encryptTextButton.Location = new System.Drawing.Point(472, 137);
            this.encryptTextButton.Name = "encryptTextButton";
            this.encryptTextButton.Size = new System.Drawing.Size(129, 38);
            this.encryptTextButton.TabIndex = 8;
            this.encryptTextButton.Text = "Encrypt plain text";
            this.encryptTextButton.UseVisualStyleBackColor = true;
            this.encryptTextButton.Click += new System.EventHandler(this.encryptTextButton_Click);
            // 
            // decryptTextButton
            // 
            this.decryptTextButton.Location = new System.Drawing.Point(472, 137);
            this.decryptTextButton.Name = "decryptTextButton";
            this.decryptTextButton.Size = new System.Drawing.Size(129, 38);
            this.decryptTextButton.TabIndex = 9;
            this.decryptTextButton.Text = "Decrypt the text";
            this.decryptTextButton.UseVisualStyleBackColor = true;
            this.decryptTextButton.Click += new System.EventHandler(this.decryptTextButton_Click);
            // 
            // encryptFileButton
            // 
            this.encryptFileButton.Location = new System.Drawing.Point(608, 137);
            this.encryptFileButton.Name = "encryptFileButton";
            this.encryptFileButton.Size = new System.Drawing.Size(129, 38);
            this.encryptFileButton.TabIndex = 10;
            this.encryptFileButton.Text = "Encrypt a text file";
            this.encryptFileButton.UseVisualStyleBackColor = true;
            this.encryptFileButton.Click += new System.EventHandler(this.EncryptFileButton_Click);
            // 
            // encryptionResult
            // 
            this.encryptionResult.Location = new System.Drawing.Point(559, 35);
            this.encryptionResult.Name = "encryptionResult";
            this.encryptionResult.Size = new System.Drawing.Size(363, 96);
            this.encryptionResult.TabIndex = 11;
            this.encryptionResult.Text = "";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.White;
            this.textBox7.Location = new System.Drawing.Point(559, 16);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(100, 13);
            this.textBox7.TabIndex = 12;
            this.textBox7.Text = "Encrypted Text";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.White;
            this.textBox8.Location = new System.Drawing.Point(559, 16);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(122, 13);
            this.textBox8.TabIndex = 14;
            this.textBox8.Text = "Decrypted Text";
            // 
            // decryptionResult
            // 
            this.decryptionResult.Location = new System.Drawing.Point(559, 35);
            this.decryptionResult.Name = "decryptionResult";
            this.decryptionResult.Size = new System.Drawing.Size(363, 96);
            this.decryptionResult.TabIndex = 13;
            this.decryptionResult.Text = "";
            // 
            // decryptFileButton
            // 
            this.decryptFileButton.Location = new System.Drawing.Point(608, 137);
            this.decryptFileButton.Name = "decryptFileButton";
            this.decryptFileButton.Size = new System.Drawing.Size(129, 38);
            this.decryptFileButton.TabIndex = 15;
            this.decryptFileButton.Text = "Decrypt a text file";
            this.decryptFileButton.UseVisualStyleBackColor = true;
            this.decryptFileButton.Click += new System.EventHandler(this.DecryptFileButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(191, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(161, 13);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "Random Key Generation";
            // 
            // randomKeyText
            // 
            this.randomKeyText.Location = new System.Drawing.Point(191, 35);
            this.randomKeyText.Name = "randomKeyText";
            this.randomKeyText.ReadOnly = true;
            this.randomKeyText.Size = new System.Drawing.Size(275, 20);
            this.randomKeyText.TabIndex = 16;
            // 
            // generateRandomKey
            // 
            this.generateRandomKey.Location = new System.Drawing.Point(472, 17);
            this.generateRandomKey.Name = "generateRandomKey";
            this.generateRandomKey.Size = new System.Drawing.Size(129, 38);
            this.generateRandomKey.TabIndex = 18;
            this.generateRandomKey.Text = "Generate";
            this.generateRandomKey.UseVisualStyleBackColor = true;
            this.generateRandomKey.Click += new System.EventHandler(this.GenerateRandomKey_Click);
            // 
            // saveEncryptedText
            // 
            this.saveEncryptedText.Location = new System.Drawing.Point(743, 137);
            this.saveEncryptedText.Name = "saveEncryptedText";
            this.saveEncryptedText.Size = new System.Drawing.Size(129, 38);
            this.saveEncryptedText.TabIndex = 19;
            this.saveEncryptedText.Text = "Save result on file";
            this.saveEncryptedText.UseVisualStyleBackColor = true;
            this.saveEncryptedText.Click += new System.EventHandler(this.SaveEncryptedText_Click);
            // 
            // saveDecryptedText
            // 
            this.saveDecryptedText.Location = new System.Drawing.Point(743, 137);
            this.saveDecryptedText.Name = "saveDecryptedText";
            this.saveDecryptedText.Size = new System.Drawing.Size(129, 38);
            this.saveDecryptedText.TabIndex = 20;
            this.saveDecryptedText.Text = "Save result on file";
            this.saveDecryptedText.UseVisualStyleBackColor = true;
            this.saveDecryptedText.Click += new System.EventHandler(this.SaveDecryptedText_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panelMenu.Controls.Add(this.navKeyGen);
            this.panelMenu.Controls.Add(this.navDecryption);
            this.panelMenu.Controls.Add(this.navEncryption);
            this.panelMenu.Controls.Add(this.panelTitle);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(185, 362);
            this.panelMenu.TabIndex = 21;
            // 
            // navEncryption
            // 
            this.navEncryption.Dock = System.Windows.Forms.DockStyle.Top;
            this.navEncryption.FlatAppearance.BorderSize = 0;
            this.navEncryption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navEncryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navEncryption.ForeColor = System.Drawing.SystemColors.Control;
            this.navEncryption.Location = new System.Drawing.Point(0, 71);
            this.navEncryption.Name = "navEncryption";
            this.navEncryption.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.navEncryption.Size = new System.Drawing.Size(185, 60);
            this.navEncryption.TabIndex = 1;
            this.navEncryption.Text = "Encrypt";
            this.navEncryption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navEncryption.UseVisualStyleBackColor = true;
            this.navEncryption.Click += new System.EventHandler(this.navEncryption_Click);
            // 
            // navDecryption
            // 
            this.navDecryption.Dock = System.Windows.Forms.DockStyle.Top;
            this.navDecryption.FlatAppearance.BorderSize = 0;
            this.navDecryption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navDecryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navDecryption.ForeColor = System.Drawing.SystemColors.Control;
            this.navDecryption.Location = new System.Drawing.Point(0, 131);
            this.navDecryption.Name = "navDecryption";
            this.navDecryption.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.navDecryption.Size = new System.Drawing.Size(185, 60);
            this.navDecryption.TabIndex = 2;
            this.navDecryption.Text = "Decrypt";
            this.navDecryption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navDecryption.UseVisualStyleBackColor = true;
            this.navDecryption.Click += new System.EventHandler(this.navDecryption_Click);
            // 
            // navKeyGen
            // 
            this.navKeyGen.Dock = System.Windows.Forms.DockStyle.Top;
            this.navKeyGen.FlatAppearance.BorderSize = 0;
            this.navKeyGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navKeyGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navKeyGen.ForeColor = System.Drawing.SystemColors.Control;
            this.navKeyGen.Location = new System.Drawing.Point(0, 191);
            this.navKeyGen.Name = "navKeyGen";
            this.navKeyGen.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.navKeyGen.Size = new System.Drawing.Size(185, 60);
            this.navKeyGen.TabIndex = 3;
            this.navKeyGen.Text = "Key Generator";
            this.navKeyGen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navKeyGen.UseVisualStyleBackColor = true;
            this.navKeyGen.Click += new System.EventHandler(this.navKeyGen_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(-3, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 71);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panelTitle.Controls.Add(this.button1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(185, 71);
            this.panelTitle.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(933, 362);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.saveDecryptedText);
            this.Controls.Add(this.saveEncryptedText);
            this.Controls.Add(this.generateRandomKey);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.randomKeyText);
            this.Controls.Add(this.decryptFileButton);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.decryptionResult);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.encryptionResult);
            this.Controls.Add(this.encryptFileButton);
            this.Controls.Add(this.decryptTextButton);
            this.Controls.Add(this.encryptTextButton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.decryptionKey);
            this.Controls.Add(this.decryptionEncryptedText);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.encryptionKey);
            this.Controls.Add(this.encryptionPlainText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Encrypter";
            this.panelMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox encryptionPlainText;
        private System.Windows.Forms.TextBox encryptionKey;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox decryptionKey;
        private System.Windows.Forms.RichTextBox decryptionEncryptedText;
        private System.Windows.Forms.Button encryptTextButton;
        private System.Windows.Forms.Button decryptTextButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button encryptFileButton;
        private System.Windows.Forms.RichTextBox encryptionResult;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.RichTextBox decryptionResult;
        private System.Windows.Forms.Button decryptFileButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox randomKeyText;
        private System.Windows.Forms.Button generateRandomKey;
        private System.Windows.Forms.Button saveEncryptedText;
        private System.Windows.Forms.Button saveDecryptedText;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button navKeyGen;
        private System.Windows.Forms.Button navDecryption;
        private System.Windows.Forms.Button navEncryption;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button button1;
    }
}
