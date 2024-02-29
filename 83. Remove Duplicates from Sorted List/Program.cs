public class Program
{
    public static void Main(string[] args)
    {
        var nodeOne = new ListNode(1, null);
        var nodeTwo = new ListNode(1, null);
        var nodeThree = new ListNode(2, null);

        nodeOne.next = nodeTwo;
        nodeTwo.next = nodeThree;

        var head = DeleteDuplicates(nodeOne);
    }

    public static ListNode DeleteDuplicates(ListNode head)
    {
        if (head != null)
        {
            ListNode current = head;

            while (current.next != null)
            {
                if (current.val == current.next.val)
                {
                    ListNode temp = current.next;
                    current.next = temp.next;
                }
                else
                {
                    current = current.next;
                }
            }
        }

        return head;
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
