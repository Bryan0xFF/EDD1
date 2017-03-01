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
        Nodo<T> Root;

        public ArbolBinario()
        {
           Root = null;
        }
         
        public Nodo<T> Insert(Nodo<T> node, T value) 
        {
            Nodo<T> newNode = new Nodo<T>(value);

            if (Root == null)
            {
                Root = newNode;
            }

            else if (value.CompareTo(Root.data) < 0)
            {
               Insert(Root.left, value);
            }
            else
            {
                Insert(Root.right, value);
            }

            return node;
        }   

        
    }
}