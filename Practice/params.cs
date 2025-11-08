//params - variable length arguments
using System;
class Program{
    void display(params int[] arr){ //only one params allowed
        for(int i=0;i<arr.Length;i++){
            Console.WriteLine(arr[i]);
        }
    }
    static void Main(){
    Program p=new Program();
    p.display(1,2,3,4,5);
    }


}
