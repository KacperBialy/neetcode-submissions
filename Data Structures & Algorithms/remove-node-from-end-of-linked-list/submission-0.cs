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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var helper = new ListNode(0, head);

        var previous = helper;
        var next = helper.next;

        for (var i = 0; i < n; i++)
            next = next.next;

        while (next != null)
        {
            previous = previous.next;
            next = next.next;
        }

        previous.next = previous.next.next;

        return helper.next;
    }
}
