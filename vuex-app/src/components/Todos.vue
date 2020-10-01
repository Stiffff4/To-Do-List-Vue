<template>
<div>
    <h3>Todos</h3>
    <div class="todos">
        <div v-for="todo in getAllTodos" :key="todo.id" v-bind:class="{'is-completed': todo.completed, 'todo': !todo.completed}">
            <div @click="setCompleted(todo.id)">{{todo.title}}</div>
            <i @click="deleteTodo(todo.id)" class="fas fa-trash-alt"></i>
        </div>
        <h1 v-if="!getAllTodos">Nothing here just yet...</h1>
    </div>
</div>
</template>

<script>
import {
    mapGetters,
    mapActions
} from 'vuex';

export default {
    name: 'Todos',
    computed: mapGetters(['getAllTodos']),
    methods: {
        ...mapActions(['fetchTodos', 'deleteTodo', 'setCompleted'])
    },
    created() {
        this.fetchTodos()
    },
}
</script>

<style scoped>
.todos {
    display: grid;
    grid-template-columns: repeat(3, 1fr);
    grid-gap: 1rem;
}

.is-completed {
    border: 1px solid #000;
    background: #00e37e;
    padding: 1rem;
    border-radius: 5px;
    text-align: center;
    position: relative;
    cursor: pointer;
    text-decoration: line-through;
    color: #FFFF;
}

.is-completed:hover {
    background: #41b883;
}

.todo {
    border: 1px solid #000;
    background: #41b883;
    padding: 1rem;
    border-radius: 5px;
    text-align: center;
    position: relative;
    cursor: pointer;
}

.todo:hover {
    background: #00e37e;
}

i {
    position: absolute;
    bottom: 10px;
    right: 10px;
    color: #fff;
    cursor: pointer;
}
</style>
