<template>
  <v-app>
    <v-main class="d-flex justify-center align-center  bg-surface-variant">
      <v-container class="bg-surface-variant mb-6">
        <v-row align="center" justify="center" align-self="center">
          <v-col cols="12" xs="12" sm="12" md="10" lg="8" xl="6" xxl="5" class="text-center">
            <h2 class="text-h4 font-weight-black text-orange">Bem vindo ao modulo!</h2>
            <v-row class="mt-12">
              <v-col>
                <v-row align="center" justify="center" align-self="center">
                  <p class="text-body-2 mb-4">
                    O sistema ainda esta em desenvolvimento mais voce pode acessar no botao abaixo
                  </p>
                </v-row>
                <v-row align="center" justify="center" class="align-end">
                  <v-btn variant="tonal" to="Login">Acessar</v-btn>
                </v-row>
              </v-col>
            </v-row>
          </v-col>
        </v-row>
      </v-container>
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
  /* Certifique-se de que a barra de progresso está na posição correta */
  .v-progress-linear {
    position: fixed;
    width: 100%;
  }
</style>