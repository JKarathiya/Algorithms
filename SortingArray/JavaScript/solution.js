function run(unsortedInput) {
    try {
        let strArray = unsortedInput.split(" ").map((char) => {
            let num = parseInt(char, 10);
            if (isNaN(num) && !isFinite(num)) {
                throw "Error with sorting";
            }
            return num;
        });

        let sortedOutput = strArray.sort((a, b) => a - b)
        return sortedOutput.join(" ");
    }
    catch (err) {
        return err;
    }
}

module.exports = run;