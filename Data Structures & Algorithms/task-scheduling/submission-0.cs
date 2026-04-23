public class Solution {
    public int LeastInterval(char[] tasks, int n) {
    Dictionary<char, int> tasksDict = new();
    foreach (var task in tasks)
    {
        if (!tasksDict.TryAdd(task, 1))
            tasksDict[task]++;
    }

    var priorityQueue = new PriorityQueue<int, int>();

    foreach (var count in tasksDict.Values)
        priorityQueue.Enqueue(count, -count);

    var queue = new Queue<(int count, int availableAt)>();

    var time = 0;
    while (priorityQueue.Count > 0 || queue.Count > 0)
    {
        time += 1;

        if (priorityQueue.Count > 0)
        {
            var nextTaskCount = priorityQueue.Dequeue() - 1;
            if (nextTaskCount > 0)
                queue.Enqueue((nextTaskCount, time + n));
        }

        if (queue.Count > 0 && queue.Peek().availableAt == time)
        {
            var (count, _) = queue.Dequeue();
            priorityQueue.Enqueue(count, -count);
        }
    }

    return time; 
    }
}
