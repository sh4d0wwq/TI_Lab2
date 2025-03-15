using System.Collections;
using System.Text;
using TI_2;

namespace TI_Lab2
{
    public partial class Form1 : Form
    {
        readonly StreamCipher streamCipher = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void RegisterTextBox_TextChanged(object sender, EventArgs e)
        {
            LengthLabel.Text = $@"Длина введённых состояний: {RegisterTextBox.Text.Count(x => x is '0' or '1')}";
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            if (string.Join("", RegisterTextBox.Text.Where(x => x is '0' or '1')).Length != 31)
            {
                MessageBox.Show("Длина вашего регистра должна равняться 31 состояниям!", "Внимание");
                return;
            }

            if (PlainTextBox.Text.Length is 0)
            {
                MessageBox.Show("Выберите файл с вашим исходным текстом для шифрования/дешифрования!", "Внимание");
                return;
            }

            streamCipher.ProduceBitRegister(string.Join("", RegisterTextBox.Text.Where(x => x is '0' or '1')));
            streamCipher.ProduceBitKey(streamCipher.PlainText.Length);
            KeyTextBox.Text = BitArrayToStr(streamCipher.BitKey);

            streamCipher.Cipher();
            CipherTextBox.Text = BitArrayToStr(streamCipher.CipherBit);
        }

        string BitArrayToStr(BitArray array)
        {
            StringBuilder temp = new();
            if (array.Length <= 240)
            {
                foreach (bool bit in array)
                {
                    temp.Append(bit ? 1 : 0);
                }
            }
            else
            {
                temp.Append("Первые 20 байт: \n");
                for (int i = 0; i < 160; i++)
                    temp.Append(array[i] ? 1 : 0);
                temp.Append($"{Environment.NewLine}Последние 20 байт: \n");
                for (int i = 160; i > 0; i--)
                {
                    temp.Append(array[array.Length - i] ? 1 : 0);
                }
            }

            return temp.ToString();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                StringBuilder stringBuilder = new StringBuilder();

                var bytes = File.ReadAllBytes(OpenFileDialog.FileName);
                for (int i = 0; i < bytes.Length; i++)
                {
                    BitArray help = new BitArray(new[] { bytes[i] });
                    foreach (bool bit in help)
                    {
                        stringBuilder.Append(bit ? 1 : 0);
                    }
                }
                streamCipher.PlainText = new BitArray(stringBuilder.Length);
                for (int i = 0; i < streamCipher.PlainText.Length; i++)
                {
                    streamCipher.PlainText[i] = stringBuilder[i] == '1';
                }

                PlainTextBox.Text = BitArrayToStr(streamCipher.PlainText);
            }
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                using FileStream fileStream = new FileStream(SaveFileDialog.FileName, FileMode.Create);
                byte[] result = new byte[streamCipher.CipherBit.Count / 8];
                streamCipher.CipherBit.CopyTo(result, 0);
                fileStream.Write(result, 0, result.Length);
            }
        }
    }
}
