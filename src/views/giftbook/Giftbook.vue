<template>
	<div>
		<div>
			<van-nav-bar fixed title="礼簿" @click-right="onClickRight">
				<template #right>
					<van-icon name="plus" size="18" />
				</template>
			</van-nav-bar>
		</div>
	</div>
</template>

<script>
	import { IndexBar, IndexAnchor, Cell } from "vant";
	export default {
		name: "Friends",
		components: {
			[IndexBar.name]: IndexBar,
			[IndexAnchor.name]: IndexAnchor,
			[Cell.name]: Cell,
		},
	}
</script>

<style lang="scss" scoped>

</style>
