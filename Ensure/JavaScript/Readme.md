# Ensure

Implement the ensure funtion so that it throws an error if called without arguments or the argument is ***undefined***. Otherwise it should return given value.

```javascript
function ensure(value){
    if(value === undefined) {
        throw new Error('no arguments');
    }
    return value;
}

try {
    console.log(ensure());
} catch(err){
    console.log(err);
}
```