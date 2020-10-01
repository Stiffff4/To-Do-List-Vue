import axios from 'axios';

const url = 'https://localhost:44326/todo/'

const state = {
    todos: []
}

const getters = {
    getAllTodos: (state) => state.todos
}

const actions = {
    async fetchTodos({commit}){
        const response = await axios.get(url)
        commit('setTodos', response.data)
    },
    async addTodo({commit}, title){ 
        const response = await axios.post(url, {
            title,
            completed: false,
            deleted: false
        });
        commit('newTodo', response.data)
    },
    async setCompleted({commit}, id){
        await axios.put(url+id)
        commit('completeTodo', id)
    },
    async deleteTodo({commit}, id){
        await axios.delete(url+id)
        commit('removeTodo', id)
    }
}

const mutations = {
    setTodos: (state, todos) => state.todos = todos,
    newTodo: (state, todo) => state.todos = [...state.todos, todo],
    completeTodo: (state, id) => {
        let item = state.todos.find(item => item.id === id)
        item.completed = !item.completed
    },
    removeTodo: (state, id) => state.todos = state.todos.filter(todo => todo.id !== id)
}

export default {
    state,
    getters,
    actions,
    mutations
}