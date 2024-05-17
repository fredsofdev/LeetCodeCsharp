using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week5
{
    public class RedBlackBST
    {
        private Node? root;
        class Node
        {
            public int key;
            public int value;
            public Node left;
            public Node right;
            public bool color = true;
            public Node(int key, int value)
            {
                this.key = key;
                this.value = value;
            }

            public bool isRed() => color;
        }

        public int? Get(int key)
        {
            Node x = root;
            while(x != null)
            {
                int cmp = key.CompareTo(x.key);
                if(cmp < 0) x = x.left;
                else if (cmp > 0) x = x.right;
                else return x.value;
            }
            return null;
        }

        public void Put(int key, int value)
        {
            root = put(root, key, value);
        }

        private Node put(Node x, int key, int value)
        {
            if(x == null) return new Node(key, value);
            int cmp = key.CompareTo(x.key);
            if (cmp < 0) put(x.left, key, value);
            else if (cmp > 0) put(x.right, key, value);
            else x.value = value;

            if(!x.left.isRed() && x.right.isRed()) RotateLeft(x);
            if(x.left.isRed() && x.left.left.isRed()) RotateRight(x);
            if (x.left.isRed() && x.right.isRed()) FlipColors(x);

            return x;
        }

        private Node RotateLeft(Node node)
        {
            Node right = node.right;
            node.right = right.left;
            right.left = node;
            right.color = node.color;
            node.color = true;
            return right;
        }

        private Node RotateRight(Node node)
        {
            Node left = node.left;
            node.left = left.right;
            left.right = node;
            left.color = node.color;
            node.color = true;
            return left;
        }

        private Node FlipColors(Node node)
        {
            node.color = true;
            node.right.color = false;
            node.left.color = false;
            return node;
        }

    }
}
