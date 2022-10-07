Problem: 

Given a string _input_ consisting of N lowercase letters, returns the minimum number of letters that must be deleted to obtain a word in which every letter occurs a unique number of times. We only care about occurrences of letters that appear at least once in result.

Example

1. Given _input_ = "aaaabbbb", the function should return 1. We can delete one occurrence of a or one occurrence of b then one letter will occur four times and the other one three times.

2. Given _input_ = "ccaaffddecee", the function should return 6. For example, we can delete all occurrences of e and f and one occurrence of d to obtain the word "ccaadc". Note that both e and f will occur zero times in the new word, but that is fine, since we only care about letters that appear at least once.

3. Given _input_ = "eeee", the function should return 0 (there is no need to delete any characters).

4. Given _input_ = "example", the function should return 4.

Write an efficient algorithm for the following assumptions:
- N is an integer with the range [0..300,000];
- string _input_ consists only of lowercase letters(a-z).

Solution: