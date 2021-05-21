using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiK_KR
{
    internal class HuffmanTree
    {
        private Node _head;
        public Dictionary<string, double> Alphabet;
        public Dictionary<string, string> CodesDictionary;


        /// <summary>
        /// Метод кодирования
        /// </summary>
        /// <param name="inputNodes"> Очередь входных узлов </param>
        public string Encode(string inputStr)
        {
            Alphabet = GetAlphabet(inputStr);
            Alphabet = Alphabet.OrderBy(symbol => symbol.Key)
                .ToDictionary(pair => pair.Key, pair => pair.Value);

            Queue<Node> nodes = new Queue<Node>();

            for (int i = 0; i < Alphabet.Count; i++)
            {
                nodes.Enqueue(new Node(Alphabet.Values.ElementAt(i), Alphabet.Keys.ElementAt(i)));
            }

            nodes = new Queue<Node>(nodes.OrderBy(node => node.Frequency)); // Сортировка по возрастанию по частоте

            while (nodes.Count != 1) // Построение дерева Хаффмана
            {
                nodes.Enqueue(nodes.Dequeue() + nodes.Dequeue());
                nodes = new Queue<Node>(nodes.OrderBy(node => node.Frequency));
            }
            _head = nodes.Dequeue();

            CodesDictionary = GetCodesDictionary(); // Построение словаря символов и кодов

            string outputHuffmanCode = "";
            foreach(char c in inputStr)
            {
                CodesDictionary.TryGetValue(c.ToString(), out string currentCode);
                outputHuffmanCode += currentCode;
            }

            return outputHuffmanCode;
        }

        private Dictionary<string, double> GetAlphabet(string inputStr)
        {
            var alphabet = inputStr
                .GroupBy(c => c.ToString().ToLower())
                .ToDictionary(g => g.Key, g => (double)g.Count() / inputStr.Length);

            return alphabet;
        }

        /// <summary>
        /// Получение словаря кодов для символов обходом дерева в глубину
        /// </summary>
        /// <returns></returns>
        private Dictionary<string, string> GetCodesDictionary()
        {
            _head.FindCode();
            CodesDictionary = new Dictionary<string, string>();
            Stack<Node> stack = new Stack<Node>();

            // Обход дерева Хаффмана в глубину
            stack.Push(_head);
            while (stack.Count != 0)
            {
                Node tempNode = stack.Pop();
                if (tempNode.Symbol != null) CodesDictionary.Add(tempNode.Symbol, tempNode.Code);
                //do
                //{
                //    if (tempNode.Left != null)
                //    {
                //        if (tempNode.Right != null) stack.Push(tempNode.Right);
                //        tempNode = tempNode.Left;
                //        if (tempNode.Symbol != null) CodesDictionary.Add(tempNode.Symbol, tempNode.Code);
                //    }
                //    else
                //    {
                //        tempNode = tempNode.Right;
                //        if (tempNode?.Symbol != null)
                //            CodesDictionary.Add(tempNode.Symbol, tempNode.Code);
                //    }
                //} while (tempNode != null);

                if (tempNode.Left != null)
                {
                    stack.Push(tempNode.Left);
                }
                if (tempNode.Right != null)
                {
                    stack.Push(tempNode.Right);
                }
            }

            // Сортирвка полученного словаря символов и кодов
            CodesDictionary = CodesDictionary.OrderBy(symbol => symbol.Key)
                .ToDictionary(pair => pair.Key, pair => pair.Value);

            return CodesDictionary;
        }


        /// <summary>
        /// Декодирование строки
        /// </summary>
        /// <param name="encodedString"> Входная закодированная строка </param>
        /// <returns> Возвращает декодированную строку в коде Хаффмана </returns>
        public string Decode(string encodedString)
        {
            var decodeString = "";
            var currentNode = _head;

            // Обход дерева в сответствии с входной закодированной строкой
            for (var i = 0; i < encodedString.Length; i++)
            {
                if (encodedString[i] == '0')
                {
                    currentNode = currentNode.Left;
                }
                else
                {
                    currentNode = currentNode.Right;
                }


                if (currentNode != null)
                {
                    if (currentNode.Symbol != null)
                    {
                        decodeString += currentNode.Symbol;
                        currentNode = _head;
                    }
                }
                else
                {
                    return "Ошибка";
                }
            }

            return decodeString;
        }
    }
}
