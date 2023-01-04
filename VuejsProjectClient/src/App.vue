<script>
     //import HelloWorld from './components/HelloWorld.vue'
    import NavBar from './components/NavBar.vue'
    //import ButtonCounter from './components/ButtonCounter.vue'

    export default {
        name: 'App',
        components: {
            //HelloWorld,
            NavBar
        }
    }
</script>

<template>
    <img alt="Vue logo" src="./assets/logo.png" height="50px" width="50px">
    <!-- <HelloWorld msg="Welcome to Your Vue.js App" /> -->
    <NavBar/>
    <!-- <h2>Here is Child component</h2> -->
    <!-- <ButtonCounter /> -->
</template>

<style>
    #app {
        font-family: Avenir, Helvetica, Arial, sans-serif;
        -webkit-font-smoothing: antialiased;
        -moz-osx-font-smoothing: grayscale;
        text-align: center;
        color: #2c3e50;
        margin-top: 51px;
    }
</style>
