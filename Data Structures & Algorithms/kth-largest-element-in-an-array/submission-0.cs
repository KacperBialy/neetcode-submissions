public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var priorityQueue = new PriorityQueue<int, int>();

        foreach(var num in nums)
        {
            priorityQueue.Enqueue(num, num);

            if(priorityQueue.Count > k)
                priorityQueue.Dequeue();
        }

        return priorityQueue.Peek();
    }
}
