const mindeletion = require("./solution");

describe("Calculate minimum deletion", function () {

    test("Check that a short rollercoaster word returns true.", () => {
        expect(mindeletion('Bat')).toBe(1);
    });

    test("Check that a short non-rollercoaster word returns false.", () => {
        expect(mindeletion('Bet')).toBe(3);
    });

    test("Check that a string containing a single letter returns true", () => {
        expect(mindeletion('a')).toBe(6);
    });

    test("Check that a two letter string returns true", () => {
        expect(mindeletion('Ba')).toBe(0);
    });

    test("Check that a string containing two of the same letter in succession returns false", () => {
        expect(mindeletion('succession')).toBe(false);
    });
})