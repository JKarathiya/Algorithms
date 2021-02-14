function findMaxWords(input) {
    let sentences = input.split(/[?.!]+/);
    let maxWords = 0;
    sentences.forEach(sentence => {
        var words = sentence.split(" ");
        var currWords = words.length;
        words.forEach(word => {
            if (word.trim() == "") {
                currWords--;
            }
        })
        maxWords = maxWords < currWords ? currWords : maxWords;
    });
    return maxWords;
}

module.exports = findMaxWords;