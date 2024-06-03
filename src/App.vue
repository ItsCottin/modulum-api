<template>
    <main>
        <RouterView />
    </main>
</template>

<script>
    //import Card from 'primevue/card';
    import { ref } from 'vue';

    const msg = ref('');
    export default {
        name: 'App',
        components: {}
    };
</script>

