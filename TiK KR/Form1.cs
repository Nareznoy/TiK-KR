using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiK_LR__6;

namespace TiK_KR
{
    public partial class Form1 : Form
    {
        private HuffmanTree _huffmanTree;


        readonly List<long> _inputMessages = new List<long>(); // Входные блоки данных
        readonly List<long> _CRCs = new List<long>(); // CRC коды входных блоков данных
        readonly List<bool> _isCorrect = new List<bool>(); // Содержит информацию о проверенных блоках данных
        readonly List<long> _messagesForCheck = new List<long>(); // Принятые сообщения для проверки

        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateCRC_button_Click(object sender, EventArgs e)
        {
            
        }

        private void CheckData_button_Click(object sender, EventArgs e)
        {
            
        }

        private void CalculateCRC_button_Click_1(object sender, EventArgs e)
        {
            int fromBase = Convert.ToInt32(comboBox1.Text);

            if (message16_textBox.Text == "")
            {
                MessageBox.Show("Введите входные данные для получения CRC!", "Ошибка!");
                return;
            }

            _inputMessages.Clear();
            _CRCs.Clear();
            _isCorrect.Clear();

            message2_textBox.Text = "";
            CalculatedCRC_textBox.Text = "";
            InputCRC_textBox.Text = "";

            string[] stringMessages = message16_textBox.Text.Split();
            foreach (string str in stringMessages)
            {
                try
                {
                    // Конвертация входного блока данных
                    _inputMessages.Add(Convert.ToInt64(str, fromBase));
                }
                catch
                {
                    MessageBox.Show("Неверные входные данные для получения CRC!", "Ошибка!");
                    return;
                }

                message2_textBox.Text += Convert.ToString(_inputMessages.Last(), toBase: 2) + " ";

                // Получение CRC кода входного блока данных
                _CRCs.Add(CRC.CalculateCRC(_inputMessages.Last()));
                CalculatedCRC_textBox.Text += Convert.ToString(_CRCs.Last(), toBase: 2) + " ";
                InputCRC_textBox.Text += Convert.ToString(_CRCs.Last(), toBase: 2) + " ";
            }
        }

        private void CheckData_button_Click_1(object sender, EventArgs e)
        {
            if (messageForCheck_textBox.Text == "")
            {
                MessageBox.Show("Введите входные данные для проверки!", "Ошибка!");
                return;
            }
            else if (_CRCs.Count == 0)
            {
                MessageBox.Show("Сначала необходимо получить CRC!", "Ошибка!");
                return;
            }

            _messagesForCheck.Clear();

            bool state = true; // Есть ли ошибка в принятом коде
            string errorBlockNumber = ""; // Номер блока с ошибкой

            int fromBase = Convert.ToInt32(comboBox2.Text);

            string[] stringMessages = messageForCheck_textBox.Text.Split();
            for (int i = 0; i < stringMessages.Length; i++)
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

                _isCorrect.Add(CRC.CheckMessage(_messagesForCheck.Last(), _CRCs[i])); // Проверка принятого сообщения

                if (_isCorrect.Last()) continue; // Если сообщение без ошибок, то проверить следующее
                state = false;
                errorBlockNumber += i + 1 + " ";
            }

            CheckResultLabel.Text = state ? "Данные приняты верно!" : "Данные приняты с ошибкой в блоке: " + errorBlockNumber;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (huffmanInputStr_textBox.Text == "")
            {
                MessageBox.Show("Введите входные данные для построения кода Хаффмана!", "Ошибка!");
                return;
            }

            dataGridView1.Rows.Clear();

            _huffmanTree = new HuffmanTree();
            huffmanCode_textBox.Text = _huffmanTree.Encode(huffmanInputStr_textBox.Text); // Построение дерева Хаффмана

            // Вывод кодов на интерфейс
            for (int i = 0; i < _huffmanTree.CodesDictionary.Count; i++)
            {
                string currentStr = _huffmanTree.Alphabet.Keys.ElementAt(i);
                dataGridView1.Rows.Add("'" + currentStr + "'", Math.Round(_huffmanTree.Alphabet[currentStr], 2), _huffmanTree.CodesDictionary[currentStr]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Введите входные данные для декодироваия кода!", "Ошибка!");
                return;
            }
            else if (_huffmanTree == null)
            {
                MessageBox.Show("Сначала необходимо построить кодовое дерево!", "Ошибка!");
                return;
            }

            textBox3.Text = _huffmanTree.Decode(textBox2.Text);
        }
    }
}
