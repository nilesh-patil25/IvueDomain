import { createRouter, createWebHistory } from 'vue-router'
import Home from './components/Home.Vue';
import Employee from './components/EmployeeOps.vue'
import Department from './components/DepartMent.vue'

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },

  {
    path: '/employee',
    name: 'Employee',
    component:Employee
  },
  {
    path: '/department',
    name: 'Department',
    component:Department
  }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router