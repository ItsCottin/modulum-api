<template>
    <v-app>
        <v-main>
            <v-container class="d-flex align-center mx-auto fill-height fluid">
                <v-layout align-center justify-center>
                    <v-sheet class="align-center justify-center" rounded>
                        <v-container>
                            <div class="text-h2 my-12">Login</div>
                            <div class="text-h4 my-5">Realize seu Login</div>
                        </v-container>
                        <v-form>
                            <v-container>
                                <v-text-field label="Usuario" variant="outlined" class="rounded-xl"></v-text-field>
                                <v-text-field label="Senha" variant="outlined" class="rounded-xl"></v-text-field>
                            </v-container>
                        </v-form>
                        <v-container>
                            <v-sheet>
                                <v-btn variant="tonal" text="Entrar" class="rounded-xl" block></v-btn>
                            </v-sheet>

                            <v-container class="text-center">
                                <router-link to="/register" class="block">
                                    Nao tem um usuario ? Cadastre-se
                                </router-link>
                            </v-container>
                        </v-container>
                    </v-sheet>
                </v-layout>
            </v-container>
        </v-main>
    </v-app>
</template>