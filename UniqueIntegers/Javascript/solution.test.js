const uniqueIntegers = require("./solution");

describe("Find Max words", function () {

    test("Test Case: 0", () => {
        expect(uniqueIntegers(4).reduce((x, y) => x + y)).toBe(0);
    });

    test("Test Case: 1", () => {
        expect(uniqueIntegers(3).reduce((x, y) => x + y)).toBe(0);
    });

    test("Test Case: 2", () => {
        expect(uniqueIntegers(5).reduce((x, y) => x + y)).toBe(0);
    });
})