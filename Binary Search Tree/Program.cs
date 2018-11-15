using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            BinaryTree bT = new BinaryTree();
            Node newNode = new Node();

            for(int i = 0; i < 10; i++)
            {
                bT.Add(r.Next(1, 101));
            }
            bT.Add(50);
            bT.Search(50);

        }
    }
}
