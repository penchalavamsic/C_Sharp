//boxing and unboxing
using System;
class Program{
    int a=10; //type int
    obj o=a //type object reference -stored in heap
    int b=(int)o; //unboxing type casting -stored in stack

}