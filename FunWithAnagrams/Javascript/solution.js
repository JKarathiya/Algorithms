function funWithAnagrams(text) {
    let tempset = new Set();
    let result = [];

    for (let i = 0; i < text.length; i++) {
        let tempString = text[i].split('').sort().join('');
        if (!tempset.has(tempString)) {
            result.push(text[i]);
            tempset.add(tempString);
        }
    }
    return result.sort();
}

module.exports = funWithAnagrams;