function maximumpossiblevalue(input) {
    let abs = input >= 0 ? 1 : -1;
    let max = -8000;
    var str = Math.abs(input).toString();
    for (let i = 0; i < str.length; i++) {
        let val = abs * parseInt(str.substring(0, i) + "5" + str.substring(i, str.length));
        if (val > max)
            max = val;
    }
    return max;
}

module.exports = maximumpossiblevalue;