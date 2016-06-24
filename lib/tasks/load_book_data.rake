desc "import ready to wed data"
task load_book_data: :environment do
  lessons         = File.read('db/ready_to_wed.json')
  data_hash       = JSON.parse(lessons)
  chapter_numbers = data_hash.keys

  chapter_numbers.map do |number|
    Lesson.create!(chapter: "#{number}", title: "#{data_hash[number]["title"]}",
                   summary: "#{data_hash[number]["summary"]}")
  end
end
