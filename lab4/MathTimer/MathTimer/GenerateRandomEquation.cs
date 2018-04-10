using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTimer
{
    public class GenerateRandomEquation
    {
        private static Random random = new Random();
        private static char[] operators = new char[] {'+', '-', '*', '/'};
        private int previouslyGeneratedOperand;

        public GenerateRandomEquation()
        {
            previouslyGeneratedOperand = 0;  // 0 is not a valid operand
        }

        public int GenerateOperand()
        {
            while (true)
            {
                int generatedOperand = random.Next(1, 11);  // a number between 1-100
                if (previouslyGeneratedOperand == 0)
                {
                    previouslyGeneratedOperand = generatedOperand;
                    return generatedOperand;
                }
                else if (generatedOperand <= previouslyGeneratedOperand)
                {
                    return generatedOperand;
                }
            }
        }

        public char GenerateOperator()
        {
            return operators[random.Next(operators.Length)];
        }

    }
}
