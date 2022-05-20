<template>
  <router-link class="card" :to="{ name: route }">
    <img class="image" :src="image" alt="" />
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
  border: 2px solid rgba($electric-blue, 0.2);
  border-radius: 8px;
  width: 250px;
  height: 250px;
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: space-evenly;
  transition: 0.2s;

  .image {
    width: 64px;
  }

  .title {
    font-size: 16px;
    color: $electric-blue;
    font-weight: 600;
  }

  &:hover {
    background: rgba($electric-blue, 0.1);
    border: 4px solid rgba($electric-blue, 0.2);
  }
}
</style>
