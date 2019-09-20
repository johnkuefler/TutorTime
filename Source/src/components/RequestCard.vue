<style scoped>
  .button {
    background-color: #64CC96;
    -moz-border-radius: 17px;
    -webkit-border-radius: 17px;
    border-radius: 17px;
    display: inline-block;
    cursor: pointer;
    color: #000000;
    font-family: Arial;
    font-size: 17px;
    font-weight: bold;
    padding: 10px 10px;
    text-decoration: none;
  }

  .button:hover {
    background-color: #C8F2DC;
  }

  .button:active {
    position: relative;
    top: 1px;
  }

  .card {
    border: 1px #efefef solid;
    transition-timing-function: ease-in;
    transition-property: box-shadow;
    transition-duration: .1s;
    transition-timing-function: linear;
    text-align: left;
    padding: 10px;
    background-color: #F5F4F4;
    border-radius: 15px;
    width: 100%;
  }
</style>


<template>


  <div class="card shadow-sm ">
    <div class="m-2">
      <p><b>Time:</b> {{request.dateTime | formatDate}}</p>
      <p><b>Request:</b> {{request.problem}}</p>
      <p><b>Requester:</b> {{request.name}}</p>
      <div class="row" style="padding:10px 10px;">
        <h3>{{request.numberOfPeople}}</h3>
        <div style="padding:0px 30px" />
        <a href="#" class="button" @click="joinSession()">+ Join Session</a>
      </div>

    </div>
  </div>

</template>

<script>
  import axios from 'axios';
  import dayjs from 'dayjs';
  export default {
    name: 'RequestCard',
    props: {
      request: {
        type: Object,
        default: () => { }
      },
    },
    methods: {
      async joinSession() {
        const { data } = await axios.put('/api/tutoringrequest/join?requestid=' + this.request.id);
        this.request = data;
      }
    },
    filters: {
      formatDate(date) {
        const value = dayjs(date).format('MM/DD/YYYY hh:mm A')
        return value
      }
    }
  }

</script>