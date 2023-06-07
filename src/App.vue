<template>
  <v-app id="inspire">
    <v-navigation-drawer v-model="drawer">
      <v-card class="mx-auto pa-2" max-width="300" height="100vh">
        <v-list>
          <v-list-subheader>MENU</v-list-subheader>
          <v-list-item active-color="primary" rounded="xl" title="Inicio" :to="{name:'inicio'}">
            <template v-slot:prepend>
              <v-icon icon="$vuetify"></v-icon>
            </template>
            <v-list-item-title v-text="Inicio"></v-list-item-title>
          </v-list-item>
          <v-list-item active-color="primary" rounded="xl" title="Login" :to="{name:'login'}">
            <template v-slot:prepend>
              <v-icon icon="mdi-account"></v-icon>
            </template>
            <v-list-item-title v-text="Login"></v-list-item-title>
          </v-list-item>
          <v-list-item active-color="primary" rounded="xl" title="Cadastro" :to="{name:'cadastro'}">
            <template v-slot:prepend>
              <v-icon icon="mdi-account-multiple"></v-icon>
            </template>
            <v-list-item-title v-text="Cadastro"></v-list-item-title>
          </v-list-item>
        </v-list>
      </v-card>
    </v-navigation-drawer>

    <v-app-bar>
      <v-app-bar-nav-icon @click="drawer = !drawer"></v-app-bar-nav-icon>

      <v-toolbar-title>MODULUM</v-toolbar-title>
      <v-spacer></v-spacer>

      <v-btn icon>
        <v-icon>mdi-export</v-icon>
      </v-btn>
    </v-app-bar>

    <v-main>
      
      <v-sheet class="bg-deep-purple pt-12 pa-1" rounded>
        <!-- Local onde as paginas serão renderizadas -->
        <router-view/>
      </v-sheet>
      
    </v-main>
    
  </v-app>
</template>

<style>
.bg-deep-purple {
  height: 100%;
  z-index: -1;
}
</style>

<script>

  export default {

    data: () => ({ 
      drawer: null,

      // Itens do Menu
      items: [
        { text: 'Real-Time', icon: 'mdi-clock' },
        { text: 'Audience', icon: 'mdi-account' },
        { text: 'Conversions', icon: 'mdi-flag' },
      ],
    }),
  }

</script>
