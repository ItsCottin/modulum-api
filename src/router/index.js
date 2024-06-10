
import { createRouter, createMemoryHistory } from 'vue-router'

// Pages
import Login from '../views/Login.vue'
import Index from '../views/Index.vue'
import Register from '../views/Register.vue'
import store from '../store';

const routes = [
    // Referenciar as paginas aqui
    {
        path: '/',
        name: 'Index',
        component: Index
    },
    {
        path: '/Login',
        name: 'Login',
        component: Login
    },
    {
        path: '/Register',
        name: 'Register',
        component: Register
    }
    //{ path: '/about', component: AboutView },
]

const router = createRouter({
    history: createMemoryHistory(),
    routes,
})

router.beforeEach((to, from, next) => {
    store.dispatch('startLoading');
    next();
});

router.afterEach(() => {
    setTimeout(() => { // Adicione um pequeno atraso para ver a barra de progresso
        store.dispatch('stopLoading');
    }, 500); // Altere o tempo conforme necessário
});

export default router