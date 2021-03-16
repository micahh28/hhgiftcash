<template>
  <div>
    <div>
      <van-nav-bar fixed placeholder title="联系人" @click-right="onClickRight">
        <template #right>
          <van-icon name="plus" size="18" />
        </template>
      </van-nav-bar>
    </div>
    <div>
      <van-search v-model="value" placeholder="请输入搜索关键词" />
    </div>
    <div>
      <van-index-bar :sticky="false">
        <van-index-anchor index="A" />
        <van-cell title="张三" />
        <van-cell title="张三" />
        <van-cell title="张三" />

        <van-index-anchor index="B" />
        <van-cell title="张三" />
        <van-cell title="张三" />
        <van-cell title="张三" />

        <van-index-anchor index="C" />
        <van-cell title="张三" />
        <van-cell title="张三" />
        <van-cell title="张三" />

        <van-index-anchor index="D" />
        <van-cell title="张三" />
        <van-cell title="张三" />
        <van-cell title="张三" />

        <van-index-anchor index="E" />
        <van-cell title="张三" />
        <van-cell title="张三" />
        <van-cell title="张三" />
      </van-index-bar>
    </div>
  </div>
</template>

<script>
  import {
    IndexBar,
    IndexAnchor,
    Cell,
    Search
  } from "vant";

  export default {
    name: "Friends",
    components: {
      [IndexBar.name]: IndexBar,
      [IndexAnchor.name]: IndexAnchor,
      [Cell.name]: Cell,
      [Search.name]: Search,
    },
    methods: {
      onClickRight() {},
    },
    data() {
      return {
        value: '',
      };
    },
  };
</script>

<style lang="scss" scoped>
</style>