<template>
  <div class="container">
    <span class="text-red-500 text-2xl">
      Hello from Vue. ID (from controller): {{ id }}
    </span>
  </div>
</template>

<script>
import { defineComponent } from 'vue';
export default defineComponent({
  name: 'App',

  props: {
    id: Number
  },

  components: {},
});
</script>
