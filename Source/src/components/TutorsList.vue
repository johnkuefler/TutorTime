<template>
  <div class="text-center">
    <div v-for="tutor in tutors">
      <tutor-card :title="tutor.subject" rounded img-url="https://images.unsplash.com/photo-1509869175650-a1d97972541a?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1950&q=80">Tutor: {{tutor.firstName}} {{tutor.lastName}} <br> Location: {{tutor.location}}</tutor-card>
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