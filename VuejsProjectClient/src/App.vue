

<script>
    import HelloWorld from './components/HelloWorld.vue'
    import Navbar from './components/Navbar.vue'
    import ButtonCounter from './components/ButtonCounter.vue'

    export default {
        name: 'App',
        components: {
            ButtonCounter,
            //Navbar,
            HelloWorld
        }
    }
</script>

<template>
    <!--<img alt="Vue logo" src="./assets/logo.png">-->
    <h2>Here is Child component</h2>
    <ButtonCounter />
    <HelloWorld msg="Welcome to Your Vue.js App" />
</template>

<style>
    #app {
        font-family: Avenir, Helvetica, Arial, sans-serif;
        -webkit-font-smoothing: antialiased;
        -moz-osx-font-smoothing: grayscale;
        text-align: center;
        color: #2c3e50;
        margin-top: 50px;
    }
</style>
