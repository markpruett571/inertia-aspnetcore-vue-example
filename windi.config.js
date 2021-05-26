import { defineConfig } from "windicss/helpers";

export default defineConfig({
  extract: {
    include: ["App/Pages/**/*.{vue,html,mdx,pug,jsx,tsx}"],
    exclude: ["node_modules", ".git"],
  },
});