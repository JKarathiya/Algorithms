function calculatePascalLayerTotal(layer) {
    if (layer < 0) return -1;

    let arr = 0;
    let total = 0;

    for (let i = 0; i <= layer; i++) {
        total = (layer == i || i == 0) ? 1 : total * (layer - i + 1) / i;
        arr += total;
    }

    return arr;
}

module.exports = calculatePascalLayerTotal;