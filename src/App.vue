<template>
  <div id="app">
    <SideBar />
    <Board />
  </div>
</template>

<script>
import SideBar from './components/SideBar.vue'
import Board from './components/Board.vue'

export default {
  name: 'App',
  components: {
    SideBar,
    Board
  }
}
</script>

<style>
#app {
}
</style>
