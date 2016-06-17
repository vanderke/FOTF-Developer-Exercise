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

import_tasks.each do |task_name|
  puts "Running task: #{task_name} "
  Rake::Task[task_name].invoke
end
