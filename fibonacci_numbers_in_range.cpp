// Числа Фибоначчи определены следующим образом: 
// F1=1, F2=2, для n>2 выполнено Fn=Fn−1+Fn−2
// Заданы числа a, b и цифра d. Требуется вывести все числа Фибоначчи Fi, которые удовлетворяют условию a≤Fi≤b и при этом десятичная запись числа Fi не содержит цифры d.

#include <iostream>
#include <vector>
using namespace std;

int main() {
    unsigned long a,b,d;
    cin >> a >> b >> d;
    vector <unsigned long> fb, res;

    for (unsigned long fb_res, i = 0; true; i++)
    {
        if (i == 0 || i == 1) fb_res = i + 1;
        else fb_res = fb[i - 1] + fb[i - 2];

        if (b < fb_res) break;
        fb.push_back(fb_res);

        if (a <= fb_res)
        {
            bool d_find = false;
            for (unsigned long temp_res = fb_res; temp_res; temp_res /= 10) {
                if (temp_res % 10 == d) {
                    d_find = true;
                    break;
                }
            }
            if (!d_find) res.push_back(fb_res);
        } 
    };

    cout << res.size() << endl;
    for (int n : res)
        cout << n << " ";

    system("pause");
    return 0;
}