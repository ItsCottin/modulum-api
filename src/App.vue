<template>
  <v-app>
    <v-progress-linear v-if="isLoading" indeterminate color="primary" height="4" absolute top></v-progress-linear>
    <v-main>
      <router-view />
    </v-main>
  </v-app>
</template>

<script>
import { mapState } from 'vuex';

export default {
  name: 'App',
  computed: {
    ...mapState({
      isLoading: state => state.isLoading,
    }),
  },
};
</script>

<style>
.v-progress-linear {
  position: fixed;
  width: 100%;
  z-index: 1000;
}
</style>
