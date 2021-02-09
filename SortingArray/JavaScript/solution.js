function run(unsortedInput) {

    let error = "Error with sorting";

    if (typeof unsortedInput === 'string' || val instanceof String) {
        try {
            let strArray = unsortedInput.split(" ").map((char) => {
                let num = parseInt(char, 10);
                if (isNaN(num) && !isFinite(num)) {
                    throw error;
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
    return error;
}

module.exports = run;