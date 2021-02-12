import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/home/Home.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/home',
    name: 'Home',
    component: Home
  },
  {
    path: '/profile',
    name: 'Profile',
    component: () => import('../views/profile/profile.vue')
  },
  {
    path: '/friends',
    name: 'Friends',
    component: () => import('../views/friends/Friends.vue')
  },
  {
    path: '/giftbook',
    name: 'Giftbook',
    component: () => import('../views/giftbook/Giftbook.vue')
  }
]

const router = new VueRouter({
  mode: 'history',
  routes
})

export default router
