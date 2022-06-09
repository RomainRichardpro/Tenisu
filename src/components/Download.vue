<template>
  <a class="card" :href="file" target="_blank" @click="download">
    <div class="image-container">
      <img class="image" :src="image" :alt="title" />
    </div>
    <div class="title">{{ title }}</div>
    <div class="text">{{ text }}</div>
    <div class="link" :href="file" target="_blank">
      <img src="@/assets/import.svg" alt="logo" />
    </div>
  </a>
</template>

<script>
export default {
  name: "Download",
  props: {
    title: String,
    image: String,
    text: String,
    file: String,
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
  transition: 0.2s;

  .image {
    height: 40px;
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

    .link {
      background: $electric-blue;
      border: 2px solid $electric-blue;

      img {
        filter: brightness(100);
      }
    }
  }

  .text {
    font-family: "Mulish", Helvetica, Arial, sans-serif;
    color: $dark-blue;
    font-weight: 300;
    font-size: 16px;
  }

  .link {
    background: #d9e9ff;
    border-radius: 8px;
    width: 32px;
    height: 32px;
    border: 2px solid #d9e9ff;
    padding: 4px;
    transition: 0.3s;
    display: flex;
    align-content: center;
    justify-content: center;
  }
}
</style>
