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

        var heap = new PriorityQueue<(int source, int index), int>();

        foreach (var source in sources)
        {
            if (_tweets.TryGetValue(source, out var tweets) && tweets.Count > 0)
            {
                var last = tweets.Count - 1;
                heap.Enqueue((source, last), -tweets[last].timestamp);
            }
        }

        List<int> newsFeed = [];
        while (newsFeed.Count < 10 && heap.Count > 0)
        {
            var (source, index) = heap.Dequeue();
            newsFeed.Add(_tweets[source][index].tweetId);
            if (index > 0)
                heap.Enqueue((source, index - 1), -_tweets[source][index - 1].timestamp);
        }

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
