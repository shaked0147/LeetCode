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
         if (lists.Length == 0)
                return null;

            List<int> list = new List<int>();
            int i = 0;
            while(i < lists.Length)
            {
                if (lists[i] != null)
                {
                    list.Add(lists[i].val);
                    lists[i] = lists[i].next;
                }

                if (lists[i] == null)
                    i++;
            }
            list.Sort();

            if (list.Count == 0)
                return null;

            ListNode head = new ListNode(list[0]);
            ListNode tail = head;

            for(i = 1; i < list.Count; i++)
            {
                tail.next = new ListNode(list[i]);
                tail = tail.next;
            }
            return head;
    }
}