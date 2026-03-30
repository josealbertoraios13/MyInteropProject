#ifndef MATH_HPP
#define MATH_HPP

#include "../../core/include/math.h"

class Math{
    public:
        static double Sum(double num1, double num2);
        static double Subtract(double num1, double num2);
        static double Multiply(double num1, double num2);
        static double Divide(double num1, double num2);
        static double Power(double base_value, double exponent_value);
        static double SquareRoot(double num);
};

#endif // MATH_HPP