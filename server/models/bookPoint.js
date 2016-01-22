var mongoose = require('mongoose');
var Schema = mongoose.Schema;

var Lesson = new Schema ({
  lesson: String,
  title: String,
  summary: String
});

module.exports = mongoose.model('Lessons', Lesson);



