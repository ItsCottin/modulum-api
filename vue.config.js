const { defineConfig } = require('@vue/cli-service')
const path = require('path')

module.exports = defineConfig({
  transpileDependencies: true,
  publicPath: process.env.NODE_ENV === 'production'
    ? '/modulum/'
    : '/',
  configureWebpack: {
    resolve: {
      alias: {
        'nprogress': path.resolve(__dirname, 'src/assets/nprogress.js'),
      },
    },
  },
})