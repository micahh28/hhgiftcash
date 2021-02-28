<template>
  <div>
    <!-- 导航栏 -->
    <div>
      <van-nav-bar
        fixed
        placeholder
        title="账单详细"
        left-arrow
        left-text="返回"
        @click-left="onClickLeft"
        @click-right="onClickRight"
      >
        <template #right>
          <van-icon name="plus" size="18" />
        </template>
      </van-nav-bar>
    </div>
    <!-- 内容 -->
    <div class="detail">
      <div class="card">
        <div class="type">
          <span>洗碗机</span>
        </div>
        <div class="amount">-2222</div>
        <div class="info">
          <div class="infocell">
            <span>记录时间</span>
            <span>202015555</span>
          </div>
          <div class="infocell">
            <span>备注</span>
            <span>哈哈哈</span>
          </div>
        </div>
        <div class="operation van-hairline--top">
          <span class="van-hairline--right" @click="deleteDetail"
            ><van-icon name="delete" />删除</span
          >
          <span @click="editDetail"><van-icon name="edit" />编辑</span>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import { Dialog } from "vant";

export default {
  name: "Detail",
  components: {
    [Dialog.Component.name]: Dialog.Component,
  },
  methods: {
    onClickLeft() {
      window.history.length > 1 ? this.$router.go(-1) : this.$router.push("/");
    },
    onClickRight() {},
    deleteDetail() {
      Dialog.confirm({
        title: "提示",
        message: "确定删除该账单记录吗？",
      })
        .then(() => {
          // on confirm
        })
        .catch(() => {
          // on cancel
        });
    },
    editDetail() {},
  },
};
</script>

<style>
.detail {
  height: 100%;
  display: flex;
  flex-direction: column;
  background-color: #f5f5f5;
  padding: 12px 24px 0 24px;
}
.card {
  border-radius: 12px;
  background-color: #fff;
  padding: 0 12px;
  display: flex;
  flex-direction: column;
  align-items: center;
}
.card .type {
  padding: 24px 0 12px 0;
}
.card .type span {
  display: inline-block;
  height: 22px;
  border-radius: 50%;
  text-align: center;
  line-height: 20px;
}
.card .amount {
  font-size: 24px;
  font-weight: 600;
  margin-bottom: 24px;
}
.card .info {
  width: 100%;
  font-size: 14px;
  text-align: left;
}
.card .info .infocell {
  display: flex;
  align-items: center;
  justify-content: flex-start;
  margin-bottom: 12px;
}
.card .info .infocell span:nth-of-type(1) {
  flex: 3;
  color: rgba(0, 0, 0, 0.5);
}
.card .info .infocell span:nth-of-type(2) {
  flex: 9;
}
.card .operation {
  width: 100%;
  height: 50px;
  display: flex;
  align-items: center;
  font-size: 16px;
}
.card .operation .van-icon {
  margin-right: 4px;
}
.card .operation span {
  display: flex;
  align-items: center;
  justify-content: center;
  height: 100%;
  flex: 1;
}
.card .operation span:nth-of-type(1) {
  color: red;
}
</style>