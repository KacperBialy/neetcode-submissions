public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
    var carDetails = new List<(int position, int speed)>();
    for (var i = 0; i < position.Length; i++)
        carDetails.Add((position[i], speed[i]));

    carDetails.Sort((detailB, detailA) => detailA.position.CompareTo(detailB.position));

    var fleets = 0;
    var lastTime = 0.0;

    foreach (var detail in carDetails)
    {
        var time = (double)(target - detail.position) / detail.speed;

        if (fleets == 0 || time > lastTime)
        {
            lastTime = time;
            fleets++;
        }
    }

    return fleets;
    }
}
