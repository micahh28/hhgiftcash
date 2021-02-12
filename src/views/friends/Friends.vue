<template>
  <div>
    <div>
      <van-nav-bar fixed title="联系人" @click-right="onClickRight">
        <template #right>
          <van-icon name="plus" size="18" />
        </template>
      </van-nav-bar>
    </div>
    <dir>
      <van-index-bar>
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
    </dir>
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
  methods: {
    onClickRight() {},
  },
  data() {
    return {};
  },
};
</script>

<style lang="scss" scoped>
</style>