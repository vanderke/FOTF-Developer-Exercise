require 'rails_helper'

describe "View the list of lessons" do
  it "shows the lessons but use reviews index" do
    lesson1 = Lesson.create!(chapter:"1", title:"Chapter1", summary:"Four score...")
    lesson2 = Lesson.create!(chapter:"2", title:"Chap2,", summary:"for whom the bell..")
    lesson3 = Lesson.create!(chapter:"3", title:"Chap3", summary:"and miles to go before I sleep")

    all_lessons = [lesson1, lesson2, lesson3]


    all_lessons.each do |lesson|
      visit lesson_reviews_path(lesson)
      expect(page).to have_text(lesson.title)
      expect(page).to have_text(lesson.chapter)
      expect(page).to have_text(lesson.summary)
    end

  end

end
