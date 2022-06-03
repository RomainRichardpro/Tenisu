<template>
  <router-link class="card" :to="{ name: route }">
    <img class="image" :src="image" :alt="title" />
    <div class="title">{{ title }}</div>
  </router-link>
</template>

<script>
export default {
  name: "ProfilCard",
  props: {
    title: String,
    image: String,
    route: String,
  },
};
</script>

<style scoped lang="scss">
@import "~@/styles/variables.scss";

.card {
  background: #ffffff;
  outline: 2px solid rgba($electric-blue, 0.2);
  border-radius: 8px;
  width: 250px;
  height: 250px;
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: space-evenly;
  transition: 0.3s;

  .image {
    width: 64px;
  }

  .title {
    font-family: "Montserrat", Helvetica, Arial, sans-serif;
    font-size: 16px;
    color: $electric-blue;
    font-weight: 600;
    text-decoration: none;
  }

  &:hover {
    background: rgba($electric-blue, 0.1);
    outline: 6px solid rgba($electric-blue, 0.2);
  }
}
</style>
