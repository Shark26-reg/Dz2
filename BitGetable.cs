using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz2
{
    internal interface IBitGetable
    {
        bool GetBitByIndex(byte index);
        void SetBitByIndex(byte index, bool value);
    }

    internal class Bits : IBitGetable
    {
        public byte Value { get; private set; }
        public long Value1 { get; private set; }
        public int Value2 { get; private set; }

        public Bits(byte value)
        {
            Value = value;
        }
        public Bits(long value)
        {
            Value1 = value;
        }
        public Bits(int value)
        {
            Value2 = value;
        }

        public bool GetBitByIndex(byte index)
        {
            return (Value & (1 << index)) != 0;
        }

        public void SetBitByIndex(byte index, bool value)
        {
            if (value)
            {
                Value |= (byte)(1 << index);
            }
            else
            {
                Value &= (byte)~(1 << index);
            }
        }

        public bool this[byte index]
        {
            get => GetBitByIndex(index);
            set => SetBitByIndex(index, value);
        }

        public static implicit operator byte(Bits bits) => bits.Value;
        public static explicit operator Bits(byte value) => new(value);
        public static implicit operator long(Bits bits) => bits.Value;
        public static explicit operator Bits(long value) => new(value);
        public static implicit operator int(Bits bits) => bits.Value;
        public static explicit operator Bits(int value) => new(value);
    }
}
