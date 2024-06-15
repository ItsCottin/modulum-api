<template>
  <v-app>
    <v-main class="bg-surface-variant">
      <v-container>
        <v-row align="center" justify="center">
          <v-col cols="12" xs="12" sm="12" md="10" lg="8" xl="6" xxl="5">
            <v-row>
              <v-col cols="12">
                <v-card-text class="mt-6">
                  <v-row align="center" justify="center">
                    <h2 class="text-h4 font-weight-black text-orange">Login</h2>
                  </v-row>
                  <v-row align="center" justify="center">
                    <v-col cols="12" sm="8">
                      <v-text-field variant="outlined" label="Email" color="blue" autocomplete="false" class="mt-6" />
                      <v-text-field variant="outlined" label="Password" color="blue" autocomplete="false" type="password" />
                      <v-row>
                        <v-col cols="12" sm="12" class="mb-6" itemtype="">
                          <span class="caption blue--text">Esqueci minha senha</span>
                        </v-col>
                      </v-row>
                      <v-btn color="dark" variant="tonal" block>Entrar 2</v-btn>
                      
                      <div style="  text-align: center;">
                        <v-card-text class="white--text">
                          <h3 class="text-center ">
                            Nao tem uma conta ainda?
                          </h3>
                          <h6 class="text-center">
                            Vamos preparar tudo para que voce possa criar sua primeira conta
                          </h6>
                        </v-card-text>
                        <div class="text-center">
                          <v-btn color="dark" variant="tonal" to="/Register">Cadastre-se</v-btn>
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