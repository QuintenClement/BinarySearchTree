using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class BinaryTree
    {
        public Node root;

        public void Add(int value, Node currentNode = null)
        {
            Node newNode = new Node();
            newNode.value = value;
            if (root == null)
            {
                root = newNode;
                return;
            }

            if (currentNode == null)
            {
                currentNode = root;
            }

            if (currentNode.value == newNode.value)
            {
                return;
            }
           
                       
            if (currentNode.value > newNode.value)
            {
                if (currentNode.leftChild == null)
                {
                    // tweak
                    currentNode.leftChild = newNode;
                    return;
                }
                else
                {
                    Add(newNode.value, currentNode.leftChild);
                    return;
                }
            }
            else if (currentNode.value < newNode.value)
            {
                if (currentNode.rightChild == null)
                {
                    currentNode.rightChild = newNode;
                    return;
                }
                else
                {
                    Add(newNode.value, currentNode.rightChild);
                    return;
                }
            }
            
        }

        public bool Search(int value, Node currentNode = null)
        {
            try
            {
                if (root != null)
                {

                    if (currentNode == null)
                    {
                        currentNode = root;
                    }
                    if (value < currentNode.value)
                    {
                        return Search(value, currentNode.leftChild);
                    }
                    if (value > currentNode.value)
                    {
                        return Search(value, currentNode.rightChild);
                        
                    }
                    if (value == currentNode.value)
                    {
                        Console.WriteLine("This tree contains " + root.value);
                        return true;
                    }
                }
                return false;

            }
            catch
            {
                Console.WriteLine("This tree does not contain what you are looking for.");
                return false;
            }
        }
    }
}
