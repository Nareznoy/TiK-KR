using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiK_KR
{
    internal class Node : IComparable<Node>
    {
        public string Code; // Код узла
        public string Symbol; // Символ узла
        public double Frequency; // Частота узла

        public Node Left; // Левый потомок
        public Node Right; // Правый потомок
        public Node Parent; // Предок


        public Node(double frequency, string symbol)
        {
            this.Frequency = frequency;
            this.Symbol = symbol;
        }

        private Node(double frequency, Node left, Node right)
        {
            this.Frequency = frequency;
            this.Left = left;
            this.Right = right;
        }


        /// <summary>
        /// Сравнение узлов происходит по частоте узлов
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Node other)
        {
            return Frequency.CompareTo(other);
        }


        /// <summary>
        /// Определение кода узла
        /// </summary>
        /// <param name="code"></param>
        public void FindCode(string code = "")
        {
            if (Symbol != "") this.Code = code;
            Left?.FindCode(code + "0");
            Right?.FindCode(code + "1");
        }

        /// <summary>
        /// Перегрузка оператора сложения узлов
        /// </summary>
        /// <param name="lNode"> Первый узел </param>
        /// <param name="rNode"> Второй узел </param>
        /// <returns> Возвращает новый узел, образованный сложением двух узлов </returns>
        public static Node operator +(Node lNode, Node rNode)
        {
            var newNode = new Node(lNode.Frequency + rNode.Frequency, lNode, rNode);
            lNode.Parent = newNode;
            rNode.Parent = newNode;
            return newNode;
        }
    }
}
