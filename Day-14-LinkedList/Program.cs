﻿// See https://aka.ms/new-console-template for more information
using Day_14_LinkedList;

Console.WriteLine("----- Welcome TO LinkedList -----\n");

LinkedListOps list = new LinkedListOps();
list.Add(56);
list.Add(30);
list.Add(70);
list.Display();
list.SearchandInsert(30);
list.Display();

