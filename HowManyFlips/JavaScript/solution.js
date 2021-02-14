function howmanyflips(target) {
    let curr = '1';
    let count = 0;
    let chars = target.split('');
    chars.forEach(char => {
        if (char == curr) {
            count++;
            curr = String.fromCharCode(48 + (parseInt(curr) + 1) % 2);
        }
    })
    return count;
}

module.exports = howmanyflips;