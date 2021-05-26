<template>
  <div class="container">
    <span class="text-red-500 text-2xl">
      Hello from Vue. ID (from controller): {{ id }}
    </span>
  </div>
</template>

<script>
import { defineComponent } from 'vue';
import Layout from '@/Shared/Layout.vue';

export default defineComponent({
  name: 'App',
  layout: Layout,

  props: {
    id: Number
  },

  components: {},
});
</script>
