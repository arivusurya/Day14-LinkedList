using System;
using static DataStructure.Node;
using Testcase;

namespace DataStructure{

    public class Program{
        public static void Main(string[] args)
        {
           MyLinkList linkList = new MyLinkList();
           linkList.Add(56);
           linkList.Add(70);
           linkList.insert(2,30);
            Test mycase = new Test();
            mycase.tc8(linkList,30,40);
        }
    }



}