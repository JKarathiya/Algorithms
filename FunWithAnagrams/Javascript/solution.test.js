const funWithAnagrams = require("./solution");

describe("Fun with Anagrams", function () {

    test("Test Case 0", () => {
        let input = ["code", "doce", "ecod", "framer", "frame"];
        let expected = ["code", "frame", "framer"];
        expect(funWithAnagrams(input)).toEqual(expected);
    });

    test("Test Case 0", () => {
        let input = ["code", "aaagmnrs", "anagrams", "doce"];
        let expected = ["aaagmnrs", "code"];
        expect(funWithAnagrams(input)).toEqual(expected);
    });
})