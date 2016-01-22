![Ready To Wed](client/img/Ready-to-Wed-Screen-Shot.png "Website Screenshot")

##Welcome

This is the repo for my Focus on the Family developer exercise.

Please follow the startup instructions after you clone the repo in order to run the site locally.


##Startup Instructions

This exercise can run with the server of your choice or with Gulp.

- Run $ NPM install
    —This installs all dependencies in Package.json

- Run $ NPM install -g node-mongo-seeds
    —This installs node Mongo Seeds. This allows us to seed the database with product info. This info is located in the seeds folder under lessons.json.

- Run $ seed
    —The seed command processes lessons.json and places it into the database.

***Tip**  Ensure <$ mongod> is running so that you can use mongo.

***Tip** Tests are run with Mocha and Chai. The tests will clear the database. Run the seed command after running the tests in order to repopulate the DB.

***Tip** This app was built with Chrome and has not been tested with other browsers at the time of this writing. Please use Chrome for best results.

##This is a custom MEAN stack SPA build.
- It utilizes Mongoose in addition to Mongo so that the database can have a Schema.
- It uses Node Mongo Seeds to initialize database with info. This allows for a presentable site from launch.
- It uses Testing with Chai and Mocha.
Gulp is the selected taskruunner.
Bootstrap

##Future Plans
- Allow Log in with authentication.
- Ability to create, edit, and delete new posts. Post can only be created at this time.
- Animations including a slider and smoother page transitions.
- Link newsletter submit to mail server.
- Angular code into services and directives

If the need to edit the book's points/lessons from a database wasn't a requirement I would have served the content from a template with Swig or Handlebars.

##In Progress Tasks
- Still working on mocha and chai testing
- Still working on implementation of edit and delete
- Gulp edits to minify code.

You can add a lesson at #/editLessons

EditLessons is the main edit page. You will be able to select a lesson by clicking on it and it will take you to the edit lesson page.
EditLessonName is not finished yet. It is the page that will allow you to edit a lesson by id.



# FOTF-Developer-Exercise
##Introduction##
The purpose of this exercise is to give you a chance to showcase your talents and abilities. Please have fun with this, and wow us with your best.
##Business Problem to Solve##
The ministry needs a new website for a book that the ministry wants to create curriculum for. The name of this book is "Ready to Wed", and it's written by Greg and Erin Smalley. You can find out a little bit about this book by looking at http://www.amazon.com/Ready-Wed-Start-Marriage-Youll/dp/1624054064/ref=tmm_pap_swatch_0?_encoding=UTF8&qid=&sr=.
##Requirements##
The work needs to provide the following:

- The site needs to present the information in a mobile and desktop friendly way.
- The site needs to display the 12 main points of the book (Provided in the appendix).
- The data needs to come through some sort of data layer. In other words, we don't want the text hard coded in the web pages. Show us that you understand how to use a DAL. You can use either a database (i.e. MongoDB, SQL Server, MySQL) or a JSON feed for the source of your data.
- The front end part of the site should include the use of some sort of JavaScript framework (i.e. JQuery, Backbone, Angular, Bootstrap)
- The back end part of the site should showcase your knowledge of appropriate design patterns.
- Your work should showcase how well you understand Object Oriented Design principles.
- Your work should showcase your understanding of TDD and unit testing.
- The project should include instructions for running the website on a local environment.

###Bonus###
It would be really great if you can make the site incorporate some sort of administration interface that allows an administrative user to edit the 12 main points of the book.

##Delivery##
When you are finished, submit a pull request. If there is any configuration that needs to be done, please note that in your pull request.

##Appendix##
Here is JSON string that contains the 12 main points of the book:



    {
    "1":{
        "title":"Life Long Commitment",
          "summary":"Lifelong commitment begins with a decision that divorce is not an option and a determination to invest in your marriage every day."
    },

    "2":{
        "title":"Spending Enjoyable Time Together",
        "summary":"In the busyness of life, remember that love isn’t self-sufficient. Your marriage must be constantly fed and nurtured by spending regular time together."
    },

    "3":{
        "title":"Positive Communication",
        "summary":"Communication gives life to marriage when you spend time getting to know your spouse and allowing yourself to be deeply known by him or her."
    },

    "4":{
        "title":"Shared Spiritual Intimacy",
        "summary":"Couples who have a deep, shared faith and have Christ at the center of their marriage have a more satisfying relationship and deeper intimacy."
    },

    "5":{
        "title":"Healthy Individuals",
        "summary":"A healthy marriage is made of two healthy people. Commit to a lifetime of spiritual, emotional, physical and mental growth and development."
    },

    "6":{
        "title":"Mutually Satisfying Physical Intimacy",
        "summary":"Sex is God’s gift to a married couple as a way to experience the deepest, most profound intimacy possible—the two becoming one flesh."
    },

    "7":{
        "title":"Healthy Conflict Management",
        "summary":"Conflict is an inevitable part of marriage, but handled well, healthy conflict can become an opportunity for deeper intimacy and connection."
    },

    "8":{
        "title":"Shared Responsibility (Teamwork)",
        "summary":"Marriage means you are always on the same team. Make decisions and divide household responsibilities in a way that honors both of you."
    },

    "9":{
        "title":"Coping With Change, Stress and Crises",
        "summary":"You will face challenges on your journey together. Always fight for your marriage and trust that God will turn your pain to blessing."
    },

    "10":{
        "title":"Cherish",
        "summary":"Created by God, your fiancé(e) is of infinite worth and value. Reflect often on the things that you love and cherish about your future spouse."
    },

    "11":{
        "title":"Nourish",
        "summary":"Love involves action and behavior. You need to nourish your relationship with your fiancé(e) in ways that speak love to him or her."
    },

    "12":{
        "title":"Community-Mindedness",
        "summary":"Connecting regularly with like-minded couples who are committed to the good of your relationship is vital to the success of your marriage."
    }
    }

