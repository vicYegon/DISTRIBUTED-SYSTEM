const btn_menu = document.querySelector(".btn-menu");
const side_bar = document.querySelector(".sidebar");
const theme_ball = document.querySelector(".theme-ball");
const theme_btn = document.querySelector(".theme-btn");

const monthName = document.getElementById("month_name");
const dayName = document.getElementById("day_name");
const dayNumber = document.getElementById("date_number");
const yearEl = document.getElementById("year");
const dayTime = document.getElementById("day_time");



// to avoid the theme returning to default mode when refreshing the page use
const localData = localStorage.getItem("theme");

if(localData == null){
    localStorage.setItem("theme", "light");
}

if(localData == "dark"){
    document.body.classList.add("dark-mode");
    theme_ball.classList.add("dark");
}else if(localData == "light"){
    document.body.classList.remove("dark-mode");
    theme_ball.classList.remove("dark");
}

theme_btn.addEventListener("click", () => {
    document.body.classList.toggle("dark-mode");
    theme_ball.classList.toggle("dark");
    if(document.body.classList.contains("dark-mode")){
        localStorage.setItem("theme", "dark");
    }else{
        localStorage.setItem("theme", "light");
    }
});

// to make sidebar responsive do this
btn_menu.addEventListener("click", function () {
  side_bar.classList.toggle("expand");
  changebtn();
});

function changebtn() {
  if (side_bar.classList.contains("expand")) {
    btn_menu.classList.replace("bx-menu", "bx-menu-alt-right");
  } else {
    btn_menu.classList.replace("bx-menu-alt-right", "bx-menu");
  }
}

// calender function
function updateTime(){
  const date = new Date();
  const month = date.getMonth();
  let hours = date.getHours();
  let minutes = date.getMinutes();
  let seconds = date.getSeconds();

  if(hours <10){
      hours = "0" + hours;
  }

  if(minutes <10){
      minutes = "0" + minutes;
  }

  if(seconds<10){
      seconds = "0" + seconds;
  }
  let timeString = hours + ":" + minutes + ":" + seconds;

  monthName.innerText = date.toLocaleString("en", {month:"long"});

  dayName.innerText = date.toLocaleString("en", {weekday:"long"});

  dayNumber.innerText = date.getDate();

  dayTime.innerText = timeString;

  yearEl.innerText = date.getFullYear();
}

setInterval(updateTime, 1000);

