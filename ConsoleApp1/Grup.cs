using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Grup
    {
        private string _no;
        private int _studenlimit;
        public int StudenLimit
        {
            get
            {
                return _studenlimit;
            }
            set
            {
                _studenlimit = value;

            }
        }
        public string No
        {
            get
            {
                return this._no;
            }
            set
            {
                if (hasUpper(value) && HasDigit(value))
                {
                   _no = value; 
                }
                 
            }
        }
        public bool HasDigit(string text)
        {
            for (int i = 0; i < 3; i++)
            {
                if (Char.IsDigit(text[i]))
                {
                    return true;
                }
            }
            return false;

        }
        public bool hasUpper(string text)
        {
            for (int i = 3; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
