<template>
  <div>
    <van-search
      v-model="value"
       show-action
      shape="round"
      background="#4fc08d"
      placeholder="请输入搜索关键词"
    >
      <template #action>
        <div @click="onSearch">搜索</div>
      </template>
    </van-search>
  </div>
</template>

<script>
import { Search } from "vant";
export default {
  name: "Home",
  components: {
    [Search.name]: Search,
  },
  data() {
    return {
      value: "",
    };
  },
};
</script>
