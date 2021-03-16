import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/home/Home.vue'

Vue.use(VueRouter)

const routes = [{
    path: '/',
    redirect: {
      name: 'Home'
    }
  },
  {
    path: '/home',
    name: 'Home',
    meta: {
      showTab: true //是否显示Tabbar
    },
    component: Home
  },
  {
    path: '/profile',
    name: 'Profile',
    meta: {
      showTab: true //是否显示Tabbar
    },
    component: () => import('../views/profile/profile.vue')
  },
  {
    path: '/friends',
    name: 'Friends',
    meta: {
      showTab: true //是否显示Tabbar
    },
    component: () => import('../views/friends/Friends.vue')
  },
  {
    path: '/giftbook',
    name: 'Giftbook',
    meta: {
      showTab: true //是否显示Tabbar
    },
    component: () => import('../views/giftbook/Giftbook.vue')
  },
  {
    path: '/friendshipbook',
    name: 'FriendshipBook',
    component: () => import('../views/giftbook/FriendshipBook.vue')
  },
  {
    path: '/billbook',
    name: 'BillBook',
    component: () => import('../views/giftbook/BillBook.vue')
  },
  {
    path: '/detail',
    name: 'Detail',
    component: () => import('../views/detail/Detail.vue')
  },
  {
    path: '/detailform',
    name: 'DetailForm',
    component: () => import('../views/detail/DetailForm.vue')
  },
  {
    path: '/login',
    name: 'Login',
    component: () => import('../views/Account/Login.vue')
  }
]

const router = new VueRouter({
  mode: 'history',
  routes
})

export default router