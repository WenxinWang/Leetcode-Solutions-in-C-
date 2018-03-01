/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 
 
 * review list knowlegde : https://www.cnblogs.com/caokai520/p/4334453.html
 *  Link List data Structreu in c#: https://www.oudahe.com/p/30864/
 
*/
 
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        
        if (l1 == null) return l2;
        if (l2 == null) return l1;
                
        var resultList = new ListNode(0);    // fake head, val = 0;
        var curList = resultList;
        
        while (l1 != null && l2 != null)
        {
            if (l1.val < l2.val)
            {
                curList.next = l1;
                l1 = l1.next;
            }
            else
            {
                curList.next = l2;
                l2 = l2.next;
            }
           curList = curList.next;
        }
        
        if (l1 == null)
        {
            curList.next = l2;
        }        
         if (l2 == null)
        {
           curList.next = l1;
        }
        
        return resultList.next;
    }
}

/** input: [1,2,4],[1,3,4] -> wrong output: [4]
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        
        if (l1 == null) return l2;
        if (l2 == null) return l1;
                
        var resultList = new ListNode(0);
        var curList = resultList;
        
        while (l1 != null && l2 != null)
        {
            if (l1.val < l2.val)
            {
                resultList.next = l1;
                l1 = l1.next;
            }
            else
            {
                resultList.next = l2;
                l2 = l2.next;
            }
            resultList = resultList.next;
        }
        
        if (l1 == null)
        {
            resultList.next = l2;
        }        
         if (l2 == null)
        {
           resultList.next = l1;
        }
        
        return resultList.next;
    }
}

*/
// Time Complexity: O(n1 + n2), n1 + n2 is the length of l1 and l2.
// Space Complexity: O(n1 + n2)
