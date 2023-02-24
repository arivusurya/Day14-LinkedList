using System;

namespace DataStructure{

    public class Program{
        public static void Main(string[] args)
        {
           Node head = new Node(56);
           Node second = new Node(70);
           Node tail = new Node(30);
           head.next =second;
           second.next = tail;
           
        }
    }



}