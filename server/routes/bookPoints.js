var express = require('express');
var router = express.Router();
var mongoose = require('mongoose-q')(require('mongoose'));
var BookPoint = require('../models/bookPoint');

router.get('/', function(req, res, next){
  BookPoint.find(function(err, response){
    if(err){
      res.json({message:err});
    } else {
      res.json(response);
    }
  });
});


//save a new book Point
router.post('/', function(req, res, next) {
    var newBookPoint = new BookPoint({
        lesson: req.body.lesson,
        title: req.body.title,
        summary: req.body.summary
    });
    console.log(newBookPoint, " point");
    newBookPoint.saveQ()
    .then(function(result) {
        res.json(result);
    })
    .catch(function(err) {
        res.send(err);
    })
    .done();
});

//update a Book Point
router.put('/:id', function(req, res, next) {
    var updateBookPoint = {
        lesson: req.body.lesson,
        title: req.body.title,
        summary: req.body.summary
    };
   var id = req.params.id;
   BookPoint.findByIdAndUpdate(id, updateBookPoint)
    .then(function(result) {
        res.json(result);
    })
    .catch(function(err) {
        res.send(err);
    })
    .done();
});

//delete a book Point
router.delete('/:id', function(req, res, next) {
    Lesson.findByIdAndRemove(req.params.id,
      function(err, data) {
        if(err) {
            res.send(err);
        } else {
            res.json(data);
        }
    });
});

module.exports = router;
