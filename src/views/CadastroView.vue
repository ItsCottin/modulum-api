<template>
    <v-card class="mx-auto" max-width="344" title="Cadastro de Usuário">
        <v-container>
            <v-text-field v-model="nome" color="primary" label="Nome Completo" variant="underlined"></v-text-field>
            <v-text-field v-model="usuario" color="primary" label="Nom de Usuário" variant="underlined"></v-text-field>
            <v-text-field v-model="email" color="primary" label="E-mail" variant="underlined"></v-text-field>
            <v-text-field v-model="senha" color="primary" label="Senha" placeholder="Informe sua Senha" variant="underlined"></v-text-field>
            <v-checkbox v-model="Termos" color="primary" label="Eu concordo com os termos do site"></v-checkbox>
        </v-container>
        <v-divider></v-divider>
        <v-card-actions>
            <v-spacer></v-spacer>
            <v-btn color="success">Cadastrar
                <v-icon icon="mdi-chevron-right" end></v-icon>
            </v-btn>
        </v-card-actions>
    </v-card>
</template>

<script>
export default {
    data: () => ({
        nome: null,
        usuario: null,
        email: null,
        senha: null,
        Termos: false,
    }),
}
</script>
