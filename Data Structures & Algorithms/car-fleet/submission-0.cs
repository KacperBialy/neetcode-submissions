public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        List<(int position, int speed)> carDetails = new List<(int position, int speed)>();
        for(int i = 0; i < position.Length; i++) 
        {
            carDetails.Add((position[i], speed[i]));
        }

        carDetails.Sort((detailB, detailA) => detailA.position.CompareTo(detailB.position));

        Stack<double> fleets = new Stack<double>();

        foreach(var detail in carDetails)
        {
            double time = (double)(target - detail.position) / detail.speed;
            
            if(!fleets.Any() || time > fleets.Peek())
            {
                fleets.Push(time);
            }
        }

        return fleets.Count;
    }
}