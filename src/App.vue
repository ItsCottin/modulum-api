<template>
  <nav class="navbar fixed-top navbar-expand-lg bg-body-tertiary">
    <div class="container-fluid">
      <div class="collapse navbar-collapse" id="navbarNav">
        <ul class="navbar-nav">
          <li class="nav-item">
            <a class="navbar-brand" href="#">
              <img src="https://getbootstrap.com/docs/5.3/assets/brand/bootstrap-logo.svg" alt="Logo" width="30" height="24" class="d-inline-block align-text-top">
              Bootstrap
            </a>
          </li>
          <li class="nav-item">
            <router-link class="nav-link" :to="{name:'login'}">Login</router-link>
          </li>
          <li class="nav-item">
            <router-link class="nav-link" :to="{name:'cadastro'}">Cadastro</router-link>
          </li>
          <li class="nav-item">
            <router-link class="nav-link" :to="{name:'inicio'}">Inicio</router-link>
          </li>
        </ul>
      </div>
    </div>
  </nav>
  <div class="mt-5 align-self-center">
    <router-view/>
  </div>
</template>

<script setup>

</script>

<style lang="scss">
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #2c3e50;
}

nav {

  a {
    font-weight: bold;
    color: #2c3e50;
  }
}
</style>
