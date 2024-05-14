using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_answers
{
    public class LinkedListAnswers
    {

        public bool HasCycle(ListNode head)
        {
            HashSet<ListNode> visited = new HashSet<ListNode>();
            while (head != null)
            {
                if (visited.Contains(head))
                {
                    return true;
                }
                visited.Add(head);
                head = head.next;
            }
            return false;
        }   
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            // find head
            var dummyNode = new ListNode(0);
            var currentNode = dummyNode;
            var currentA = list1;
            var currentB = list2;
            

            // compare each node from each list
            while (currentA!= null && currentB != null)
            {
                // if a is less
                if(currentA.val <= currentB.val)
                {
                    currentNode.next = currentA;               
                    currentA = currentA.next;
                }
                // if b is less
                else
                {
                    currentNode.next = currentB;
                    currentB = currentB.next;
                }
                currentNode = currentNode.next;
            }
            // check for any remainding nodes (can only be from 1 list)
            if (currentA != null)
            {
                while(currentA != null)
                {
                    currentNode.next = currentA;
                    currentA = currentA.next;
                    currentNode = currentNode.next;
                }
            }
            else
            {
                while (currentB != null)
                {
                    currentNode.next = currentB;
                    currentB = currentB.next;
                    currentNode = currentNode.next;
                }
            }
            return dummyNode.next;
        }
    }
}
