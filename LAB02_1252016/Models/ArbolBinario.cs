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
    }


    public class ArbolBinario<T> where T : IComparable<T>
    {
        Nodo<T> Root;

        public ArbolBinario()
        {
           Root = null;
        }
         
        public Nodo<T> Insert(Nodo<T> root, T value) 
        {
            Nodo<T> node = new Nodo<T>();

            if (root == null)
            {
                root = node;
            }

            else if (value.CompareTo(node.data) < 0)
            {
               Insert(root.left, value);
            }
            else
            {
                Insert(root.right, value);
            }

            return root;
        }   

        
    }
}