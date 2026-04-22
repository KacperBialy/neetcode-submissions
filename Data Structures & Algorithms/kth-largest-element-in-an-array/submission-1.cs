public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var priorityQueue = new PriorityQueue<int, int>(k);

        foreach(var num in nums)
        {
            if(priorityQueue.Count < k)
                priorityQueue.Enqueue(num, num);
            else if(num > priorityQueue.Peek())
                priorityQueue.EnqueueDequeue(num, num);
        }

        return priorityQueue.Peek();
    }
}
