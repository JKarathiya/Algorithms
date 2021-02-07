function run(unsortedInput) {
    try {
        let strArray = unsortedInput.split(" ").map((char) => {
            let num = parseInt(char, 10);
            if (!isNumber(num)) {
                throw "Error with sorting";
            }
            return num;
        });

        let sortedOutput = strArray.sort((a, b) => { return a - b })
        return sortedOutput.join(" ");
    }
    catch (err) {
        return err;
    }
}

function isNumber(n) {
    return !isNaN(parseFloat(n)) && isFinite(n);
}
module.exports = run;