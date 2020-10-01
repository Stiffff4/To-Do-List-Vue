<template>
<div>
    <h3>To-Do List</h3>
    <div class="add">
        <form @submit="onSubmit">
            <input type="text" v-model="title" placeholder="Add a todo">
            <input type="submit" class="submit" value="Submit">
        </form>
    </div>
    <div>
        <h4>Not completed: <span class="green">Green</span>
        </h4>
        <h4>Completed: <span class="light">Light Green</span></h4>
        <h4>Click a todo to set it as completed/not completed</h4>
    </div>
</div>
</template>

<script>
import Vue from 'vue'
import {
    mapActions
} from 'vuex'
import VueSwal from 'vue-swal'

Vue.use(VueSwal)

export default {
    name: 'AddTodo',
    data() {
        return {
            title: ''
        }
    },
    methods: {
        ...mapActions(['addTodo']),
        onSubmit(e) {
            e.preventDefault();
            if (this.title) {
                this.addTodo(this.title);
                this.title = '';
            } else this.$swal('Add a todo is required.')
        }
    },
}
</script>

<style scoped>
form {
    display: flex;
}

.green {
    color: #41b882;
}

.light {
    color: #00e37e;
    text-decoration: line-through;
}

.submit:hover {
    background: #17e68a;
}

input[type="text"] {
    flex: 10;
    padding: 10px;
    border: 1px solid #41b883;
    outline: 0;
}

input[type="submit"] {
    flex: 2;
    background: #41b883;
    color: #fff;
    border: 1px #41b883 solid;
    cursor: pointer;
}
</style>
