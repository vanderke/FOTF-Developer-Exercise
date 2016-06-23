function getUserModel() {
  // Existing object
var obj = $.getJSON("/users/new.json" , function(user) {
  console.log(user);
})
  // Create a Deferred
  defer = $.Deferred();

// Set object as a promise
defer.promise( obj );
console.log(obj);

// Resolve the deferred
// defer.resolve( "3" );

console.log("I'm in this thing");
// Use the object as a Promise
}

$(document).ready(function() {
  ko.applyBindings(new getUserModel());
});
