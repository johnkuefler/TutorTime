<template>

    
        <div class="card">
            <div class="ml-3">
                <p>Time: {{request.dateTime}}</p>
                <p>Request: {{request.problem}}</p>
                <p>Requester: {{request.name}}</p>
                <div class="row" style="padding:10px 10px;">
                  <h3>{{request.numberOfPeople}}</h3>
                  <div style="padding:0px 30px"/>
                  <a href="#" class="button" @click="joinSession()">+ Join Session</a>
                </div>
                
            </div>
        </div>

</template>

<script>
  import axios from 'axios';
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
         const { data } = await axios.put('/api/tutoringrequest/join?requestid='+this.request.id);
         this.request = data;
      }
    },
  }

</script>

<style scoped>
    .button 
    {
      background-color:#82e09b;
      -moz-border-radius:17px;
      -webkit-border-radius:17px;
      border-radius:17px;
      border:1px solid #18ab29;
      display:inline-block;
      cursor:pointer;
      color:#000000;
      font-family:Arial;
      font-size:17px;
      font-weight:bold;
      padding:10px 10px;
      text-decoration:none;
    }
    .button:hover {
      background-color:#5cbf2a;
    }
    .button:active {
      position:relative;
      top:1px;
    }
    .card {
        border: 1px #efefef solid;
        -webkit-box-shadow: 10px 10px 10px -2px rgba(219, 219, 219, 1);
        -moz-box-shadow: 10px 10px 10px -2px rgba(219, 219, 219, 1);
        box-shadow: 10px 10px 10px -2px rgba(219, 219, 219, 1);
        transition-timing-function: ease-in;
        transition-property: box-shadow;
        transition-duration: .1s;
        transition-timing-function: linear;
        text-align: left;
    }

</style>