using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr24oop
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource _ctsLUCIFER;
        private CancellationTokenSource _ctsNHash;
        private CancellationTokenSource _ctsRSA;
        private CancellationTokenSource _ctsAll;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLUCIFER_Click(object sender, EventArgs e)
        {
            if (_ctsLUCIFER == null)
            {
                _ctsLUCIFER = new CancellationTokenSource();
                Task.Run(() => PerformLUCIFER(_ctsLUCIFER.Token));
                buttonLUCIFER.Text = "Stop LUCIFER";
            }
            else
            {
                _ctsLUCIFER.Cancel();
                _ctsLUCIFER = null;
                buttonLUCIFER.Text = "Start LUCIFER";
            }
        }

        private void buttonNHash_Click(object sender, EventArgs e)
        {
            if (_ctsNHash == null)
            {
                _ctsNHash = new CancellationTokenSource();
                Task.Run(() => PerformNHash(_ctsNHash.Token));
                buttonNHash.Text = "Stop N-Hash";
            }
            else
            {
                _ctsNHash.Cancel();
                _ctsNHash = null;
                buttonNHash.Text = "Start N-Hash";
            }
        }

        private void buttonRSA_Click(object sender, EventArgs e)
        {
            if (_ctsRSA == null)
            {
                _ctsRSA = new CancellationTokenSource();
                Task.Run(() => PerformRSA(_ctsRSA.Token));
                buttonRSA.Text = "Stop RSA";
            }
            else
            {
                _ctsRSA.Cancel();
                _ctsRSA = null;
                buttonRSA.Text = "Start RSA";
            }
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            if (_ctsLUCIFER == null && _ctsNHash == null && _ctsRSA == null)
            {
                _ctsLUCIFER = new CancellationTokenSource();
                _ctsNHash = new CancellationTokenSource();
                _ctsRSA = new CancellationTokenSource();
                Task.Run(() => PerformLUCIFER(_ctsLUCIFER.Token));
                Task.Run(() => PerformNHash(_ctsNHash.Token));
                Task.Run(() => PerformRSA(_ctsRSA.Token));
                buttonLUCIFER.Text = "Stop LUCIFER";
                buttonNHash.Text = "Stop N-Hash";
                buttonRSA.Text = "Stop RSA";
                buttonAll.Text = "Stop All";
            }
            else
            {
                _ctsLUCIFER?.Cancel();
                _ctsNHash?.Cancel();
                _ctsRSA?.Cancel();
                _ctsLUCIFER = null;
                _ctsNHash = null;
                _ctsRSA = null;
                buttonLUCIFER.Text = "Start LUCIFER";
                buttonNHash.Text = "Start N-Hash";
                buttonRSA.Text = "Start RSA";
                buttonAll.Text = "Start All";
            }
        }

        private void buttonStopAll_Click(object sender, EventArgs e)
        {
            _ctsLUCIFER?.Cancel();
            _ctsNHash?.Cancel();
            _ctsRSA?.Cancel();
            _ctsLUCIFER = null;
            _ctsNHash = null;
            _ctsRSA = null;
            buttonLUCIFER.Text = "Start LUCIFER";
            buttonNHash.Text = "Start N-Hash";
            buttonRSA.Text = "Start RSA";
            buttonAll.Text = "Start All";
        }

        private void PerformLUCIFER(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                var result = DESEncryption("Example text", "password");
                UpdateTextBox(textBoxLUCIFER, result);
                Thread.Sleep(1000); // Затримка для демонстрації
            }
        }

        private void PerformNHash(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                var result = ComputeSHA256("Example text");
                UpdateTextBox(textBoxNHash, result);
                Thread.Sleep(1000); // Затримка для демонстрації
            }
        }

        private void PerformRSA(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                var result = RSAEncryption("Example text");
                UpdateTextBox(textBoxRSA, result);
                Thread.Sleep(1000); // Затримка для демонстрації
            }
        }

        private void UpdateTextBox(TextBox textBox, string text)
        {
            if (textBox.InvokeRequired)
            {
                textBox.Invoke(new Action(() => textBox.Text = text));
            }
            else
            {
                textBox.Text = text;
            }
        }

        private string DESEncryption(string plainText, string password)
        {
            using (DES des = DES.Create())
            {
                var salt = Encoding.UTF8.GetBytes("12345678"); // 8 байтний соль
                var key = new Rfc2898DeriveBytes(password, salt).GetBytes(8); // DES використовує 8 байтний ключ
                des.Key = key;
                des.GenerateIV();

                using (var encryptor = des.CreateEncryptor())
                {
                    var plainBytes = Encoding.UTF8.GetBytes(plainText);
                    var encryptedBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);
                    return Convert.ToBase64String(encryptedBytes);
                }
            }
        }

        private string ComputeSHA256(string plainText)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(plainText);
                var hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        private string RSAEncryption(string plainText)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048))
            {
                var data = Encoding.UTF8.GetBytes(plainText);
                var encryptedData = rsa.Encrypt(data, false);
                return Convert.ToBase64String(encryptedData);
            }
        }
    }
}