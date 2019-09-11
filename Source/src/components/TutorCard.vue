<template>

  <div class="l-card" :class="{'round-card':rounded}">
    <img :src="tutor.imageUrl">
    <h3>{{tutor.subject}}</h3>
    <p>Tutor: {{tutor.firstName}} {{tutor.lastName}}</p>
    <p>Location: {{tutor.location}}</p>
    <p>Time: {{tutor.time}}</p>
    <p>
      <slot></slot>
    </p>
  </div>

</template>

<script>
  export default {
    name: 'TutorCard',
    data: () => ({ count: 0 }),
    props: {
      tutor: {
        type: Object,
        default: () => { }
      },
      rounded: Boolean,
    }
  }

</script>

<style scoped>
  .l-card {
    border: 1px #efefef solid;
    -webkit-box-shadow: 20px 21px 33px -6px rgba(219, 219, 219, 1);
    -moz-box-shadow: 20px 21px 33px -6px rgba(219, 219, 219, 1);
    box-shadow: 20px 21px 33px -6px rgba(219, 219, 219, 1);
    transition-timing-function: ease-in;
    transition-property: box-shadow;
    transition-duration: .1s;
    transition-timing-function: linear;

  }

  img {
    max-width: 100%;

  }

  .round-card {
    border-radius: 10px;
    overflow: hidden;
  }

  .l-card:hover {
    -webkit-box-shadow: 22px 25px 33px -2px rgba(219, 219, 219, 1);
    -moz-box-shadow: 22px 25px 33px -2px rgba(219, 219, 219, 1);
    box-shadow: 22px 25px 33px -2px rgba(219, 219, 219, 1);

  }
</style>