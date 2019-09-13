<template>
    <div class="container">
        <div class="card">
            <div class="card-header" style="height:50px">
                {{ tutor.subject }} Name: {{tutor.firstName}} {{tutor.lastName}} Location: {{tutor.location}} Time: {{tutor.time}}
            </div>
        </div>

        <div class="row">
            <div v-for="request in tutoringRequests" class="col-md-4" :key="request.id">
                <request-card :request="request"></request-card>
            </div>
        </div>
    </div>
</template>
<script>
    import axios from 'axios';

    export default {
        name: 'TutorRequests',
        data: () => ({
            tutoringRequests: []
        }),
        props: {
          tutor: {
            type: Object,
            default: () => { }
          },
        },

        mounted() {
            this.getTutorRequests();
        },

        methods: {
            async getTutorRequests() {
                const { data } = await axios.get('/api/tutoringrequest/'+this.tutor.id);
                this.tutoringRequests = data;
            },

        },
    };
</script>


<style scoped>
    .card-header {
        background-color:lightgray
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