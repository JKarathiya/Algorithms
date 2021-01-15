const calculatePascalLayerTotal = require("./solution");

describe("Calculate Pascal Layer Total", function () {

    test("Ensure the solution can handle the invalid input -1.", () => {
        expect(calculatePascalLayerTotal(-5)).toBe(-1);
    });

    test("Calculate the total for layer 0.", () => {
        expect(calculatePascalLayerTotal(0)).toBe(1);
    });

    test("Calculate the total for layer 1.", () => {
        expect(calculatePascalLayerTotal(1)).toBe(2);
    });

    test("Calculate the total for layer 3.", () => {
        expect(calculatePascalLayerTotal(3)).toBe(8);
    });

    test("Calculate the total for layer 5.", () => {
        expect(calculatePascalLayerTotal(5)).toBe(32);
    });

    test("Calculate the total for layer 7.", () => {
        expect(calculatePascalLayerTotal(7)).toBe(128);
    });

    test("Calculate the total for a large layer (20).", () => {
        expect(calculatePascalLayerTotal(20)).toBe(1048576);
    });

    test("Calculate the total for a very large layer (30).", () => {
        expect(calculatePascalLayerTotal(30)).toBe(1073741824);
    });
})