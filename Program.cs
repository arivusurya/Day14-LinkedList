using System;
using static DataStructure.Node;

namespace DataStructure{

    public class Program{
        public static void Main(string[] args)
        {
           MyLinkList linkList = new MyLinkList();
           linkList.Add(56);
           linkList.Add(70);
           linkList.insert(2,30);
           linkList.DeleteFirst();
           linkList.display();
        }
    }



}