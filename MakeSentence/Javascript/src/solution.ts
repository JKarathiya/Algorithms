const findStr = (
    str: string,
    map: Map<string, boolean>,
    tempArr: string[][],
    index: number
) => {
    if (tempArr[index]) return tempArr[index];

    tempArr[index] = [];
    const strLength = str.length;

    for (let i = index; i < strLength; i++) {

        let tempStr = str.substring(index, i + 1);

        if (!map.get(tempStr)) continue;

        if (i === strLength - 1) {
            tempArr[index].push(tempStr);
            break;
        }

        const tmp = findStr(str, map, tempArr, i + 1);
        for (let j = 0; j < tmp.length; j++) {
            tempArr[index].push(tempStr + " " + tmp[j]);
        }
    }

    return tempArr[index];
};

export const makeSentence = (str: string, dict: string[]) => {
    let tempArr: string[][] = Array(str.length);
    let map = new Map();

    dict.forEach((word) => map.set(word, true));
    return findStr(str, map, tempArr, 0);
};