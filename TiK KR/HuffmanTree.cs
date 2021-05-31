using System.Collections.Generic;
using System.Linq;
using System;

namespace TiK_KR
{
    static class HuffmanTree
    {
        private static Node _head;
        private static Dictionary<string, double> _alphabet;
        private static Dictionary<string, string> _codesDictionary;

        public static Dictionary<string, string> GetCodesDictionary => _codesDictionary;

        public static Dictionary<string, double> GetAlphabet => _alphabet;


        /// <summary>
        ///     Метод кодирования
        /// </summary>
        /// <param name="inputNodes"> Очередь входных узлов </param>
        public static string Encode(string inputStr)
        {
            _alphabet = CalculateAlphabet(inputStr);

            var nodes = new Queue<Node>();

            for (var i = 0; i < _alphabet.Count; i++)
                nodes.Enqueue(new Node(_alphabet.Values.ElementAt(i), _alphabet.Keys.ElementAt(i)));

            nodes = new Queue<Node>(nodes.OrderBy(node => node.Frequency)); // Сортировка по возрастанию по частоте

            while (nodes.Count != 1) // Построение дерева Хаффмана
            {
                nodes.Enqueue(nodes.Dequeue() + nodes.Dequeue());
                nodes = new Queue<Node>(nodes.OrderBy(node => node.Frequency));
            }

            _head = nodes.Dequeue();

            _codesDictionary = CalculateCodesDictionary(); // Построение словаря символов и кодов

            var outputHuffmanCode = "";
            foreach (var c in inputStr)
            {
                _codesDictionary.TryGetValue(c.ToString(), out var currentCode);
                outputHuffmanCode += currentCode;
            }

            return outputHuffmanCode;
        }

        private static Dictionary<string, double> CalculateAlphabet(string inputStr)
        {
            var alphabet = inputStr
                .GroupBy(c => c.ToString().ToLower())
                .ToDictionary(g => g.Key, g => (double) g.Count() / inputStr.Length);

            alphabet = alphabet.OrderByDescending(symbol => symbol.Value)
                .ToDictionary(pair => pair.Key, pair => pair.Value);

            return alphabet;
        }

        /// <summary>
        ///     Получение словаря кодов для символов обходом дерева в глубину
        /// </summary>
        /// <returns></returns>
        private static Dictionary<string, string> CalculateCodesDictionary()
        {
            _head.FindCode();
            _codesDictionary = new Dictionary<string, string>();
            var stack = new Stack<Node>();

            // Обход дерева Хаффмана в глубину
            stack.Push(_head);
            while (stack.Count != 0)
            {
                var tempNode = stack.Pop();
                if (tempNode.Symbol != null) _codesDictionary.Add(tempNode.Symbol, tempNode.Code);

                if (tempNode.Left != null) stack.Push(tempNode.Left);
                if (tempNode.Right != null) stack.Push(tempNode.Right);
            }

            // Сортирвка полученного словаря символов и кодов
            _codesDictionary = _codesDictionary.OrderBy(symbol => symbol.Key)
                .ToDictionary(pair => pair.Key, pair => pair.Value);

            return _codesDictionary;
        }


        /// <summary>
        ///     Декодирование строки
        /// </summary>
        /// <param name="encodedString"> Входная закодированная строка </param>
        /// <returns> Возвращает декодированную строку в коде Хаффмана </returns>
        public static string Decode(string encodedString)
        {
            var decodeString = "";
            var currentNode = _head;

            // Обход дерева в сответствии с входной закодированной строкой
            for (var i = 0; i < encodedString.Length; i++)
            {
                if (encodedString[i] == '0')
                    currentNode = currentNode.Left;
                else
                    currentNode = currentNode.Right;


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

        public static double CalculateEntropy()
        {
            double entropy = 0;
            foreach (KeyValuePair<string, double> pair in _alphabet)
            {
                entropy += pair.Value * Math.Log(pair.Value, 2);
            }
            return -entropy;
        }

        public static double CalculateAverageCodeLength()
        {
            double averageCodeLength = 0;
            foreach (KeyValuePair<string, double> pair in _alphabet)
            {
                string currentStr = pair.Key;
                _codesDictionary.TryGetValue(currentStr, out string code);
                averageCodeLength += code.Length * pair.Value;
            }
            return averageCodeLength;
        }
    }
}