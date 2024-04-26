public class Program
{
    public static void Main(string[] args)
    {
        var node1 = new ListNode(1, null);
        var node2 = new ListNode(2, null);
        var node3 = new ListNode(3, null);
        var node4 = new ListNode(4, null);
        var node5 = new ListNode(5, null);

        node1.next = node2;
        node2.next = node3;
        node3.next = node4;
        node4.next = node5;

        var head = node1;

        var reverseList = ReverseList(head);
    }

    public static ListNode ReverseList(ListNode head)
    {
        ListNode newList = null;
        if(head != null) {
            ListNode current = head;
            while(current != null) {
                newList = new ListNode(current.val, newList);
                current = current.next;
            }
        }

        return newList;
    }
}


public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
