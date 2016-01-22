process.env.NODE_ENV = 'test';

var chai = require('chai');
var chaiHttp = require('chai-http');
var mongoose = require("mongoose");

var server = require('../server/app');
var BookPoint = require('../server/models/bookPoint');

var should = chai.should();
chai.use(chaiHttp);


describe('Book Points', function() {

  // lessons.collection.drop();

  beforeEach(function(done){
    var newBookPoint = new BookPoint({
      lesson: 'Test Lesson',
      title: 'Test Title',
      summary: 'Test Summary'
    });
    newBookPoint.save(function(err) {
      done();
    });
  });
  afterEach(function(done){
    BookPoint.collection.drop();
    done();
  });

  it('should list ALL bookPoints on / GET', function(done) {
    chai.request(server)
      .get('/')
      .end(function(err, res){
        res.should.have.status(200);
        res.should.be.json;
        res.body.should.be.a('array');
        res.body[0].should.have.property('_id');
        res.body[0].should.have.property('lesson');
        res.body[0].should.have.property('title');
        res.body[0].should.have.property('summary');
        res.body[0].lesson.should.equal('Test Lesson');
        res.body[0].title.should.equal('Test Title');
        res.body[0].summary.should.equal('Test Summnary');
        done();
      });
  });

  xit('should list a SINGLE bookPoint on /bookPoint/<id> GET', function(done) {
      var newBookPoint = new BookPoint({
       lesson: 'Test Lesson',
       title: 'Test Title',
       summary: 'Test Summary'
      });
      newBookPoint.save(function(err, data) {
        chai.request(server)
          .get('/bookPoint/'+data.id)
          .end(function(err, res){
            res.should.have.status(200);
            res.should.be.json;
            res.body.should.be.a('object');
            res.body.should.have.property('_id');
            res.body[0].should.have.property('lesson');
            res.body[0].should.have.property('title');
            res.body[0].should.have.property('summary');
            res.body[0].lesson.should.equal('Test Lesson');
            res.body[0].title.should.equal('Test Title');
            res.body[0].summary.should.equal('Test Summnary');
            res.body._id.should.equal(data.id);
            done();
          });
      });
  });

  xit('should add a SINGLE bookPoint on /bookPoint POST', function(done) {
    chai.request(server)
      .post('/bookPoint')
      .send({'lesson': 'Test Lesson', 'title': 'Test Title', 'summary':'Test Summary'})
      .end(function(err, res){
        res.should.have.status(200);
        res.should.be.json;
        res.body.should.be.a('object');
        res.body.should.have.property('SUCCESS');
        res.body.SUCCESS.should.be.a('object');
        res.body.SUCCESS.should.have.property('lesson');
        res.body.SUCCESS.should.have.property('title');
        res.body.SUCCESS.should.have.property('summary');
        res.body.SUCCESS.should.have.property('_id');
        res.body.SUCCESS.lesson.should.equal('Test Lesson');
        res.body.SUCCESS.title.should.equal('Test Title');
        res.body.SUCCESS.summary.should.equal('Test Summary');
        done();
      });
  });

  xit('should update a SINGLE bookPoint on /bookPoint/<id> PUT', function(done) {
    chai.request(server)
      .get('/bookPoints')
      .end(function(err, res){
        chai.request(server)
          .put('/bookPoint/'+res.body[0]._id)
          .send({'lesson': 'Test Lesson'})
          .end(function(error, response){
            response.should.have.status(200);
            response.should.be.json;
            response.body.should.be.a('object');
            response.body.should.have.property('UPDATED');
            response.body.UPDATED.should.be.a('object');
            response.body.UPDATED.should.have.property('lesson');
            response.body.UPDATED.should.have.property('_id');
            response.body.UPDATED.name.should.equal('Test Lesson');
            done();
        });
      });
  });

  xit('should delete a SINGLE bookPoint on /bookPoint/<id> DELETE', function(done) {
    chai.request(server)
      .get('/bookPoints')
      .end(function(err, res){
        chai.request(server)
          .delete('/bookPoint/'+res.body[0]._id)
          .end(function(error, response){
            response.should.have.status(200);
            response.should.be.json;
            response.body.should.be.a('object');
            response.body.should.have.property('REMOVED');
            response.body.REMOVED.should.be.a('object');
            response.body.REMOVED.should.have.property('lesson');
            response.body.REMOVED.should.have.property('_id');
            response.body.REMOVED.lesson.should.equal('Test Lesson');
            done();
        });
      });
  });

});
