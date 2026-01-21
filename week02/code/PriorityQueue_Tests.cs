using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Make a queue and enqueue these values and priorities: (A, 1), (B, 2), (C, 3),
    // then dequeue once
    // Expected Result: PriorityQueue is [A (Pri:1), B (Pri:2), C (Pri:3)], then C is dequeued

    // Initial Result: Queue was enqueued correctly, but dequeued B

    // Defect(s) Found: The for loop in Dequeue didn't run for the last item in the queue
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 3);

        Assert.AreEqual("[A (Pri:1), B (Pri:2), C (Pri:3)]", priorityQueue.ToString());
        Assert.AreEqual("C", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Make a queue and enqueue these values and priorities: (A, 3), (B, 1), (C, 3),
    // then dequeue once
    // Expected Result: The code should dequeue A

    // Initial Result: The code dequeued C

    // Defect(s) Found: The Dequeue function checked for whether the current index's priority was
    // also equal to the high priority index's priority, so the high priority index was changed to
    // the last high-priority index instead of the first
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 3);
        priorityQueue.Enqueue("B", 1);
        priorityQueue.Enqueue("C", 3);

        Assert.AreEqual("[A (Pri:3), B (Pri:1), C (Pri:3)]", priorityQueue.ToString());
        Assert.AreEqual("A", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Make a queue and enqueue these values and priorities: (A, 1), (B, 2), (C, 3),
    // then dequeue until there's nothing left, then dequeue again
    // Expected Result: InvalidOperationException error

    // Initial Result: No error was thrown
    
    // Defect(s) Found: Dequeue didn't remove anything from the queue
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 3);

        Assert.AreEqual("[A (Pri:1), B (Pri:2), C (Pri:3)]", priorityQueue.ToString());

        priorityQueue.Dequeue();
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();

        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }
}