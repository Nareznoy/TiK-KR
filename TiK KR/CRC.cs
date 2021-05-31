using System;

namespace TiK_LR__6
{
    internal class CRC
    {
        private readonly long _poly; // Генераторный полином
        private readonly int _polyLength;

        public CRC(long polynom)
        {
            _poly = polynom;
            _polyLength = (int)Math.Log(_poly, 2) + 1;
        }

        public long CalculateCRC(long inputCode, bool isCheck = false)
        {
            // Добавление в конце принятого сообщения нулей
            if (!isCheck)
                inputCode <<= _polyLength - 1;

            while ((int) Math.Log(inputCode, 2) + 1 >= _polyLength) inputCode = XOR(inputCode, _poly);

            return inputCode;
        }

        public long XOR(long inputCode, long poly)
        {
            var ret = inputCode >> ((int)Math.Log(inputCode, 2) + 1 - ((int)Math.Log(poly, 2) + 1));
            ret ^= poly;

            return Convert.ToInt64(
                Convert.ToString(ret, 2) + Convert.ToString(inputCode, 2).Substring((int)Math.Log(poly, 2) + 1), 2);
        }

        //public long XORString(long inputCode, long poly)
        //{
        //    var ret = Convert.ToInt64(Convert.ToString(inputCode, 2).Substring(0, ((int)Math.Log(poly, 2) + 1)), 2);
        //    ret ^= poly;

        //    return Convert.ToInt64(
        //        Convert.ToString(ret, 2) + Convert.ToString(inputCode, 2).Substring((int)Math.Log(poly, 2) + 1), 2);
        //}

        public bool CheckMessage(long message, long crc)
        {
            message <<= _polyLength - 1; // Добавление в конец сообщения нулей
            var messagePlusCrcInt = message + crc; // Прибавление к сообщению CRC кода

            return CalculateCRC(messagePlusCrcInt, true) == 0; // Равен ли CRC код нулю
        }
    }
}