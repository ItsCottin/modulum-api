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
                    <h2 class="text-h4 font-weight-black text-orange">Cadastro</h2>
                  </v-row>
                  <v-row align="center" justify="center">
                    <v-col cols="12" sm="8">
                      <v-row class="mt-6">
                        <v-col cols="12" sm="6">
                          <v-text-field variant="outlined" label="Primeiro Nome" color="blue" autocomplete="false" />
                        </v-col>
                        <v-col cols="12" sm="6">
                          <v-text-field variant="outlined" label="Sobrenome" color="blue" autocomplete="false" />
                        </v-col>
                      </v-row>
                      <v-text-field variant="outlined" label="Nome de Login" color="blue" autocomplete="false" />
                      <v-text-field variant="outlined" label="Email" color="blue" autocomplete="false" />
                      <v-text-field variant="outlined" label="Senha" color="blue" autocomplete="false" type="password" />
                      <v-text-field variant="outlined" label="Confirme Senha" color="blue" autocomplete="false" type="password" />

                      <v-btn color="dark" variant="tonal" block>Cadastrar</v-btn>
                      <div style="  text-align: center;">
                        <v-card-text class="white--text">
                          <h3 class="text-center">
                            Ja tem uma conta?
                          </h3>
                          <h6 class="text-center">
                            Vamos preparar tudo para que voce possa entrar na sua conta
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