using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var r1 = l1;
            var r2 = l2;
            var newList = new ListNode(0);
            var Head = newList;
            var carry = 0;
            while (r1 != null || r2 != null)
            {
                var a = r1?.val ?? 0;
                var b = r2?.val ?? 0;
                var sum = a + b + carry;
                carry = sum / 10;
                newList.next = new ListNode(sum % 10);
                newList = newList.next;
                r1 = r1?.next;
                r2 = r2?.next;
            }

            if (carry != 0)
            {
                newList.next = new ListNode(carry);
            }

            return Head.next;
        }
    }
}
