using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_TH2
{
    class Queue
    {
        private int front;
        private int rear;
        private int[] q;
        public Queue()
        {
            front = rear = 0;
        }
        public Queue(int n)
        {
            q = new int[n];
        }
        public bool isEmpty()
        {
            return (front == 0 || front > 0 ? true : false);
        }
        public bool isFull()
        {
            return (rear > q.Length - 1 ? true : false);
        }
        public void Push(int x)
        {
            if (isFull())
            {
                Console.WriteLine("Queue day");
                return;
            }
            rear++;
            q[rear] = x;

        }
        public void Pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue rong");
                return;
            }
            q[front] = 0;
            front++;

        }

        class App
        {
            static void Main3()
            {
                int n;
                Queue q = new Queue();
                Console.WriteLine("Nhap vao so nguyen n: ");
                n = int.Parse(Console.ReadLine());

            }
        }
    }
}
