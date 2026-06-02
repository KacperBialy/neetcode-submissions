public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {
         var map = times
        .GroupBy(t => t[0], t => (node: t[1], time: t[2]))
        .ToDictionary(g => g.Key, g => g.ToList());

        var priorityQueue = new PriorityQueue<int, int>();
        priorityQueue.Enqueue(k, 0);

        var visited = new HashSet<int>();
        var answer = 0;
        while (priorityQueue.TryDequeue(out var node, out var currentTime))
        {
            if (!visited.Add(node))
                continue;

            answer = currentTime;

            if (!map.TryGetValue(node, out var next)) 
                continue;                              

            foreach (var (to, nextTime) in next)
                priorityQueue.Enqueue(to, currentTime + nextTime);
        }

        return visited.Count == n ? answer : -1;
    }
}
