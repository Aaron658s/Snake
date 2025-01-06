#include <iostream>
#include <string>
using namespace std;


void greet()
{
    cout << "Hello Guys";
}
int main()
{
    std::cout << "Hello World!";
    int x = 13;
    float y = 162.213;
    double z = 128939.821084084840;
    //Please greet the message back!
    string greetBack = "Oh, Hi";
    char a = 'A';
    bool b = true;
    //Conditional Statement
    if (x <= 18)
    {
        cout << " Hello Kid";
    }
    else
    {
        cout << " Hey Adult";
    }   
    
    greet();
    
    return 0;
}