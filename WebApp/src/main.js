import Vue from 'vue'
import App from './App.vue'
import router from './router'
import store from './store'

// 一些项目高频组件
import {
  NavBar,
  Tabbar,
  TabbarItem,
  Icon,
  Button,
  Toast
} from "vant";

Vue.use(NavBar);
Vue.use(Tabbar);
Vue.use(TabbarItem);
Vue.use(Icon);
Vue.use(Button);
Vue.use(Toast);

Vue.config.productionTip = false

new Vue({
  router,
  store,
  render: h => h(App)
}).$mount('#app')