<template>
	<div>
		<van-search v-model="searchKeyword" show-action shape="round" background="#f46464" placeholder="请输入搜索关键词">
			<template #action>
				<span @click="onSearch">搜索</span>
			</template>
		</van-search>

	</div>
</template>

<script>
	import {
		Search
	} from "vant";
	export default {
		name: "Home",
		components: {
			[Search.name]: Search,
		},
		data() {
			return {
				searchKeyword: "",
			};
		},
		methods: {
			onSearch() {
				alert(this.searchKeyword)
			},
		}
	};
</script>
