using leetcode_answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests
{
    public class LinkedListTests
    {
        public LinkedListAnswers answer = new LinkedListAnswers();

        public ListNode CreateLinkedList(List<int> list, bool cycle)
        {
            ListNode head = new ListNode(list[0]);
            ListNode currentNode = head;
            if(list.Count > 1)
            {
                for(int i = 1; i < list.Count; i++)
                {
                    ListNode nextNode = new ListNode(list[i]);
                    currentNode.next = nextNode;
                    currentNode = nextNode; 
                }
                if(cycle) currentNode.next = head;
            }
            return head;
            
        }
        [Test]
        public void TestHasCycle()
        {
            List<int> list = new List<int>();
            // 3,2,0,-4
            list.Add(1); list.Add(2); list.Add(3);
            ListNode head = CreateLinkedList(list, true);
            Assert.That(answer.HasCycle(head), Is.True);

        }

        //[Test]
        //public void TestMergeTwoLists()
        //{
        //    List<int> list1 = new List<int>();
        //    list1.Add(1); list1.Add(2);list1.Add(4); 
        //    ListNode head1 = CreateLinkedList(list1, false);
        //    List<int> list2 = new List<int>();
        //    list2.Add(1); list2.Add(3); list2.Add(4);
        //    ListNode head2 = CreateLinkedList(list2, false);
        //    List<int> resultList = new List<int>();
        //    // [1,1,2,3,4,4]
        //    resultList.Add(1); resultList.Add(1); resultList.Add(2);  resultList.Add(3); resultList.Add(4); resultList.Add(4);
        //    ListNode resultHead = CreateLinkedList(resultList, false);
        //    Assert.That(answer.MergeTwoLists(head1, head2), Is.EqualTo(resultHead));
        //}
        
    }
}
