import vue from '@vitejs/plugin-vue';
const { resolve } = require('path');

export default ({ command }) => ({
  plugins: [
    vue(),
  ],

  build: {
    outDir: resolve(__dirname, 'wwwroot/js'),
    emptyOutDir: true,
    manifest: true,
    target: 'es2018',
    rollupOptions: {
      input: resolve(__dirname, './App/app.js')
    }
  },

  server: {
    open: false,
    cors: true,
    strictPort: true,
    port: 3000,
    hmr: {
      host: 'localhost',
      port: 3000
    }
  },

  resolve: {
    alias: [
        { find: '~', replacement: resolve(__dirname, './App') },
        { find: '@', replacement: resolve(__dirname, './App') },
        { find: '@css', replacement: resolve(__dirname, './App/css') },
        { find: '@scss', replacement: resolve(__dirname, './App/scss') },
        { find: 'js', replacement: resolve(__dirname, './App/js') },
        { find: '@images', replacement: resolve(__dirname, './App/images') },
        { find: '@scripts', replacement: resolve(__dirname, './App/scripts') },
        { find: '@components', replacement: resolve(__dirname, './App/views/components') },
        ],
  },

  optimizeDeps: {
    include: [
      'vue',
      '@inertiajs/inertia',
      '@inertiajs/inertia-vue3',
      '@inertiajs/progress',
      'axios'
    ]
  }
});