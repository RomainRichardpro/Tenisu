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
      <Download
        :image="Json"
        title="headtohead.json"
        text="3 Ko"
        file="https://data.latelier.co/training/tennis_stats/headtohead.json"
      />
      <h2>Les tâches à réaliser :</h2>
      <div class="tasks">
        <Task title="Tâche n°1" class="card-task"
          ><p class="text-tasks">
            Crée un endpoint qui retourne les joueurs. La liste doit être triée
            du meilleur au moins bon.
          </p>
        </Task>
        <Task title="Tâche n°2" class="card-task"
          ><p class="text-tasks">
            Créer un endpoint qui permet de retourner les informations d’un
            joueur grâce à son ID.
          </p>
        </Task>
        <Task title="Tâche n°3" class="card-task"
          ><p class="text-tasks">
            Créer un endpoint qui retourne les statistiques suivantes :
          </p>
          <p>- Pays qui a le plus grand ratio de parties gagnées</p>
          <p>- IMC moyen de tous les joueurs</p>
          <p class="text-tasks">- La médiane de la taille des joueurs</p>
        </Task>
        <Task title="Tâche n°4" class="card-task"
          ><p class="text-tasks">Déploie ton projet sur le Cloud.</p>
        </Task>
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
    window.onscroll = this.onScroll;
  },
  methods: {
    onScroll() {
      if (window.scrollY > 50) {
        document.getElementById("navBar").classList.add("scrolled");
      } else {
        document.getElementById("navBar").classList.remove("scrolled");
      }
    },
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

.text-tasks {
  text-align: center;
  margin-bottom: 16px;
}

@media (max-width: 1230px) {
  .back {
    position: static;
  }

  h1 {
    margin-top: 40px;
  }
}

@media (max-width: 1020px) {
  .content {
    width: 800px;
  }
}

@media (max-width: 865px) {
  .content {
    width: 700px;
  }

  .cards {
    flex-wrap: wrap;
  }

  .tasks {
    flex-wrap: wrap;
  }

  .card-task {
    width: 100%;
  }
}

@media (max-width: 760px) {
  .content {
    width: 600px;
  }
}

@media (max-width: 670px) {
  .content {
    width: 550px;
  }

  .download {
    flex-direction: column;
  }

  .card-download {
    width: 100%;
  }
}

@media (max-width: 600px) {
  .content {
    width: 500px;
  }
}

@media (max-width: 515px) {
  .content {
    width: 400px;
  }

  h1 {
    line-height: 32px;
  }

  h2 {
    line-height: 32px;
  }
}

@media (max-width: 430px) {
  .content {
    width: 350px;
  }
}

@media (max-width: 380px) {
  .content {
    width: 300px;
  }
}
</style>
