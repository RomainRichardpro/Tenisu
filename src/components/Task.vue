<template>
  <div class="card" :class="{ 'task-checked': checked === true }">
    <input v-model="checked" type="checkbox" class="option-input" />
    <div class="title">{{ title }}</div>
    <slot></slot>
    <div v-if="checked" class="completed">Réalisé !</div>
  </div>
</template>

<script>
export default {
  name: "Task",
  props: {
    title: String,
    text: String,
  },
  data() {
    return {
      checked: false,
    };
  },
};
</script>

<style scoped lang="scss">
@import "~@/styles/variables.scss";

.card {
  background: #ffffff;
  outline: 2px solid rgba($electric-blue, 0.2);
  border-radius: 8px;
  width: 450px;
  padding: 40px 32px 16px 32px;
  display: flex;
  position: relative;
  flex-direction: column;
  align-items: center;
  transition: 0.2s;

  &.task-checked {
    background: rgba($green, 0.1);
    outline: 1px solid $green;

    &:hover {
      background: rgba($green, 0.1);
      outline: 6px solid rgba($green, 0.5);
    }
  }

  input.option-input {
    position: absolute;
    top: 16px;
    right: 16px;
  }

  .option-input {
    -webkit-appearance: none;
    -moz-appearance: none;
    -ms-appearance: none;
    -o-appearance: none;
    appearance: none;
    height: 20px;
    width: 20px;
    transition: all 0.15s ease-out 0s;
    background: mix($green, white, 20%);
    border: 1px solid $green;
    border-radius: 4px;
    cursor: pointer;
    display: inline-block;
  }
  .option-input:hover {
    background: $green;
    opacity: 0.5;
  }
  .option-input:checked {
    background: $green;
  }

  .title {
    font-family: "Montserrat", Helvetica, Arial, sans-serif;
    font-size: 16px;
    color: $electric-blue;
    font-weight: 600;
    text-decoration: none;
    margin-bottom: 24px;
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
    text-align: center;
    margin-top: 24px;
    line-height: 25px;
  }

  .completed {
    font-family: "Mulish", Helvetica, Arial, sans-serif;
    font-size: 14px;
    color: $green;
    text-align: right;
    font-weight: 700;
    position: absolute;
    top: 22px;
    right: 48px;
  }
}
</style>
