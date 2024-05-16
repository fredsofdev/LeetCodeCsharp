using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week4.BST
{
    /// <summary>
    /// Morris Traversal Algorithm
    /// </summary>
    internal class MorrisBST
    {

        public void Traversal(TreeNode root)
        {
            TreeNode current = root;
            while (current != null)
            {
                if(current.left == null)
                {
                    Console.Write(current.val + " ");
                    current = current.right;
                }
                else
                {
                    TreeNode predecessor = current.left;
                    while (predecessor.right != null && predecessor.right != current)
                    {
                        predecessor = predecessor.right;    
                    }

                    if(predecessor.right == null)
                    {
                        predecessor.right = current;
                        current = current.left;
                    }
                    else
                    {
                        predecessor.right = null;
                        Console.Write(current.val + " ");
                        current = current.right;
                    }
                }

            }
        }

        public static void Run()
        {
            MorrisBST tree = new MorrisBST();
            TreeNode root = new TreeNode(1, 1);
            root.left = new TreeNode(2, 2);
            root.right = new TreeNode(3, 3);
            root.left.left = new TreeNode(4, 4);
            root.left.right = new TreeNode(5, 5);

            Console.WriteLine("Inorder Traversal of the given tree:");
            tree.Traversal(root);
        }
    }
}
