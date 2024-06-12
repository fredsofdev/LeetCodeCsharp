using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
internal class _117_Populating_Next_Right_Pointers_in_Each_Node_2
{
    //Failed to solve because cannot have idea to solve
    public Node Connect(Node root)
    {
        Node dummyHead = new Node(0); 
        Node pre = dummyHead;  
        Node real_root = root;

        while (root != null)
        {
            if (root.left != null)
            {
                pre.next = root.left;
                pre = pre.next;
            }
            if (root.right != null)
            {
                pre.next = root.right;
                pre = pre.next;
            }
            root = root.next;
            if (root == null)
            { 
                pre = dummyHead; 
                root = dummyHead.next; 
                dummyHead.next = null;
            }
        }
        return real_root;
    }
   
}
