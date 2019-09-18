<template>
    <div class="container ">
        <div class="card ">
            <div class="tutor-request-card " style="height:50px">
                <div class="pl-2 ">
                    <span class="h1 pl-2">{{ tutor.subject }}</span> <span class="pl-5"><b>Name:</b> {{tutor.firstName}} {{tutor.lastName}}</span> <span class="pl-5"><b>Location:</b> {{tutor.location}}</span> <span class="pl-5"><b>Time:</b>{{tutor.time}}</span>
                </div>
            </div>
        </div>
        <div class="row ">
            <div v-for="request in tutoringRequests" class="col-md-4 " :key="request.id">
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
                const { data } = await axios.get('/api/tutoringrequest/' + this.tutor.id);
                this.tutoringRequests = data;
            },

        },
    };
</script>


<style scoped>
    .tutor-request-card {
        background-color: #F5F4F4;

    }

    .card {
        text-align: left;
        margin: 30px;

    }
</style>