const riverRecords = require("./solution");

describe("Calculate Pascal Layer Total", function () {

    test("Test Case 0", () => {
        var input = [2, 3, 10, 2, 4, 8, 1];
        expect(riverRecords(input)).toBe(8);
    });

    test("Test Case 1", () => {
        var input = [7, 9, 5, 6, 3, 2];
        expect(riverRecords(input)).toBe(2);
    });
})