using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int minPartitions(List<int> used, List<int> totalCapacity)
    {
        int partitionCount = 0;
        totalCapacity.Sort();
        totalCapacity.Reverse();
        int unallocatedDataSize = used.Count;
        while (unallocatedDataSize > 0 && totalCapacity.Count != 0)
        {
            var partitionSize = totalCapacity[partitionCount];
            totalCapacity.RemoveAt(partitionCount);
            partitionCount = partitionCount + 1;
            unallocatedDataSize = unallocatedDataSize - partitionSize;
        }
        return partitionCount;
    }
}