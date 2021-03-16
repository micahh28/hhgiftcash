<template>
  <div>
    <!-- 导航栏 -->
    <div>
      <van-nav-bar fixed placeholder title="礼簿详细" left-arrow left-text="返回" @click-left="onClickLeft"
        @click-right="onClickRight">
        <template #right>
          <van-icon name="delete-o" size="18" />
        </template>
      </van-nav-bar>
    </div>

    <!-- 头部总计 -->
    <div class="app-content">
      <div class="summary">
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
            <h6 style="text-align: center">人情个数</h6>
            <br />
          </van-col>
        </van-row>
      </div>

      <!-- 内容 -->
      <div>
        <van-pull-refresh v-model="refreshing" @refresh="onRefresh">
          <van-list v-model="loading" :finished="finished" finished-text="我是有底线的" @load="onLoad">
            <van-cell v-for="item in list" :key="item.friendId" size="large" is-link center :title="item.friendName"
              :label="'共' + item.cont + '笔'" :value="item.cashGiftTotal" :to="{ path: 'detail', query: { id: item } }"
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
    name: "FriendshipBook",
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
              friendId: 1,
              friendName: "杨过",
              cont: 2,
              cashGiftTotal: 100,
            },
            {
              friendId: 2,
              friendName: "令狐冲",
              cont: 2,
              cashGiftTotal: 100,
            },
            {
              friendId: 3,
              friendName: "风清扬",
              cont: 2,
              cashGiftTotal: 100,
            },
          ];

          datalist.forEach((item) => this.list.push(item));

          // 加载状态结束
          this.loading = false;

          // 数据全部加载完成
          if (this.list.length >= 10) {
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
            message: "该礼簿所有来往都将被删除，确定删除？",
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
  .summary {
    margin: 20px 0 20px 0;
    padding: 24px;
    background-image: url(../../assets/img/giftbook/bg_summary.png);
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