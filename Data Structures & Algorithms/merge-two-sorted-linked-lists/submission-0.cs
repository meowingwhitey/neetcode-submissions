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
 
public class Solution 
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
    {
        ListNode head = new ListNode();
        ListNode cursor = head;
        while(list1 != null || list2 != null)
        {
            if(list1 == null && list2 == null)    
                return null;

            if(list1 == null)
            {
                cursor.next = list2;
                list2 = list2.next;
                cursor = cursor.next;
                continue;
            }
            if(list2 == null)
            {
                cursor.next = list1;
                list1 = list1.next;
                cursor = cursor.next;
                continue;
            }
            if(list1.val < list2.val)
            {
                cursor.next = list1;
                list1 = list1.next;
            }
            else 
            {
                cursor.next = list2;
                list2 = list2.next;
            }
            cursor = cursor.next;
        }
        return head.next;
    }
}