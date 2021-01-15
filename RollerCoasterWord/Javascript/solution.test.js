const rollercoasterWord = require("./solution");

describe("Calculate Pascal Layer Total", function () {

    test("Check that a short rollercoaster word returns true.", () => {
        expect(rollercoasterWord('Bat')).toBe(true);
    });

    test("Check that a short non-rollercoaster word returns false.", () => {
        expect(rollercoasterWord('Bet')).toBe(false);
    });

    test("Check that a string containing a single letter returns true", () => {
        expect(rollercoasterWord('a')).toBe(true);
    });

    test("Check that a two letter string returns true", () => {
        expect(rollercoasterWord('Ba')).toBe(true);
    });

    test("Check that a string containing two of the same letter in succession returns false", () => {
        expect(rollercoasterWord('succession')).toBe(false);
    });
})