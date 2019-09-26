<style scoped>
    .tutor-request-card {
        background-color: #F5F4F4;

    }

      .button {
        background-color: #64CC96;
        -moz-border-radius: 17px;
        -webkit-border-radius: 17px;
        border-radius: 17px;
        display: inline-block;
        cursor: pointer;
        color: #000000;
        font-family: Arial;
        font-size: 17px;
        font-weight: bold;
        padding: 10px 10px;
        text-decoration: none;
      }

      .button:hover {
        background-color: #C8F2DC;
      }

      .button:active {
        position: relative;
        top: 1px;
      }
</style>

<template>
    <div>
        <div v-if="loading"><img src="/images/loader.gif" alt=""></div>
        <div v-else class="card">
            <div class="border">
                <div class="tutor-request-card py-3">
                    <div class="pl-2 ">
                        <span class="h1 pl-2">{{ tutor.subject }}</span> <span class="pl-5"><b>Name:</b> {{tutor.firstName}} {{tutor.lastName}}</span> <span class="pl-5"><b>Location:</b> {{tutor.location}}</span> <span class="pl-5"><b>Time:</b>{{tutor.time}}</span>
                        <a href="#" class="button mx-5" @click="launchCreateSessionModal()">+ Add Session</a>
                    </div>
                </div>
            </div>
            <div class="row mx-0">
                <div v-for="request in tutoringRequests" class="col-md-4 p-4 " :key="request.id">
                    <request-card :request="request"></request-card>
                </div>
            </div>
        </div>


        <modal name="request-modal" height="auto" :scrollable="true">
            <div class="px-5 py-3">
                <div class="row">
                    <div class="col-12">
                        <h4>Add Request</h4>
                    </div>
                </div>
                <div class="row  mt-3">
                    <div class="col-12">
                        <input class="form-control" placeholder="Your Name" v-model="requestForm.name">
                    </div>
                </div>
                <div class="row  mt-3">
                    <div class="col-12">
                        <input class="form-control" placeholder="Problem" v-model="requestForm.problem">
                    </div>
                </div>
                <div class="row  mt-3">
                    <div class="col-12">
                        <input type="datetime-local" class="form-control" placeholder="Date/Time" v-model="requestForm.dateTime">
                    </div>
                </div>
                <div class="row mt-3">
                    <div class="col-2 offset-8">
                        <button type="button" class="btn" @click="$modal.hide('request-modal')">Cancel</button>
                    </div>
                    <div class="col-2">
                        <button type="button" class="button"
                                @click="submitRequest">
                            Submit
                        </button>
                    </div>
                </div>
            </div>
        </modal>
    </div>
</template>

<script>
    import axios from 'axios';

    export default {
        name: 'TutorRequests',
        data: () => ({
            tutoringRequests: [],
            loading: false,
            requestForm: {
                tutorId: '',
                name: '',
                numberOfPeople: 1,
                problem: '',
                dateTime: new Date()
            }
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
            launchCreateSessionModal() {
               this.$modal.show('request-modal');
            },
            async submitRequest() {
                this.requestForm.tutorId = this.tutor.id;

               this.loading = true;
                await axios.post('/api/tutoringrequest/', this.requestForm);
               this.$modal.hide('request-modal');
               await this.getTutorRequests();
            }

        },
    };
</script>