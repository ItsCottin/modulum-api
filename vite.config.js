import { fileURLToPath, URL } from 'node:url'

import { defineConfig } from 'vite'
import vue from '@vitejs/plugin-vue'
import { readFileSync } from 'fs';
import path from 'path';

const { version } = JSON.parse(readFileSync(path.resolve(__dirname, './package.json'), 'utf8'));

// https://vitejs.dev/config/
export default defineConfig({
  plugins: [
    vue(),
    ],
  base: "/modulum/",
  resolve: {
    alias: {
      '@': fileURLToPath(new URL('./src', import.meta.url))
    }
  },
  define: {
    'process.env': {
       PROJECT_VERSION: JSON.stringify(version),
    }
  }
})
