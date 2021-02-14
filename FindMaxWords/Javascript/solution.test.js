const findMaxWords = require("./solution");

describe("Calculate Pascal Layer Total", function () {

    test("Check that a short rollercoaster word returns true.", () => {
        expect(findMaxWords("We test coders. Give us a try?")).toBe(4);
    });

    test("Check that a short non-rollercoaster word returns false.", () => {
        expect(findMaxWords('Forget Cvs..Save time . x x')).toBe(2);
    });
})