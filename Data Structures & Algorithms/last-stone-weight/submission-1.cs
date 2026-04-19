public class Solution {
    public int LastStoneWeight(int[] stones) {
        var priorityQueue = new PriorityQueue<int, int>();

        foreach (var stone in stones)
        {
            priorityQueue.Enqueue(stone, -stone);
        }

        while (priorityQueue.Count > 1)
        {
            var stoneA = priorityQueue.Dequeue();
            var stoneB = priorityQueue.Dequeue();

            if (stoneA == stoneB)
                continue;

            var newValue = stoneA - stoneB;
            priorityQueue.Enqueue(newValue, -newValue);
        }

        return priorityQueue.Count > 0 ? priorityQueue.Dequeue() : 0;
    }
}
