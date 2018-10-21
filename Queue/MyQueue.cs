using System;
using System.Collections.Generic;


/* @author: nilay tufek
 * ntufek@gmail.com
 */

namespace Queue
{
    
    public class Node<V>
    {
        public V value;            
        public Node<V> NextNode = null;

        public Node(V v)
        {
            value = v;
        }

        public static implicit operator Node<V>(int v)
        {
            throw new NotImplementedException();
        }
    }
    
    class MyQueue<V>
    {
        public Node<V> first = null;
        public Node<V> last = null;

        public MyQueue()
        {
            first = null;
            last = first;
        }
        public void Enqueue(Node<V> node)
        {
            if (first == null)
            {
                first = node;
            }
            else
            {
                last.NextNode = node;
            }
            last = node;
        }

        public V Dequeue()
        {
            V deQ = first.value;

            first = first.NextNode;
            return deQ;
        }

        public bool Search(V val)
        {
            Node<V> tmp = first;
            while (tmp != null)
            {
                if (0 == Comparer<V>.Default.Compare(tmp.value, val))
                {
                    return true;
                }
                tmp = tmp.NextNode;
            }

            return false;
        }

        public V[] GetQ()
        {
            V[] arr = new V[0];
            Node<V> tmp = first;
            int i = 0;
            while (tmp != null)
            {
                Array.Resize(ref arr, i + 1);
                arr[i] = tmp.value;
                tmp = tmp.NextNode;
                i++;

            }
            return arr;


        }

    }
}
