<template>
  <div @click="copy" @mouseleave="leave" class="code">
    &lt;<span class="electric-blue">link</span>
    <span class="green"> href</span>="<span class="orange-light">{{
      link
    }}</span
    >" rel="stylesheet"&gt;
  </div>
</template>

<script>
export default {
  name: "Fonts",
  props: {
    link: String,
  },
};
</script>

<style scoped lang="scss">
.code {
  background-color: #031e41;
  padding: 16px 24px;
  border-radius: 8px;
  font-family: "Mulish", Helvetica, Arial, sans-serif;
  font-weight: 600;
  color: white;
  white-space: nowrap;
  overflow: auto;
  margin-top: 16px;
  margin-bottom: 24px;
}

span.electric-blue {
  color: $electric-blue;
}

span.green {
  color: $green;
}

span.orange-light {
  color: $orange-light;
}
</style>
