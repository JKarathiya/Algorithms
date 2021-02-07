const run = require("./solution");

describe("sorting array", function () {

    test("Test Case 0", () => {
        var input = "t e s t 1";
        expect(run(input)).toBe("Error with sorting");
    });

    test("Test Case 1", () => {
        var input = "11 5 7 3 8 1 9";
        expect(run(input)).toBe("1 3 5 7 8 9 11");
    });

    test("Test Case 2", () => {
        var input = "7 9 5 6 3 2";
        expect(run(input)).toBe("2 3 5 6 7 9");
    });
})