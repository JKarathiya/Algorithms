const CheckAllZeros = (binaryStr) =>{
    for(let i = 0; i < binaryStr.length; i++) {
        if (binaryStr[i] === '1'){
            return true;
        }
    }
    return false;
}

function getMinimumOperations(binaryStr) {
    let totalOperations = 0;
    let i = 0;
    let j = 1;
    while (CheckAllZeros(binaryStr)) {
        if (j < binaryStr.length) {
            if ((binaryStr[i] === '0' && binaryStr[j] === '1') || (binaryStr[i] === '1' && binaryStr[j] === '0')) {
                binaryStr = binaryStr.substring(0, i) + '11' + binaryStr.substring(i+2);
                totalOperations +=1;
            } else if (binaryStr[i] === '1' && binaryStr[j] === '1') {
                binaryStr = binaryStr.substring(0, i) + '00' + binaryStr.substring(i+2);
                totalOperations += 1;
                i += 1;
                j += 1;
            } else {
                i += 1;
                j += 1;
            }
        }
    }
    return totalOperations;
}

module.exports = getMinimumOperations;