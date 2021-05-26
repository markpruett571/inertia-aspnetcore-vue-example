import { createApp, h } from 'vue';
import { App, plugin } from '@inertiajs/inertia-vue3';
import { InertiaProgress } from '@inertiajs/progress';

InertiaProgress.init();

const el = document.getElementById('app');

createApp({
  render: () => h(App, {
    initialPage: JSON.parse(el.dataset.page),
    resolveComponent: async (name) => {
        const page = await import(`./Pages/${name}.vue`);
        return page.default;
    },
    transformProps: props => {
      return {
        ...props.controller
      }
    }
  })
}).use(plugin).mount(el);