import { createRouter, createWebHistory } from "vue-router";
import Home from "../views/Home.vue";
import Frontend from "../views/Frontend.vue";
import Backend from "../views/Backend.vue";
import Fullstack from "../views/Fullstack.vue";

const routes = [
  {
    path: "/",
    name: "Home",
    component: Home,
  },
  {
    path: "/frontend",
    name: "Frontend",
    component: Frontend,
  },
  {
    path: "/backend",
    name: "Backend",
    component: Backend,
  },
  {
    path: "/fullstack",
    name: "Fullstack",
    component: Fullstack,
  },
];

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes,
});

export default router;
