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
			<van-row type="flex" justify="center">
				<van-col span="12" @click="onAllTotal">
					<br />
					<h3 style="text-align: center;">{{alltotal}}</h3>
					<h6 style="text-align: center;">总计（元）</h6>
					<br />
				</van-col>
				<van-col span="12">
					<br />
					<h3 style="text-align: center;">{{allcount}}</h3>
					<h6 style="text-align: center;">礼簿个数</h6>
					<br />
				</van-col>
			</van-row>
		</div>

		<div style="margin-left: 20px;margin-right: 20px;">
			<van-row type="flex">
				<van-col span="12" class="book" @click="onBookClick" v-for="book in giftbooks" :key="book.id">
					<h4>{{book.name}}</h4>
					<br />
					<h6>共{{book.count}}笔</h6>
					<br />
					<br />
					<h3>￥{{book.total}}</h3>
				</van-col>
			</van-row>
		</div>
	</div>
</template>

<script>
	import {
		Col,
		Row,
	} from "vant";
	export default {
		name: "Friends",
		components: {
			[Col.name]: Col,
			[Row.name]: Row,
		},
		methods: {
			onClickRight() {
				alert("添加礼簿")
			},
			onAllTotal() {
				alert("总计888")
			},
			onBookClick() {
				alert("选择了")
			}
		},
		computed: {
			alltotal() {
				let sum = 0;
				this.giftbooks.forEach((item) => {
					sum += item.total;
				});
				return sum;
			},
			allcount() {
				return this.giftbooks.length
			},
		},
		data() {
			return {
				giftbooks: [{
						id: 1,
						name: "婚礼",
						count: 30,
						total: 566
					},
					{
						id: 2,
						name: "弄璋之喜",
						count: 24,
						total: 666
					},
					{
						id: 3,
						name: "弄瓦之喜",
						count: 24,
						total:866
					}
				]
			};
		},
	}
</script>

<style scoped>
	.summary {
		margin: 20px;
		padding: 24px;
		background-image: url(../../assets/img/giftbook/bg_summary.png);
		background-repeat: no-repeat;
		background-size: 100% 100%;
		-moz-background-size: 100% 100%;
		color: #FFFFFF;
	}

	.book {
		padding: 32px 24px 50px 24px;
		background-image: url(../../assets/img/giftbook/bg_book.png);
		background-repeat: no-repeat;
		background-size: 100% 100%;
		-moz-background-size: 100% 100%;
	}
</style>
