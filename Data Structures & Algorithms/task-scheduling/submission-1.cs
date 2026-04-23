public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        var taskCounters = tasks.GroupBy(task => task, (task, elements) => elements.Count())
                .Select(count => (c: count, -count));

            var priorityQueue = new PriorityQueue<int, int>(taskCounters);

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
