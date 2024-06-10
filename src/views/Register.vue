<template>
  <v-app>
    <v-main class="bg-surface-variant">
      <v-container>
        <v-row align="center" justify="center">
          <v-col cols="12" xs="12" sm="12" md="10" lg="8" xl="6" xxl="5">
            <v-row>
              <v-col cols="12" md="12">
                <v-card-text class="mt-12">
                  <h4 class="text-center">
                    Preencha para criar uma conta
                  </h4>
                  <h6 class="text-center  grey--text ">
                    Vamos preparar tudo para que você possa começar a criar seu <br>
                    primeiro sistema dentro da nossa plataforma
                  </h6>
                  <v-row align="center" justify="center">
                    <v-col cols="12" sm="8">
                      <v-row class="mt-9">
                        <v-col cols="12" sm="6">
                          <v-text-field variant="outlined" label="Primeiro Nome" color="blue" autocomplete="false" class="mt-4" />
                        </v-col>
                        <v-col cols="12" sm="6">
                          <v-text-field variant="outlined" label="Sobrenome" color="blue" autocomplete="false" class="mt-4" />
                        </v-col>
                      </v-row>
                      <v-text-field variant="outlined" label="Nome de Login" color="blue" autocomplete="false" />
                      <v-text-field variant="outlined" label="Email" color="blue" autocomplete="false" />
                      <v-text-field variant="outlined" label="Senha" color="blue" autocomplete="false" type="password" />
                      <v-text-field variant="outlined" label="Confirme Senha" color="blue" autocomplete="false" type="password" />

                      <v-btn color="dark" variant="tonal" block>Cadastrar</v-btn>

                      <h5 class="text-center  grey--text mt-4 mb-3">
                        Ou entre com:
                      </h5>
                      <div class="d-flex justify-center align-center mx-3 mb-3">
                        <v-btn class="mx-2" variant="tonal" color="grey">
                          <v-icon color="red">fab fa-google</v-icon>
                        </v-btn>
                        <v-btn class="mx-2" variant="tonal" color="grey">
                          <v-icon color="blue">fab fa-facebook-f</v-icon>
                        </v-btn>
                        <v-btn class="mx-2" variant="tonal" color="grey">
                          <v-icon color="light-blue lighten-3">fab fa-twitter</v-icon>
                        </v-btn>
                      </div>
                      <div style="  text-align: center;">
                        <v-card-text class="white--text">
                          <h3 class="text-center ">
                            Já tem uma conta?
                          </h3>
                          <h6 class="text-center">
                            Vamos preparar tudo para que você possa entrar na sua conta
                          </h6>
                        </v-card-text>
                        <div class="text-center">
                          <v-btn color="dark" variant="tonal" to="/Login">Entrar</v-btn>
                        </div>
                      </div>
                    </v-col>
                  </v-row>
                </v-card-text>
              </v-col>
            </v-row>
          </v-col>
        </v-row>
      </v-container>
    </v-main>
  </v-app>
</template>

<script>import { mapState } from 'vuex';

export default {
  name: 'App',
  computed: {
    ...mapState({
      isLoading: state => state.isLoading,
    }),
  },
};</script>

<style>
  /* Certifique-se de que a barra de progresso está na posição correta */
  .v-progress-linear {
    position: fixed;
    width: 100%;
  }
</style>