using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProject
{
    public class LinkedList
    {
        private Node head;
        private Node current;//This will have latest node
        public int Count;

        public LinkedList()
        {
            head = null;
            current = null;
            Count = 0;
        }

        public void AddAtStart(object data)
        {
            Node newNode = new Node();
            newNode.Value = data;

            //first time--list is empty
            if (head == null)
            {
                newNode.Next = null;

                //only one node--both the start (head) and end (current)
                head = newNode;
                current = newNode;
            }
            else //not my first rodeo
            {
                newNode.Next = head;
                head = newNode;
                //current is correct--don't change
            }
            //could reset head = newNode here
            Count++;
        }

        public void AddToEnd(object data)
        {
            Node newNode = new Node();
            newNode.Value = data;
            newNode.Next = null; //it's actually null by default

            //first time
            if (head == null)
            {
                //only one node--both the start (head) and end (current)
                head = newNode;
                current = newNode;
            }
            else //every other time (list has something)
            {
                //point the old last item to this as its next
                current.Next = newNode;
                //tell the list this is its last (current)
                current = newNode;
            }
            Count++;
        }

        public void RemoveFromStart()
        {
            if (Count == 1)
            {
                //back to an empty list
                head = null;
                current = null;
                Count = 0;
            }
            else if (Count > 1)
            {
                head = head.Next;
            }
            else
            {
                //really we want to throw an exception here
                Console.WriteLine("No elements in list");
            }
        }

        public void PrintAllNodes()
        {
            //start at the first node
            //console.writeline the node's value
            //go to the next node
            Node thisNode = head;
            while (thisNode != null)
            {
                Console.WriteLine(thisNode.Value);
                thisNode = thisNode.Next;
            }
        }

        //1a. Create a method to Removeall (Object o)
        //Removes all occurrances of (Object o) from the list
        public void RemoveAll(Object o)
        {
            //unsure if correct
            LinkedList.Remove(o);

            //created List
            List<string> unknown = new List<string>();

            unknown.Add("Not clear");
            unknown.Add("Unsure");
            unknown.Add("Hope for the best");
            unknown.Add("Stick with it");
            unknown.Add("It will eventually click");

            Console.WriteLine();
            foreach (string unknowns in unknown)
            {
                Console.WriteLine(unknown);
            }

            Console.WriteLine("Elements RemoveAll(?)", unknown.RemoveAll(unknowns));
        }

        private static void Remove(object o)
        {
            throw new NotImplementedException();
        }

        //2. Design an algorithm that counts the occurrences of 
        //  numbers in an array
        //2a. Us an array to find the frequency


        //Returns the number of times numrepeat occurs in arr[0...a-1]
        static int FrequencyOccurences(int[] arr, int a, int numrepeat)
        {
            int input = 0;
            for (int i = 0; i < a; i++)
            {
                if (numrepeat == arr[i])
                    input++;
            }
        }

        //Not sure if this will work to complete 2 & 2a
        //See Program.cs

        //public static void Main()
        //{
        //    int[] arr = { };
        //    int a = arr.Length;
        //    int numrepeat = 2;
        //    Console.WriteLine(FrequencyOccurrences(arr, a));
        //}

        var c = new List<int>() { };
        var d = c.Groupby(e => e);
        foreach (var numoftimes in d)
            {
            Console.WriteLine("{0} {1}", numoftimes.Key, numoftimes.Count());
            }
        

    }
}
