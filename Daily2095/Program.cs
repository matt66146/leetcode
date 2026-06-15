

var data = new int[] { 1, 2 };
ListNode head = new();

if (data.Length >= 2)
{
    head = new ListNode(data[0], new ListNode(data[1]));

}
else
{
    head = new ListNode(data[0], null);
}

ListNode current = head.next;
for (int i = 2; i < data.Length; i++)
{
    current.next = new ListNode(data[i]);
    current = current.next;
}

current = head;

var result = DeleteMiddle(head);
//Console.WriteLine("head: " + result?.val.ToString());
//Console.WriteLine("next: " + result?.next?.ToString());
PrintListNodes(result);



ListNode DeleteMiddleV1(ListNode head)
{
    ListNode current = head;
    int length = 0;
    while (current != null)
    {
        length++;
        current = current.next;
    }
    current = head;
    int i = 0;
    int middle = (length / 2);
    if (middle < 0) middle = 0;
    if (middle == 0)
    {
        return null;
    }
    while (current != null)
    {
        if (i == middle - 1)
        {




            if (current.next != null)
            {
                current.next = current.next.next;
            }

            break;

        }
        current = current.next;
        i++;
    }

    return head;

}
ListNode DeleteMiddleV2(ListNode head)
{
    List<ListNode> cheese = new();
    ListNode current = head;
    int length = 0;
    while (current != null)
    {
        length++;
        cheese.Add(current);
        current = current.next;
    }

    if (cheese.Count == 1)
    {
        return null;
    }

    var prev = cheese[(cheese.Count / 2) - 1];
    ListNode? next = null;
    try
    {
        next = cheese[(cheese.Count / 2) + 1];
    }
    catch (Exception ex)
    {

    }

    prev.next = next;

    return head;
}
ListNode DeleteMiddle(ListNode head)
{
    ListNode fast = head;
    ListNode slow = head;
    ListNode prev = head;

    if (head.next == null)
    {
        return null;
    }
    if (head.next.next == null)
    {
        head.next = null;
        return head;
    }

    while (fast != null && fast.next != null)
    {

        fast = fast.next.next;
        prev = slow;
        slow = slow.next;

    }
    prev.next = prev.next.next;
    return head;
}


void PrintListNodes(ListNode head)
{
    while (head != null)
    {
        Console.WriteLine(head.val);
        head = head.next;
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