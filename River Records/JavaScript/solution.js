function maxTrailing(levels) {
    let minValue = levels[0];
    let maxValue = -1;

    for (let i = 0; i < levels.length; i++) {
        if (levels[i] < minValue)
            minValue = levels[i];
        let result = levels[i] - minValue;
        if (result != 0 && result > maxValue)
            maxValue = result;
    }

    return maxValue;
}

module.exports = maxTrailing;