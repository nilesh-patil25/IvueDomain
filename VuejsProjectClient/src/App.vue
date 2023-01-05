<script>
import ButtonCounter from './components/ButtonCounter.vue'
import NavBar from './components/NavBar.vue'

export default {
    data() {
        return {
            todoId: 1,
            todoData: null,
            deptData: null,postEmpData:null
        }
    },
    name: 'App',
    components: {
        NavBar,
        ButtonCounter
    },
    methods: {
        async getAllUsers() {
            this.todoData = null
            const res = await fetch(
                'https://localhost:5001/api/Employees')
            this.todoData = await res.json()
        },
        async GetAllDepartment() {
            this.deptData = null
            const res = await fetch(
                'https://localhost:5001/api/Departments')
            this.deptData = await res.json()
        },
        async PostEmployees() {
            var axios = require('axios');
            var data = JSON.stringify({
                "emploeeName":"ravi"
            });

            var config = {
                method: 'post',
                url: 'https://localhost:5001/api/Employees',
                headers: {
                    'Content-Type': 'application/json'
                },
                data: data
            };

            axios(config)
                .then(function (response) {
                    console.log(JSON.stringify(response.data));
                })
                .catch(function (error) {
                    console.log(error);
                });
        }
    }, mounted() {
        this.getAllUsers();
        this.GetAllDepartment();
        this.PostEmployees();
    },
    watch: {
        todoId() {
            this.getAllUsers()
        }
    }
}
</script>

<template>
    <NavBar />
    <ButtonCounter />
    <button @click="getAllUsers">Get all Employees</button>
    <p v-if="!todoData">Loading...</p>
    <pre v-else>{{ todoData }}</pre>

    <button @click="GetAllDepartment()">Get All Department</button>
    <p v-if="!todoData">Loading...</p>
    <pre v-else>{{ deptData }}</pre>

    <button @click="PostEmployees()" ></button>
    <input style="height:250px;width:250px" type="text" placeholder=" employeeName:,department: {departmentId: 1,departmentName: IT}, },
    dateofJoining: 2023-01-03T18:51:03.2133333,
    photoFileName: .png">
    <p v-if="!todoData">Loading...</p>
    <pre v-else>{{ postEmpData }}</pre>
</template>

<style>
#app {
    font-family: Avenir, Helvetica, Arial, sans-serif;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
    color: #23384e;
}

<!-- #nav {
    text-align: center;
} -->

#nav a {
    font-weight: bold;
    color: #2c3e50;
}

#nav a.router-link-exact-active {
    color: whitesmoke;
    background: crimson;
    border-radius: .5rem;
}
</style>
