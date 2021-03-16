<template>
  <div class="container">
    <div class="left-bottom-sign"></div>
    <div class="right-top-sign"></div>
    <!-- 设置白色背景防止软键盘把下部绝对定位元素顶上来盖住输入框等 -->
    <div class="wrapper">
      <div class="left-top-sign">LOGIN</div>
      <div class="welcome">欢迎回来！</div>
      <div class="input-content">
        <div class="input-item">
          <span class="tit">手机号码</span>
          <input :value="name" placeholder="用户名/手机号/邮箱" maxlength="10" />
        </div>
        <div class="input-item">
          <span class="tit">密码</span>
          <input type="password" :value="password" placeholder="请输入密码" maxlength="20" />
        </div>
      </div>
      <van-button round color="#fa436a" loading-text="登录中..." :loading="logining" block class="confirm-btn"
        @click="toLogin">登录</van-button>
      <div class="forget-section">忘记密码?</div>
    </div>
    <div class="register-section">
      还没有账号?
      <span class="register-section-lnk" @click="toRegist">马上注册</span>
    </div>
  </div>
</template>

<script>
  export default {
    name: "Login",
    data() {
      return {
        name: "",
        password: "",
        logining: false,
      };
    },
    methods: {
      toRegist() {
        console.log("注册");
      },
      toLogin() {
        console.log("登陆");
      },
    },
  };
</script>

<style>
  .container {
    padding-top: 115px;
    position: relative;
    width: 100vw;
    height: 100vh;
    overflow: hidden;
    background: #fff;
  }

  .wrapper {
    position: relative;
    z-index: 90;
    background: #fff;
    padding-bottom: 21px;
  }

  .left-top-sign {
    font-size: 60px;
    color: #f8f8f8;
    position: relative;
    left: -8px;
  }

  .right-top-sign {
    position: absolute;
    top: 40px;
    right: -15px;
    z-index: 95;
  }

  .right-top-sign:before,
  .right-top-sign:after {
    display: block;
    content: "";
    width: 200px;
    height: 40px;
    background: #b4f3e2;
  }

  .right-top-sign:before {
    transform: rotate(50deg);
    border-radius: 0 50px 0 0;
  }

  .right-top-sign:after {
    position: absolute;
    right: -99px;
    top: 0;
    transform: rotate(-50deg);
    border-radius: 50px 0 0 0;
    /* background: pink; */
  }

  .left-bottom-sign {
    position: absolute;
    left: -135px;
    bottom: -160px;
    border: 50px solid #d0d1fd;
    border-radius: 50%;
    padding: 90px;
  }

  .welcome {
    position: relative;
    left: 25px;
    top: -45px;
    font-size: 23px;
    color: #555;
    text-shadow: 1px 0px 1px rgba(0, 0, 0, 0.3);
  }

  .input-content {
    padding: 0 30px;
  }

  .input-item {
    display: flex;
    flex-direction: column;
    align-items: flex-start;
    justify-content: center;
    padding: 0 15px;
    background: #f8f6fc;
    height: 60px;
    border-radius: 4px;
    margin-bottom: 25px;
  }

  .input-item .tit {
    height: 25px;
    line-height: 28px;
    font-size: 13px;
    color: #606266;
  }

  .input-item input {
    height: 30px;
    font-size: 15px;
    color: #303133;
    width: 100%;
    border: none;
    background: none;
  }

  .confirm-btn {
    margin-left: auto;
    margin-right: auto;
    width: 312px;
    height: 38px;
    line-height: 38px;
    margin-top: 35px;
    font-size: 16px;
  }

  .confirm-btn:after {
    border-radius: 100px;
  }

  .forget-section {
    font-size: 13px;
    color: #4399fc;
    text-align: center;
    margin-top: 20px;
  }

  .register-section {
    position: absolute;
    left: 0;
    bottom: 25px;
    width: 100%;
    font-size: 13px;
    color: #606266;
    text-align: center;
  }

  .register-section-lnk {
    color: #4399fc;
    margin-left: 5px;
  }
</style>