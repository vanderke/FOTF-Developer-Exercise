// the JSON string
var data;
// array of MainPoint objects
var mainPoints = [];
// html string that will be appended to the DOM 
var points;

// data structure to store a single main point
// and provide ability to include it in HTML
function MainPoint (title, summary) {
    this.title = title;
    this.summary = summary;

    // add a main point to the DOM
    this.display = function () {
        // surround the point with a div
        points += "<div class=\"container\">";

        // add the title and the summary
        points += "<h4>" + this.title + "</h4>";
        points += "<div>" + this.summary + "</div>"; 

        // close the surrounding div
        points += "</div>";
    }
}

// get JSON and parse it when page is loaded
$(document).ready(function() {
	populateData();

	var json_obj = $.parseJSON(data);
    getMainPoints(json_obj);
    displayMainPoints();

    $('#sign-in').popup({
      transition: 'all 0.3s',
    });

   $('#login').click(function () {
      $('#sign-in').popup('toggle');
   });
});

// get each individual main point and create an 
// object for it; put the object in the array
function getMainPoints(json_obj) {
    $.each(json_obj, function(i, obj) {
        var title = obj.title;
        var summary = obj.summary;

        var point = new MainPoint(title, summary);
        mainPoints.push(point);
    });
}

// loop through the main points and display all of them
function displayMainPoints() {
    points = "<div class=\"container\"><h3>Main Points</h3>";
    for (var point in mainPoints) {
        mainPoints[point].display();
    }

    points += "</div><br />";

    // append the div to the body
    // use string concatenation so that only one append
    // is used because it is an expensive operation
    $(".contents").append( $(points) );
}

// I opted for this because I didn't have a server to get the 
// file from and I wanted to work with JSON, which I would use when
// making an ajax call
// ** I've used jqeury before to pull data from a server in JSON format
function populateData() {
	data = "{" 
+ "\"1\":{"
+ "  \"title\":\"Life Long Commitment\","
+ "      \"summary\":\"Lifelong commitment begins with a decision that divorce is not an option and a determination to invest in your marriage every day.\" },"
+ " \"2\":{\"title\":\"Spending Enjoyable Time Together\", "
+ "     \"summary\":\"In the busyness of life, remember that love isn’t self-sufficient. Your marriage must be constantly fed and nurtured by spending regular time together.\"}, " 
 
+ " \"3\":{ "
+ "     \"title\":\"Positive Communication\", "
+ "     \"summary\":\"Communication gives life to marriage when you spend time getting to know your spouse and allowing yourself to be deeply known by him or her.\"}, "
 
+ " \"4\":{ "
+ "     \"title\":\"Shared Spiritual Intimacy\", "
+ "     \"summary\":\"Couples who have a deep, shared faith and have Christ at the center of their marriage have a more satisfying relationship and deeper intimacy.\" }, " 
 
+ " \"5\":{ "
+ "     \"title\":\"Healthy Individuals\", "
+ "    \"summary\":\"A healthy marriage is made of two healthy people. Commit to a lifetime of spiritual, emotional, physical and mental growth and development.\"}," 

+ " \"6\":{ "
+ "     \"title\":\"Mutually Satisfying Physical Intimacy\", "
+ "     \"summary\":\"Sex is God’s gift to a married couple as a way to experience the deepest, most profound intimacy possible—the two becoming one flesh.\"}," 
 
+ " \"7\":{ "
+ "     \"title\":\"Healthy Conflict Management\", "
+ "     \"summary\":\"Conflict is an inevitable part of marriage, but handled well, healthy conflict can become an opportunity for deeper intimacy and connection.\"}, " 

+ " \"8\":{ "
+ "     \"title\":\"Shared Responsibility (Teamwork)\", "
+ "     \"summary\":\"Marriage means you are always on the same team. Make decisions and divide household responsibilities in a way that honors both of you.\"}, " 
 
+ " \"9\":{ "
+ "     \"title\":\"Coping With Change, Stress and Crises\", "
+ "     \"summary\":\"You will face challenges on your journey together. Always fight for your marriage and trust that God will turn your pain to blessing.\"}, " 

+ " \"10\":{ "
+ "     \"title\":\"Cherish\", "
+ "     \"summary\":\"Created by God, your fiancé(e) is of infinite worth and value. Reflect often on the things that you love and cherish about your future spouse.\"}, " 

+ " \"11\":{ "
+ "     \"title\":\"Nourish\", "
+ "     \"summary\":\"Love involves action and behavior. You need to nourish your relationship with your fiancé(e) in ways that speak love to him or her.\"}, " 

+ " \"12\":{ "
+ "     \"title\":\"Community-Mindedness\", "
+ "    \"summary\":\"Connecting regularly with like-minded couples who are committed to the good of your relationship is vital to the success of your marriage.\"} "
+ "}";
}