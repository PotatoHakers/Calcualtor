using System.Windows.Forms;

namespace Calculator.Method
{
    public class CalculateMethod
    {
        public string Calculate(float a, int count, string textBox)
        {
            if (textBox.Length > 8 && textBox != "  NOT ÷ 0")
            {
                textBox = " EXCEEDED";
            }

            switch (count)
            {
                case 1:
                    textBox =( a + float.Parse(textBox)).ToString();
                    return textBox;
                case 2:
                    textBox = (a - float.Parse(textBox)).ToString();
                    return textBox;
                case 3:
                    textBox = (a * float.Parse(textBox)).ToString();
                    return textBox;
                case 4:
                    textBox = (a / float.Parse(textBox)).ToString();
                    return textBox;
                   
                default: return "0";
                    
            }
            return "0";
        }
    }
}
