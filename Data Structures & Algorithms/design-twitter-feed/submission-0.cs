public class Twitter {

 private int _timestamp;
    private readonly Dictionary<int, List<(int tweetId, int timestamp)>> _tweets = new();
    private readonly Dictionary<int, HashSet<int>> _followee = new();

    public void PostTweet(int userId, int tweetId)
    {
        if (!_tweets.ContainsKey(userId))
            _tweets[userId] = [];

        _tweets[userId].Add((tweetId, _timestamp++));
    }

    public List<int> GetNewsFeed(int userId)
    {
        var sources = new List<int> { userId };
        if (_followee.TryGetValue(userId, out var followingSet))
            sources.AddRange(followingSet);

        PriorityQueue<int, int> priorityQueue = new();
        foreach (var source in sources)
        {
            if (_tweets.TryGetValue(source, out var tweetSet))
            {
                foreach (var tweet in tweetSet)
                {
                    if (priorityQueue.Count < 10)
                        priorityQueue.Enqueue(tweet.tweetId, tweet.timestamp);
                    else
                        priorityQueue.EnqueueDequeue(tweet.tweetId, tweet.timestamp);
                }
            }
        }

        List<int> newsFeed = [];

        while (priorityQueue.Count > 0)
            newsFeed.Add(priorityQueue.Dequeue());

        newsFeed.Reverse();
        return newsFeed;
    }

    public void Follow(int followerId, int followeeId)
    {
        if (followerId == followeeId)
            return;

        if (!_followee.ContainsKey(followerId))
            _followee[followerId] = [];

        _followee[followerId].Add(followeeId);
    }

    public void Unfollow(int followerId, int followeeId)
    {
        if (_followee.TryGetValue(followerId, out var followingSet))
            followingSet.Remove(followeeId);
    }
}
