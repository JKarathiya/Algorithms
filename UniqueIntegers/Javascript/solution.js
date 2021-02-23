function uniqueIntegers(N) {
    let result = [];
    for (let i = 0; i < N - 1; i = i + 2) {
        result[i] = i + 1;
        result[i + 1] = -result[i];
    }
    return result;
}

module.exports = uniqueIntegers;