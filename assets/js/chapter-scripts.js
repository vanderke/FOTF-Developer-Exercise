//Chapter 1

function ch1_heading(){
  var results = document.getElementById("chapter1_heading");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter1_heading.innerHTML = "";
        chapter1_heading.innerHTML += "<h3 class='chapter-heading'>"+data.ch1.chapter+"</h3>";
      }
    }
    hr.send(null);

}

function ch1_title(){
  var results = document.getElementById("chapter1_title");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter1_title.innerHTML = "";
        chapter1_title.innerHTML += "<h3 class='chapter-title'>"+data.ch1.title+"</h3>";
      }
    }
    hr.send(null);

}

function ch1_summary(){
  var results = document.getElementById("chapter1_summary");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter1_summary.innerHTML = "";
        chapter1_summary.innerHTML += "<p>"+data.ch1.summary+"</p>";
      }
    }
    hr.send(null);

}


//Chapter 2

function ch2_heading(){
  var results = document.getElementById("chapter2_heading");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter2_heading.innerHTML = "";
        chapter2_heading.innerHTML += "<h3 class='chapter-heading'>"+data.ch2.chapter+"</h3>";
      }
    }
    hr.send(null);

}

function ch2_title(){
  var results = document.getElementById("chapter2_title");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter2_title.innerHTML = "";
        chapter2_title.innerHTML += "<h3 class='chapter-title'>"+data.ch2.title+"</h3>";
      }
    }
    hr.send(null);

}

function ch2_summary(){
  var results = document.getElementById("chapter2_summary");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter2_summary.innerHTML = "";
        chapter2_summary.innerHTML += "<p>"+data.ch2.summary+"</p>";
      }
    }
    hr.send(null);

}

//Chapter 3

function ch3_heading(){
  var results = document.getElementById("chapter3_heading");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter3_heading.innerHTML = "";
        chapter3_heading.innerHTML += "<h3 class='chapter-heading'>"+data.ch3.chapter+"</h3>";
      }
    }
    hr.send(null);

}

function ch3_title(){
  var results = document.getElementById("chapter3_title");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter3_title.innerHTML = "";
        chapter3_title.innerHTML += "<h3 class='chapter-title'>"+data.ch3.title+"</h3>";
      }
    }
    hr.send(null);

}

function ch3_summary(){
  var results = document.getElementById("chapter3_summary");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter3_summary.innerHTML = "";
        chapter3_summary.innerHTML += "<p>"+data.ch3.summary+"</p>";
      }
    }
    hr.send(null);

}



//Chapter 4

function ch4_heading(){
  var results = document.getElementById("chapter4_heading");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter4_heading.innerHTML = "";
        chapter4_heading.innerHTML += "<h3 class='chapter-heading'>"+data.ch4.chapter+"</h3>";
      }
    }
    hr.send(null);

}

function ch4_title(){
  var results = document.getElementById("chapter4_title");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter4_title.innerHTML = "";
        chapter4_title.innerHTML += "<h3 class='chapter-title'>"+data.ch4.title+"</h3>";
      }
    }
    hr.send(null);

}

function ch4_summary(){
  var results = document.getElementById("chapter4_summary");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter4_summary.innerHTML = "";
        chapter4_summary.innerHTML += "<p>"+data.ch4.summary+"</p>";
      }
    }
    hr.send(null);

}


//Chapter 5

function ch5_heading(){
  var results = document.getElementById("chapter5_heading");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter5_heading.innerHTML = "";
        chapter5_heading.innerHTML += "<h3 class='chapter-heading'>"+data.ch5.chapter+"</h3>";
      }
    }
    hr.send(null);

}

function ch5_title(){
  var results = document.getElementById("chapter5_title");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter5_title.innerHTML = "";
        chapter5_title.innerHTML += "<h3 class='chapter-title'>"+data.ch5.title+"</h3>";
      }
    }
    hr.send(null);

}

function ch5_summary(){
  var results = document.getElementById("chapter5_summary");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter5_summary.innerHTML = "";
        chapter5_summary.innerHTML += "<p>"+data.ch5.summary+"</p>";
      }
    }
    hr.send(null);

}

//Chapter 6

function ch6_heading(){
  var results = document.getElementById("chapter6_heading");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter6_heading.innerHTML = "";
        chapter6_heading.innerHTML += "<h3 class='chapter-heading'>"+data.ch6.chapter+"</h3>";
      }
    }
    hr.send(null);

}

function ch6_title(){
  var results = document.getElementById("chapter6_title");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter6_title.innerHTML = "";
        chapter6_title.innerHTML += "<h3 class='chapter-title'>"+data.ch6.title+"</h3>";
      }
    }
    hr.send(null);

}

function ch6_summary(){
  var results = document.getElementById("chapter6_summary");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter6_summary.innerHTML = "";
        chapter6_summary.innerHTML += "<p>"+data.ch6.summary+"</p>";
      }
    }
    hr.send(null);

}


//Chapter 7

function ch7_heading(){
  var results = document.getElementById("chapter7_heading");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter7_heading.innerHTML = "";
        chapter7_heading.innerHTML += "<h3 class='chapter-heading'>"+data.ch7.chapter+"</h3>";
      }
    }
    hr.send(null);

}

function ch7_title(){
  var results = document.getElementById("chapter7_title");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter7_title.innerHTML = "";
        chapter7_title.innerHTML += "<h3 class='chapter-title'>"+data.ch7.title+"</h3>";
      }
    }
    hr.send(null);

}

function ch7_summary(){
  var results = document.getElementById("chapter7_summary");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter7_summary.innerHTML = "";
        chapter7_summary.innerHTML += "<p>"+data.ch7.summary+"</p>";
      }
    }
    hr.send(null);

}


//Chapter 8

function ch8_heading(){
  var results = document.getElementById("chapter8_heading");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter8_heading.innerHTML = "";
        chapter8_heading.innerHTML += "<h3 class='chapter-heading'>"+data.ch8.chapter+"</h3>";
      }
    }
    hr.send(null);

}

function ch8_title(){
  var results = document.getElementById("chapter8_title");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter8_title.innerHTML = "";
        chapter8_title.innerHTML += "<h3 class='chapter-title'>"+data.ch8.title+"</h3>";
      }
    }
    hr.send(null);

}

function ch8_summary(){
  var results = document.getElementById("chapter8_summary");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter8_summary.innerHTML = "";
        chapter8_summary.innerHTML += "<p>"+data.ch8.summary+"</p>";
      }
    }
    hr.send(null);

}

//Chapter 9

function ch9_heading(){
  var results = document.getElementById("chapter9_heading");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter9_heading.innerHTML = "";
        chapter9_heading.innerHTML += "<h3 class='chapter-heading'>"+data.ch9.chapter+"</h3>";
      }
    }
    hr.send(null);

}

function ch9_title(){
  var results = document.getElementById("chapter9_title");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter9_title.innerHTML = "";
        chapter9_title.innerHTML += "<h3 class='chapter-title'>"+data.ch9.title+"</h3>";
      }
    }
    hr.send(null);

}

function ch9_summary(){
  var results = document.getElementById("chapter9_summary");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter9_summary.innerHTML = "";
        chapter9_summary.innerHTML += "<p>"+data.ch9.summary+"</p>";
      }
    }
    hr.send(null);

}



//Chapter 10

function ch10_heading(){
  var results = document.getElementById("chapter10_heading");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter10_heading.innerHTML = "";
        chapter10_heading.innerHTML += "<h3 class='chapter-heading'>"+data.ch10.chapter+"</h3>";
      }
    }
    hr.send(null);

}

function ch10_title(){
  var results = document.getElementById("chapter10_title");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter10_title.innerHTML = "";
        chapter10_title.innerHTML += "<h3 class='chapter-title'>"+data.ch10.title+"</h3>";
      }
    }
    hr.send(null);

}

function ch10_summary(){
  var results = document.getElementById("chapter10_summary");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter10_summary.innerHTML = "";
        chapter10_summary.innerHTML += "<p>"+data.ch10.summary+"</p>";
      }
    }
    hr.send(null);

}


//Chapter 11

function ch11_heading(){
  var results = document.getElementById("chapter11_heading");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter11_heading.innerHTML = "";
        chapter11_heading.innerHTML += "<h3 class='chapter-heading'>"+data.ch11.chapter+"</h3>";
      }
    }
    hr.send(null);

}

function ch11_title(){
  var results = document.getElementById("chapter11_title");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter11_title.innerHTML = "";
        chapter11_title.innerHTML += "<h3 class='chapter-title'>"+data.ch11.title+"</h3>";
      }
    }
    hr.send(null);

}

function ch11_summary(){
  var results = document.getElementById("chapter11_summary");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter11_summary.innerHTML = "";
        chapter11_summary.innerHTML += "<p>"+data.ch11.summary+"</p>";
      }
    }
    hr.send(null);

}

//Chapter 12

function ch12_heading(){
  var results = document.getElementById("chapter12_heading");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter12_heading.innerHTML = "";
        chapter12_heading.innerHTML += "<h3 class='chapter-heading'>"+data.ch12.chapter+"</h3>";
      }
    }
    hr.send(null);

}

function ch12_title(){
  var results = document.getElementById("chapter12_title");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter12_title.innerHTML = "";
        chapter12_title.innerHTML += "<h3 class='chapter-title'>"+data.ch12.title+"</h3>";
      }
    }
    hr.send(null);

}

function ch12_summary(){
  var results = document.getElementById("chapter12_summary");
    var hr = new XMLHttpRequest();
    hr.open("GET", "ready_to_wed_chapters.json", true);
    hr.setRequestHeader("Content-type", "application/json");
    hr.onreadystatechange = function() {
      if(hr.readyState == 4 && hr.status == 200) {
        var data = JSON.parse(hr.responseText);
        chapter12_summary.innerHTML = "";
        chapter12_summary.innerHTML += "<p>"+data..summary+"</p>";
      }
    }
    hr.send(null);

}
