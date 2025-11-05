<template>
  <div style="max-width:600px;margin:60px auto;font-family:sans-serif;">
    <h1>Task Tracker Lite</h1>
    <div style="margin-bottom:20px;">
      <input v-model="newTitle" placeholder="Task title" style="padding:6px;"/>
      <button @click="addTask" style="padding:6px 10px;">Add</button>
    </div>
    <div v-if="tasks.length===0">No tasks yet. Add one above.</div>
    <ul>
      <li v-for="task in tasks" :key="task.id" style="margin-bottom:8px;">
        <span :style="{textDecoration: task.isCompleted ? 'line-through' : 'none'}">{{task.title}}</span>
        <button v-if="!task.isCompleted" @click="completeTask(task.id)" style="margin-left:10px;">Complete</button>
      </li>
    </ul>
  </div>
</template>
<script>
import axios from 'axios'
export default {
  data(){return{tasks:[],newTitle:''}},
  methods:{
    async loadTasks(){const r=await axios.get('/api/tasks');this.tasks=r.data},
    async addTask(){if(!this.newTitle)return;await axios.post('/api/tasks',{title:this.newTitle});this.newTitle='';await this.loadTasks()},
    async completeTask(id){await axios.put(`/api/tasks/${id}/complete`);await this.loadTasks()}
  },
  mounted(){this.loadTasks()}
}
</script>
