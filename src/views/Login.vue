<template>
    <v-card class="mx-auto"
            max-width="600">
        <v-img class="align-end text-white"
               height="200"
               src="https://cdn.vuetifyjs.com/images/cards/docks.jpg"
               cover>
            <v-card-title>Seja bem vindo ao Modulum</v-card-title>
        </v-img>

        <v-card-subtitle class="pt-4">
            Realize seu Login
        </v-card-subtitle>

        <v-card-text>
            <v-form v-model="valid">
                <v-container>
                    <v-text-field label="Usuario" variant="outlined"></v-text-field>
                    <v-text-field label="Senha" variant="outlined"></v-text-field>
                </v-container>
            </v-form>
        </v-card-text>

        <v-card-actions>
            <v-btn height="62" min-width="164" variant="tonal" text="Entrar"></v-btn>
            <v-btn height="62" min-width="164" variant="tonal" text="Cadastrar" to="/register"></v-btn>
        </v-card-actions>
    </v-card>
</template>