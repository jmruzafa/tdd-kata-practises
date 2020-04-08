const assert = require('chai').assert;
const { convertToRoman } = require('../lib/romanCalc');

describe('Given 0', () => {
  it('Should return empty', () => {
    const result = convertToRoman(0);
    assert.equal(result, '');
  });
});