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

    public class ArbolBinario<T> where T : IComparable
    {
        Nodo<T> root;

        public ArbolBinario()
        {
           root = null;
        }
         
        public Nodo<T> Insert(Nodo<T> node, T value)
        {
            
            if (node == null)
            {
                node = new Nodo<T>();
                node.data = value;
            }

            else if (value.CompareTo(node.data) < 0)
            {
                root.left = Insert(node.left, value); 
            }
            else
            {
                root.right = Insert(node.right, value);
            }

            return root;
        }   

        public Nodo<T> SearchByComparer(Nodo<T> node, T value)
        {
            if (root.data == null || value.CompareTo(root.data) == 0)
            {
                return root;
            }

            //si es menor el valor comparado contra el valor del nodo actual, toma el hijo izquierdo del nodo y entra en la recursion!

            else if (value.CompareTo(node.data) < 0)
            {
                return SearchByComparer(node.left, value);
            }

            else
            {
                return SearchByComparer(node.right, value);
            }
           
        }
    }
}