<template>
  <div class="card" :style="{ backgroundColor: color }">
    <div class="card-content">
      <div class="name">{{ name }}</div>
      <div class="info">{{ info }}</div>
    </div>
    <button class="button">Copier</button>
  </div>
</template>

<script>
export default {
  name: "Colors",
  props: {
    name: String,
    info: String,
    color: String,
  },
};
</script>

<style scoped lang="scss">
@import "~@/styles/variables.scss";

.card {
  width: 253px;
  height: 270px;
  border-radius: 8px;
  position: relative;
  cursor: pointer;

  &::after {
    content: "";
    position: absolute;
    top: 0;
    bottom: 0;
    left: 0;
    right: 0;
    background-color: $dark-blue;
    border-radius: 8px;
    z-index: 0;
    opacity: 0;
    transition: 0.4s;
  }

  .button {
    visibility: hidden;
    border: 2px solid #ffffff;
    border-radius: 8px;
    font-family: "Montserrat", Helvetica, Arial, sans-serif;
    font-size: 20px;
    color: #ffffff;
    background-color: transparent;
    padding: 8px 16px;
    display: flex;
    margin: 0 auto;
    margin-top: 50%;
    transform: translateY(-50%);
    cursor: pointer;
    z-index: 10;
    position: relative;

    &:hover {
      background-color: rgba(white, 0.3);
      transition: 0.4s;
    }
  }

  &:hover {
    &::after {
      opacity: 0.5;
    }
    .button {
      visibility: visible;
    }
  }

  .card-content {
    position: absolute;
    bottom: 0px;
    width: 100%;
    background: rgba(black, 0.15);
    padding: 20px 24px;
    border-radius: 8px;
    font-family: "Montserrat", Helvetica, Arial, sans-serif;
    font-size: 16px;
    font-weight: 500;
    color: white;
  }

  .info {
    margin-top: 8px;
  }
}
</style>
