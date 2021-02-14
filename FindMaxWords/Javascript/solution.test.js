const findMaxWords = require("./solution");

describe("Find Max words", function () {

    test("Test Case: 0", () => {
        expect(findMaxWords("We test coders. Give us a try?")).toBe(4);
    });

    test("Test Case: 1", () => {
        expect(findMaxWords('Forget Cvs..Save time . x x')).toBe(2);
    });
})