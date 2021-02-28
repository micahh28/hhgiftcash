<template>
  <div>
    <!-- 顶部导航 -->
    <div>
      <van-tabs v-model="activeName" animated>
        <van-tab title="人情礼簿" name="friendship">
          <!-- 内容 -->
          <div class="app-content">
            <div class="summary">
              <van-row type="flex" justify="center">
                <van-col span="12">
                  <br />
                  <h3 style="text-align: center">{{ alltotal }}</h3>
                  <h6 style="text-align: center">总计（元）</h6>
                  <br />
                </van-col>
                <van-col span="12">
                  <br />
                  <h3 style="text-align: center">{{ allcount }}</h3>
                  <h6 style="text-align: center">礼簿个数</h6>
                  <br />
                </van-col>
              </van-row>
            </div>
            <div>
              <van-row type="flex">
                <van-col
                  span="12"
                  class="book"
                  @click="onBookClick(book.id)"
                  v-for="book in friendshipbooks"
                  :key="book.id"
                >
                  <h4>{{ book.name }}</h4>
                  <br />
                  <h6>共{{ book.count }}笔</h6>
                  <br />
                  <br />
                  <h3>￥{{ book.total }}</h3>
                </van-col>
              </van-row>
            </div>
          </div>
        </van-tab>
        <van-tab title="账簿" name="bill">
          <!-- 内容 -->
          <div class="app-content">
            <div class="summary-bill">
              <van-row type="flex" justify="center">
                <van-col span="12">
                  <br />
                  <h3 style="text-align: center">{{ alltotal }}</h3>
                  <h6 style="text-align: center">总计（元）</h6>
                  <br />
                </van-col>
                <van-col span="12">
                  <br />
                  <h3 style="text-align: center">{{ allcount }}</h3>
                  <h6 style="text-align: center">账簿个数</h6>
                  <br />
                </van-col>
              </van-row>
            </div>
            <div>
              <van-row type="flex">
                <van-col
                  span="12"
                  class="bookgreen"
                  @click="onBookClick(book.id)"
                  v-for="book in billbooks"
                  :key="book.id"
                >
                  <h4>{{ book.name }}</h4>
                  <br />
                  <h6>共{{ book.count }}笔</h6>
                  <br />
                  <br />
                  <h3>￥{{ book.total }}</h3>
                </van-col>
              </van-row>
            </div>
          </div>
        </van-tab>
      </van-tabs>
    </div>

    <div class="add">
      <van-button round color="#f46464" to="/shipform">添加</van-button>
    </div>
  </div>
</template>
<script>
import { Col, Row, Tab, Tabs, Button } from "vant";
export default {
  name: "Friends",
  components: {
    [Col.name]: Col,
    [Row.name]: Row,
    [Tab.name]: Tab,
    [Tabs.name]: Tabs,
    [Button.name]: Button,
  },
  methods: {
    onBookClick(id) {
      // 跳转到详情页面
      if (this.activeName == "friendship") {
        this.$router.push({ path: "/friendshipbook", query: { id } });
      } else {
        this.$router.push({ path: "/billbook", query: { id } });
      }
    },
  },
  computed: {
    alltotal() {
      let sum = 0;
      if (this.activeName == "friendship") {
        this.friendshipbooks.forEach((item) => {
          sum += item.total;
        });
      } else {
        this.billbooks.forEach((item) => {
          sum += item.total;
        });
      }

      return sum;
    },
    allcount() {
      if (this.activeName == "friendship") {
        return this.friendshipbooks.length;
      } else {
        return this.billbooks.length;
      }
    },
  },
  data() {
    return {
      activeName: "friendship",
      friendshipbooks: [
        {
          id: 1,
          name: "婚礼",
          count: 30,
          total: 556,
        },
        {
          id: 2,
          name: "弄璋之喜",
          count: 24,
          total: 666,
        },
        {
          id: 3,
          name: "弄瓦之喜",
          count: 24,
          total: 866,
        },
      ],
      billbooks: [
        {
          id: 1,
          name: "装修",
          count: 30,
          total: 256,
        },
        {
          id: 2,
          name: "买车",
          count: 24,
          total: 66,
        },
      ],
    };
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
.summary-bill {
  margin: 20px 0 20px 0;
  padding: 24px;
  background-image: url(../../assets/img/giftbook/bg_summary_bill.png);
  background-repeat: no-repeat;
  background-size: 100% 100%;
  -moz-background-size: 100% 100%;
  color: #ffffff;
}
.book {
  padding: 32px 24px 50px 24px;
  background-image: url(../../assets/img/giftbook/bg_book.png);
  background-repeat: no-repeat;
  background-size: 100% 100%;
  -moz-background-size: 100% 100%;
}
.bookgreen {
  padding: 32px 24px 50px 24px;
  background-image: url(../../assets/img/giftbook/bg_book_green.png);
  background-repeat: no-repeat;
  background-size: 100% 100%;
  -moz-background-size: 100% 100%;
}
.add {
  position: fixed;
  bottom: 100px;
  right: 30px;
  border-radius: 50%;
  border: 1px solid #e9e9e9;
  box-shadow: 0px 0px 10px 0px rgba(0, 0, 0, 0.2);
}
</style>
