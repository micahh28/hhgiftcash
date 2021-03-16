<template>
	<div id="app">
		<!-- 路由 -->
		<router-view />

		<!-- Tabbar -->
		<van-tabbar fixed placeholder v-model="active" active-color="#ee0a24" inactive-color="#000"
			v-if="$route.meta.showTab">
			<van-tabbar-item name="Home" icon="home-o" to="/home">首页</van-tabbar-item>
			<van-tabbar-item name="Giftbook" icon="balance-list-o" to="/giftbook">礼簿</van-tabbar-item>
			<van-tabbar-item name="Friends" icon="friends-o" to="/friends">联系人</van-tabbar-item>
			<van-tabbar-item name="Profile" icon="contact" to="/profile">我的</van-tabbar-item>
		</van-tabbar>
	</div>
</template>

<script>
	export default {
		name: "App",
		components: {

		},
		computed: {
			active: {
				get: function () {
					return this.$route.name
				},
				set: function () {}
			}
		},
		// data() {
		// 	return {
		// 		active: this.$route.name,
		// 	};
		// },
	};
</script>

<style>
	@import "assets/css/base.css";
</style>