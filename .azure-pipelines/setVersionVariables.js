const assert = require('assert').strict;

const prefix = process.env['VERSION_PREFIX'];
const suffix = process.env['VERSION_SUFFIX'];
const ciSuffix = process.env['CI_VERSION_SUFFIX'];

assert.notStrictEqual(prefix, null);
assert.notStrictEqual(prefix, undefined);
assert.notStrictEqual(prefix, "");

assert.notStrictEqual(ciSuffix, null);
assert.notStrictEqual(ciSuffix, undefined);
assert.notStrictEqual(ciSuffix, "");

const releaseVersionCommand = createCommand(
    'RELEASE_VERSION',
    suffix && suffix.length > 0
    ? `${prefix}-${suffix}`
    : `${prefix}`
);

const ciVersionCommand = createCommand(
    'CI_VERSION',
    suffix && suffix.length > 0
    ? `${prefix}-${suffix}.${ciSuffix}`
    : `${prefix}-${ciSuffix}`
);

console.log(releaseVersionCommand);
console.log(ciVersionCommand);

function createCommand(key, value) {
    return `##vso[task.setvariable variable=${key};]${value}`
}
