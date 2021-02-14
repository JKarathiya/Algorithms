const howmanyflips = require("./solution");

describe("How Many Flips", function () {

    test("Test Case: 0", () => {
        expect(howmanyflips('01011')).toBe(3);
    });

    test("Test Case: 1", () => {
        expect(howmanyflips('0011')).toBe(1);
    });
})