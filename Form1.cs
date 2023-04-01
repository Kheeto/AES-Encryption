using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypter_App
{
    public partial class Form1 : Form
    {
        private static byte[] IV = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public Form1()
        {
            InitializeComponent();
            HandleNavigation(true, false, false);
        }

        #region Button Handling

        private void encryptTextButton_Click(object sender, EventArgs e)
        {
            try
            {
                string encrypted = EncryptText(encryptionPlainText.Text, encryptionKey.Text, IV);
                encryptionResult.Text = encrypted;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void decryptTextButton_Click(object sender, EventArgs e)
        {
            try
            {
                string decrypted = DecryptText(decryptionEncryptedText.Text, decryptionKey.Text, IV);
                decryptionResult.Text = decrypted;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void EncryptFileButton_Click(object sender, EventArgs e)
        {
            string content = ReadFileContent();
            if (content == string.Empty) return;

            try
            {
                string encrypted = EncryptText(content, encryptionKey.Text, IV);
                encryptionResult.Text = encrypted;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void DecryptFileButton_Click(object sender, EventArgs e)
        {
            string content = ReadFileContent();
            if (content == string.Empty) return;

            try
            {
                string decrypted = DecryptText(content, decryptionKey.Text, IV);
                decryptionResult.Text = decrypted;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void SaveEncryptedText_Click(object sender, EventArgs e)
        {
            SaveContentOnFile(encryptionResult.Text);
        }

        private void SaveDecryptedText_Click(object sender, EventArgs e)
        {
            SaveContentOnFile(decryptionResult.Text);
        }

        private void GenerateRandomKey_Click(object sender, EventArgs e)
        {
            randomKeyText.Text = RandomString(16);
        }

        private void navEncryption_Click(object sender, EventArgs e)
        {
            HandleNavigation(true, false, false);
        }

        private void navDecryption_Click(object sender, EventArgs e)
        {
            HandleNavigation(false, true, false);
        }

        private void navKeyGen_Click(object sender, EventArgs e)
        {
            HandleNavigation(false, false, true);
        }

        private void HandleNavigation(bool encryption, bool decryption, bool keyGeneration)
        {
            // Encryption
            textBox3.Visible = encryption;
            textBox7.Visible = encryption;
            encryptionPlainText.Visible = encryption;
            encryptionResult.Visible = encryption;
            textBox2.Visible = encryption;
            encryptionKey.Visible = encryption;
            encryptTextButton.Visible = encryption;
            encryptFileButton.Visible = encryption;
            saveEncryptedText.Visible = encryption;

            // Decryption
            textBox4.Visible = decryption;
            textBox8.Visible = decryption;
            decryptionEncryptedText.Visible = decryption;
            decryptionResult.Visible = decryption;
            textBox5.Visible = decryption;
            decryptionKey.Visible = decryption;
            decryptTextButton.Visible = decryption;
            decryptFileButton.Visible = decryption;
            saveDecryptedText.Visible = decryption;

            // Key Generation
            textBox1.Visible = keyGeneration;
            randomKeyText.Visible = keyGeneration;
            generateRandomKey.Visible = keyGeneration;
        }

        #endregion
        #region Encryption and Decryption

        private string EncryptText(string plainText, string password, byte[] IV)
        {
            byte[] Key = Encoding.UTF8.GetBytes(password);

            AesManaged aes = new AesManaged();
            aes.Key = Key;
            aes.IV = IV;

            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write);

            byte[] InputBytes = Encoding.UTF8.GetBytes(plainText);
            cs.Write(InputBytes, 0, InputBytes.Length);
            cs.FlushFinalBlock();

            byte[] Encrypted = ms.ToArray();

            return Convert.ToBase64String(Encrypted);
        }

        private string DecryptText(string plainText, string password, byte[] IV)
        {
            byte[] Key = Encoding.UTF8.GetBytes(password);

            AesManaged aes = new AesManaged();
            aes.Key = Key;
            aes.IV = IV;

            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write);

            byte[] InputBytes = Convert.FromBase64String(plainText);
            cs.Write(InputBytes, 0, InputBytes.Length);
            cs.FlushFinalBlock();

            byte[] Decrypted = ms.ToArray();

            return UTF8Encoding.UTF8.GetString(Decrypted, 0, Decrypted.Length);
        }

        #endregion
        #region Window resize handling

        private Size oldSize;
        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);

            foreach (Control cnt in this.Controls)
                ResizeAll(cnt, base.Size);

            oldSize = base.Size;
        }
        private void ResizeAll(Control control, Size newSize)
        {
            int width = newSize.Width - oldSize.Width;
            control.Left += (control.Left * width) / oldSize.Width;
            control.Width += (control.Width * width) / oldSize.Width;

            int height = newSize.Height - oldSize.Height;
            control.Top += (control.Top * height) / oldSize.Height;
            control.Height += (control.Height * height) / oldSize.Height;
        }

        #endregion
        #region Read and Saving to files

        private string ReadFileContent()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            if (filePath == string.Empty) return string.Empty;
            if (fileContent == string.Empty)
            {
                MessageBox.Show("Error: File is empty");
                return string.Empty;
            }

            return fileContent;
        }

        public void SaveContentOnFile(string content)
        {
            if (content == null || content == string.Empty) return;

            Stream myStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog.OpenFile()) != null)
                {
                    byte[] bytes = Encoding.ASCII.GetBytes(content.ToCharArray());
                    try
                    {
                        myStream.Write(bytes, 0, bytes.Length);
                    }
                    catch (Exception e) { MessageBox.Show(e.Message); }
                    myStream.Close();
                }
            }
        }

        #endregion
        #region Random key generation

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars =
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "abcdefghijklmnopqrstuvwxyz" +
                "0123456789" +
                ".,;:_-+*@#^?!/()=!?%$<>";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        #endregion
    }
}
