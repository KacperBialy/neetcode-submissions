public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var priorityQueue = new PriorityQueue<int[], double>();

        foreach (var point in points)
            priorityQueue.Enqueue(point, Math.Sqrt(Math.Pow(point[0], 2) + Math.Pow(point[1], 2)));

        List<int[]> result = [];

        foreach (var _ in Enumerable.Range(0, k))
        {
            result.Add(priorityQueue.Dequeue());
        }

        return result.ToArray();
    }
}
