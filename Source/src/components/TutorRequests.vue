<style scoped>
    .tutor-request-card {
        background-color: #F5F4F4;

    }
</style>

<template>
    <div v-if="loading"><img src="/images/loader.gif" alt=""></div>
    <div v-else class="card">
        <div class="border">
            <div class="tutor-request-card" style="height:50px">
                <div class="pl-2 ">
                    <span class="h1 pl-2">{{ tutor.subject }}</span> <span class="pl-5"><b>Name:</b> {{tutor.firstName}} {{tutor.lastName}}</span> <span class="pl-5"><b>Location:</b> {{tutor.location}}</span> <span class="pl-5"><b>Time:</b>{{tutor.time}}</span>
                </div>
            </div>
        </div>
        <div class="row mx-0">
            <div v-for="request in tutoringRequests" class="col-md-4 p-4 " :key="request.id">
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
            tutoringRequests: [],
            loading: false,
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
                this.loading = true;
                const { data } = await axios.get('/api/tutoringrequest/' + this.tutor.id);
                this.tutoringRequests = data;
                this.loading = false;
            },

        },
    };
</script>