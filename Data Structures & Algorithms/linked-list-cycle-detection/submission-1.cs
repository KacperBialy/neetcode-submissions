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
    public bool HasCycle(ListNode head) {
        var hashSet = new HashSet<int>();

        while (head != null)
        {
            if (!hashSet.Add(head.GetHashCode()))
                return true;

            head = head.next;
        }

        return false;
    }
}
