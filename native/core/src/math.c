#include <stdio.h>
#include "../include/math.h"

double sum(double num1, double num2) {
    return num1 + num2;
}

double subtract(double num1, double num2) {
    return num1 - num2;
}

double multiply(double num1, double num2) {
    return num1 * num2;
}

double divide(double num1, double num2) {
    if (num2 == 0) {
        fprintf(stderr, "Error: Division by zero\n");
        return 0; // Return 0 or handle as needed
    }
    return num1 / num2;
}

double power(double base_value, double exponent_value) {
    double result = 1.0;
    for (int i = 0; i < (int)exponent_value; i++) {
        result *= base_value;
    }
    return result;
}

double square_root(double num) {
    if (num < 0) {
        fprintf(stderr, "Error: Cannot compute square root of a negative number\n");
        return 0; // Return 0 or handle as needed
    }

    const double TOLERANCE = 0.00001;
    const double TWO = 2.0;

    double guess = num / TWO;
    double epsilon = TOLERANCE; // Tolerance for convergence
    while (guess * guess - num >= epsilon || num - guess * guess >= epsilon) {
        guess = (guess + num / guess) / TWO;
    }
    return guess;
}