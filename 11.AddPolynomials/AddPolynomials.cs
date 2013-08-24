// Write a method that adds two polynomials. Represent them as arrays of their coefficients.

using System;

class AddPolynomials
{
    // calculating the sum of two polynomials
    static void SumOfPolynomials(decimal[] first, decimal[] second, decimal[] result)
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
            result[i] = first[i] + second[i];
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
    
    // printing the polynominal
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
        int lenght = 0;
        if (firstPolynomial.Length > secondPolynomial.Length)
        {
            lenght = firstPolynomial.Length;
        }
        else
        {
            lenght = secondPolynomial.Length;
        }
        decimal[] result = new decimal[lenght];
        SumOfPolynomials(firstPolynomial, secondPolynomial, result);
        Console.Write("The sum of two polynomials is: ");
        PrintPolynomial(result);
    }
}