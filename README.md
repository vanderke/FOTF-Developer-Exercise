# Dave's FOTF-Developer-Exercise

##Instructions to run##
I chose ruby on rails as my implementation, so it should be really easy to run this app. The rails version I used is 4.2.4, but everything should be handled by the gemfile. All you should have to do to run this is cd into the root directory of the app and run:

- bundle install
- rake db:migrate
- rake db:seed
- rails server

##Information you should know##
I spent the first day of this researching some options for implementation. Namely I looked at Java and Apache, Javascript and Node, and Ruby on Rails. I have knowledge/experience about/in almost every area of software development, but not in the same technologies. For example, I've done unit testing with JUnit before, but I've not set up any servers with Java. I have set up servers with Rails, but I hadn't done any testing. So no matter what technologies I looked at, there were unkowns that I would have to learn on the fly. I chose Ruby on Rails because it is convention over configuration. I trusted that if I simply figured out the conventions, then the development would be easier. I was right. But that means I had to learn a LOT about the conventions, and that meant lots of tutorials and research. As a result, I spent so much time learning that I didn't have enough time to implement everything that I wanted to implement. The biggest example is site administration.

My original thought for site administration was to have a separate app for employees of FOTF. This separate app would make requests as an admin user to the Ready to Wed site, and that would prevent anyone from just making themselves admins. I wasn't sure if that was an accurate/feasible idea or not, so I decided to simply go with making a User model and having an admin field in the database. There would not be any admin field in the signup form, so no one would be able to just click "yes, I'm an admin", and I would simply root the database with an admin user for FOTF to use. I didn't really like this idea because it means that anyone who has access to the site (everyone) could become an admin by simply guessing the email and password of the admin account. Nonetheless, it seemed like all I had time for. As it turns out, I didn't even have time to get to admin functionality because I was learning so much about the rails way of doing things. Users can make accounts and sign in/out, but there is no point. It simply demonstrates that I can do it.

There are other aspects of the site that I have similar sob stories about, but I'll save my breath for a later conversation.

##Dislaimer##
Since I spent most of my time learning, a lot of the code in this project is taken from tutorials and adapted for my purposes. That being said, I DID write it, and I know how it works. (I wouldn't have been able to adapt it if I didn't know how it works)