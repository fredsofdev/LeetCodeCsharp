using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week4.BST
{
    public class BSTTable<Key , Value> where Key : IComparable
    {
        private TreeNode<Key, Value>? root;

        public void Put(Key key, Value value)
        {
            root = put(root, key, value);
        }

        private TreeNode<Key, Value> put(TreeNode<Key, Value>? x, Key key, Value value) 
        {
            if(x == null) return new (key, value);
            int cmp = x.key.CompareTo(key);
            if (cmp < 0) x.left = put(x.left, key, value);
            else if (cmp > 0) x.right = put(x.right, key, value);
            else x.val = value;
            return x;
        }

        public Value Get(Key key)
        {
            TreeNode<Key,Value> x = root;
            while (x != null)
            {
                int cmp = x.key.CompareTo(key);
                if (cmp > 0) x = x.right;
                else if (cmp < 0) x = x.left;
                else return x.val;
            }
            return default;
        }

        public void Delete(Key key) { } 


        public Key? Floor(Key key)
        {
            var fl = floor(root, key);
            if (fl == null) return default;
            return fl.key;
        }

        private TreeNode<Key, Value>? floor(TreeNode<Key, Value>? x, Key key)
        {
            if (x == null) return null;
            int cmp = x.key.CompareTo(key);
            if (cmp == 0) return x;

            if (cmp < 0) return floor(x.left, key);

            var t = floor(x.right, key);
            if (t != null) return t;
            return x;
        }

    }
}
