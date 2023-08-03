using System;
using System.Collections;
using System.Collections.Generic;

//ref link:https://www.youtube.com/watch?v=PP0h9BHxUGw&list=PLRwVmtr-pp07QlmssL4igw1rnrttJXerL&index=19
// generic list - cant be modified
// .NET Reflector 6 tutorial

//class MeList<T> : IEnumerable<T>

class MainClass
{
    static void Main()
    {
        //ArrayList myPartyAges = new ArrayList() { 25, 34, "kulpot", 32 }; // old school list
        List<int> myPartyAges = new List<int>() { 25, 34, 32 }; // generic list
        //List<Base> myPartyAges = new List<Base>() { new Derived(), new Derived() }; 
        //List<Base> myPartyAges = new List<Base>() { new Derived(), new Base() };    // exception error for new Base()
        //foreach (int age in myPartyAges)
            //myPartyAges.RemoveAt(2); // error cant modify only read only sequence
            //myPartyAges.Add(35); // error cant modify only read only sequence
        
        //foreach (int age in myPartyAges)
        IEnumerator<int> rator = myPartyAges.GetEnumerator();
        while (rator.MoveNext())
        {
            Console.WriteLine(rator.Current);
            myPartyAges.RemoveAt(0);    // invalid error cant modify sequence
            Console.WriteLine(rator.Current);
        }
    }
}