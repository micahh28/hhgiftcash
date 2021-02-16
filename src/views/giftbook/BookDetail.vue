<template>
	<div>
		<div>
			<van-nav-bar fixed placeholder title="礼簿详细" @click-right="onClickRight">
				<template #right>
					<van-icon name="plus" size="18" />
				</template>
			</van-nav-bar>
		</div>
		<div class="summary">
			<van-row type="flex" justify="center">
				<van-col span="12" @click="onAllTotal">
					<br />
					<h3 style="text-align: center;">{{total}}</h3>
					<h6 style="text-align: center;">总计（元）</h6>
					<br />
				</van-col>
				<van-col span="12">
					<br />
					<h3 style="text-align: center;">{{count}}</h3>
					<h6 style="text-align: center;">人情个数</h6>
					<br />
				</van-col>
			</van-row>
		</div>
		<div>
			<van-pull-refresh v-model="refreshing" @refresh="onRefresh">
				<van-list v-model="loading" :finished="finished" finished-text="我是有底线的" @load="onLoad">
					<van-cell v-for="item in list" :key="item" :title="item" />
				</van-list>
			</van-pull-refresh>
		</div>
	</div>
</template>

<script>
	import {
		List,
		PullRefresh,
		Col,
		Row,
	} from "vant";
	export default {
		name: "Friends",
		components: {
			[List.name]: List,
			[PullRefresh.name]: PullRefresh,
			[Col.name]: Col,
			[Row.name]: Row,
		},
		computed: {
			total() {
				return 22;
			},
			count() {
				return 2
			},
		},
		data() {
			return {
				list: [],
				loading: false,
				finished: false,
				refreshing: false,
			};
		},
		methods: {
			onLoad() {
				setTimeout(() => {
					if (this.refreshing) {
						this.list = [];
						this.refreshing = false;
					}

					for (let i = 0; i < 10; i++) {
						this.list.push(this.list.length + 1);
					}
					this.loading = false;

					if (this.list.length >= 40) {
						this.finished = true;
					}
				}, 1000);
			},
			onRefresh() {
				// 清空列表数据
				this.finished = false;

				// 重新加载数据
				// 将 loading 设置为 true，表示处于加载状态
				this.loading = true;
				this.onLoad();
			},
		},
	}
</script>

<style>
	.summary {
		margin: 20px;
		padding: 24px;
		background-image: url(../../assets/img/giftbook/bg_summary.png);
		background-repeat: no-repeat;
		background-size: 100% 100%;
		-moz-background-size: 100% 100%;
		color: #FFFFFF;
	}
</style>
