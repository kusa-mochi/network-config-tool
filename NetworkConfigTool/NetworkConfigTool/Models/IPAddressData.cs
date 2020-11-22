using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkConfigTool.Models
{
    public struct IPAddressData
    {
        public int Num1
        {
            get
            {
                return _Num1;
            }
            set
            {
                if (0 <= value && value <= 255)
                {
                    _Num1 = value;
                }
            }
        }
        public int Num2
        {
            get
            {
                return _Num2;
            }
            set
            {
                if (0 <= value && value <= 255)
                {
                    _Num2 = value;
                }
            }
        }
        public int Num3
        {
            get
            {
                return _Num3;
            }
            set
            {
                if (0 <= value && value <= 255)
                {
                    _Num3 = value;
                }
            }
        }
        public int Num4
        {
            get
            {
                return _Num4;
            }
            set
            {
                if (0 <= value && value <= 255)
                {
                    _Num4 = value;
                }
            }
        }

        public IPAddressData(int n1, int n2, int n3, int n4)
        {
            Func<int, bool> ipNumberValidator = num => 0 <= num && num <= 255;
            if (
                !ipNumberValidator(n1) ||
                !ipNumberValidator(n2) ||
                !ipNumberValidator(n3) ||
                !ipNumberValidator(n4)
                )
            {
                throw new ArgumentOutOfRangeException();
            }
            _Num1 = n1;
            _Num2 = n2;
            _Num3 = n3;
            _Num4 = n4;
        }

        private int _Num1;
        private int _Num2;
        private int _Num3;
        private int _Num4;
    }
}
