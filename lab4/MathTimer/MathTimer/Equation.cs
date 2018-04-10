using System;

namespace MathTimer
{
    public class Equation
    {
        public int Operand1 { get; set; }
        public int Operand2 { get; set; }
        public char Operator { get; set; }
        private GenerateRandomEquation generator;

        public Equation()
        {
            generator = new GenerateRandomEquation();
            Operand1 = generator.GenerateOperand();
            Operator = generator.GenerateOperator();
            Operand2 = generator.GenerateOperand();
        }

        public int EvaluateExpression()
        {
            if (Operator == '+')
                return Operand1 + Operand2;
            if (Operator == '-')
                return Operand1 - Operand2;
            if (Operator == '*')
                return Operand1 * Operand2;
            if (Operator == '/')
                return Operand1 / Operand2;
            throw new ArgumentException($"Operator {Operator} is not a valid operator!");
        }
    }
}
