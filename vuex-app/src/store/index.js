import Vuex from 'vuex';
import Vue from 'vue';
import todos from './modules/todos';
import VueSwal from 'vue-swal';

Vue.use(Vuex);
Vue.use(VueSwal);

export default new Vuex.Store({
    modules: {
        todos
    }
})