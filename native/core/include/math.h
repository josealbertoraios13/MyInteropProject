#ifndef MATH_H
#define MATH_H

// Isso avisa ao C++ para não mudar o nome da função durante a compilação
#ifdef __cplusplus
extern "C" {
#endif

double sum(double num1, double num2);

double subtract(double num1, double num2);

double multiply(double num1, double num2);

double divide(double num1, double num2);

double power(double base_value, double exponent_value);

double square_root(double num);

#ifdef __cplusplus
}
#endif

#endif // MATH_H