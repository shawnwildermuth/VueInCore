<template>
  <div>
    <h3>People at Company</h3>
    <ul>
      <li v-for="i in items" :key="i.id">{{ i.firstName }} {{ i.lastName }}</li>
    </ul>
  </div>
</template>

<script>
  import axios from "axios";
  import { onMounted, reactive } from "vue";

  export default {
    name: 'App',
    setup() {
      const items = reactive([]);

      onMounted(async () => {
        let result = await axios.get("/api/people");
        items.splice(0, 0, ...result.data);
      });

      return {
        items
      };
    }
  }
</script>

