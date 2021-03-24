Problem: 

Given a string str and a dictionary dict containing a list of non-empty words,​
add spaces in str to construct a “sentence” where each word is a valid word in dict.  
Return all possible sentences.  
There are no words in str which are not in the dict​
(You are allowed to reuse the words in dict.) 

Example:

```
str = "penpineapplepenapple"​
dict = ["apple", "pen", "applepen", "pine", "pineapple"] 
 
makeSentence(str, dict) 
 
Output:​
[​
    "pen pine apple pen apple",​
    "pen pineapple pen apple",​
    "pen pine applepen apple"​
] 
```

Run test 
```
npm test
```