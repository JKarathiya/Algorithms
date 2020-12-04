const calculatePascalLayerTotal = require("./solution");

describe("Calculate Pascal Layer Total", function () {

    test("Returns 1 for 0th Layer", () => {
        expect(calculatePascalLayerTotal(0)).toBe(1);
    });

    test("Returns 2 for 1th Layer", () => {
        expect(calculatePascalLayerTotal(1)).toBe(2);
    });

    test("Returns 32 for 5th Layer", () => {
        expect(calculatePascalLayerTotal(5)).toBe(32);
    });
})