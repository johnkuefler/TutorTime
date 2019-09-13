<template>

    <a :href="'/home/tutorrequests/'+tutor.id" style="text-decoration:none">
        <div class="l-card" :class="{'round-card':rounded}">
            <img :src="tutor.imageUrl">
            <div class="ml-3 mt-3">
                <h3>{{tutor.subject}}</h3>
                <p>Tutor: {{tutor.firstName}} {{tutor.lastName}}</p>
                <p>Location: {{tutor.location}}</p>
                <p>Time: {{tutor.time}}</p>
            </div>
        </div>
    </a>

</template>

<script>
  export default {
    name: 'TutorCard',
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
    -webkit-box-shadow: 10px 10px 10px -2px rgba(219, 219, 219, 1);
    -moz-box-shadow: 10px 10px 10px -2px rgba(219, 219, 219, 1);
    box-shadow: 10px 10px 10px -2px rgba(219, 219, 219, 1);
    transition-timing-function: ease-in;
    transition-property: box-shadow;
    transition-duration: .1s;
    transition-timing-function: linear;
    text-align: left;
    -webkit-text-fill-color: black;

  }

  img {
    max-width: 100%;

  }

  .round-card {
    border-radius: 3px;
    overflow: hidden;
  }

  .l-card:hover {
    -webkit-box-shadow: 15px 15px 15px -2px rgba(219, 219, 219, 1);
    -moz-box-shadow: 15px 15px 15px -2px rgba(219, 219, 219, 1);
    box-shadow: 15px 15px 15px -2px rgba(219, 219, 219, 1);

  }
</style>