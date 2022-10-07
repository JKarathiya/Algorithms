const getMinimumOperations = require("./solution");

describe("Calculate Pascal Layer Total", function () {

    test("Minimum operation for '000' should be 0.", () => {
        expect(getMinimumOperations('000')).toBe(0);
    });

    test("Minimum operation for '101' should be 4.", () => {
        expect(getMinimumOperations('101')).toBe(4);
    });

    test("Minimum operation for '1100' should be 1.", () => {
        expect(getMinimumOperations('1100')).toBe(1);
    });

    test("Minimum operation for '1111' should be 2.", () => {
        expect(getMinimumOperations('1111')).toBe(2);
    });
})