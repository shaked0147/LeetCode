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
    public ListNode MergeKLists(ListNode[] lists) {
         ListNode answer = new ListNode();
            ListNode tail = answer;
            if (lists == null || lists.Length == 0)
            {
                answer = null;
                return answer;
            }

            int min = int.MaxValue;
            int minplace = 0;
            for (int i = 0; i < lists.Length; i++)
            {
                if (lists[i] != null)
                {
                    if(min > lists[i].val)
                    {
                        min = lists[i].val;
                        minplace = i;
                    }
                }
            }
            if (min == int.MaxValue)
                return null;

            answer.val = lists[minplace].val;
            lists[minplace] = lists[minplace].next;
            min = int.MaxValue;

            bool flag = true;
            while (flag)
            {
                for (int i = 0; i < lists.Length; i++)
                {
                    if (lists[i] != null)
                    {
                        if (lists[i].val < min)
                        {
                            min = lists[i].val;
                            minplace = i;
                        }
                    }
                }

                if (min != int.MaxValue)
                {
                    tail.next = new ListNode();
                    tail = tail.next;
                    tail.val = min;
                    lists[minplace] = lists[minplace].next;
                    min = int.MaxValue;
                }

                flag = false;
                for (int i = 0; i < lists.Length; i++)
                    if (lists[i] != null)
                        flag = true;
            }

            return answer;
    }
}