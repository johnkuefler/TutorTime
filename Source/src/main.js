import Vue from 'vue'
Vue.config.productionTip = false
Vue.component('tutors-list', require('./components/TutorsList.vue').default);
Vue.component('tutor-card', require('./components/TutorCard.vue').default);



window.Vue = Vue;