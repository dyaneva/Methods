// Extend the program to support also subtraction and multiplication of polynomials.

using System;

class SubtractionAndMultiplicationOfPolynomials
{
    // subtraction of polynomials
    static void SubstractionOfPolynomials(decimal[] first, decimal[] second, decimal[] result)
    {
        int minLen = 0;
        int smaller = 0;
        if (first.Length > second.Length)
        {
            minLen = second.Length;
            smaller = 2;
        }
        else
        {
            minLen = first.Length;
            smaller = 1;
        }
        for (int i = 0; i < minLen; i++)
        {
            result[i] = first[i] - second[i];
        }

        for (int i = minLen; i < result.Length; i++)
        {
            if (smaller == 1)
            {
                result[i] = second[i];
            }
            else
            {
                result[i] = first[i];
            }
        }
    }
    // multiplication of polynomials
    static void MultiplicationPolynomials(decimal[] first, decimal[] second, decimal[] result)
    {        
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = 0;
        }
        for (int i = 0; i < first.Length; i++)
        {
            for (int j = 0; j < second.Length; j++)
            {
                int index = i + j;
                result[index] += (first[i] * second[j]);
            }
        }
    }
    // printing the polynomial
    static void PrintPolynomial(decimal[] polynomial)
    {
        for (int i = polynomial.Length - 1; i >= 0; i--)
        {
            if (polynomial[i] != 0 && i != 0)
            {
                if (polynomial[i - 1] >= 0)
                {
                    Console.Write("{1}x^{0} +", i, polynomial[i]);
                }
                else
                {
                    Console.Write("{1}x^{0} ", i, polynomial[i]);
                }
            }
            else if (i == 0)
            {
                Console.Write("{0}", polynomial[i]);
            }
        }
        Console.WriteLine();
    }
    static void Main()
    {
        decimal[] firstPolynomial = { 2, -7 };
        decimal[] secondPolynomial = { 4, 9, -11 };
        // subtraction of two polynomials
        int lenght = 0;
        if (firstPolynomial.Length > secondPolynomial.Length)
        {
            lenght = firstPolynomial.Length;
        }
        else
        {
            lenght = secondPolynomial.Length;
        } 
        decimal[] resultOfSubstraction = new decimal[lenght];
        SubstractionOfPolynomials(firstPolynomial, secondPolynomial, resultOfSubstraction);
        Console.Write("The substraction of two polynomials is: ");
        PrintPolynomial(resultOfSubstraction);
        // multiplication of two polynomials
        decimal[] resultOfMultiplication = new decimal[firstPolynomial.Length + secondPolynomial.Length];
        MultiplicationPolynomials(firstPolynomial, secondPolynomial, resultOfMultiplication);
        Console.Write("The multiplication of two polynomials is: ");
        PrintPolynomial(resultOfMultiplication);    
    }
}
