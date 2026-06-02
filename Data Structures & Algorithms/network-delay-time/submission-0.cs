public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {
        var map = new Dictionary<int, List<(int node, int time)>>();

        foreach (var time in times)
        {
            if (map.TryGetValue(time[0], out var value))
                value.Add((time[1], time[2]));
            else
                map[time[0]] = [(time[1], time[2])];
        }

        var priorityQueue = new PriorityQueue<(int node, int time), int>();
        priorityQueue.Enqueue((k, 0), 0);

        var visited = new HashSet<int>();
        var answer = 0;
        while (priorityQueue.Count > 0)
        {
            var (currentNode, currentTime) = priorityQueue.Dequeue();

            if(!visited.Add(currentNode))
                continue;

            answer = currentTime;

            if (map.TryGetValue(currentNode, out var next) && next.Count > 0)
            {
                foreach (var (node, time) in next)
                    priorityQueue.Enqueue((node, currentTime + time), currentTime + time);
            }

        }

        return visited.Count == n ? answer : -1; 
    }
}
