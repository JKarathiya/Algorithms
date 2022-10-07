# Consolidating Partitions

There is a computer with a hard drive that is partitioned into serveral partions. The data needs to be moved around so that the minimum number of partitions are being used. Given how much space is currently being used on each partition, as well as the total capacity of each, what is the minimum number of partitions needed to hold all thedata if it is moved around optimally?

#### Example
```used = [3, 2, 1, 3, 1]```

```totalCapacity = [3, 5, 3, 5, 5]```

The data can be moved around like so:

* Move all the data (3 units of space) from the first partition to the second. This would empty the first partition, and the second partition would then be at fully capacity.
* Move the data from the third partition (1 unit) and fifth partion (1 unit) into the fourth partion. This would empty the third and fifth partitions and the fourth partition would then be at full capacity.

By doing this, all the data can be fit into a minimum of 2 partitions.
Therefore, the answer is 2.

#### Function Description
Complete the function miniPartitions.

minPartitions has the following parameters:

```int used[n]: the amount of used space on each partition```
```int totalCapacity[n]: the total capacity of each partition```

Returns:
int: the minimum number of partitions needed to store all the data.