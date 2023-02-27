int a = 5;
int b = 10;
int c = 15;

// Створення анонімного методу, який приймає три цілі аргументи та повертає їх середнє арифметичне
Func<int, int, int, double> average = delegate (int x, int y, int z) {
    return (x + y + z) / 3.0;
};

double result = average(a, b, c);
Console.WriteLine("Середнє арифметичне: {0}", result);

