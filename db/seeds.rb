# This file should contain all the record creation needed to seed the database with its default values.
# The data can then be loaded with the rake db:seed (or created alongside the db with db:setup).
#
# Examples:
#
#   cities = City.create([{ name: 'Chicago' }, { name: 'Copenhagen' }])
#   Mayor.create(name: 'Emanuel', city: cities.first)
require 'rake'

Rake::Task.clear #necessary to avoid tasks being loaded several times in dev mode
FOTFDeveloperExercise::Application.load_tasks
import_tasks = [ 'load_book_data']

import_tasks.each do |task_name|
  puts "Running task: #{task_name} "
  Rake::Task[task_name].invoke
end

#Creating admin user
admin = User.new(username: "admin", email: "admin@example.com",  password: "supersecret",
                 password_confirmation: "supersecret", admin: true)
puts "Created admin user" if admin.save

#Create a general user
user = User.new(username: "user", email: "user@example.com", password: "supersecret",
                password_confirmation: "supersecret")
puts "Created general user" if user.save

#Creating 3 Reviews per Lesson
chapters = (1..12).to_a
random_sentences = Faker::Lorem.paragraph

chapters.each do |chapter|
  3.times do
    Review.create(lesson_id: "#{chapter}", comment: random_sentences )
  end
end

puts "Created #{Review.count} Reflections"
