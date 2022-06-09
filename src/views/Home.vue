<template>
  <div class="home">
    <div class="navbar">
      <div class="logo"><img src="@/assets/tenisu.svg" alt="logo" /></div>
    </div>
    <div class="select">
      <h1>Vous êtes plutôt ?</h1>
      <div class="cards">
        <ProfilCard route="Frontend" :image="Rainbow" title="Frontend" />
        <ProfilCard route="Backend" :image="Spider" title="Backend" />
        <ProfilCard route="Fullstack" :image="Rocket" title="Fullstack" />
      </div>
    </div>
  </div>
</template>

<script>
import ProfilCard from "@/components/ProfilCard.vue";
import Rainbow from "@/assets/rainbow.png";
import Spider from "@/assets/spider.png";
import Rocket from "@/assets/rocket.png";

export default {
  name: "Home",
  components: {
    ProfilCard,
  },
  data() {
    return {
      Rainbow,
      Spider,
      Rocket,
    };
  },
};
</script>

<style scoped>
@import "~@/styles/variables.scss";

.home {
  width: 100%;
  min-height: 100vh;
  background-color: #f2f7ff;
}

.navbar {
  height: 80px;
  width: 100%;
  background-color: white;
  position: fixed;
  display: flex;
  align-items: center;
  padding-right: 45px;
  padding-left: 45px;
}

.select {
  display: flex;
  justify-content: center;
  flex-direction: column;
  height: 100vh;
  padding-bottom: 80px;
}

h1 {
  width: 930px;
  margin: 0 auto;
  margin-bottom: 56px;
}

.cards {
  display: flex;
  justify-content: center;
  gap: 90px;
  align-items: center;
}

@media (max-width: 975px) {
  .cards {
    gap: 56px;
  }

  h1 {
    width: 862px;
  }
}

@media (max-width: 975px) {
  .card {
    width: 200px;
  }

  h1 {
    width: 712px;
  }
}

@media (max-width: 750px) {
  .select {
    justify-content: space-evenly;
    padding-bottom: 200px;
    padding-top: 200px;
  }

  h1 {
    width: auto;
  }

  .card {
    width: 70%;
  }

  .cards {
    flex-direction: column;
    gap: 24px;
    height: 550px;
  }
}

@media (max-width: 600px) {
  .card {
    width: 90%;
  }
}
</style>
