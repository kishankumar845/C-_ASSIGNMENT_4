using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStackConsoleApplication
{
    public class StackException : Exception
    {
        public StackException(String Message) : base(Message)
        {

        }
    }
    internal class CustomStackException
    {
        static readonly int MAX1 = 1000;
        int top1;
        int[] arr1 = new int[MAX1];

        public bool IsEmpty()
        {
            return (top1 < 0);
        }
        public CustomStackException()
        {
            top1 = 0;
        }
        public void Push(int data)
        {
            if(top1 >= MAX1)
            {
                throw (new StackException("witnessing Stack Overflow scenario"));
            }
            else
            {
                arr1[top1++] = data;
                Console.WriteLine("data will be stored in the array : {0} ", data);
            }
        }
        public void Pop()
        {
            if(top1<0)
            {
                throw (new StackException("Witnessing Stack Underflow Scenario"));
            }
            else
            {
                int value = arr1[top1--];
                Console.WriteLine("After performing pop operation, The Value will be: {0}", value);   
            }
        }
        public void Peek()
        {
            if(top1<0)
            {
                Console.WriteLine("Stack Underflow");
            }
            else
            {
                Console.WriteLine(arr1[top1]);            
            }

        }
        public void PrintStack()
        {
            if(top1<0)
            {
                Console.WriteLine("Stack UnderFlow");
            }
            else
            {
                Console.WriteLine("Stack Elements are as follows:");
                for(int i=top1;i>0;i--)
                {
                    Console.WriteLine(arr1[i]); 
                    Console.ReadKey();  
                }
            }
        }
        static void Main()
        {
            CustomStackException cl2 = new CustomStackException();
            Console.WriteLine("Program starts...");
            Console.WriteLine("Please Enter Valid Credentials to get into the Application : ");
            Console.ReadLine();
            Console.WriteLine("< br >");
            Console.WriteLine("Please wait we are checking the status of the Stack, whether it is empty or not!!");
            //Console.ReadLine();
            Console.WriteLine("Evrything is perfect! plase go ahead with pressing ENTER");
            Console.ReadLine();
            cl2.IsEmpty();
            Console.WriteLine("Thanks for your patience! here is the Top Most element");
            cl2.Peek();
            cl2.PrintStack();
            
            try
            {
                cl2.Push(100);
                cl2.Push(200);
            }
            catch(StackException stackException)
            {
                Console.WriteLine(stackException.Message);
            }
            try
            {
                cl2.Pop();
            }
            catch(StackException stackException1)
            {
                Console.WriteLine(stackException1.Message);
            }

            Console.WriteLine("Program ends..."); 
           
        }
      
    }
}
