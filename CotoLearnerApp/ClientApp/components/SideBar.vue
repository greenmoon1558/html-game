<template>
  <div class="sidebar">
    <h1 class="sidebar__title">{{ heading }}</h1>
    <p>{{ headingText }}</p>
    <p>{{ title }}</p>
    <p>{{ text }}</p>
  </div>
</template>

<script>
export default {
  name: 'SideBar',
   data () {
    return { 
      heading: 'css catty',
      headingText: 'Допоможи трьом котикам опинитися в їх будиночках.',
      title: 'Позиція за замовчуванням',
      text: 'За замовчуванням для елемента є позиція: статична, яка не впливає на елемент. Розглянемо наступні позиції, де всі коти сидять разом:'

    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

</style>
