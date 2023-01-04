<script>
    export default {
        data() {
            return {
                count: 0
            }
        }
    }
</script>

<template>
    <button @click="count++">You clicked me this much Times {{ count }}.</button>
</template>
