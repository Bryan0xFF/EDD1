using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LAB02_1252016.Models
{
    public class Nodo<T>
    {
        public T data;
        public Nodo<T> left;
        public Nodo<T> right;

        public Nodo(T data)
        {
            this.data = data;
        }
    }


    public class ArbolBinario<T> where T : IComparable<T>
    {
        public Nodo<T> Root { get; set; }

        public ArbolBinario()
        {
           Root = null;
        }
         
        public Nodo<T> Insert(ref Nodo<T> node, T value) 
        {
            Nodo<T> newNode = new Nodo<T>(value);

            if (node == null)
            {
                node = newNode;
                node.data = newNode.data;
            }

            else if (value.CompareTo(node.data)  == -1)
            {
               Insert(ref node.left, value);
            }
            else
            {
                Insert(ref node.right, value);
            }

            return node;
        }   

        
    }
}