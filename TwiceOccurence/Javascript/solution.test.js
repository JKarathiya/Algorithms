const twiceOccurence = require("./solution");

describe("Find Max words", function () {

    test("Test Case: 0", () => {
        expect(twiceOccurence("aba")).toBe("a");
    });

    test("Test Case: 1", () => {
        expect(twiceOccurence("zz")).toBe("z");
    });

    test("Test Case: 2", () => {
        expect(twiceOccurence("bob")).toBe("b");
    });
})