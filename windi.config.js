import { defineConfig } from "windicss/helpers";

export default defineConfig({
  extract: {
    include: ["App/**/*.{vue,html,mdx,pug,jsx,tsx}"],
    exclude: ["node_modules", ".git"],
  },
});