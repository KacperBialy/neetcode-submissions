public class Solution {
    public int CalPoints(string[] operations) {
        List<int> scores = [];
        foreach (var operation in operations)
        {
            switch (operation)
            {
                case "C":
                    scores.RemoveAt(scores.Count - 1);
                    break;
                case "D":
                    scores.Add(scores[^1] * 2);
                    break;
                case "+":
                    scores.Add(scores[^1] + scores[^2]);
                    break;
                default:
                    scores.Add(int.Parse(operation));
                    break;
            }
        }

        return scores.Sum();
    }
}