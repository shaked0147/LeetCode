using System.Numerics;
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        BigInteger mul1 = 1, mul2 = 1;
            BigInteger number1 = 0, number2 = 0;

            while(l1 != null || l2 != null)
            {
                if(l1 != null)
                {
                    number1 += l1.val * mul1;
                    l1 = l1.next;
                    mul1 *= 10;
                }

                if (l2 != null)
                {
                    number2 += l2.val * mul2;
                    l2 = l2.next;
                    mul2 *= 10;
                }
            }

            BigInteger r = number1 + number2;

            ListNode head, tail;
            head = new ListNode();
            tail = head;

            while (r > 0)
            {
                tail.val = (int)(r % 10);
                r /= 10;
                if (r != 0)
                {
                    tail.next = new ListNode();
                    tail = tail.next;
                }
            }

            return head;
    }
}