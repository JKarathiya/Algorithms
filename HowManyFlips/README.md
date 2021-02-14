Given a string S, the task is to find minimum flips required to convert an initial binary string consisting of only zeroes to S where every flip of a character flips all succeeding characters as well. 
Examples: 
 

Input: S = “01011” 
Output: 3 
Explanation: 
Initial String – “00000” 
Flip the 2nd bit – “01111” 
Flip the 3rd bit – “01000” 
Flip the 4th bit – “01011” 
Total Flips = 3
Input: S = “01001” 
Output: 3 
Explanation: 
Initial String – “00000” 
Flip the 2nd bit – “01111” 
Flip the 3rd bit – “01000” 
Flip the 5th bit – “01001” 
Total Flips = 3 
