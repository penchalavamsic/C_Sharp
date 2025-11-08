using System;
using Linq;
using System.Collections.Generic;
class student{
    public int id{get;set;}
    public string name{get;set;}
}
class Program{
    static void Main(){
        new 

    List l=new List(){
        new student(){id=1,name="pooja"},
        new student(){id=2,name="priya"},
    };
    var result=l.Where(s=>s.id==1).Select(s=>s.name);
    foreach(var s in result){
        Console.WriteLine(s);
    }
    }
}