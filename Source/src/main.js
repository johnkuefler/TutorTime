import Vue from 'vue'
Vue.config.productionTip = false
Vue.component('tutors-list', require('./components/TutorsList.vue').default);
Vue.component('tutor-card', require('./components/TutorCard.vue').default);
Vue.component('tutor-requests', require('./components/TutorRequests.vue').default);
Vue.component('request-card', require('./components/RequestCard.vue').default);



window.Vue = Vue;