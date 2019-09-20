<template>
  <div v-if="loading"><img src="/images/loader.gif" alt=""></div>
  <div v-else class="container">
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
      loading: false,

    }),

    mounted() {
      this.getTutors();
    },

    methods: {
      async getTutors() {
        this.loading = true;
        const { data } = await axios.get('/api/tutors');
        this.tutors = data;
        this.loading = false;

      },

    },
  };
</script>