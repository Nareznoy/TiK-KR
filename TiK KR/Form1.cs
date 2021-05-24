using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TiK_LR__6;

namespace TiK_KR
{
    public partial class Form1 : Form
    {
        string[] basePatterns = new string[] { @"([0-1]+[ ]{0,1})", 
                                               @"([0-7]+[ ]{0,1})", 
                                               @"([0-9]+[ ]{0,1})", 
                                               @"([0-9a-fA-F]+[ ]{0,1})" };

        private CRC crc;

        private readonly List<long> _CRCs = new List<long>(); // CRC коды входных блоков данных
        private readonly List<long> _inputMessages = new List<long>(); // Входные блоки данных
        private readonly List<bool> _isCorrect = new List<bool>(); // Содержит информацию о проверенных блоках данных
        private readonly List<long> _messagesForCheck = new List<long>(); // Принятые сообщения для проверки

        //private HuffmanTree _huffmanTree;

        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateCRC_button_Click_1(object sender, EventArgs e)
        {
            //if ((Regex.Replace(poly_textBox.Text, @"[0-1]+", "") != "") || poly_textBox.Text == "")
            //{
            //    MessageBox.Show("Неверный формат полинома", "Ошибка!");
            //    return;
            //}

            //if (message16_textBox.Text == "")
            //{
            //    MessageBox.Show("Введите входные данные для получения CRC!", "Ошибка!");
            //    return;
            //}

            //if ((Regex.Replace(messageForCheck_textBox.Text, basePatterns[comboBox1.SelectedIndex], "") != ""))
            //{
            //    MessageBox.Show("Неверный формат входных данных для получения CRC!", "Ошибка!");
            //    return;
            //}

            if (!IsValidCRC())
            {
                return;
            }

            var fromBase = Convert.ToInt32(comboBox1.Text);
            long poly = Convert.ToInt64(poly_textBox.Text, 2);
            crc = new CRC(poly);

            _inputMessages.Clear();
            _CRCs.Clear();
            _isCorrect.Clear();

            message2_textBox.Text = "";
            CalculatedCRC_textBox.Text = "";
            InputCRC_textBox.Text = "";
            

            var stringMessages = message16_textBox.Text.Split();
            foreach (var str in stringMessages)
            {
                //try
                //{
                    _inputMessages.Add(Convert.ToInt64(str, fromBase));
                //}
                //catch
                //{
                //    MessageBox.Show("Неверные входные данные для получения CRC!", "Ошибка!");
                //    return;
                //}

                message2_textBox.Text += Convert.ToString(_inputMessages.Last(), 2) + " ";

                // Получение CRC кода входного блока данных
                _CRCs.Add(crc.CalculateCRC(_inputMessages.Last()));
                CalculatedCRC_textBox.Text += Convert.ToString(_CRCs.Last(), 2) + " ";
                InputCRC_textBox.Text += Convert.ToString(_CRCs.Last(), 2) + " ";
            }
        }

        private void CheckData_button_Click_1(object sender, EventArgs e)
        {
            if (!IsValidCRC_Check())
            {
                return;
            }


            _messagesForCheck.Clear();

            var state = true; // Есть ли ошибка в принятом коде
            var errorBlockNumber = ""; // Номер блока с ошибкой

            var fromBase = Convert.ToInt32(comboBox2.Text);

            var stringMessages = messageForCheck_textBox.Text.Split();
            for (var i = 0; i < stringMessages.Length; i++)
            {
                try
                {
                    _messagesForCheck.Add(Convert.ToInt64(stringMessages[i], fromBase));
                }
                catch
                {
                    MessageBox.Show("Неверные входные данные для проверки!", "Ошибка!");
                    return;
                }

                _isCorrect.Add(crc.CheckMessage(_messagesForCheck.Last(), _CRCs[i])); // Проверка принятого сообщения

                if (_isCorrect.Last()) continue; // Если сообщение без ошибок, то проверить следующее
                state = false;
                errorBlockNumber += i + 1 + " ";
            }

            CheckResultLabel.Text =
                state ? "Данные приняты верно!" : "Данные приняты с ошибкой в блоке: " + errorBlockNumber;
        }

        private void buildHuffmanTree_button_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            //_huffmanTree = new HuffmanTree();
            huffmanCode_textBox.Text = HuffmanTree.Encode(huffmanInputStr_textBox.Text); // Построение дерева Хаффмана

            entropyLabel.Text = "Энтропия: " + Math.Round(HuffmanTree.CalculateEntropy(), 3).ToString();
            averageLengthLabel.Text = "Средняя длина сообщения: " + Math.Round(HuffmanTree.CalculateAverageCodeLength(), 3).ToString();

            // Вывод кодов на интерфейс
            for (var i = 0; i < HuffmanTree.GetCodesDictionary.Count; i++)
            {
                var currentStr = HuffmanTree.GetAlphabet.Keys.ElementAt(i);
                dataGridView1.Rows.Add("'" + currentStr + "'", Math.Round(HuffmanTree.GetAlphabet[currentStr], 3),
                    HuffmanTree.GetCodesDictionary[currentStr]);
            }
        }

        private void decodeHuffman_button_Click(object sender, EventArgs e)
        {
            if (!IsValidHuffmanDecode())
            {
                return;
            }

            textBox3.Text = HuffmanTree.Decode(textBox2.Text);
        }

        private bool IsValidCRC()
        {
            if ((Regex.Replace(poly_textBox.Text, @"[0-1]+", "") != "") || poly_textBox.Text == "")
            {
                MessageBox.Show("Неверный формат полинома", "Ошибка!");
                return false;
            }

            if (message16_textBox.Text == "")
            {
                MessageBox.Show("Введите входные данные для получения CRC!", "Ошибка!");
                return false;
            }

            if ((Regex.Replace(messageForCheck_textBox.Text, basePatterns[comboBox1.SelectedIndex], "") != ""))
            {
                MessageBox.Show("Неверный формат входных данных для получения CRC!", "Ошибка!");
                return false;
            }
            return true;
        }

        private bool IsValidCRC_Check()
        {
            if (messageForCheck_textBox.Text == "")
            {
                MessageBox.Show("Введите входные данные для проверки!", "Ошибка!");
                return false;
            }

            if (_CRCs.Count == 0)
            {
                MessageBox.Show("Сначала необходимо получить CRC!", "Ошибка!");
                return false;
            }

            if ((Regex.Replace(messageForCheck_textBox.Text, basePatterns[comboBox2.SelectedIndex], "") != ""))
            {
                MessageBox.Show("Неверный формат входных данных для проверки!", "Ошибка!");
                return false;
            }

            return true;
        }

        private bool IsValidHuffman()
        {
            if (huffmanInputStr_textBox.Text == "")
            {
                MessageBox.Show("Введите входные данные для построения кода Хаффмана!", "Ошибка!");
                return false;
            }

            return true;
        }

        private bool IsValidHuffmanDecode()
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Введите входные данные для декодироваия кода!", "Ошибка!");
                return false;
            }

            if (HuffmanTree.GetCodesDictionary == null)
            {
                MessageBox.Show("Сначала необходимо построить кодовое дерево!", "Ошибка!");
                return false;
            }

            if (Regex.Replace(textBox2.Text, @"[0-1]+", "") != "")
            {
                MessageBox.Show("Неверный формат входных данных для проверки!", "Ошибка!");
                return false;
            }

            return true;
        }
    }
}