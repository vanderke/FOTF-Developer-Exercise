var FirebaseTokenGenerator = require('firebase-token-generator');
var tokenGenerator = new FirebaseTokenGenerator('focusonthefamily');
var token = tokenGenerator.createToken({uid: 'admin', some: 'arbitrary', data: 'here'});
var Firebase = require('firebase');

function authHandler(error, authData) {
  if (error) {
    console.log('Login Failed!', error);
  } else {
    console.log('Authenticated successfully with payload:', authData);
  }
}

var ref = new Firebase('https://sweltering-fire-3131.firebaseio.com/points');
ref.authWithCustomToken(token, authHandler);
// ref.authWithCustomToken(token, function(error, authData) {
//   if (error) {
//     console.log('Login Failed!', error);
//   } else {
//     console.log('Login Succeeded!', authData);
//   }
// });

function authDataCallback(authData) {
  if (authData) {
    console.log('User ' + authData.uid + ' is logged in with ' + authData.provider);
  } else {
    console.log('User is logged out');
  }
}
ref.onAuth(authDataCallback);

// Create a callback to handle the result of the authentication
// function authHandler(error, authData) {
//   if (error) {
//     console.log('Login Failed!', error);
//   } else {
//     console.log('Authenticated successfully with payload:', authData);
//   }
// }

// Authenticate users with a custom authentication token

// Alternatively, authenticate users anonymously
ref.authAnonymously(authHandler);

// Or with an email/password combination
// ref.authWithPassword({
//   email: 'admin',
//   password: 'focusonthefamily'
// }, authHandler);

// Or via popular OAuth providers ("facebook", "github", "google", or "twitter")
ref.authWithOAuthPopup('<provider>', authHandler);
ref.authWithOAuthRedirect('<provider>', authHandler);
