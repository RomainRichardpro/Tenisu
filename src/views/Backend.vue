<template>
  <nav id="navBar">
    <div class="logo"><img src="@/assets/tenisu.svg" alt="" /></div>
  </nav>
  <div class="background-content">
    <div class="content">
      <router-link to="/" class="back">&#60; Retour</router-link>
      <h1 class="title">
        Test Technique L’Atelier - <span class="electric-blue">Backend</span> 🕷
      </h1>
      <p>
        Vous trouverez ci-dessous les éléments utiles pour la réalisation du
        test technique.
      </p>
      <h2>Votre mission :</h2>
      <p>
        Créer une API simple permettant de retourner les statistiques des
        joueurs de tennis. Les trois premières tâches devraient prendre
        <b>environ une heure</b>. Tu as le choix de réaliser la 4ème tâche sur
        n’importe quel Cloud. Un focus particulier doit être fait sur les 3
        premières, la 4ème est fortement conseillée !
      </p>
      <h2>Ce que l’on regarde :</h2>
      <ul>
        <li>Un code clean et lisible</li>
        <li>L’architecture applicative</li>
        <li>L’API devra respecter les fondamentaux REST</li>
        <li>Les exceptions devront être gérées</li>
        <li>L’implémentation des tests unitaires</li>
      </ul>
      <h2>Ce que l’on demande :</h2>
      <ul>
        <li>Créer un nouveau repo Github</li>
        <li>Compléter les tâches avec tes technos préférées</li>
        <li>Créer le projet from scratch</li>
        <li>Ajouter les fonctionnalités supplémentaires que tu souhaites</li>
        <li>
          Fournir un README pour savoir comment lancer et tester ton application
        </li>
        <li>Envoyer le lien de ton repo</li>
      </ul>
      <h2>Pour pouvoir résoudre cette mission :</h2>
      <Download :image="Json" title="headtohead.json" text="3 Ko" />
      <h2>Les tâches à réaliser :</h2>
      <div class="tasks">
        <Task
          title="Tâche n°1"
          text="Créer un endpoint qui retourne tous les joueurs. 
La liste doit être triée du meilleur au moins bon."
        />
        <Task
          title="Tâche n°2"
          text="Créer un endpoint qui permet de retourner 
les informations d’un joueur grâce à son ID."
        />
        <Task
          title="Tâche n°3"
          text="Créer un endpoint qui retourne les statistiques suivantes : - Pays qui a le plus grand ratio de parties gagnées - IMC moyen de tous les joueurs - La médiane de la taille des joueurs"
        />
        <Task title="Tâche n°4" text="Déploie ton projet sur le Cloud." />
      </div>
    </div>
  </div>
</template>

<script>
import Download from "@/components/Download.vue";
import Json from "@/assets/json.png";
import Task from "@/components/Task.vue";

export default {
  name: "Backend",
  components: {
    Download,
    Task,
  },
  data() {
    return {
      Json,
    };
  },
  mounted() {
    window.onscroll = function () {
      if (window.scrollY > 50) {
        document.getElementById("navBar").classList.add("scrolled");
      } else {
        document.getElementById("navBar").classList.remove("scrolled");
      }
    };
  },
};
</script>

<style scoped lang="scss">
@import "~@/styles/variables.scss";

nav {
  height: 80px;
  width: 100%;
  background-color: white;
  display: flex;
  align-items: center;
  padding-right: 45px;
  padding-left: 45px;
  position: fixed;
  z-index: 1;
  transition: 0.3s;
}

nav.scrolled {
  box-shadow: 0px 5px 8px rgba($electric-blue, 0.2);
  transition: 0.3s;
}

.background-content {
  background-color: #f2f7ff;
  padding-top: 120px;
  padding-bottom: 50px;
}
.back {
  text-decoration: underline;
  position: fixed;
  left: 45px;
}

.content {
  width: 930px;
  margin: 0 auto;
}

.title {
  margin-bottom: 24px;
}

span.electric-blue {
  color: $electric-blue;
}

.tasks {
  display: flex;
  flex-wrap: wrap;
  justify-content: flex-start;
  gap: 24px;
}
</style>
