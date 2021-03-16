<template>
  <div>
    <!-- 导航栏 -->
    <div>
      <van-nav-bar fixed placeholder title="账簿详细" left-arrow left-text="返回" @click-left="onClickLeft"
        @click-right="onClickRight">
        <template #right>
          <van-icon name="delete-o" size="18" />
        </template>
      </van-nav-bar>
    </div>

    <!-- 头部总计 -->
    <div class="app-content">
      <div class="summary-bill">
        <van-row type="flex" justify="center">
          <van-col span="12">
            <br />
            <h3 style="text-align: center">{{ total }}</h3>
            <h6 style="text-align: center">总计（元）</h6>
            <br />
          </van-col>
          <van-col span="12">
            <br />
            <h3 style="text-align: center">{{ count }}</h3>
            <h6 style="text-align: center">账单笔数</h6>
            <br />
          </van-col>
        </van-row>
      </div>

      <!-- 内容 -->
      <div>
        <van-pull-refresh v-model="refreshing" @refresh="onRefresh">
          <van-list v-model="loading" :finished="finished" finished-text="我是有底线的" @load="onLoad">
            <van-cell v-for="item in list" :key="item.friendId" size="large" is-link center :title="item.billName"
              :label="item.billTime" :value="item.money" :to="{ path: 'detail', query: { id: item } }"
              value-class="van-cell__value2" />
          </van-list>
        </van-pull-refresh>
      </div>
    </div>

  </div>
</template>

<script>
  import {
    List,
    Cell,
    PullRefresh,
    Col,
    Row,
    Dialog
  } from "vant";
  export default {
    name: "BillBook",
    components: {
      [Cell.name]: Cell,
      [List.name]: List,
      [PullRefresh.name]: PullRefresh,
      [Col.name]: Col,
      [Row.name]: Row,
      [Dialog.Component.name]: Dialog.Component,
    },
    computed: {
      total() {
        return 22;
      },
      count() {
        return 2;
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
          let datalist = [{
              billId: 1,
              billName: "空调",
              billTime: "2021/2/20",
              money: 100,
            },
            {
              billId: 2,
              billName: "洗碗机",
              billTime: "2021/2/20",
              money: 100,
            },
            {
              billId: 3,
              billName: "洗衣机",
              billTime: "2021/2/20",
              money: 100,
            },
            {
              billId: 4,
              billName: "电视",
              billTime: "2021/2/20",
              money: 100,
            },
          ];

          datalist.forEach((item) => this.list.push(item));

          // 加载状态结束
          this.loading = false;

          // 数据全部加载完成
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
      // 返回按钮
      onClickLeft() {
        window.history.length > 1 ? this.$router.go(-1) : this.$router.push("/");
      },
      // 删除
      onClickRight() {
        Dialog.confirm({
            title: "提示",
            message: "该账簿所有记录都将被删除，确定删除？",
          })
          .then(() => {
            // on confirm
          })
          .catch(() => {
            // on cancel
          });
      },
    },
  };
</script>

<style>
  .summary-bill {
    margin: 20px 0 20px 0;
    padding: 24px;
    background-image: url(../../assets/img/giftbook/bg_summary_bill.png);
    background-repeat: no-repeat;
    background-size: 100% 100%;
    -moz-background-size: 100% 100%;
    color: #ffffff;
  }

  .van-cell__value1 {
    color: #f46464;
  }

  .van-cell__value2 {
    color: #4fc08d;
  }
</style>