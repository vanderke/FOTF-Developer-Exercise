desc "import content data"
task :load_book_data => :environment do
  lessons = File.read('db/ready_to_wed.json')
  data_hash = JSON.parse(lessons)
  
end
