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
        }

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
    }
}
