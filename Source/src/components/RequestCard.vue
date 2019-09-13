<template>


  <div class="card">
    <div class="ml-3 mt-5">
      <p>Time: {{request.time}}</p>
      <p>Request: {{request.problem}}</p>
      <p>Requester: {{request.name}}</p>
      <h3>{{request.numberOfPeople}}</h3>
    </div>
  </div>

</template>

<script>
  export default {
    name: 'RequestCard',
    props: {
      request: {
        type: Object,
        default: () => { }
      },
    }
  }

</script>

<style scoped>
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