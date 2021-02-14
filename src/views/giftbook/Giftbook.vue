<template>
	<div>
		<div>
			<van-nav-bar fixed placeholder title="礼簿" @click-right="onClickRight">
				<template #right>
					<van-icon name="plus" size="18" />
				</template>
			</van-nav-bar>
		</div>
		<div class="summary">
			
		</div>

	</div>
</template>

<script>
	import {
		IndexBar,
		IndexAnchor,
		Cell,
	} from "vant";
	export default {
		name: "Friends",
		components: {
			[IndexBar.name]: IndexBar,
			[IndexAnchor.name]: IndexAnchor,
			[Cell.name]: Cell,
		},
		methods: {
			onClickRight() {
				alert("添加礼簿")
				console.log(this.$route);
			},
		}
	}
</script>

<style scoped>
	.summary {
		background-image: url(../../assets/img/giftbook/bg_summary.png);
		backgroundRepeat: "no-repeat";
		backgroundPosition: "center";
		backgroundSize: "100% 100%";
		z-index: -1;
		height: 60px;
		width: auto;
	}
</style>
