using System;
using System.Collections;

namespace _7_SortedList_Stack_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            /****************************************************************/
            /*               SORTED LİST YAPISI                             */
            /****************************************************************/
            SortedList SortedL = new SortedList();

            SortedL.Add(100, "Yüz");
            SortedL.Add(90, "Doksan");
            SortedL.Add(1, "Bir");
            SortedL.Add(9000, "Dokuzbin");
            // SortedL.Add("A", "B"); HATA VERİR!!!!

            /****************************************************************/
            /*               STACK YAPISI                                   */
            /****************************************************************/
            Stack S1 = new Stack();

            S1.Push("Bir");
            S1.Push("İki");
            S1.Push("Üç");
            S1.Push("Dört");

            object O1 = S1.Pop();
            object O2 = S1.Peek();

            /****************************************************************/
            /*               QUEUE YAPISI                                   */
            /****************************************************************/
            Queue Q1 = new Queue();
            Q1.Enqueue("Bir");
            Q1.Enqueue("İki");
            Q1.Enqueue("Üç");
            Q1.Enqueue("Dört");

            object Object1 = Q1.Peek();
            object Object2 = Q1.Dequeue();

        }
    }
}
