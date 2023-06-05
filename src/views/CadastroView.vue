<template>
  <div class="container">
        <div class="wrapper d-flex flex-fill align-items-center justify-content-center h-100">
            <div class="card login-form">
                <div class="card-body">
                    <h5 class="card-title text-center">Cadastro</h5>
                    <form>
                        <div class="mb-3">
                            <label for="inputNome" class="form-label">Nome Completo:</label>
                            <input type="text" class="form-control" id="inputNome" aria-describedby="Nome Completo">
                        </div>
                        <div class="mb-3">
                            <label for="inputLogin" class="form-label">Nome de Usuário:</label>
                            <input type="text" class="form-control" id="inputLogin" aria-describedby="Nome de Usuário">
                        </div>
                        <div class="mb-3">
                            <label for="inputEmail" class="form-label">E-mail:</label>
                            <input type="email" class="form-control" id="inputEmail" aria-describedby="Endereço de E-mail">
                        </div>
                        <div class="mb-3">
                            <label for="inputSenha" class="form-label">Senha:</label>
                            <input type="password" class="form-control" id="inputSenha">
                        </div>
                        <div class="mb-3">
                            <label for="inputConfirmarSenha" class="form-label">Confirmar Senha:</label>
                            <input type="password" class="form-control" id="inputConfirmarSenha">
                        </div>
                        <button class="btn btn-primary w-100">Cadastrar</button>
                        <div class="sign-up mt-4">
                            já tem conta? <RouterLink :to="{name:'login'}" >Entrar</RouterLink>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</template>

<script>

</script>
