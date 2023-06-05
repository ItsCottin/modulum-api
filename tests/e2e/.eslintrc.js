module.exports = {
  plugins: [
    'cypress'
  ],
  env: {
    mocha: true,
    'cypress/globals': true
  },
  rules: {
    "no-mixed-spaces-and-tabs": 0, // disable rule
    strict: 'off'
  }
}
