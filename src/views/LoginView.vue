<template>
  <div class="container">
        <div class="wrapper d-flex align-items-center justify-content-center h-100">
            <div class="card login-form">
                <div class="card-body">
                    <h5 class="card-title text-center">Login</h5>
                    <form>
                        <div class="mb-3">
                            <label for="inputLogin" class="form-label">Usuário:</label>
                            <input type="text" class="form-control" id="inputLogin" aria-describedby="Nome de Usuário">
                        </div>
                        <div class="mb-3">
                            <label for="inputSenha" class="form-label">Senha:</label>
                            <input type="password" class="form-control" id="inputSenha">
                        </div>
                        <button class="btn btn-primary w-100">Entrar</button>
                        <div class="sign-up mt-4">
                            Não tem conta? <RouterLink :to="{name:'cadastro'}" >Cadastre-se</RouterLink>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</template>
