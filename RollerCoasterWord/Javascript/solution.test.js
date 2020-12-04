const rollercoasterWord = require("./solution");

describe("Calculate Pascal Layer Total", function () {

    test("Returns true for 'Bat'", () => {
        expect(rollercoasterWord('Bat')).toBe(true);
    });

    test("Returns false for 'Bet", () => {
        expect(rollercoasterWord('Bet')).toBe(false);
    });

    test("Returns true for 'decriminalisation'", () => {
        expect(rollercoasterWord('decriminalisation')).toBe(true);
    });
})