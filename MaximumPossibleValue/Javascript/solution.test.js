const maximumpossiblevalue = require("./solution");

describe("Maximum Possible Value", function () {

    test("Test Case: 0", () => {
        expect(maximumpossiblevalue(268)).toBe(5268);
    });

    test("Test Case: 1", () => {
        expect(maximumpossiblevalue(670)).toBe(6750);
    });

    test("Test Case: 2", () => {
        expect(maximumpossiblevalue(-999)).toBe(-5999);
    });

    test("Test Case: 3", () => {
        expect(maximumpossiblevalue(0)).toBe(50);
    });
})