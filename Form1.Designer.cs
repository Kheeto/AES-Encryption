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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.encryptFileButton = new System.Windows.Forms.Button();
            this.encryptionResult = new System.Windows.Forms.RichTextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.decryptionResult = new System.Windows.Forms.RichTextBox();
            this.decryptFileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // encryptionPlainText
            // 
            this.encryptionPlainText.Location = new System.Drawing.Point(26, 32);
            this.encryptionPlainText.Name = "encryptionPlainText";
            this.encryptionPlainText.Size = new System.Drawing.Size(362, 96);
            this.encryptionPlainText.TabIndex = 0;
            this.encryptionPlainText.Text = "";
            // 
            // encryptionKey
            // 
            this.encryptionKey.Location = new System.Drawing.Point(26, 153);
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
            this.textBox2.Location = new System.Drawing.Point(26, 134);
            this.textBox2.Name = "textBox2";
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
            this.textBox3.Location = new System.Drawing.Point(26, 12);
            this.textBox3.Name = "textBox3";
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
            this.textBox4.Location = new System.Drawing.Point(25, 238);
            this.textBox4.Name = "textBox4";
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
            this.textBox5.Location = new System.Drawing.Point(25, 359);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(194, 13);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "Decryption Key (16 chars)";
            // 
            // decryptionKey
            // 
            this.decryptionKey.Location = new System.Drawing.Point(25, 378);
            this.decryptionKey.Name = "decryptionKey";
            this.decryptionKey.Size = new System.Drawing.Size(275, 20);
            this.decryptionKey.TabIndex = 5;
            // 
            // decryptionEncryptedText
            // 
            this.decryptionEncryptedText.Location = new System.Drawing.Point(25, 257);
            this.decryptionEncryptedText.Name = "decryptionEncryptedText";
            this.decryptionEncryptedText.Size = new System.Drawing.Size(363, 96);
            this.decryptionEncryptedText.TabIndex = 4;
            this.decryptionEncryptedText.Text = "";
            // 
            // encryptTextButton
            // 
            this.encryptTextButton.Location = new System.Drawing.Point(307, 134);
            this.encryptTextButton.Name = "encryptTextButton";
            this.encryptTextButton.Size = new System.Drawing.Size(129, 38);
            this.encryptTextButton.TabIndex = 8;
            this.encryptTextButton.Text = "Encrypt plain text";
            this.encryptTextButton.UseVisualStyleBackColor = true;
            this.encryptTextButton.Click += new System.EventHandler(this.encryptTextButton_Click);
            // 
            // decryptTextButton
            // 
            this.decryptTextButton.Location = new System.Drawing.Point(307, 359);
            this.decryptTextButton.Name = "decryptTextButton";
            this.decryptTextButton.Size = new System.Drawing.Size(129, 38);
            this.decryptTextButton.TabIndex = 9;
            this.decryptTextButton.Text = "Decrypt the text";
            this.decryptTextButton.UseVisualStyleBackColor = true;
            this.decryptTextButton.Click += new System.EventHandler(this.decryptTextButton_Click);
            // 
            // encryptFileButton
            // 
            this.encryptFileButton.Location = new System.Drawing.Point(443, 134);
            this.encryptFileButton.Name = "encryptFileButton";
            this.encryptFileButton.Size = new System.Drawing.Size(129, 38);
            this.encryptFileButton.TabIndex = 10;
            this.encryptFileButton.Text = "Encrypt a text file";
            this.encryptFileButton.UseVisualStyleBackColor = true;
            // 
            // encryptionResult
            // 
            this.encryptionResult.Location = new System.Drawing.Point(394, 32);
            this.encryptionResult.Name = "encryptionResult";
            this.encryptionResult.Size = new System.Drawing.Size(394, 96);
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
            this.textBox7.Location = new System.Drawing.Point(394, 13);
            this.textBox7.Name = "textBox7";
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
            this.textBox8.Location = new System.Drawing.Point(394, 238);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(122, 13);
            this.textBox8.TabIndex = 14;
            this.textBox8.Text = "Decrypted Text";
            // 
            // decryptionResult
            // 
            this.decryptionResult.Location = new System.Drawing.Point(394, 257);
            this.decryptionResult.Name = "decryptionResult";
            this.decryptionResult.Size = new System.Drawing.Size(363, 96);
            this.decryptionResult.TabIndex = 13;
            this.decryptionResult.Text = "";
            // 
            // decryptFileButton
            // 
            this.decryptFileButton.Location = new System.Drawing.Point(443, 359);
            this.decryptFileButton.Name = "decryptFileButton";
            this.decryptFileButton.Size = new System.Drawing.Size(129, 38);
            this.decryptFileButton.TabIndex = 15;
            this.decryptFileButton.Text = "Decrypt a text file";
            this.decryptFileButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1344, 776);
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
            this.Name = "Form1";
            this.Text = "Encrypter";
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
    }
}

