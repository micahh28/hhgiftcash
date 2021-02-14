<template>
	<div id="app">
		<!-- 路由 -->
		<router-view />

		<!-- Tabbar -->
		<van-tabbar v-model="active" active-color="#ee0a24" inactive-color="#000">
			<van-tabbar-item name="Home" icon="home-o" to="/home">首页</van-tabbar-item>
			<van-tabbar-item name="Giftbook" icon="balance-list-o" to="/giftbook">礼簿</van-tabbar-item>
			<van-tabbar-item name="Friends" icon="friends-o" to="/friends">联系人</van-tabbar-item>
			<van-tabbar-item name="Profile" icon="contact" to="/profile">我的</van-tabbar-item>
		</van-tabbar>
	</div>
</template>

<script>
	import Vue from "vue";
	import {
		NavBar
	} from "vant";
	import {
		Tabbar,
		TabbarItem
	} from "vant";
	import {
		Icon
	} from 'vant';


	Vue.use(NavBar);
	Vue.use(Tabbar);
	Vue.use(TabbarItem);
	Vue.use(Icon);

	export default {
		name: "App",
		components: {

		},
		computed: {
			active() {
				return this.$route.name
			}
		},
		data() {
			return {

			};
		},
		
	};
</script>

<style>
</style>
