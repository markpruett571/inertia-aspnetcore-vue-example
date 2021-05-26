<template>
  <div>
    Hello from Vue. ID: {{ id }}
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
