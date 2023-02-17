namespace SwapNodePairs.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;

    public UnitTest1()
    {
        _test = new Class1();
    }

    [TestMethod]
    public void TestMethod1()
    {
        ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, null))));
        ListNode answer = new ListNode(2, new ListNode(1, new ListNode(4, new ListNode(3, null))));
        ListNode result = _test.SwapPairs(head);
        bool same = true;

        while (result != null)
        {
            var ans = answer.val;
            var res = result.val;
            if (ans != res)
            {
                same = false;
                break;
            }
            answer = answer.next;
            result = result.next;
        }

        Assert.IsTrue(same);

    }
    [TestMethod]
    public void TestMethod2()
    {
        ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null)))));
        ListNode answer = new ListNode(2, new ListNode(1, new ListNode(4, new ListNode(3, new ListNode(5, null)))));
        ListNode result = _test.SwapPairs(head);
        bool same = true;

        while (result != null)
        {
            var ans = answer.val;
            var res = result.val;
            if (ans != res)
            {
                same = false;
                break;
            }
            answer = answer.next;
            result = result.next;
        }

        Assert.IsTrue(same);

    }
    [TestMethod]
    public void TestMethod3()
    {
        ListNode head = new ListNode(1, null);
        ListNode answer = new ListNode(1, null);
        ListNode result = _test.SwapPairs(head);
        bool same = true;

        while (result != null)
        {
            var ans = answer.val;
            var res = result.val;
            if (ans != res)
            {
                same = false;
                break;
            }
            answer = answer.next;
            result = result.next;
        }

        Assert.IsTrue(same);

    }
}