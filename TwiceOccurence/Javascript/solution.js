function twiceOccurence(input) {
    let charSet = new Set();
    for (let i = 0; i < input.length; i++) {
        if (!charSet.has(input[i])) {
            return input[i];
        }
        charSet.add(input[i]);
    }
    return "";
}

module.exports = twiceOccurence;