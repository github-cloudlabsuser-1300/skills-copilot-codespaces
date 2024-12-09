const { add, subtract, multiply, divide } = require('./test');

test('adds 5 + 3 to equal 8', () => {
    expect(add(5, 3)).toBe(8);
});

test('subtracts 5 - 3 to equal 2', () => {
    expect(subtract(5, 3)).toBe(2);
});

test('multiplies 5 * 3 to equal 15', () => {
    expect(multiply(5, 3)).toBe(15);
});

test('divides 5 / 3 to equal approximately 1.6667', () => {
    expect(divide(5, 3)).toBeCloseTo(1.6667, 4);
});

test('divides 5 / 0 to return "Error: Division by zero"', () => {
    expect(divide(5, 0)).toBe('Error: Division by zero');
});