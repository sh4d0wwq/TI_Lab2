using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_2
{
    class StreamCipher
    {
        public BitArray BitRegister { get; private set; }
        public BitArray BitKey { get; private set; }
        public BitArray PlainText { get; set; }
        public BitArray CipherBit { get; private set; }

        public void ProduceBitRegister(string parsingString)
        {
            BitRegister = new BitArray(parsingString.Length);
            for (int i = 0; i < parsingString.Length; i++)
            {
                BitRegister[i] = parsingString[i] == '1';
            }
        }

        public void ProduceBitKey(int length)
        {
            BitKey = new BitArray(length);
            for (int i = 0; i < length; i++)
            {
                BitKey[i] = BitRegister[0];

                int len = BitRegister.Length;
                bool nextValue = BitRegister[len - 31] ^ BitRegister[len - 3];

                for (int index = 0; index < BitRegister.Length - 1; index++)
                {
                    BitRegister[index] = BitRegister[index + 1];
                }

                BitRegister[BitRegister.Length - 1] = nextValue;
            }
        }

        public void Cipher() => CipherBit = BitKey.Xor(PlainText);
    }
}
