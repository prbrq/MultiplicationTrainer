using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTrainer
{
    class Exercise
    {
        public int FirstNumber { get; private set; }
        public int SecondNumber { get; private set; }
        public int RigthAnswer
        {
            get
            {
                return FirstNumber * SecondNumber;
            }
        }

        public Exercise(int firstNumber, int secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }

        public override string ToString()
        {
            return $"{FirstNumber} x {SecondNumber} = ";
        }
    }
}
