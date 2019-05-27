using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator.Models
{
    public class Tree
    {
        Node top;
        public Tree()
        {
            top = null;
        }
        public Tree(int initial)
        {
            top = new Node(initial);
        }
        public void Add(int value)
        {
            if (top == null)
            {
                Node node = new Node(value);
                top = node;
                return;
            }
            Node currentNode = top;
            bool isAdded = false;
            do
            {
                if (value < currentNode.value)
                {
                    if (currentNode.left == null)
                    {
                        Node newNode = new Node(value);
                        currentNode.left = newNode;
                        isAdded = true;
                    }
                    else
                    {
                        currentNode = currentNode.left;
                    }
                }
                if (value >= currentNode.value)
                {
                    if (currentNode.right == null)
                    {
                        Node newNode = new Node(value);
                        currentNode.right = newNode;
                        isAdded = true;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                    }
                }

            } while (!isAdded);
        }
        public void AddRc(int initial)
        {
            AddR(ref top, initial);
        }
        private void AddR(ref Node node, int value)
        {
            if (node == null)
            {
                Node newNode = new Node(value);
                node = newNode;
                return;
            }
            if (value < node.value)
            {
                AddR(ref node.left, value);
            }
            if (value >= node.value)
            {
                AddR(ref node.right, value);
            }
        }
        public void Print(Node node, ref string message)
        {
            if (node == null)
            {
                node = top;
            }
            if (node.left != null)
            {
                Print(node.left, ref message);
                message = message + node.value.ToString().PadLeft(3);
            }
            else
            {
                message = message + node.value.ToString().PadLeft(3);
            }
            if (node.right != null)
            {
                Print(node.right, ref message);

            }
        }
    }
}
