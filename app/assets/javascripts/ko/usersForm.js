function getUserModel() {
  $.getJSON("/users/1.json", function(user) {
    console.log(user);
  });

}

$(document).ready(function() {
  ko.applyBindings(new getUserModel());
});
