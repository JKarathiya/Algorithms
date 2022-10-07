const minPartitions = require("./solution");

describe("Consolidating Partitions", function () {

    test("Test Case 0", () => {

        //Arrange
        let used = [3, 2, 1, 3, 1];
        let totalCapacity = [3, 5, 3, 5, 5];
        let expected = 2;

        //Act
        let result = minPartitions(used, totalCapacity);

        //Assert
        expect(result).toBe(expected);
    });

    test("Test Case 1", () => {

        //Arrange
        let used = [3, 3, 3];
        let totalCapacity = [5, 5, 5];
        let expected = 3;

        //Act
        let result = minPartitions(used, totalCapacity);

        //Assert
        expect(result).toBe(expected);
    });
})