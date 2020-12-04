function calculatePascalLayerTotal(layer) {
    if (layer < 0) {
        return -1;
    }

    let arr = new Array(layer + 1);
    let total = 0;

    for (let i = 0; i <= layer; i++) {
        total = (layer == i || i == 0) ? 1 : total * (layer - i + 1) / i;
        arr[i] = total;
    }

    return arr.reduce(function (acc, val) { return acc + val; }, 0)
}

module.exports = calculatePascalLayerTotal;