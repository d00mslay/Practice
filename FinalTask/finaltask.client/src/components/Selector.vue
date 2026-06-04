<template>
  <div>
    <ul>
      <li v-for="project in projects"
          :key="project"
          @click="selectProject(project)"
          :class="{ active: curProject === project }"> {{project}}</li>
    </ul>
  </div>
  <div v-if="curProject != ''">
    <ul>
      <li v-for="task in getTasks(curProject)"
          :key="task"
          @click="selectTask(task)"
          :class="{active: curTask === task}">{{task}}</li>
    </ul>
  </div>
  
</template>


<script>
  export default {
    data() {
      return {
        projects: ["pr1", "pr2", "pr3", "pr4"],
        curProject : "",

        curTask : ""
      }
    },
    methods: {
      selectProject(project) {
        this.curProject = project;
      },
      getTasks(project) {
        if (project === "pr1") return ["Длинное-длинное название задачи", "Длинное-длинное название задачи", "Длинное-длинное название задачи", "Длинное-длинное название задачи"];
        if (project === "pr2") return ["ts5", "ts6", "ts7"];
        if (project === "pr3") return ["ts8", "ts9"];
        if (project === "pr4") return ["ts10", "ts12", "ts13", "ts14"];
      },
      selectTask(task){
        this.curTask = task;
      }
    }

  }
</script>


<style scoped>
  ul{
    list-style: none;
    width: 200px;
    padding: 0;
    border-radius: 3px;
    border: 3px solid #000;
  }
  li {
    display: block;
    background: #1A032D;
    color: #fff;
    padding: 20px 0;
  }
  li:hover, li.active{
    background: #24043e;
    cursor: pointer
  }
</style>
