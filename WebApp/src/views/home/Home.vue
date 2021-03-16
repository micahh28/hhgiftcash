<template>
  <div>
    <div class="home-head">
      <!-- 搜索框 -->
      <form action="/">
        <van-search v-model="searchKeyword" show-action shape="round" background="transparent" placeholder="请输入搜索关键词"
          @search="onSearch">
          <template #action>
            <div @click="onSearch">搜索</div>
          </template>
        </van-search>
      </form>

      <div style="padding: 2vh 32px">
        <label style="color: #fff">2021年
          <van-icon name="arrow-down" color="#fff" />
        </label>
      </div>

      <!-- 年度统计 -->
      <van-row type="flex" justify="center" class="home-head_alltotal">
        <van-col span="12">
          <h3>{{ allincome }}</h3>
          <h5>总收入</h5>
        </van-col>
        <van-col span="12">
          <h3>{{ allexpense }}</h3>
          <h5>总支出</h5>
        </van-col>
      </van-row>
    </div>

    <!-- 主体内容 -->
    <div class="app-content">
      <div v-for="bill in MonthlyBills" :key="bill.month">
        <van-cell-group :title="bill.month">
          <van-cell>
            <!-- 使用 title 插槽来自定义标题 -->
            <template #title>
              <van-row type="flex" justify="center" class="cell-month_data">
                <van-col span="12">
                  <div>
                    <van-tag round type="danger">收</van-tag> 2笔
                  </div>
                  <h2>333</h2>
                </van-col>
                <van-col span="12">
                  <div>
                    <van-tag round type="success">支</van-tag> 2笔
                  </div>
                  <h2>333</h2>
                </van-col>
              </van-row>
            </template>
          </van-cell>
          <van-cell value="收支差666" is-link />
        </van-cell-group>
      </div>
    </div>

    <!-- 添加按钮 -->
    <div class="home-add">
      <van-button round color="#f46464" to="/shipform">记一笔</van-button>
    </div>
  </div>
</template>

<script>
  import {
    Search,
    Col,
    Row,
    Cell,
    CellGroup,
    Tag
  } from "vant";
  export default {
    name: "Home",
    components: {
      [Search.name]: Search,
      [Col.name]: Col,
      [Row.name]: Row,
      [Cell.name]: Cell,
      [CellGroup.name]: CellGroup,
      [Tag.name]: Tag,
    },
    computed: {
      allexpense() {
        return 666;
      },
      allincome() {
        return 666;
      },
    },
    data() {
      return {
        searchKeyword: "",
        MonthlyBills: [{
            month: "2月",
            extotal: 555,
            intotal: 666
          },
          {
            month: "3月",
            extotal: 555,
            intotal: 666
          },
          {
            month: "4月",
            extotal: 555,
            intotal: 666
          },
          {
            month: "5月",
            extotal: 555,
            intotal: 666
          },
          {
            month: "6月",
            extotal: 555,
            intotal: 666
          },
          {
            month: "7月",
            extotal: 555,
            intotal: 666
          },
        ],
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
  .home-head {
    height: 24vh;
    background-image: url(../../assets/img/giftbook/bg_summary.png);
    background-position: center;
    background-size: cover;
    background-repeat: no-repeat;
  }

  .home-head_alltotal {
    text-align: center;
    color: #fff;
    font-weight: normal;
  }

  .cell-month_data {
    padding: 10px;
    text-align: center;
  }

  .home-add {
    position: fixed;
    bottom: 100px;
    right: 30px;
    border-radius: 50%;
    border: 1px solid #e9e9e9;
    box-shadow: 0px 0px 10px 0px rgba(0, 0, 0, 0.2);
    z-index: 999;
  }
</style>