
import { createRouter, createMemoryHistory } from 'vue-router'

// Pages
import Login from '../views/Login.vue'

const routes = [
    // Referenciar as paginas aqui
    {
        path: '/',
        name: 'Login',
        component: Login
    }
    //{ path: '/about', component: AboutView },
]

const router = createRouter({
    history: createMemoryHistory(),
    routes,
})

export default router