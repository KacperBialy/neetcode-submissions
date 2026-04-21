public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var priorityQueue = new PriorityQueue<int[], int>();

        foreach (var point in points)
        {
            priorityQueue.Enqueue(point, -(point[0] * point[0] + point[1] * point[1]));

            if (priorityQueue.Count > k)
                priorityQueue.Dequeue();
        }

        var result = new int[k][];

        for (var i = 0; i < k; i++)
            result[i] = priorityQueue.Dequeue();

        return result;
    }
}
