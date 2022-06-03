<template>
  <nav id="navBar">
    <div class="logo"><img src="@/assets/tenisu.svg" alt="" /></div>
  </nav>
  <div class="background-content">
    <div class="content">
      <router-link to="/" class="back">&#60; Retour</router-link>
      <h1 class="title">
        Test Technique L’Atelier -
        <span class="electric-blue">Fullstack</span> 🚀
      </h1>
      <p>
        Vous trouverez ci-dessous les éléments utiles pour la réalisation du
        test technique.
      </p>
      <h2>Votre mission :</h2>
      <p>
        Crée une application (Back &amp; Front) simple permettant de récupérer
        et d’afficher les statistiques des joueurs de tennis. L’exercice devrait
        te prendre <b>environ 2h</b>. Tu as le choix de réaliser la 4ème tâche
        sur n’importe quel Cloud. Un focus particulier doit être fait sur les 3
        premières, la 4ème est fortement conseillée ! Les tâches Back et Front
        pourront être réalisées dans l’ordre que tu souhaites.
      </p>
      <h2>Ce que l’on regarde :</h2>
      <h3>FRONT</h3>
      <ul>
        <li>Un code clean et lisible</li>
        <li>Ton code devra être simple à comprendre</li>
        <li>Avoir une bonne structure / organisation de tes composants</li>
        <li>
          L’interface devra être responsive avec une bonne UX (Mobile &amp;
          Desktop)
        </li>
        <li>L’implémentation des tests</li>
      </ul>
      <h3>BACK</h3>
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
      <div class="download">
        <Download :image="Json" title="headtohead.json" text="3 Ko" />
        <Download :image="Image" title="Ressources" text="7,1 Mo" />
      </div>
      <h2>Les tâches à réaliser :</h2>
      <h3>FRONT</h3>
      <div class="tasks">
        <Task
          title="Tâche n°1"
          text="La version Desktop doit être identique à la maquette.
La version Mobile doit être une adaptation de la version Desktop.
Maquette : ressources/Home.jpg"
        />
        <Task
          title="Tâche n°2"
          text="La version Desktop doit se rapprocher de la maquette.
La version Mobile doit être une adaptation de la version Desktop.
Maquette : ressources/Details.jpg"
        />
        <Task
          title="Tâche n°3"
          text="Affiche sur la première interface les statistiques retournées par ton API. Maquette : ressources/Home.jpg"
        />
      </div>
      <h3>BACK</h3>
      <div class="tasks">
        <Task
          title="Tâche n°1"
          text="Crée un endpoint qui retourne les joueurs. La liste doit être triée du meilleur au moins bon."
        />
        <Task
          title="Tâche n°2"
          text="Créer un endpoint qui permet de retourner les informations d’un joueur grâce à son ID."
        />
        <Task
          title="Tâche n°3"
          text="Créer un endpoint qui retourne les statistiques suivantes : - Pays qui a le plus grand ratio de parties gagnées - IMC moyen de tous les joueurs - La médiane de la taille des joueurs"
        />
        <Task title="Tâche n°4" text="Déploie ton projet sur le Cloud." />
      </div>
    </div>
  </div>
  <div class="end-page">
    <div class="content">
      <h2>Pour t’aider :</h2>
      <h3 class="colors">Les couleurs :</h3>
      <div class="cards">
        <Colors name="Orange" info="#F2753B" color="#F2753B" />
        <Colors name="Orange Light" info="#EBAD65" color="#EBAD65" />
        <Colors
          name="Black 30"
          info="#000000, 30% opacity"
          color="rgba(0, 0, 0, 0.3)"
        />
      </div>
      <h3>Les typographies :</h3>
      <p>Montserrat :</p>
      <div class="code" title="coucou">
        &lt;<span class="electric-blue">link</span>
        <span class="green"> href</span>="<span class="orange-light"
          >https://fonts.googleapis.com/css2?family=Montserrat:wght@300;600;700;900&amp;display=swap</span
        >" rel="stylesheet"&gt;
      </div>
      <p>Mulish :</p>
      <div class="code">
        &lt;<span class="electric-blue">link</span>
        <span class="green"> href</span>="<span class="orange-light"
          >https://fonts.googleapis.com/css2?family=Mulish:wght@600;700&amp;display=swap</span
        >" rel="stylesheet"&gt;
      </div>
    </div>
  </div>
</template>

<script>
import Colors from "@/components/Colors.vue";
import Download from "@/components/Download.vue";
import Json from "@/assets/json.png";
import Image from "@/assets/image.png";
import Task from "@/components/Task.vue";

export default {
  name: "Fullstack",
  components: {
    Colors,
    Download,
    Task,
  },
  data() {
    return {
      Json,
      Image,
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

.end-page {
  background-color: white;
  padding-top: 2px;
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

.download {
  display: flex;
  flex-wrap: wrap;
  justify-content: flex-start;
  gap: 24px;
}

.tasks {
  display: flex;
  flex-wrap: wrap;
  justify-content: flex-start;
  gap: 24px;
}

.cards {
  display: flex;
  gap: 24px;
}

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
