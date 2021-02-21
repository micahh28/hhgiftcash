<template>
  <div>
    <van-search
      v-model="searchKeyword"
      show-action
      shape="round"
      background="#f46464"
      placeholder="请输入搜索关键词"
    >
      <template #action>
        <span @click="onSearch">搜索</span>
      </template>
    </van-search>
    <div class="add">
      <!-- <van-icon name="records" /> -->
      <van-button round color="#f46464" to="/shipform">记一笔</van-button>
    </div>
  </div>
</template>

<script>
import { Search, Button } from "vant";
export default {
  name: "Home",
  components: {
    [Search.name]: Search,
    [Button.name]: Button,
  },
  data() {
    return {
      searchKeyword: "",
    };
  },
  methods: {
    onSearch() {
      alert(this.searchKeyword);
    },
  },
};
</script>

<style>
.add {
  position: fixed;
  bottom: 100px;
  right: 30px;
  border-radius: 50%;
  border: 1px solid #e9e9e9;
  box-shadow: 0px 0px 10px 0px rgba(0, 0, 0, 0.2);
}
</style>
