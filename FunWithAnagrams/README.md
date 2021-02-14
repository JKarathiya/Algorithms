# Fun with Anagrams

Two strings are anagrams if they are permutations of each others. In other words, both strings have the same size and the same characters. For example, "aaagmnrs" is and anagram of "anagrams". Given an array of string, remove each string that is an anagram of an earlier string, then return the remaining array in sorted order.

#### Example

```str = ['code', 'doce', 'ecod', 'framer', 'frame']```

* ```code``` and ```doce``` are anagrams. Remove ```doce``` from the array and keep the first occurrence ```code``` in the array.
* ```code``` and ```ecod``` are anagrams. Remove ```ecod``` from the array and keep the first occurrence ```code``` in the array.
* ```code``` and ```framer``` are not anagrams. Keep both strings in the array.
* ```framer``` and ```frame``` are not anagrams due to the extra ```r``` in ```framer```. Keep both strings in the array.
* Order the remaining strings in ascending order: ```['code','frame','framer']```.

#### Function Description
Complete the function funWithAnagrams.

funWithAnagrams has the following parameters:

```string text[n]: an array of strings;```

Returns

```string[m]: an array of the remaining strings in ascending alphabetical order.```

