function rollercoasterWord(input) {
    let word = input.toLowerCase();
    for (let i = 0; i < word.length - 2; i++) {
        let a = word[i],
            b = word[i + 1],
            c = word[i + 2];
        if (!((a < b && b > c) ||
            (a > b && b < c))) {
            return false
        }
    }
    return true
}

module.exports = rollercoasterWord;