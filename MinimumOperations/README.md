Given a binary string consisting of character '0' and '1', the following operation can be performed on it:

Choose two adjacent cahracters, and replace both the characters with their bitwise XOR value. For example, if binaryStr = "1100" and the first two characters are chosen, then after one operation, the string becomes binaryStr = "0000".

The goal is to find the minimum number of operations needed to convert all characters of the string to '0'

#Example
Consider the given binary string to be binaryStr = "101"

#An optimal sequence of operations is:

1. Select the 1st and 2nd character, then binaryStr == "111".
2. Select the 1st and 2nd character, then binaryStr == "001".
3. Select the 2st and 3nd character, then binaryStr == "011".
4. Select the 2st and 3nd character, then binaryStr == "000".

Optimally, all characters can be converted to 0 in 4 operations.

#Function Description
Complete the function getMinimumOperations.

getMinimumOperations has the following parameter:
string binaryStr: the binary string

#Returns
int: the minimum operations needed to convert all characters to 0
