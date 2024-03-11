using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathGame
{
    public class Equation
    {
        public int operantA { get; set; }
        public int operantB { get; set; }
        public int operation { get; set; } // 0-> +;1-> -;2-> *;3-> /; 

        public Equation(int operantA, int operantB, int operation)
        {
            setParametars(operantA, operantB, operation);
        }

        public void setParametars(int A,int B,int oper) {
            if (B > A) {
                int tmp = B;
                B = A;
                A = tmp;
            }
            if (oper == 3 && A%B!=0) {
                A/=B;
                A *= B;
            }
            this.operantA = A;
            this.operantB = B;
            this.operation = oper;
        }

        public int getResult() {
            if (operation == 0)
            {
                return operantA + operantB;
            }
            else if (operation == 1)
            {
                return operantA - operantB;
            }
            else if (operation == 2)
            {
                return operantA * operantB;
            }
            else if (operation == 3)
            {
                return operantA / operantB;
            }
            return -1;
        }

        public string operationToString() {
            if(operation == 0) { return "+"; }
            else if(operation == 1) { return "-"; }
            else if(operation == 2) { return "*"; }
            else if(operation == 3) { return "/"; }
            return "error";
          
        }
    }
}
