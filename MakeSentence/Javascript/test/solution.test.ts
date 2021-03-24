import { makeSentence } from "../src/solution";

describe("Make Sentence Test", function () {

    test("Test case: 1", () => {
        const str = "penpineapplepenapple";
        const dict = ["apple", "pen", "applepen", "pine", "pineapple"];
        const expected = [
            "pen pine apple pen apple",
            "pen pineapple pen apple",
            "pen pine applepen apple"
        ];

        expect(makeSentence(str, dict).sort()).toEqual(expected.sort());
    });
})