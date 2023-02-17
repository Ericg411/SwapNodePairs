namespace SwapNodePairs;

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

public class Class1
{
    public ListNode SwapPairs(ListNode head)
    {
        if (head == null)
        {
            return null;
        }
        ListNode result = new ListNode();
        List<int> listOne = new List<int>();
        List<int> listTwo = new List<int>();
        bool initialized = false;
        while (head != null)
        {
            listOne.Add(head.val);
            head = head.next;
            if (head != null)
            {
                listTwo.Add(head.val);
                head = head.next;
            }
        }
        if (listOne.Count > listTwo.Count)
        {
            result = new ListNode(listOne[listOne.Count - 1], null);
            initialized = true;
            listOne.RemoveAt(listOne.Count - 1);
        }
        for (int i = listOne.Count - 1; i >= 0; i--)
        {
            if (i == listOne.Count - 1 && !initialized)
            {
                result = new ListNode(listOne[i], null);
            }
            else
            {
                result = new ListNode(listOne[i], result);
            }
            if (listTwo.Count != 0)
            {
                result = new ListNode(listTwo[i], result);
            }
        }
        return result;
    }
}
