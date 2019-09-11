<template>
  <div class="container">
    <div class="row">
      <div v-for="tutor in tutors" :key="tutor.id" class="col-md-4">
        <tutor-card rounded :tutor="tutor"></tutor-card>
      </div>
    </div>
  </div>
</template>
<script>
  import axios from 'axios';

  export default {
    name: 'TutorsList',

    data: () => ({
      tutors: [],

    }),

    mounted() {
      this.getTutors();
    },

    methods: {
      async getTutors() {
        const { data } = await axios.get('/api/tutors');
        this.tutors = data;

      },

    },
  };
</script>