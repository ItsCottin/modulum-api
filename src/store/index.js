import { createStore } from 'vuex';

export default createStore({
    state: {
        isLoading: false,
    },
    mutations: {
        setLoading(state, isLoading) {
            console.log('setLoading called with:', isLoading);
            state.isLoading = isLoading;
        },
    },
    actions: {
        startLoading({ commit }) {
            console.log('startLoading action called');
            commit('setLoading', true);
        },
        stopLoading({ commit }) {
            console.log('stopLoading action called');
            commit('setLoading', false);
        },
    },
});
