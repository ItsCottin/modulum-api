<template>
    <v-card class="mx-auto" max-width="344" title="Login">
        <v-container>
            <v-form v-model="form" @submit.prevent="onSubmit" >
                <v-text-field v-model="usuario" :readonly="loading" :rules="[required]" class="mb-2" clearable label="Usuário" variant="underlined"></v-text-field>
                <v-text-field v-model="password" :readonly="loading" :rules="[required]" clearable label="Senha" placeholder="Informe sua Senha" variant="underlined"></v-text-field>
                <v-card-actions>
                    <v-spacer></v-spacer>
                    <v-btn color="success">Entrar
                        <v-icon icon="mdi-chevron-right" end></v-icon>
                    </v-btn>
                </v-card-actions>
            </v-form>
        </v-container>
    </v-card>
</template>
<script>
export default {
    data: () => ({
        form: false,
        usuario: null,
        password: null,
        loading: false,
    }),

    methods: {
        onSubmit () {
            if (!this.form) return

            this.loading = true

            setTimeout(() => (this.loading = false), 2000)
        },
        required (v) {
            return !!v || 'Campo Obrigaório'
        },
    },
}
</script>