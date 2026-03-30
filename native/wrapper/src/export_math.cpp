#include "../include/math.hpp"

extern "C" {
    Math* create() {
        return new Math();
    }

    double native_sum(Math* math, double num1, double num2) {
        return math->Sum(num1, num2);
    }

    double native_subtract(Math* math, double num1, double num2) {
        return math->Subtract(num1, num2);
    }

    double native_multiply(Math* math, double num1, double num2) {
        return math->Multiply(num1, num2);
    }

    double native_divide(Math* math, double num1, double num2) {
        return math->Divide(num1, num2);
    }

    double native_power(Math* math, double base, double exponent) {
        return math->Power(base, exponent);
    }

    double native_square_root(Math* math, double num) {
        return math->SquareRoot(num);
    }

    void destroy(Math* math) {
        delete math;
    }
}