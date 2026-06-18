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
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        
        ListNode left = dummy;
        ListNode right = head;
        
        for (int i = 0; i < n; i++) {
            right = right.next;
        }
        
        while (right != null) {
            left = left.next;
            right = right.next;
        }
        
        left.next = left.next.next;
        
        return dummy.next;
    }
}
