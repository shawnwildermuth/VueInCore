<template>
  <div>
    <h3>Contact Page</h3>
    <form @submit.prevent="onSave">
      <div class="form-group">
        <label>First Name</label>
        <input type="text" class="form-control" v-model="firstName" />
      </div>
      <div class="form-group">
        <label>Last Name</label>
        <input type="text" class="form-control" v-model="lastName" />
      </div>
      <div class="form-group">
        <input type="submit" class="btn btn-success" value="Save" />
      </div>
    </form>
  </div>
</template>
<script>
  import { ref } from "vue";
  export default {
    setup() {
      const firstName = ref("");
      const lastName = ref("");

      function onSave() {
        console.log(`${firstName.value} ${lastName.value}`);
      }

      return {
        firstName,
        lastName,
        onSave
      };
    }
  }
</script>