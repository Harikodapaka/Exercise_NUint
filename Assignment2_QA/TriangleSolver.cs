using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_QA
{
    public static class TriangleSolver
    {
        public static string Analyze(int sideA, int sideB, int sideC)
        {
            if (ValidateSide(sideA) && ValidateSide(sideB) && ValidateSide(sideC))
            {
                if(ValidateTraingle(sideA, sideB, sideC))
                {
                    if ((sideA == sideB)&& (sideB == sideC))
                    {
                        return "Euqilataral Triangle Formed...";
                    }else if ((sideA != sideB) &&(sideB != sideC) && (sideC!=sideA))
                    {
                        return "Scalene Triangle Formed...";
                    }
                    else
                    {
                        return "Isosceles Triangle Formed...";
                    }
                }
                else
                {
                    return "Can not form triangle with given sides";
                }
            }
            return "Invalid side entered..";
        }

        private static bool ValidateTraingle(int A, int B, int C)
        {
            if ((A + B > C) && (C + B > A) && (A + C > B)) 
            {
                return true;
            }
            return false;
        }

        private static bool ValidateSide(int side)
        {
            if(side <= 0)
            {
                Console.WriteLine("Input {0} is not a valid side!!", side);
                return false;
            }
            return true;
        }
    }
}
