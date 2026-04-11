using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe_Shop.Utilty
{
    public class Validation
    {
        public bool isValidTexts(string input1, string input2)
        {
            bool isValid = !string.IsNullOrWhiteSpace(input1) && !string.IsNullOrWhiteSpace(input2);
            if(!isValid)
            {
                MessageBox.Show("Inputan tidak sesuai");
            }
            return isValid;
        }

        public bool isMatchText(string inputA, string inputB)
        {
            bool isMatch = inputA == inputB;
            if(!isMatch)
            {
                MessageBox.Show("Inputan tidak sesuai");
            }
            return isMatch;
        }
    }
}
