<template>
  <div class="card" @click="download">
    <div class="image-container">
      <img class="image" :src="image" :alt="title" />
    </div>
    <div class="title">{{ title }}</div>
    <div class="text">{{ text }}</div>
    <a
      class="link"
      href="https://data.latelier.co/training/tennis_stats/headtohead.json"
      target="_blank"
      download="headtohead.json"
    >
      <img src="@/assets/import.svg" alt="logo" />
    </a>
  </div>
</template>

<script>
export default {
  name: "Download",
  props: {
    title: String,
    image: String,
    text: String,
  },
  // methods: {
  //   download() {
  //     const url =
  //       "https://data.latelier.co/training/tennis_stats/headtohead.json";
  //     const a = document.createElement("a");
  //     a.href = url;
  //     a.target = "_blank";
  //     a.download = url.split("/").pop();
  //     document.body.appendChild(a);
  //     a.click();
  //     document.body.removeChild(a);
  //   },
  // },
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
    outline: 2px solid white;
    padding: 4px;
    transition: 0.3s;

    &:hover {
      background: $electric-blue;
      border-radius: 8px;
      outline: 2px solid $electric-blue;
      transition: 0.3s;
    }
  }
}
</style>
